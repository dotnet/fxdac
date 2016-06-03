[assembly:System.CLSCompliant(true)]
namespace System.Security.Principal {
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class IdentityNotMappedException : System.SystemException {
    public IdentityNotMappedException() { }
    public IdentityNotMappedException(string message) { }
    public IdentityNotMappedException(string message, System.Exception inner) { }
    public System.Security.Principal.IdentityReferenceCollection UnmappedIdentities { get { return default(System.Security.Principal.IdentityReferenceCollection); } }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
  }

  [System.FlagsAttribute]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum TokenAccessLevels {
    AdjustDefault = 128,
    AdjustGroups = 64,
    AdjustPrivileges = 32,
    AdjustSessionId = 256,
    AllAccess = 983551,
    AssignPrimary = 1,
    Duplicate = 2,
    Impersonate = 4,
    MaximumAllowed = 33554432,
    Query = 8,
    QuerySource = 16,
    Read = 131080,
    Write = 131296,
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum WindowsAccountType {
    Anonymous = 3,
    Guest = 1,
    Normal = 0,
    System = 2,
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum WindowsBuiltInRole {
    AccountOperator = 548,
    Administrator = 544,
    BackupOperator = 551,
    Guest = 546,
    PowerUser = 547,
    PrintOperator = 550,
    Replicator = 552,
    SystemOperator = 549,
    User = 545,
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class WindowsIdentity : System.Security.Claims.ClaimsIdentity, System.IDisposable, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable, System.Security.Principal.IIdentity {
    public const string DefaultIssuer = "AD AUTHORITY";
    public WindowsIdentity(System.IntPtr userToken) { }
    public WindowsIdentity(System.IntPtr userToken, string type) { }
    public WindowsIdentity(System.IntPtr userToken, string type, System.Security.Principal.WindowsAccountType acctType) { }
    public WindowsIdentity(System.IntPtr userToken, string type, System.Security.Principal.WindowsAccountType acctType, bool isAuthenticated) { }
    public WindowsIdentity(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public WindowsIdentity(string sUserPrincipalName) { }
    public WindowsIdentity(string sUserPrincipalName, string type) { }
    public sealed override string AuthenticationType { get { return default(string); } }
    public System.Security.Principal.IdentityReferenceCollection Groups { get { return default(System.Security.Principal.IdentityReferenceCollection); } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.Security.Principal.TokenImpersonationLevel ImpersonationLevel { get { return default(System.Security.Principal.TokenImpersonationLevel); } }
    public virtual bool IsAnonymous { get { return default(bool); } }
    public override bool IsAuthenticated { get { return default(bool); } }
    public virtual bool IsGuest { get { return default(bool); } }
    public virtual bool IsSystem { get { return default(bool); } }
    public override string Name { get { return default(string); } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.Security.Principal.SecurityIdentifier Owner { get { return default(System.Security.Principal.SecurityIdentifier); } }
    public virtual System.IntPtr Token { get { return default(System.IntPtr); } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.Security.Principal.SecurityIdentifier User { get { return default(System.Security.Principal.SecurityIdentifier); } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public void Dispose() { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    protected virtual void Dispose(bool disposing) { }
    public static System.Security.Principal.WindowsIdentity GetAnonymous() { return default(System.Security.Principal.WindowsIdentity); }
    public static System.Security.Principal.WindowsIdentity GetCurrent() { return default(System.Security.Principal.WindowsIdentity); }
    public static System.Security.Principal.WindowsIdentity GetCurrent(bool ifImpersonating) { return default(System.Security.Principal.WindowsIdentity); }
    public static System.Security.Principal.WindowsIdentity GetCurrent(System.Security.Principal.TokenAccessLevels desiredAccess) { return default(System.Security.Principal.WindowsIdentity); }
    public virtual System.Security.Principal.WindowsImpersonationContext Impersonate() { return default(System.Security.Principal.WindowsImpersonationContext); }
    public static System.Security.Principal.WindowsImpersonationContext Impersonate(System.IntPtr userToken) { return default(System.Security.Principal.WindowsImpersonationContext); }
    void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class WindowsImpersonationContext : System.IDisposable {
    internal WindowsImpersonationContext() { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public void Dispose() { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    protected virtual void Dispose(bool disposing) { }
    public void Undo() { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class WindowsPrincipal : System.Security.Claims.ClaimsPrincipal {
    public WindowsPrincipal(System.Security.Principal.WindowsIdentity ntIdentity) { }
    public override System.Security.Principal.IIdentity Identity { get { return default(System.Security.Principal.IIdentity); } }
    public virtual bool IsInRole(int rid) { return default(bool); }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public virtual bool IsInRole(System.Security.Principal.SecurityIdentifier sid) { return default(bool); }
    public virtual bool IsInRole(System.Security.Principal.WindowsBuiltInRole role) { return default(bool); }
    public override bool IsInRole(string role) { return default(bool); }
  }

} // end of System.Security.Principal
