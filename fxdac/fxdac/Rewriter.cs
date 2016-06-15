using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class FxdacSyntaxRewriter : CSharpSyntaxRewriter
{
    public static Predicate<string> s_ShouldRemoveType = new Predicate<string>((typeName) => {
        return typeName.StartsWith("System.Runtime.InteropServices._") ||
        typeName.StartsWith("Mono.Runtime");
    });
    public static string[] s_MembersToRemove = new string[] {
        "RuntimeHelpers.Prepare*",
        "RuntimeHelpers.ExecuteCodeWithGuaranteedCleanup*",
        "RuntimeHelpers.ProbeForSufficientStack*"
    };

    public static Predicate<string> s_IsInternalAttribute = new Predicate<string>((attributeName) => {
        return
        attributeName.StartsWith("System.Runtime.ForceTokenStabilizationAttribute") || 
        attributeName.StartsWith("System.MonoLimitationAttribute") || 
        attributeName.StartsWith("System.MonoTODOAttribute") || 
        attributeName.StartsWith("System.MonoDocumentationNoteAttribute") || 
        attributeName.StartsWith("System.MonoNotSupportedAttribute") ||
        attributeName.StartsWith("System.Security.DynamicSecurityMethodAttribute") ||
        attributeName.StartsWith("System.Runtime.CompilerServices.TypeDependencyAttribute");
    });
    public static Predicate<string> s_ShouldRemoveAttributeApplication = new Predicate<string>((attributeName) => {
        return s_IsInternalAttribute(attributeName) ||

        attributeName.StartsWith("System.Diagnostics.DebuggerTypeProxyAttribute") || // TODO: do we need this in reference assemblies?
        attributeName.StartsWith("System.Xml.Serialization.XmlIgnoreAttribute") || // TODO: decide what to do here. Switch.Attributes property has it applied.
        attributeName.StartsWith("System.ComponentModel.TypeConverterAttribute") || // TODO: probably not all should be removed

        // TODO: wes said to exclude these for now and review with Jan
        attributeName.StartsWith("System.Security.SecurityCriticalAttribute") || 
        attributeName.StartsWith("System.Security.SecuritySafeCriticalAttribute") ||
        attributeName.StartsWith("System.Security.SecurityTransparentAttribute") ||

        attributeName.StartsWith("System.Security.Permission") || // CAS
        attributeName.StartsWith("System.Security.SuppressUnmanagedCodeSecurityAttribute") || // CAS

        attributeName.StartsWith("System.ComponentModel.Design.Serialization.RootDesignerSerializerAttribute") || // This attribute has been deprecated. Use DesignerSerializerAttribute instead.

        attributeName.StartsWith("System.ComponentModel.Design.Serialization.DesignerSerializerAttribute") ||
        attributeName.StartsWith("System.ComponentModel.DesignerSerializationVisibilityAttribute") ||
        attributeName.StartsWith("System.ComponentModel.RecommendedAsConfigurableAttribute") ||
        attributeName.StartsWith("System.ComponentModel.DesignerAttribute") ||
        attributeName.StartsWith("System.ComponentModel.SRCategoryAttribute") ||
        attributeName.StartsWith("System.SRDescriptionAttribute") ||

        // COM
        attributeName.StartsWith("System.Runtime.InteropServices.ComVisibleAttribute") ||
        attributeName.StartsWith("System.Runtime.InteropServices.ClassInterfaceAttribute") ||
        attributeName.StartsWith("System.Runtime.InteropServices.ComDefaultInterfaceAttribute") ||

        attributeName.StartsWith("System.Mono") ||

        // Wes said that these should not be in contracts
        attributeName.StartsWith("System.Runtime.ConstrainedExecution.ReliabilityContractAttribute") ||
        attributeName.StartsWith("System.Runtime.CompilerServices.TypeForwardedFromAttribute") ||
        attributeName.StartsWith("System.Diagnostics.DebuggerDisplayAttribute") ||
        attributeName.StartsWith("System.Runtime.TargetedPatching") ||
        attributeName.StartsWith("System.Runtime.CompilerServices.MethodImpl");
    });

    public static FxDependency[] s_AssemblyToTypeDependenciesToRemove = new FxDependency[] {

        new FxDependency() { From="System.Runtime", To="System.AppDomain" },
        new FxDependency() { From="System.Runtime", To="System.Runtime.Remoting.ObjectHandle" },
        new FxDependency() { From="System.Runtime", To="System.Security.Policy.IIdentityPermissionFactory" },
        new FxDependency() { From="System.Runtime", To="System.Security.IPermission" },
        new FxDependency() { From="System.Runtime", To="System.Security.Permissions.SecurityAction" },
        new FxDependency() { From="System.Runtime", To="System.Security.Cryptography.X509Certificates.X509Certificate" },
        new FxDependency() { From="System.Runtime", To="System.Security.SecurityZone" },
        new FxDependency() { From="System.Runtime", To="System.Security.SecurityContextSource" },
        new FxDependency() { From="System.Runtime", To="System.MarshalByRefObject" },

        new FxDependency() { From="System.Threading", To="System.Security.AccessControl.EventWaitHandleSecurity" },
        new FxDependency() { From="System.Threading", To="System.Security.AccessControl.EventWaitHandleRights" },
        new FxDependency() { From="System.Threading", To="System.Security.AccessControl.MutexSecurity" },
        new FxDependency() { From="System.Threading", To="System.Security.AccessControl.MutexRights" },
        new FxDependency() { From="System.Threading", To="System.Security.AccessControl.SemaphoreSecurity" },
        new FxDependency() { From="System.Threading", To="System.Security.AccessControl.SemaphoreRights" },

        new FxDependency() { From="System.Threading", To="System.MarshalByRefObject" },
        new FxDependency() { From="System.Threading.Synchronization", To="System.MarshalByRefObject" },
        new FxDependency() { From="System.Threading.Timer", To="System.MarshalByRefObject" },
        new FxDependency() { From="System.Threading.ThreadPool", To="System.MarshalByRefObject" },
        new FxDependency() { From="System.Runtime.IsolatedStorage", To="System.MarshalByRefObject" },
        new FxDependency() { From="System.Diagnostics.TraceSource", To="System.MarshalByRefObject" },
        new FxDependency() { From="System.ComponentModel.TypeConverter", To="System.MarshalByRefObject" },
        new FxDependency() { From="System.Net", To="System.MarshalByRefObject" },
        new FxDependency() { From="System.Net.Requests", To="System.MarshalByRefObject" },
        new FxDependency() { From="System.ComponentModel.Design", To="System.MarshalByRefObject" },

        new FxDependency() { From="System.Threading.Thread", To="System.AppDomain" },
        new FxDependency() { From="System.Threading.Thread", To="System.Runtime.Remoting.Contexts.Context" },

        new FxDependency() { From="System.ComponentModel.EventBasedAsync", To="System.ComponentModel.Component" },

        new FxDependency() { From="System.Diagnostics.Debug", To="System.Diagnostics.TraceListenerCollection" },
    };

    SemanticModel _model;
    string _assembly;
    ReportWriter _reportWriter;
    List<string> _undesiredDependencies;

    public FxdacSyntaxRewriter(ReportWriter reportWriter, SemanticModel model, string assembly)
    {
        _model = model;
        _assembly = assembly;
        _reportWriter = reportWriter;
        _undesiredDependencies = s_AssemblyToTypeDependenciesToRemove.Where(dep => dep.From == _assembly).Select(dep => dep.To).ToList();
    }

    public override SyntaxNode VisitAttributeList(AttributeListSyntax attributeList)
    {
        var nodesToRemove = attributeList.Attributes.Where(att => s_ShouldRemoveAttributeApplication(att.Name.ToString())).ToArray();
        if (nodesToRemove.Length == attributeList.Attributes.Count) {
            //Remove the entire attribute
            return attributeList .RemoveNode(attributeList, SyntaxRemoveOptions.KeepNoTrivia);
        } else {
            //Remove just the matching ones recursively
            foreach (var node in nodesToRemove)
                return VisitAttributeList(attributeList.RemoveNode(node, SyntaxRemoveOptions.KeepNoTrivia));
        }

        return
            base.VisitAttributeList(attributeList);
    }

    private bool IsUndesiredDependency(string dependencyTypeName)
    {
        foreach(var dependecny in _undesiredDependencies) {
            if (dependecny.Equals(dependencyTypeName, StringComparison.Ordinal)) return true;
        }
        return false;
    }

    public override SyntaxNode VisitClassDeclaration(ClassDeclarationSyntax node)
    {
        var symbol = _model.GetDeclaredSymbol(node);

        // should remove the whole type?
        if (s_ShouldRemoveType(node.Identifier.ToString())) {
            _reportWriter.WriteListItem("Removed type {0}", symbol.Name);
            return null;
        }

        // should remove anything from base list?
        var newNode = (ClassDeclarationSyntax)base.VisitClassDeclaration(node);
        var baseList = newNode.BaseList;
        if (baseList != null && baseList.Types.Count == 0) {
            newNode = newNode.WithBaseList(null);
        }

        {
            foreach (var dependency in _undesiredDependencies) {
                bool removeMore = true;
                while (removeMore) {
                    removeMore = false;
                    var members = newNode.DescendantNodes().OfType<MemberDeclarationSyntax>().ToArray();
                    if(members.Length < 1) { break; }
                    
                    foreach(var member in members) { 
                        if (DoesMemberDependOn(member, dependency) || ShouldRemoveMember(member)) {
                            removeMore = true;
                            _reportWriter.WriteListItem("Removed member {0}", FormatMember(member));
                            newNode = newNode.RemoveNode(member, SyntaxRemoveOptions.KeepNoTrivia);
                            break;
                        }
                    }
                }
            }
        }
        
        return newNode;
    }

    private bool ShouldRemoveMember(MemberDeclarationSyntax member)
    {
        var name = FormatMember(member);
        foreach (var memberToRemove in s_MembersToRemove) {
            if (memberToRemove.EndsWith("*")) {
                if (name.StartsWith(memberToRemove.TrimEnd('*'), StringComparison.Ordinal)) {
                    return true;
                }
            }
            if(string.Equals(name, memberToRemove, StringComparison.Ordinal)) {
                return true;
            }
        }
        return false;
    }

    private bool DoesMemberDependOn(MemberDeclarationSyntax member, string dependency)
    {
        var method = member as MethodDeclarationSyntax;
        if (method != null) {
            return DoesMethodDependOn(method, dependency);
        }

        var property = member as PropertyDeclarationSyntax;
        if (property != null) {
            return property.Type.ToString() == dependency;
        }

        var ctor = member as ConstructorDeclarationSyntax;
        if (ctor != null) {
            return DoesCtorDependOn(ctor, dependency);
        }

        return false;
    }

    private bool DoesCtorDependOn(ConstructorDeclarationSyntax ctor, string dependency)
    {
        var parameters = ctor.ParameterList;
        foreach (var parameter in parameters.Parameters) {
            var parameterType = parameter.Type;
            var parameterTypeName = parameterType != null ? parameter.Type.ToString() : "";
            if (parameterTypeName == dependency) {
                return true;
            }
        }
        return false;
    }

    public override SyntaxNode VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
    {
        if (s_ShouldRemoveType(node.Identifier.ToString())) {
            _reportWriter.WriteListItem("Removed type {0}", node.Identifier);
            return null;
        }

        var newNode = (InterfaceDeclarationSyntax)base.VisitInterfaceDeclaration(node);
        var baseList = newNode.BaseList;
        if (baseList != null && baseList.Types.Count == 0) {
            newNode = newNode.WithBaseList(null);
        }
        return newNode;
    }

    public override SyntaxNode VisitBaseList(BaseListSyntax node)
    {
        var newNode = (BaseListSyntax)base.VisitBaseList(node);

        if (newNode.Types.Count == 0) return null;

        foreach (var type in newNode.Types) {
            var typeName = type.ToString();

            foreach (var assemblyDependency in s_AssemblyToTypeDependenciesToRemove) {
                if (_assembly == assemblyDependency.From) {
                    if (typeName == assemblyDependency.To) {
                        var parent = (ClassDeclarationSyntax)node.Parent;
                        _reportWriter.WriteListItem("Removed base {0} from type {1}", typeName, parent.Identifier);
                        return SyntaxFactory.BaseList(newNode.Types.Remove(type));
                    }
                }
            }

            if (s_ShouldRemoveType(typeName)) {
                var parent = (ClassDeclarationSyntax)node.Parent;
                _reportWriter.WriteListItem("Removed base {0} from type {1}", typeName, parent.Identifier);
                return SyntaxFactory.BaseList(newNode.Types.Remove(type));
            }
        }

        return newNode;
    }

    public override SyntaxNode VisitMethodDeclaration(MethodDeclarationSyntax node)
    {
        if(node.ExplicitInterfaceSpecifier != null)
            if(s_ShouldRemoveType(node.ExplicitInterfaceSpecifier.Name.ToString())){
                _reportWriter.WriteListItem("Removed method {0}", FormatMethod(node));
                return null;
            }
        return base.VisitMethodDeclaration(node);
    }

    public override SyntaxNode VisitPropertyDeclaration(PropertyDeclarationSyntax node)
    {
        if (node.ExplicitInterfaceSpecifier != null)
            if (s_ShouldRemoveType(node.ExplicitInterfaceSpecifier.Name.ToString())) {
                _reportWriter.WriteListItem("Removed property {0}", FormatProperty(node));
                return null;
            }
        return base.VisitPropertyDeclaration(node);
    }

    private bool DoesMethodDependOn(MethodDeclarationSyntax method, string dependecny)
    {
        var returnTypeName = method.ReturnType.ToString();
        if (returnTypeName == dependecny) {
            return true;
        }

        var parameters = method.ParameterList;
        foreach (var parameter in parameters.Parameters) {
            var parameterType = parameter.Type;
            var parameterTypeName = parameterType!=null?parameter.Type.ToString():"";
            if (parameterTypeName == dependecny) {
                return true;
            }
        }
        return false;
    }

    private string FormatMember(MemberDeclarationSyntax member)
    {
        var method = member as MethodDeclarationSyntax;
        if (method != null) {
            return FormatMethod(method);
        }

        var property = member as PropertyDeclarationSyntax;
        if (property != null) {
            return FormatProperty(property);
        }

        var ctor = member as ConstructorDeclarationSyntax;
        if (ctor != null) {
            return FormatCtor(ctor);
        }

        return member.ToString();
    }

    private string FormatCtor(ConstructorDeclarationSyntax ctor)
    {
        var sb = new StringBuilder();
        var typeName = GetIdentifier(ctor.Parent);
        sb.Append(typeName);
        sb.Append('.');
        sb.Append("ctor");
        sb.Append('(');
        bool first = true;
        foreach (var parameter in ctor.ParameterList.Parameters) {
            if (first) { first = false; } else sb.Append(", ");
            sb.Append(parameter.Type);
        }
        sb.Append(')');
        return sb.ToString();
    }

    private string FormatMethod(MethodDeclarationSyntax member)
    {
        var sb = new StringBuilder();
        var typeName = GetIdentifier(member.Parent);
        sb.Append(typeName);
        sb.Append('.');
        var eis = member.ExplicitInterfaceSpecifier;
        if (eis!=null) sb.Append(eis);
        sb.Append(member.Identifier);
        sb.Append('(');
        bool first = true;
        foreach (var parameter in member.ParameterList.Parameters) {
            if (first) { first = false; }
            else sb.Append(", ");
            sb.Append(parameter.Type);
        }
        sb.Append("):");
        sb.Append(member.ReturnType);
        return sb.ToString();
    }


    string GetIdentifier(SyntaxNode typeNode)
    {
        var ct = typeNode as TypeDeclarationSyntax;
        if (ct != null) return ct.Identifier.ToString();
        return "<n/a>";
    }
    private string FormatProperty(PropertyDeclarationSyntax member)
    {
        var sb = new StringBuilder();
        var typeName = GetIdentifier(member.Parent);
        sb.Append(typeName);
        sb.Append('.');
        var eis = member.ExplicitInterfaceSpecifier;
        if (eis != null) sb.Append(eis);
        sb.Append(member.Identifier);
        sb.Append(":");
        sb.Append(member.Type);
        return sb.ToString();
    }
}

