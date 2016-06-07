using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Diagnostics;
using System;

class FxType
{
    public MemberDeclarationSyntax Declaration;
    public ITypeSymbol Symbol;

    public override string ToString()
    {
        return Declaration.ToFullString();
    }
}

[DebuggerDisplay("{Name}")]
class FxAssembly : Dictionary<string, List<FxType>>
{
    public List<string> Types = new List<string>();
    public List<string> References = new List<string>();
    public string Name;
    public string SourceFile;
    internal bool FailedToCompile;

    public void AddType(string namespaceName, FxType type)
    {
        List<FxType> types;
        if (!TryGetValue(namespaceName, out types)) {
            types = new List<FxType>();
            Add(namespaceName, types);
        }

        types.Add(type);
    }

    public int CountOfTypes
    {
        get {
            int result = 0;
            foreach(var ns in Values) {
                result += ns.Count;
            }
            return result;
        }
    }

    public bool HasEmitedType(string type)
    {
        foreach(var ns in Values) {
            foreach(var t in ns) {
                if(t.Symbol.GetDocumentationCommentId() == type) { return true; }
            }
        }
        return false;
    }


    public List<string> OrphanedTypes {
        get {
            var result = new List<string>();
            foreach(var specifiedType in Types) {
                if (!HasEmitedType(specifiedType)) {
                    result.Add(specifiedType);
                }
            }
            return result;
        }
    }

    public override string ToString()
    {
        return Name;
    }
}

class FxRedist : Dictionary<string, FxAssembly>
{
    public FxAssembly Leftover = new FxAssembly() { SourceFile = Program.s_LefroverTypesAssembly +".cs", Name = Program.s_LefroverTypesAssembly };

    public FxRedist()
    {
        Add(Leftover.Name, Leftover);
    }
    public FxAssembly GetAssemblyForType(string typeName)
    {
        foreach(var assembly in Values) {
            if (assembly.Types.Contains(typeName)){
                return assembly;
            }
        }
        return Leftover;
    }

    public int CountOfTypes
    {
        get {
            int result = 0;
            foreach(var a in Values) {
                result += a.Count;
            }
            return result;
        }
    }
}

struct FxMember
{
    public string TypeName;
    public string MemberName;

    public FxMember(string typeName, string memberName)
    {
        TypeName = typeName;
        MemberName = memberName;
    }
}

struct FxDependency
{
    public string From;
    public string To;
}