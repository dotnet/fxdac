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
namespace System.Security.AccessControl {
  public sealed partial class RegistryAccessRule : System.Security.AccessControl.AccessRule {
    public RegistryAccessRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.RegistryRights registryRights, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
    public RegistryAccessRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.RegistryRights registryRights, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
    public RegistryAccessRule(string identity, System.Security.AccessControl.RegistryRights registryRights, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
    public RegistryAccessRule(string identity, System.Security.AccessControl.RegistryRights registryRights, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
    public System.Security.AccessControl.RegistryRights RegistryRights { get { return default(System.Security.AccessControl.RegistryRights); } }
  }

  public sealed partial class RegistryAuditRule : System.Security.AccessControl.AuditRule {
    public RegistryAuditRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.RegistryRights registryRights, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
    public RegistryAuditRule(string identity, System.Security.AccessControl.RegistryRights registryRights, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
    public System.Security.AccessControl.RegistryRights RegistryRights { get { return default(System.Security.AccessControl.RegistryRights); } }
  }

  [System.FlagsAttribute]
  public enum RegistryRights {
    ChangePermissions = 262144,
    CreateLink = 32,
    CreateSubKey = 4,
    Delete = 65536,
    EnumerateSubKeys = 8,
    ExecuteKey = 131097,
    FullControl = 983103,
    Notify = 16,
    QueryValues = 1,
    ReadKey = 131097,
    ReadPermissions = 131072,
    SetValue = 2,
    TakeOwnership = 524288,
    WriteKey = 131078,
  }

  public sealed partial class RegistrySecurity : System.Security.AccessControl.NativeObjectSecurity {
    public RegistrySecurity() : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
    public override System.Type AccessRightType { get { return default(System.Type); } }
    public override System.Type AccessRuleType { get { return default(System.Type); } }
    public override System.Type AuditRuleType { get { return default(System.Type); } }
    public override System.Security.AccessControl.AccessRule AccessRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type) { return default(System.Security.AccessControl.AccessRule); }
    public void AddAccessRule(System.Security.AccessControl.RegistryAccessRule rule) { }
    public void AddAuditRule(System.Security.AccessControl.RegistryAuditRule rule) { }
    public override System.Security.AccessControl.AuditRule AuditRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags) { return default(System.Security.AccessControl.AuditRule); }
    public bool RemoveAccessRule(System.Security.AccessControl.RegistryAccessRule rule) { return default(bool); }
    public void RemoveAccessRuleAll(System.Security.AccessControl.RegistryAccessRule rule) { }
    public void RemoveAccessRuleSpecific(System.Security.AccessControl.RegistryAccessRule rule) { }
    public bool RemoveAuditRule(System.Security.AccessControl.RegistryAuditRule rule) { return default(bool); }
    public void RemoveAuditRuleAll(System.Security.AccessControl.RegistryAuditRule rule) { }
    public void RemoveAuditRuleSpecific(System.Security.AccessControl.RegistryAuditRule rule) { }
    public void ResetAccessRule(System.Security.AccessControl.RegistryAccessRule rule) { }
    public void SetAccessRule(System.Security.AccessControl.RegistryAccessRule rule) { }
    public void SetAuditRule(System.Security.AccessControl.RegistryAuditRule rule) { }
  }

} // end of System.Security.AccessControl
