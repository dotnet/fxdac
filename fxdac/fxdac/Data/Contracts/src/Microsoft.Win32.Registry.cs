[assembly:System.CLSCompliant(true)]
namespace Microsoft.Win32 {
  [System.FlagsAttribute]
  public enum RegistryOptions {
    None = 0,
    Volatile = 1,
  }

  public enum RegistryView {
    Default = 0,
    Registry32 = 512,
    Registry64 = 256,
  }

} // end of Microsoft.Win32
namespace Microsoft.Win32.SafeHandles {
  [System.Security.SecurityCriticalAttribute]
  public sealed partial class SafeRegistryHandle : Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid {
    [System.Security.SecurityCriticalAttribute]
    public SafeRegistryHandle(System.IntPtr preexistingHandle, bool ownsHandle) : base (default(bool)) { }
    [System.Security.SecurityCriticalAttribute]
    protected override bool ReleaseHandle() { return default(bool); }
  }

} // end of Microsoft.Win32.SafeHandles
