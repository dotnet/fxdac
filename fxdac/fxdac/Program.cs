using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.IO;
using Microsoft.CodeAnalysis.Emit;
using System.Reflection;
using System.Linq;

static class Program
{
    static string s_OutputFolder = @"..\..\Data\Contracts";
    static string s_OutputSources = Path.Combine(s_OutputFolder, "src");
    static string s_OutputDlls = Path.Combine(s_OutputFolder, "bin");

    static string s_SpecificationFolder = @"..\..\Data\Specifications";
    static string s_ReportPath = @"..\..\Data\report.xml";
    static string s_ExistingContracts = @"\\cpvsbuild\drops\dev14\ProjectK\raw\current\binaries.x86ret\ref\ProjectK";
    static string s_MasterAPIFile = @"..\..\Data\MasterAPIs\XamariniOSCoreFxMergedAll.cs"; // master source is a file with all APIs this tool is trying to refactor
    //static string s_MasterAPIFile = @"..\..\Data\MasterAPIs\XamariniOSAll.cs"; // master source is a file with all APIs this tool is trying to refactor
    static string s_CoreFxAPIFile = @"..\..\Data\MasterAPIs\CoreFxAll.cs";

    internal static string s_LefroverTypesAssembly = "System.Leftover"; // types not assigned to any assembly are placed here
    internal static bool s_logOrphanedTypes = false; // Orphaned types are types in the specifications that don't exist in master source.
    internal static bool s_logValidMoves = false;
    internal static bool s_logTypesNotInCoreFx = false;
    internal static bool s_logTypesNotInMasterSources = false;
    internal static bool s_logMissingContracts = false;
    internal static bool s_logAddedContracts = false;

    static void Main(string[] args)
    {
        if(args.Length > 0) {
            s_ExistingContracts = args[0];
        }

        if (!Directory.Exists(s_ExistingContracts)) {
            WriteMessage(ConsoleColor.Red, "Existing contract folder {0} does not exist", s_ExistingContracts);
        } else {

            FxRedist redist;
            using (var reportWriter = new ReportWriter(s_ReportPath)) {
                if (RefactorAssemblies(reportWriter, out redist)) {
                    if (s_ExistingContracts != null) {
                        LocationAnalysis.CompareFactorings(s_ExistingContracts, s_OutputDlls, reportWriter);
                    }
                }

                // Orphaned types are types in the specifications that don't exist in master source.
                PrintOrphanedTypes(redist, reportWriter);

                if (redist.Leftover.Count > 0) {
                    reportWriter.WriteListStart("TYPES_NOT_IN_ANY_ASSEMBLY", "total", redist.Leftover.CountOfTypes, "description", "types that are not in specification files");

                    foreach (var ns in redist.Leftover) {
                        var nsName = ns.Key;
                        foreach (var type in ns.Value) {
                            reportWriter.WriteListItem(type.Symbol.GetDocumentationCommentId().Substring(2));
                        }
                    }
                    reportWriter.WriteListEnd();
                }
            }
        }

        if (args.Length == 0) {
            Console.WriteLine("\nPress ENTER to exit ...");
            Console.ReadLine();
        }
    }

    private static bool RefactorAssemblies(ReportWriter reportWriter, out FxRedist redist)
    {
        // prepare the right folders
        PrepareOutputFolder(s_OutputSources);
        PrepareOutputFolder(s_OutputDlls);

        // load files describing the desired factoring. verify consistency of these files.
        redist = new FxRedist();
        if (!ProcessSpecifications(redist)) {
            Console.WriteLine("\nPress ENTER to exit ...");
            Console.ReadLine();
            return false;
        }

        // compile master file 
        reportWriter.WriteListStart("REMOVED");

        AddSourcesToRedist(reportWriter, redist, s_MasterAPIFile);
        AddSourcesToRedist(reportWriter, redist, s_CoreFxAPIFile);

        reportWriter.WriteListEnd();

        // generate and compile factored assemblies
        GenerateSources(redist);
        var successfulBuild = CompileAssemblies(redist);

        // warn about types that are not in any of the factored assemblies
        if (redist.Leftover.CountOfTypes > 0) {
            WriteMessage(ConsoleColor.Yellow, "\n{0} type[s] not assigned to an assembly", redist.Leftover.CountOfTypes);
        }

        return successfulBuild;
    }

    private static void AddSourcesToRedist(ReportWriter reportWriter, FxRedist redist, string source)
    {
        var parsedSource = CSharpSyntaxTree.ParseText(File.ReadAllText(source));

        var compilation = CSharpCompilation.Create("mscorlib", new SyntaxTree[] { parsedSource });
        SemanticModel semantic = compilation.GetSemanticModel(parsedSource);

        // assign roslyn syntax objects (types) to facored assemblies
        var masterCompilationUnit = parsedSource.GetCompilationUnitRoot();
        foreach (var memberSyntax in masterCompilationUnit.Members) {
            ProcessTypeOrNamespace(redist, memberSyntax, semantic, null, reportWriter);
        }
    }

    private static void PrepareOutputFolder(string folder)
    {
        if (Directory.Exists(folder)) {
            var files = Directory.GetFiles(folder);
            foreach (var file in files) {
                File.Delete(file);
            }
        }
        else {
            Directory.CreateDirectory(folder);
        }
    }

    static void PrintOrphanedTypes(FxRedist redist, ReportWriter reportWriter)
    {
        if (s_logOrphanedTypes) {
            reportWriter.WriteListStart("ORPHANED_TYPES", "description", "Orphaned types are types in the specifications that don't exist in master source.");
            foreach (var assembly in redist.Values) {
                var orphanedTypes = assembly.OrphanedTypes;
                if (orphanedTypes.Count > 0) {
                    WriteMessage(ConsoleColor.Yellow, "Orphaned types in {0}", assembly.Name);

                    foreach (var type in orphanedTypes) {
                        reportWriter.WriteListItem("{0}", type);                         
                    }
                }
            }
            reportWriter.WriteListEnd();
        }
    }

    static bool ProcessSpecifications(FxRedist redist)
    {
        Console.WriteLine("PROCESSING SPECIFICATIONS");

        Dictionary<string, string> alreadyLoadedSpecification = new Dictionary<string, string>();

        var allFiles = Directory.GetFiles(s_SpecificationFolder);

        foreach (var assemblySpecificationFile in allFiles) {
            if(!ProcessSpecification(redist, alreadyLoadedSpecification, assemblySpecificationFile)) {
                return false;
            }
        }

        foreach (var a in redist) {
            foreach(var reference in a.Value.References) {
                var referenceName = Path.GetFileNameWithoutExtension(reference);
                if(a.Value.Name == referenceName) {
                    WriteMessage(ConsoleColor.Red, "Assembly {0} references itself.", a.Value.Name);
                    return false;
                }

                if (!redist.Values.Any((a2) => {
                    return a2.Name == referenceName;
                })) {
                    WriteMessage(ConsoleColor.Red, "Assembly {0} references {1} that does not exist.", a.Value.Name, reference);
                    return false;
                }

            }
        }
        return true;
    }

    private static bool ProcessSpecification(FxRedist redist, Dictionary<string, string> alreadyLoadedSpecification, string assemblySpecificationFile)
    {
        bool success = true;
        var assembly = new FxAssembly();
        assembly.Name = Path.GetFileNameWithoutExtension(assemblySpecificationFile);
        redist.Add(assembly.Name, assembly);
        string[] assemblySpecification = File.ReadAllLines(assemblySpecificationFile);

        Dictionary<string, int> unique = new Dictionary<string, int>();

        foreach (var specificationLine in assemblySpecification) {
            var line = specificationLine.Trim();
            if (string.IsNullOrWhiteSpace(line)) continue;
            if (line.StartsWith("//")) continue; // comment
            if (line.StartsWith("/r:")) {
                assembly.References.Add(line.Substring(3));
                continue;
            }

            try {
                unique.Add("T:" + line, 0);

                try {
                    alreadyLoadedSpecification.Add(line, assemblySpecificationFile);
                }
                catch (ArgumentException) {
                    WriteMessage(ConsoleColor.Red, "{0} in files {1} and {2}", line, assemblySpecificationFile, alreadyLoadedSpecification[line]);
                    success = false;
                }
            }
            catch (ArgumentException) {
                WriteMessage(ConsoleColor.Yellow, "Type {1} duplicated in {0}", assemblySpecificationFile, line);
                success = false;
            }
        }

        assembly.Types.AddRange(unique.Keys);
        return success;
    }

    static void WriteMessage(ConsoleColor color, string format, params object[] args)
    {
        var old = Console.ForegroundColor;
        Console.ForegroundColor = color;
        Console.WriteLine(format, args);
        Console.ForegroundColor = old;
    }

    static void GenerateSources(FxRedist assemblies)
    {
        foreach (var module in assemblies) {
            string file = s_OutputSources + "\\" + module.Key + ".cs";
            module.Value.SourceFile = file;
            StreamWriter sw = new StreamWriter(file);
            sw.WriteLine("[assembly:System.CLSCompliant(true)]");
            foreach (var ns in module.Value) {
                sw.WriteLine("namespace {0} {{", ns.Key);
                foreach (var type in ns.Value) {
                    if (type.Declaration != null) {
                        sw.WriteLine(type.Declaration.ToFullString());
                    }
                }
                sw.WriteLine("}} // end of {0}", ns.Key);
            }
            sw.Close();
        }
    }

    static bool CompileAssemblies(FxRedist redist)
    {
        bool failed = false;
        Queue<FxAssembly> toCompile = new Queue<FxAssembly>(redist.Values);
        List<FxAssembly> sorted = new List<FxAssembly>();
        while(toCompile.Count > 0) {
            var a = toCompile.Dequeue();
            if (HasAllDependencies(a, sorted)) {
                sorted.Add(a);
            } else {
                toCompile.Enqueue(a);
            }
        }

        foreach (var a in sorted) {
            if (HasAllDependencies(a, sorted)) {
                if (!CompileAssembly(a)) {
                    a.FailedToCompile = true;
                    failed = true;
                }
            }
        }

        return !failed;
    }

    static bool HasAllDependencies(FxAssembly assembly, List<FxAssembly> allAssemblies)
    {
        foreach (var dependency in assembly.References) {
            var d = allAssemblies.Find((compiled) => { return compiled.Name == Path.GetFileNameWithoutExtension(dependency); });

            if (d == null || d.FailedToCompile) {
                return false;
            }
        }
        return true;
    }

    static bool CompileAssembly(FxAssembly assembly) {
        if (assembly.Name == s_LefroverTypesAssembly) return true;

        var assemblySyntaxTree = CSharpSyntaxTree.ParseText(File.ReadAllText(assembly.SourceFile));

        var references = new List<MetadataReference>();
        foreach (var reference in assembly.References) {
            var referenceFile = Path.Combine(s_OutputDlls, reference);
            if (!File.Exists(referenceFile)) {
                WriteMessage(ConsoleColor.Red, "References {1} of {0} missing", assembly.Name, referenceFile);
                return false;
            }

            references.Add(MetadataReference.CreateFromFile(referenceFile));
        }

        var options = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary).WithAllowUnsafe(true);

        CSharpCompilation compilation = CSharpCompilation.Create(
            assembly.Name,
            syntaxTrees: new[] { assemblySyntaxTree },
            references: references,
            options: options
        );

        var dllPath = Path.Combine(s_OutputDlls, assembly.Name + ".dll");

        using (var ms = new FileStream(dllPath, FileMode.Create, FileAccess.Write, FileShare.None)) {
            EmitResult compilationResult = compilation.Emit(ms);
            if (!compilationResult.Success) {
                Console.WriteLine("COMPILING {0}", assembly.Name);
                ProcessCompilationErrors(compilationResult);
                return false;
            } else {
                Console.WriteLine("{0} created.", dllPath);

                var numberOfWarnings = compilationResult.Diagnostics.Count();
                if (numberOfWarnings > 0) {
                    WriteMessage(ConsoleColor.Yellow, "{0} warning[s].", numberOfWarnings);

                    foreach(var warning in compilationResult.Diagnostics) {
                        if (warning.Id == "CS0618" || warning.Id == "CS0809") continue; // obsolete message
                        WriteMessage(ConsoleColor.Yellow, "{0}", warning);
                    }
                }
            }
        }

        var loaded = Assembly.LoadFrom(dllPath);
        var referenced = loaded.GetReferencedAssemblies();
        foreach (var r in referenced) {
            references.RemoveAll((mr) => {
                return Path.GetFileNameWithoutExtension(mr.Display).Equals(r.Name);
            });
        }

        if (references.Count > 0) {
            foreach (var r in references) {
                WriteMessage(ConsoleColor.Yellow, "Unnecessary reference {0} in {1}", r.Display, assembly.Name);
            }
        }

        return true;
    }

    static void ProcessCompilationErrors(EmitResult result)
    {
        var missingTypes = new HashSet<string>();

        IEnumerable<Diagnostic> failures = result.Diagnostics.Where(diagnostic =>
                                diagnostic.IsWarningAsError ||
                                diagnostic.Severity == DiagnosticSeverity.Error);

        foreach (Diagnostic diagnostic in failures.Distinct()) {
            if(diagnostic.Id == "CS0009") {
                WriteMessage(ConsoleColor.Red, "{0}", diagnostic);
                return; // reference is missing; no point in continuing
            }
            if (diagnostic.Id == "CS0518" || diagnostic.Id == "CS0234") {
                RecordMissingType(missingTypes, diagnostic);
            }
            else {
                WriteMessage(ConsoleColor.Red, "{0}", diagnostic);
            }
        }

        if (missingTypes.Count > 0) {
            WriteMessage(ConsoleColor.Red, "MISSING DEPENDENCIES");
            foreach (var missing in missingTypes) {
                WriteMessage(ConsoleColor.Red, "\t{0}", missing);
            }
        }
    }

    static void RecordMissingType(HashSet<string> missingIdentifiers, Diagnostic diagnostic)
    {
        var argsProperty = diagnostic.GetType().GetTypeInfo().GetProperty("Arguments", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.GetProperty);
        var argsGettter = argsProperty.GetGetMethod(true);
        var args = (IReadOnlyList<object>)argsGettter.Invoke(diagnostic, new object[0]);

        if (diagnostic.Id == "CS0234") {
            missingIdentifiers.Add(args[1].ToString() + "." + args[0].ToString());
        }
        else {
            missingIdentifiers.Add(args[0].ToString());
        }
    }

    static void ProcessTypeOrNamespace(FxRedist redist, MemberDeclarationSyntax syntax, SemanticModel typeModel, string currentNamespace, ReportWriter reportWriter)
    {
        var namespaceSyntax = syntax as NamespaceDeclarationSyntax;

        // process all types in namespace
        if (namespaceSyntax != null) {
            foreach (var namespaceMember in namespaceSyntax.Members) {
                string namespaceName = namespaceSyntax.Name.ToString();
                ProcessTypeOrNamespace(redist, namespaceMember, typeModel, namespaceName, reportWriter);
            }
            return;
        }

        ProcessType(redist, syntax, typeModel, currentNamespace, reportWriter);
    }

    private static void ProcessType(FxRedist redist, MemberDeclarationSyntax syntax, SemanticModel typeModel, string currentNamespace, ReportWriter reportWriter)
    {
        ISymbol symbol = typeModel.GetDeclaredSymbol(syntax);
        string typeId = symbol.GetDocumentationCommentId();

        var typeName = typeId.Substring(2);
        if (FxdacSyntaxRewriter.s_ShouldRemoveType(typeName)) {
            reportWriter.WriteListItem("Removed type {0}", symbol.Name);
            return;
        }
        FxAssembly typeAssembly = redist.GetAssemblyForType(typeId);

        if (typeAssembly.HasEmitedType(typeId)) return;

        // rewrite type
        var rewriter = new FxdacSyntaxRewriter(reportWriter, typeModel, typeAssembly.Name);
        syntax = (MemberDeclarationSyntax)syntax.Accept(rewriter);

        // add type to assembly
        var typeSyntax = new FxType() { Declaration = syntax, Symbol = (ITypeSymbol)symbol };
        typeAssembly.AddType(currentNamespace, typeSyntax);
    }
}


