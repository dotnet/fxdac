using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Linq;
using System;

struct Move
{
    public string From;
    public string To;

    public Move(string from, string to)
    {
        From = from;
        To = to;
    }
}

class ReportType
{
    public string Name;
    public string Namespace;
    public string PreviousAssembly;
    public string CurrentAssembly;

    public string FullName
    {
        get { return Namespace + "." + Name; }
    }

    public string AssemblyQualifiedName
    {
        get { return Assembly + "," + Namespace + "." + Name; }
    }

    public string Assembly
    {
        get {
            if (CurrentAssembly != null) return CurrentAssembly;
            return PreviousAssembly;
        }
    }

    public override string ToString()
    {
        return FullName;
    }

    public bool HasMoved
    {
        get { return string.Equals(PreviousAssembly, CurrentAssembly, System.StringComparison.Ordinal); }
    }

    public bool WasAdded
    {
        get { return PreviousAssembly == null; }
    }

    public bool WasRemoved
    {
        get { return CurrentAssembly == null; }
    }
}

class LocationAnalysis
{
    static List<Move> s_validMoves = new List<Move>() {
        new Move("System.Dynamic.Runtime", "System.Linq.Expressions"),
    };

    public static void CompareFactorings(string previous, string current, ReportWriter reportWriter)
    {
        var types = new List<ReportType>(3000);
        GenerateDump(previous, types, false);
        GenerateDump(current, types, true);

        var removed = types.Where((t) => t.CurrentAssembly == null).ToList();
        removed.Sort((left, right) => { return left.AssemblyQualifiedName.CompareTo(right.AssemblyQualifiedName); });
        var added = types.Where((t) => t.PreviousAssembly == null).ToList();
        added.Sort((left, right)=> { return left.AssemblyQualifiedName.CompareTo(right.AssemblyQualifiedName); });
        var moved = types.Where((t) => t.CurrentAssembly != t.PreviousAssembly && t.CurrentAssembly!=null && t.PreviousAssembly!=null).ToList();
        moved.Sort((left, right) => { return left.AssemblyQualifiedName.CompareTo(right.AssemblyQualifiedName); });
        var movedToSystemRuntime = moved.Where((t) => t.CurrentAssembly == "System.Runtime").ToList();
        var movedToOtherThanSystemRuntime = moved.Where((t) => t.CurrentAssembly != "System.Runtime").ToList();
        var validMoves = movedToOtherThanSystemRuntime.Where((t) => IsValidMove(t.PreviousAssembly, t.CurrentAssembly)).ToList();
        var unknownMoves = movedToOtherThanSystemRuntime.Where((t) => !IsValidMove(t.PreviousAssembly, t.CurrentAssembly)).ToList();

        reportWriter.WriteListStart("GENERAL_STATISTICS");
        reportWriter.WriteListItem("Previous types {0}", types.Where((t) => t.PreviousAssembly != null).Count());
        reportWriter.WriteListItem("Current types {0}", types.Where((t) => t.CurrentAssembly != null).Count());
        reportWriter.WriteListItem("Moved to System.Runtime {0}", movedToSystemRuntime.Count);
        reportWriter.WriteListItem("Moved to other locations {0}", movedToOtherThanSystemRuntime.Count);
        reportWriter.WriteListEnd();

        var previousContracts = types.Select((t) => t.PreviousAssembly).Where((a) => a != null).Distinct();
        var currentContracts = types.Select((t) => t.CurrentAssembly).Where((a) => a != null).Distinct();
        var addedContracts = currentContracts.Except(previousContracts).ToList();
        var removedContracts = previousContracts.Except(currentContracts).ToList();

        addedContracts.Sort();
        if (addedContracts.Count > 0) {
            reportWriter.WriteListStart("ADDED_CONTRACTS", "total", addedContracts.Count);
            foreach (var addedContract in addedContracts) {
                reportWriter.WriteListItem("{0}", addedContract);
            }
            reportWriter.WriteListEnd();
        }

        removedContracts.Sort();
        if (removedContracts.Count > 0) {
            reportWriter.WriteListStart("REMOVED_CONTRACTS", "total", removedContracts.Count);
            foreach (var removedContract in removedContracts) {
                reportWriter.WriteListItem("\t{0}", removedContract);
            }
            reportWriter.WriteListEnd();
        }

        if (moved.Count > 0) {
            reportWriter.WriteListStart("MOVED_TYPES", "total", moved.Count, "description", "corefx types that changed their location");

            if (unknownMoves.Count > 0) {
                reportWriter.WriteListStart("MOVED_NEEDS_REVIEW");
                foreach (var movedType in unknownMoves) {
                    reportWriter.WriteListItem(string.Format("{0} moved from {1}", movedType.AssemblyQualifiedName, movedType.PreviousAssembly));
                    if (movedType.PreviousAssembly == "System.Runtime") {
                        var tempColor = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("{0} moved from System.Runtime", movedType.AssemblyQualifiedName);
                        Console.ForegroundColor = tempColor;
                    }
                }
                reportWriter.WriteListEnd();
            }

            if (validMoves.Count > 0) {
                reportWriter.WriteListStart("MOVED_VALID");
                foreach (var movedType in validMoves) {
                    reportWriter.WriteListItem(string.Format("{0} moved from {1}", movedType.AssemblyQualifiedName, movedType.PreviousAssembly));
                }
                reportWriter.WriteListEnd();
            }

            if(movedToSystemRuntime.Count > 0) {
                reportWriter.WriteListStart("MOVED_TO_SYSTEM_RUNTIME");
                foreach (var movedType in movedToSystemRuntime) {
                    reportWriter.WriteListItem(string.Format("{0} moved from {1}", movedType.AssemblyQualifiedName, movedType.PreviousAssembly));                   
                }
                reportWriter.WriteListEnd();
            }

            reportWriter.WriteListEnd();
        }

        if (added.Count > 0) {
            reportWriter.WriteListStart("TYPES_NOT_IN_CORFX", "total", added.Count);
            foreach (var addedType in added) {
                reportWriter.WriteListItem(addedType.AssemblyQualifiedName);
            }
            reportWriter.WriteListEnd();
        }

        if (removed.Count > 0) {
            reportWriter.WriteListStart("TYPES_NOT_IN_MASTER_API", "total", removed.Count);
            foreach (var removedType in removed) {
                reportWriter.WriteListItem(removedType.AssemblyQualifiedName);
            }
            reportWriter.WriteListEnd();
        }
    }

    public static void GenerateDump(string directory, List<ReportType> types, bool current)
    {
        var files = Directory.GetFiles(directory, "*.dll");
        foreach (var file in files) {

            var assembly = Path.GetFileNameWithoutExtension(file);

            using (var stream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (var reader = new PEReader(stream)) {
                var mr = reader.GetMetadataReader();
                var loadedTypes = mr.TypeDefinitions;
                foreach (var type in loadedTypes) {
                    var etype = mr.GetTypeDefinition(type);
                    var nameHandle = etype.Name;
                    var name = mr.GetString(nameHandle);
                    var namespaceHandle = etype.Namespace;
                    var ns = mr.GetString(namespaceHandle);

                    if (name == "<Module>") continue;
                    if (string.IsNullOrEmpty(ns)) continue; // TODO: this needs to be removed and fixed

                    var typeName = ns + "." + name;

                    ReportType rt;
                    var index = types.FindIndex((item) => { return item.FullName == typeName; });
                    if(index >= 0) {
                        rt = types[index];
                    }
                    else {
                        rt = new ReportType();
                        rt.Name = name;
                        rt.Namespace = ns;
                        types.Add(rt);
                    }

                    if (current) {
                        rt.CurrentAssembly = assembly;
                    }
                    else {
                        rt.PreviousAssembly = assembly;
                    }
                }
            }
        }
    }

    static bool IsValidMove(string from, string to)
    {
        var index = s_validMoves.FindIndex((move) => move.From == from && move.To == to);
        return index >= 0;
    }
}

