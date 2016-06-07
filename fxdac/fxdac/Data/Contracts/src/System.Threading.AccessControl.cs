[assembly:System.CLSCompliant(true)]
namespace System.Security.AccessControl {
  public sealed partial class EventWaitHandleAccessRule : System.Security.AccessControl.AccessRule {
    public EventWaitHandleAccessRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.EventWaitHandleRights eventRights, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
    public EventWaitHandleAccessRule(string identity, System.Security.AccessControl.EventWaitHandleRights eventRights, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
    public System.Security.AccessControl.EventWaitHandleRights EventWaitHandleRights { get { return default(System.Security.AccessControl.EventWaitHandleRights); } }
  }

  public sealed partial class EventWaitHandleAuditRule : System.Security.AccessControl.AuditRule {
    public EventWaitHandleAuditRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.EventWaitHandleRights eventRights, System.Security.AccessControl.AuditFlags flags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
    public System.Security.AccessControl.EventWaitHandleRights EventWaitHandleRights { get { return default(System.Security.AccessControl.EventWaitHandleRights); } }
  }

  [System.FlagsAttribute]
  public enum EventWaitHandleRights {
    ChangePermissions = 262144,
    Delete = 65536,
    FullControl = 2031619,
    Modify = 2,
    ReadPermissions = 131072,
    Synchronize = 1048576,
    TakeOwnership = 524288,
  }

  public sealed partial class EventWaitHandleSecurity : System.Security.AccessControl.NativeObjectSecurity {
    public EventWaitHandleSecurity() : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
    public override System.Type AccessRightType { get { return default(System.Type); } }
    public override System.Type AccessRuleType { get { return default(System.Type); } }
    public override System.Type AuditRuleType { get { return default(System.Type); } }
    public override System.Security.AccessControl.AccessRule AccessRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type) { return default(System.Security.AccessControl.AccessRule); }
    public void AddAccessRule(System.Security.AccessControl.EventWaitHandleAccessRule rule) { }
    public void AddAuditRule(System.Security.AccessControl.EventWaitHandleAuditRule rule) { }
    public override System.Security.AccessControl.AuditRule AuditRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags) { return default(System.Security.AccessControl.AuditRule); }
    public bool RemoveAccessRule(System.Security.AccessControl.EventWaitHandleAccessRule rule) { return default(bool); }
    public void RemoveAccessRuleAll(System.Security.AccessControl.EventWaitHandleAccessRule rule) { }
    public void RemoveAccessRuleSpecific(System.Security.AccessControl.EventWaitHandleAccessRule rule) { }
    public bool RemoveAuditRule(System.Security.AccessControl.EventWaitHandleAuditRule rule) { return default(bool); }
    public void RemoveAuditRuleAll(System.Security.AccessControl.EventWaitHandleAuditRule rule) { }
    public void RemoveAuditRuleSpecific(System.Security.AccessControl.EventWaitHandleAuditRule rule) { }
    public void ResetAccessRule(System.Security.AccessControl.EventWaitHandleAccessRule rule) { }
    public void SetAccessRule(System.Security.AccessControl.EventWaitHandleAccessRule rule) { }
    public void SetAuditRule(System.Security.AccessControl.EventWaitHandleAuditRule rule) { }
  }

  public sealed partial class MutexAccessRule : System.Security.AccessControl.AccessRule {
    public MutexAccessRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.MutexRights eventRights, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
    public MutexAccessRule(string identity, System.Security.AccessControl.MutexRights eventRights, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
    public System.Security.AccessControl.MutexRights MutexRights { get { return default(System.Security.AccessControl.MutexRights); } }
  }

  public sealed partial class MutexAuditRule : System.Security.AccessControl.AuditRule {
    public MutexAuditRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.MutexRights eventRights, System.Security.AccessControl.AuditFlags flags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
    public System.Security.AccessControl.MutexRights MutexRights { get { return default(System.Security.AccessControl.MutexRights); } }
  }

  [System.FlagsAttribute]
  public enum MutexRights {
    ChangePermissions = 262144,
    Delete = 65536,
    FullControl = 2031617,
    Modify = 1,
    ReadPermissions = 131072,
    Synchronize = 1048576,
    TakeOwnership = 524288,
  }

  public sealed partial class MutexSecurity : System.Security.AccessControl.NativeObjectSecurity {
    public MutexSecurity() : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
    public MutexSecurity(string name, System.Security.AccessControl.AccessControlSections includeSections) : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
    public override System.Type AccessRightType { get { return default(System.Type); } }
    public override System.Type AccessRuleType { get { return default(System.Type); } }
    public override System.Type AuditRuleType { get { return default(System.Type); } }
    public override System.Security.AccessControl.AccessRule AccessRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type) { return default(System.Security.AccessControl.AccessRule); }
    public void AddAccessRule(System.Security.AccessControl.MutexAccessRule rule) { }
    public void AddAuditRule(System.Security.AccessControl.MutexAuditRule rule) { }
    public override System.Security.AccessControl.AuditRule AuditRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags) { return default(System.Security.AccessControl.AuditRule); }
    public bool RemoveAccessRule(System.Security.AccessControl.MutexAccessRule rule) { return default(bool); }
    public void RemoveAccessRuleAll(System.Security.AccessControl.MutexAccessRule rule) { }
    public void RemoveAccessRuleSpecific(System.Security.AccessControl.MutexAccessRule rule) { }
    public bool RemoveAuditRule(System.Security.AccessControl.MutexAuditRule rule) { return default(bool); }
    public void RemoveAuditRuleAll(System.Security.AccessControl.MutexAuditRule rule) { }
    public void RemoveAuditRuleSpecific(System.Security.AccessControl.MutexAuditRule rule) { }
    public void ResetAccessRule(System.Security.AccessControl.MutexAccessRule rule) { }
    public void SetAccessRule(System.Security.AccessControl.MutexAccessRule rule) { }
    public void SetAuditRule(System.Security.AccessControl.MutexAuditRule rule) { }
  }

} // end of System.Security.AccessControl
