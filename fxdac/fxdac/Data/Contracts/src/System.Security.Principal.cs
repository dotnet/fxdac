[assembly:System.CLSCompliant(true)]
namespace System.Security.Principal {
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface IIdentity {
    string AuthenticationType { get; }
    bool IsAuthenticated { get; }
    string Name { get; }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface IPrincipal {
    System.Security.Principal.IIdentity Identity { get; }
    bool IsInRole(string role);
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum PrincipalPolicy {
    NoPrincipal = 1,
    UnauthenticatedPrincipal = 0,
    WindowsPrincipal = 2,
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum TokenImpersonationLevel {
    Anonymous = 1,
    Delegation = 4,
    Identification = 2,
    Impersonation = 3,
    None = 0,
  }

} // end of System.Security.Principal
