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
        return typeName.StartsWith("System.Runtime.InteropServices._");
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
        attributeName.StartsWith("System.ComponentModel.RecommendedAsConfigurableAttribute");
    });

    public static FxDependecny[] s_AssemblyToTypeDependenciesToRemove = new FxDependecny[] {
        new FxDependecny() { From="System.Runtime", To ="System.MarshalByRefObject" },
        new FxDependecny() { From="System.Threading", To ="System.MarshalByRefObject" },
        new FxDependecny() { From="System.Threading.Synchronization", To ="System.MarshalByRefObject" },
        new FxDependecny() { From="System.Threading.Timer", To ="System.MarshalByRefObject" },
        new FxDependecny() { From="System.Threading.ThreadPool", To ="System.MarshalByRefObject" },
        new FxDependecny() { From="System.Runtime.IsolatedStorage", To ="System.MarshalByRefObject" },
        new FxDependecny() { From="System.Diagnostics.TraceSource", To ="System.MarshalByRefObject" },
        new FxDependecny() { From="System.ComponentModel.TypeConverter", To ="System.MarshalByRefObject" },
        new FxDependecny() { From="System.Net", To ="System.MarshalByRefObject" },
                new FxDependecny() { From="System.Net.Requests", To ="System.MarshalByRefObject" },
        new FxDependecny() { From="System.ComponentModel.Design", To ="System.MarshalByRefObject" },
        new FxDependecny() { From="System.ComponentModel.EventBasedAsync", To ="System.ComponentModel.Component" },
    };

    public static FxMember[] s_MethodsToRemove = new FxMember[] {
        new FxMember("System.Threading.Thread", "GetDomain")
    };

    public static FxMember[] s_PropertiesToRemove = new FxMember[] {
        new FxMember("System.Threading.Thread", "CurrentContext")
    };

    public static FxDependecny[] s_TypeToTypeDependenciesToRemove = new FxDependecny[] {
        new FxDependecny() { From="System.Activator", To ="System.AppDomain" },
        new FxDependecny() { From="System.Activator", To ="System.Runtime.Remoting.ObjectHandle" }
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

        // should remove any members?
        {
            foreach (var dependency in s_TypeToTypeDependenciesToRemove) {
                if (symbol.ToString().StartsWith(dependency.From)) {
                    var members = newNode.DescendantNodes().OfType<MethodDeclarationSyntax>().ToArray();
                    bool removeMore = true;
                    while (removeMore) {
                        removeMore = false;
                        members = newNode.DescendantNodes().OfType<MethodDeclarationSyntax>().ToArray();
                        foreach (var member in members) {
                            if (DoesMethodDependOn(member, dependency.To)) {
                                removeMore = true;
                                _reportWriter.WriteListItem("Removed {0}", FormatMember(member));
                                newNode = newNode.RemoveNode(member, SyntaxRemoveOptions.KeepNoTrivia);

                            }
                        }
                    }
                }
            }
        }

        {
            foreach (var memberToRemove in s_MethodsToRemove) {
                if (symbol.ToString().StartsWith(memberToRemove.TypeName)) {
                    var members = newNode.DescendantNodes().OfType<MethodDeclarationSyntax>().ToArray();
                    bool removeMore = true;
                    while (removeMore) {
                        removeMore = false;
                        members = newNode.DescendantNodes().OfType<MethodDeclarationSyntax>().ToArray();
                        foreach (var member in members) {
                            if (member.Identifier.ToString() == memberToRemove.MemberName) {
                                _reportWriter.WriteListItem("Removed {0}", FormatMember(member));
                                removeMore = true;
                                newNode = newNode.RemoveNode(member, SyntaxRemoveOptions.KeepNoTrivia);
                            }
                        }
                    }
                }
            }
        }

        {
            foreach (var memberToRemove in s_PropertiesToRemove) {
                if (symbol.ToString().StartsWith(memberToRemove.TypeName)) {
                    var members = newNode.DescendantNodes().OfType<PropertyDeclarationSyntax>().ToArray();
                    bool removeMore = true;
                    while (removeMore) {
                        removeMore = false;
                        members = newNode.DescendantNodes().OfType<PropertyDeclarationSyntax>().ToArray();
                        foreach (var member in members) {
                            if (member.Identifier.ToString() == memberToRemove.MemberName) {
                                _reportWriter.WriteListItem("Removed {0}", FormatMember(member));
                                removeMore = true;
                                newNode = newNode.RemoveNode(member, SyntaxRemoveOptions.KeepNoTrivia);
                            }
                        }
                    }
                }
            }
        }
        return newNode;
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
                        return SyntaxFactory.BaseList(newNode.Types.Remove(type));
                    }
                }
            }

            if (s_ShouldRemoveType(typeName)) {
                return SyntaxFactory.BaseList(newNode.Types.Remove(type));
            }
        }

        return newNode;
    }

    public override SyntaxNode VisitMethodDeclaration(MethodDeclarationSyntax node)
    {
        if(node.ExplicitInterfaceSpecifier != null)
            if(s_ShouldRemoveType(node.ExplicitInterfaceSpecifier.Name.ToString())){
                _reportWriter.WriteListItem("Removed {0}", FormatMember(node));
                return null;
            }
        return base.VisitMethodDeclaration(node);
    }

    public override SyntaxNode VisitPropertyDeclaration(PropertyDeclarationSyntax node)
    {
        if (node.ExplicitInterfaceSpecifier != null)
            if (s_ShouldRemoveType(node.ExplicitInterfaceSpecifier.Name.ToString())) {
                _reportWriter.WriteListItem("Removed {0}", FormatMember(node));
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
            var parameterTypeName = parameter.Type.ToString();
            if (parameterTypeName == dependecny) {
                return true;
            }
        }
        return false;
    }

    private string FormatMember(MethodDeclarationSyntax member)
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

    private string FormatMember(PropertyDeclarationSyntax member)
    {
        var sb = new StringBuilder();
        var type = (ClassDeclarationSyntax)member.Parent;
        sb.Append(type.Identifier);
        sb.Append('.');
        sb.Append(member.Identifier);
        return sb.ToString();
    }
}

