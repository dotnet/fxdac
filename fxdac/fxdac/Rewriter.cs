using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.IO;
using System.Linq;
using System.Text;

class FxdacSyntaxRewriter : CSharpSyntaxRewriter
{
    public static Predicate<string> s_ShouldRemoveType = new Predicate<string>((typeName) => {
        return typeName.StartsWith("System.Runtime.InteropServices._") ||
        typeName.StartsWith("Mono.Runtime");
    });

    public static Predicate<string> s_ShouldRemoveAttributeApplication = new Predicate<string>((attributeName) => {
        return attributeName.StartsWith("System.Security.Permission") ||
        attributeName.StartsWith("System.Runtime.CompilerServices.TypeDependencyAttribute") ||
        attributeName.StartsWith("System.Diagnostics.DebuggerTypeProxyAttribute") ||
        attributeName.StartsWith("System.Runtime.ForceTokenStabilizationAttribute") ||
        attributeName.StartsWith("System.MonoLimitationAttribute") ||
        attributeName.StartsWith("System.MonoTODOAttribute") ||
        attributeName.StartsWith("System.MonoDocumentationNoteAttribute") ||
        attributeName.StartsWith("System.MonoNotSupportedAttribute") ||
        attributeName.StartsWith("System.Security.DynamicSecurityMethodAttribute") ||
        attributeName.StartsWith("System.Runtime.CompilerServices.AsyncStateMachineAttribute") ||
        attributeName.StartsWith("System.ComponentModel.TypeConverterAttribute") ||
        attributeName.StartsWith("System.ComponentModel.Design.Serialization.DesignerSerializerAttribute") ||
        attributeName.StartsWith("System.ComponentModel.DesignerSerializationVisibilityAttribute") ||
        attributeName.StartsWith("System.Xml.Serialization.XmlIgnoreAttribute") ||
        attributeName.StartsWith("System.SRDescriptionAttribute") ||
        attributeName.StartsWith("System.Runtime.InteropServices.ComDefaultInterfaceAttribute") ||
        attributeName.StartsWith("System.Security.SuppressUnmanagedCodeSecurityAttributeAttribute") ||
        attributeName.StartsWith("System.Security.SuppressUnmanagedCodeSecurityAttribute") ||
        attributeName.StartsWith("System.ComponentModel.SRCategoryAttributeAttribute") ||
        attributeName.StartsWith("System.ComponentModel.SRCategoryAttribute") ||
        attributeName.StartsWith("System.ComponentModel.Design.Serialization.RootDesignerSerializerAttribute") ||
        attributeName.StartsWith("System.ComponentModel.RecommendedAsConfigurableAttribute") ||
        attributeName.StartsWith("System.ComponentModel.DesignerAttribute");
    });

    public static FxDependency[] s_AssemblyToTypeDependenciesToRemove = new FxDependency[] {

        new FxDependency() { From="System.Runtime", To ="System.AppDomain" },
        new FxDependency() { From="System.Runtime", To ="System.Runtime.Remoting.ObjectHandle" },
        new FxDependency() { From="System.Runtime", To ="System.Security.Policy.IIdentityPermissionFactory" },
        new FxDependency() { From="System.Runtime", To ="System.Security.IPermission" },
        new FxDependency() { From="System.Runtime", To ="System.Security.Permissions.SecurityAction" },
        new FxDependency() { From="System.Runtime", To ="System.Security.Cryptography.X509Certificates.X509Certificate" },
        new FxDependency() { From="System.Runtime", To ="System.Security.SecurityZone" },
        new FxDependency() { From="System.Runtime", To ="System.Security.SecurityContextSource" },
        new FxDependency() { From="System.Runtime", To ="System.MarshalByRefObject" },

        new FxDependency() { From="System.Threading", To ="System.MarshalByRefObject" },
        new FxDependency() { From="System.Threading.Synchronization", To ="System.MarshalByRefObject" },
        new FxDependency() { From="System.Threading.Timer", To ="System.MarshalByRefObject" },
        new FxDependency() { From="System.Threading.ThreadPool", To ="System.MarshalByRefObject" },
        new FxDependency() { From="System.Runtime.IsolatedStorage", To ="System.MarshalByRefObject" },
        new FxDependency() { From="System.Diagnostics.TraceSource", To ="System.MarshalByRefObject" },
        new FxDependency() { From="System.ComponentModel.TypeConverter", To ="System.MarshalByRefObject" },
        new FxDependency() { From="System.Net", To ="System.MarshalByRefObject" },
        new FxDependency() { From="System.Net.Requests", To ="System.MarshalByRefObject" },
        new FxDependency() { From="System.ComponentModel.Design", To ="System.MarshalByRefObject" },

        new FxDependency() { From="System.Threading.Thread", To ="System.AppDomain" },
        new FxDependency() { From="System.Threading.Thread", To ="System.Runtime.Remoting.Contexts.Context" },

        new FxDependency() { From="System.ComponentModel.EventBasedAsync", To ="System.ComponentModel.Component" },

        new FxDependency() { From="System.Diagnostics.Debug", To ="System.Diagnostics.TraceListenerCollection" },
    };

    SemanticModel _model;
    string _assembly;
    ReportWriter _reportWriter; 

    public FxdacSyntaxRewriter(ReportWriter reportWriter, SemanticModel model, string assembly)
    {
        _model = model;
        _assembly = assembly;
        _reportWriter = reportWriter;
    }

    public override SyntaxNode VisitAttributeList(AttributeListSyntax node)
    {
        var newNode = (AttributeListSyntax)base.VisitAttributeList(node);
        if (newNode.Attributes.Count == 0) {
            return null;
        }
        return newNode;
    }

    public override SyntaxNode VisitAttribute(AttributeSyntax node)
    {
        var attributeName = node.ToString();
        if (s_ShouldRemoveAttributeApplication(attributeName)) {
            return null;
        }
        return node;
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
            var removeDependenciesTo = s_AssemblyToTypeDependenciesToRemove.Where(dep => dep.From == _assembly).Select(dep => dep.To);
            foreach (var dependency in removeDependenciesTo) {
                bool removeMore = true;
                while (removeMore) {
                    removeMore = false;
                    var members = newNode.DescendantNodes().OfType<MemberDeclarationSyntax>().ToArray();
                    if(members.Length < 1) { break; }
                    
                    foreach(var member in members) { 
                        if (DoesMemberDependOn(member, dependency)) {
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
        var type = (ClassDeclarationSyntax)ctor.Parent;
        sb.Append(type.Identifier);
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
        var type = (ClassDeclarationSyntax)member.Parent;
        sb.Append(type.Identifier);
        sb.Append('.');
        sb.Append(member.Identifier);
        sb.Append('(');
        bool first = true;
        foreach (var parameter in member.ParameterList.Parameters) {
            if (first) { first = false; }
            else sb.Append(", ");
            sb.Append(parameter.Type);
        }
        sb.Append(')');
        return sb.ToString();
    }

    private string FormatProperty(PropertyDeclarationSyntax member)
    {
        var sb = new StringBuilder();
        var type = (ClassDeclarationSyntax)member.Parent;
        sb.Append(type.Identifier);
        sb.Append('.');
        sb.Append(member.Identifier);
        return sb.ToString();
    }
}

