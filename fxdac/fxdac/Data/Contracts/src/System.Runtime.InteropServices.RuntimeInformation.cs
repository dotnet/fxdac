[assembly:System.CLSCompliant(true)]
namespace System.Runtime.InteropServices {
  public enum Architecture {
    Arm = 2,
    Arm64 = 3,
    X64 = 1,
    X86 = 0,
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct OSPlatform : System.IEquatable<System.Runtime.InteropServices.OSPlatform> {
    public static System.Runtime.InteropServices.OSPlatform Linux { get { return default(System.Runtime.InteropServices.OSPlatform); } }
    public static System.Runtime.InteropServices.OSPlatform OSX { get { return default(System.Runtime.InteropServices.OSPlatform); } }
    public static System.Runtime.InteropServices.OSPlatform Windows { get { return default(System.Runtime.InteropServices.OSPlatform); } }
    public static System.Runtime.InteropServices.OSPlatform Create(string osPlatform) { return default(System.Runtime.InteropServices.OSPlatform); }
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.Runtime.InteropServices.OSPlatform other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Runtime.InteropServices.OSPlatform left, System.Runtime.InteropServices.OSPlatform right) { return default(bool); }
    public static bool operator !=(System.Runtime.InteropServices.OSPlatform left, System.Runtime.InteropServices.OSPlatform right) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  public static partial class RuntimeInformation {
    public static string FrameworkDescription { get { return default(string); } }
    public static System.Runtime.InteropServices.Architecture OSArchitecture { get { return default(System.Runtime.InteropServices.Architecture); } }
    public static string OSDescription { get { return default(string); } }
    public static System.Runtime.InteropServices.Architecture ProcessArchitecture { get { return default(System.Runtime.InteropServices.Architecture); } }
    public static bool IsOSPlatform(System.Runtime.InteropServices.OSPlatform osPlatform) { return default(bool); }
  }
} // end of System.Runtime.InteropServices
