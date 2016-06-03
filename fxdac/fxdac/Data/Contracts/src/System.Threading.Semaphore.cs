[assembly:System.CLSCompliant(true)]
namespace System.Security.AccessControl {
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class SemaphoreAccessRule : System.Security.AccessControl.AccessRule {
    public SemaphoreAccessRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.SemaphoreRights semaphoreRights, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
    public SemaphoreAccessRule(string identity, System.Security.AccessControl.SemaphoreRights semaphoreRights, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
    public System.Security.AccessControl.SemaphoreRights SemaphoreRights { get { return default(System.Security.AccessControl.SemaphoreRights); } }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class SemaphoreAuditRule : System.Security.AccessControl.AuditRule {
    public SemaphoreAuditRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.SemaphoreRights semaphoreRights, System.Security.AccessControl.AuditFlags flags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
    public System.Security.AccessControl.SemaphoreRights SemaphoreRights { get { return default(System.Security.AccessControl.SemaphoreRights); } }
  }

  [System.FlagsAttribute]
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public enum SemaphoreRights {
    ChangePermissions = 262144,
    Delete = 65536,
    FullControl = 2031619,
    Modify = 2,
    ReadPermissions = 131072,
    Synchronize = 1048576,
    TakeOwnership = 524288,
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class SemaphoreSecurity : System.Security.AccessControl.NativeObjectSecurity {
    public SemaphoreSecurity() : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
    public SemaphoreSecurity(string name, System.Security.AccessControl.AccessControlSections includeSections) : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
    public override System.Type AccessRightType { get { return default(System.Type); } }
    public override System.Type AccessRuleType { get { return default(System.Type); } }
    public override System.Type AuditRuleType { get { return default(System.Type); } }
    public override System.Security.AccessControl.AccessRule AccessRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type) { return default(System.Security.AccessControl.AccessRule); }
    public void AddAccessRule(System.Security.AccessControl.SemaphoreAccessRule rule) { }
    public void AddAuditRule(System.Security.AccessControl.SemaphoreAuditRule rule) { }
    public override System.Security.AccessControl.AuditRule AuditRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags) { return default(System.Security.AccessControl.AuditRule); }
    public bool RemoveAccessRule(System.Security.AccessControl.SemaphoreAccessRule rule) { return default(bool); }
    public void RemoveAccessRuleAll(System.Security.AccessControl.SemaphoreAccessRule rule) { }
    public void RemoveAccessRuleSpecific(System.Security.AccessControl.SemaphoreAccessRule rule) { }
    public bool RemoveAuditRule(System.Security.AccessControl.SemaphoreAuditRule rule) { return default(bool); }
    public void RemoveAuditRuleAll(System.Security.AccessControl.SemaphoreAuditRule rule) { }
    public void RemoveAuditRuleSpecific(System.Security.AccessControl.SemaphoreAuditRule rule) { }
    public void ResetAccessRule(System.Security.AccessControl.SemaphoreAccessRule rule) { }
    public void SetAccessRule(System.Security.AccessControl.SemaphoreAccessRule rule) { }
    public void SetAuditRule(System.Security.AccessControl.SemaphoreAuditRule rule) { }
  }

} // end of System.Security.AccessControl
namespace System.Security.Permissions {
  public sealed partial class TypeDescriptorPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission {
    public TypeDescriptorPermission(System.Security.Permissions.PermissionState state) { }
    public TypeDescriptorPermission(System.Security.Permissions.TypeDescriptorPermissionFlags flag) { }
    public System.Security.Permissions.TypeDescriptorPermissionFlags Flags { get { return default(System.Security.Permissions.TypeDescriptorPermissionFlags); } set { } }
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    public override void FromXml(System.Security.SecurityElement securityElement) { }
    public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public bool IsUnrestricted() { return default(bool); }
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
  }

  [System.FlagsAttribute]
  public enum TypeDescriptorPermissionFlags {
    NoFlags = 0,
    RestrictedRegistrationAccess = 1,
  }

} // end of System.Security.Permissions
namespace System.Threading {
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class Semaphore : System.Threading.WaitHandle {
    public Semaphore(int initialCount, int maximumCount) { }
    public Semaphore(int initialCount, int maximumCount, string name) { }
    public Semaphore(int initialCount, int maximumCount, string name, out bool createdNew) { createdNew = default(bool); }
    public Semaphore(int initialCount, int maximumCount, string name, out bool createdNew, System.Security.AccessControl.SemaphoreSecurity semaphoreSecurity) { createdNew = default(bool); }
    public System.Security.AccessControl.SemaphoreSecurity GetAccessControl() { return default(System.Security.AccessControl.SemaphoreSecurity); }
    public static System.Threading.Semaphore OpenExisting(string name) { return default(System.Threading.Semaphore); }
    public static System.Threading.Semaphore OpenExisting(string name, System.Security.AccessControl.SemaphoreRights rights) { return default(System.Threading.Semaphore); }
    [System.Runtime.ConstrainedExecution.PrePrepareMethodAttribute]
    [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
    public int Release() { return default(int); }
    [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]
    public int Release(int releaseCount) { return default(int); }
    public void SetAccessControl(System.Security.AccessControl.SemaphoreSecurity semaphoreSecurity) { }
    public static bool TryOpenExisting(string name, System.Security.AccessControl.SemaphoreRights rights, out System.Threading.Semaphore result) { result = default(System.Threading.Semaphore); return default(bool); }
    public static bool TryOpenExisting(string name, out System.Threading.Semaphore result) { result = default(System.Threading.Semaphore); return default(bool); }
  }

  public partial class ThreadExceptionEventArgs : System.EventArgs {
    public ThreadExceptionEventArgs(System.Exception t) { }
    public System.Exception Exception { get { return default(System.Exception); } }
  }

  public delegate void ThreadExceptionEventHandler(object sender, System.Threading.ThreadExceptionEventArgs e);

} // end of System.Threading
