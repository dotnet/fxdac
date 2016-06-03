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
