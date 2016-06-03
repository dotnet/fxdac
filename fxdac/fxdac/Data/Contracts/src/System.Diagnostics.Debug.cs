[assembly:System.CLSCompliant(true)]
namespace System.Diagnostics {
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class Debugger {
    public static readonly string DefaultCategory;
    [System.ObsoleteAttribute("Call the static methods directly on this type", true)]
    public Debugger() { }
    public static bool IsAttached { get { return default(bool); } }
    public static void Break() { }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]public static bool IsLogging() { return default(bool); }
    public static bool Launch() { return default(bool); }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]public static void Log(int level, string category, string message) { }
    public static void NotifyOfCrossThreadDependency() { }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(96), Inherited=false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class DebuggerStepperBoundaryAttribute : System.Attribute {
    public DebuggerStepperBoundaryAttribute() { }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(13), AllowMultiple=true)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class DebuggerVisualizerAttribute : System.Attribute {
    public DebuggerVisualizerAttribute(string visualizerTypeName) { }
    public DebuggerVisualizerAttribute(string visualizerTypeName, string visualizerObjectSourceTypeName) { }
    public DebuggerVisualizerAttribute(string visualizerTypeName, System.Type visualizerObjectSource) { }
    public DebuggerVisualizerAttribute(System.Type visualizer) { }
    public DebuggerVisualizerAttribute(System.Type visualizer, string visualizerObjectSourceTypeName) { }
    public DebuggerVisualizerAttribute(System.Type visualizer, System.Type visualizerObjectSource) { }
    public string Description { get { return default(string); } set { } }
    public System.Type Target { get { return default(System.Type); } set { } }
    public string TargetTypeName { get { return default(string); } set { } }
    public string VisualizerObjectSourceTypeName { get { return default(string); } }
    public string VisualizerTypeName { get { return default(string); } }
  }

} // end of System.Diagnostics
