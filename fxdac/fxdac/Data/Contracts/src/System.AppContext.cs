[assembly:System.CLSCompliant(true)]
namespace System {
  public static partial class AppContext {
    public static string BaseDirectory { get { return default(string); } }
    public static string TargetFrameworkName { get { return default(string); } }
    public static object GetData(string name) { return default(object); }
    public static void SetSwitch(string switchName, bool isEnabled) { }
    public static bool TryGetSwitch(string switchName, out bool isEnabled) { isEnabled = default(bool); return default(bool); }
  }

} // end of System
