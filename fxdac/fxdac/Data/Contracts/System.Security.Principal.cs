[assembly:System.CLSCompliant(true)]
namespace System.Security.Principal {
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum TokenImpersonationLevel {
    Anonymous = 1,
    Delegation = 4,
    Identification = 2,
    Impersonation = 3,
    None = 0,
  }

} // end of System.Security.Principal
