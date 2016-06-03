[assembly:System.CLSCompliant(true)]
namespace System.Security.AccessControl {
  [System.FlagsAttribute]
  public enum AccessControlActions {
    Change = 2,
    None = 0,
    View = 1,
  }

  public enum AccessControlModification {
    Add = 0,
    Remove = 3,
    RemoveAll = 4,
    RemoveSpecific = 5,
    Reset = 2,
    Set = 1,
  }

  [System.FlagsAttribute]
  public enum AccessControlSections {
    Access = 2,
    All = 15,
    Audit = 1,
    Group = 8,
    None = 0,
    Owner = 4,
  }

  public enum AccessControlType {
    Allow = 0,
    Deny = 1,
  }

  public abstract partial class AccessRule : System.Security.AccessControl.AuthorizationRule {
    protected AccessRule(System.Security.Principal.IdentityReference identity, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags)) { }
    public System.Security.AccessControl.AccessControlType AccessControlType { get { return default(System.Security.AccessControl.AccessControlType); } }
  }

  public partial class AccessRule<T> : System.Security.AccessControl.AccessRule where T : struct {
    public AccessRule(System.Security.Principal.IdentityReference identity, T rights, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
    public AccessRule(System.Security.Principal.IdentityReference identity, T rights, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
    public AccessRule(string identity, T rights, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
    public AccessRule(string identity, T rights, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
    public T Rights { get { return default(T); } }
  }

  public sealed partial class AceEnumerator : System.Collections.IEnumerator {
    internal AceEnumerator() { }
    public System.Security.AccessControl.GenericAce Current { get { return default(System.Security.AccessControl.GenericAce); } }
    object System.Collections.IEnumerator.Current { get { return default(object); } }
    public bool MoveNext() { return default(bool); }
    public void Reset() { }
  }

  [System.FlagsAttribute]
  public enum AceFlags : byte {
    AuditFlags = (byte)192,
    ContainerInherit = (byte)2,
    FailedAccess = (byte)128,
    InheritanceFlags = (byte)15,
    Inherited = (byte)16,
    InheritOnly = (byte)8,
    None = (byte)0,
    NoPropagateInherit = (byte)4,
    ObjectInherit = (byte)1,
    SuccessfulAccess = (byte)64,
  }

  public enum AceQualifier {
    AccessAllowed = 0,
    AccessDenied = 1,
    SystemAlarm = 3,
    SystemAudit = 2,
  }

  public enum AceType {
    AccessAllowed = 0,
    AccessAllowedCallback = 9,
    AccessAllowedCallbackObject = 11,
    AccessAllowedCompound = 4,
    AccessAllowedObject = 5,
    AccessDenied = 1,
    AccessDeniedCallback = 10,
    AccessDeniedCallbackObject = 12,
    AccessDeniedObject = 6,
    MaxDefinedAceType = 16,
    SystemAlarm = 3,
    SystemAlarmCallback = 14,
    SystemAlarmCallbackObject = 16,
    SystemAlarmObject = 8,
    SystemAudit = 2,
    SystemAuditCallback = 13,
    SystemAuditCallbackObject = 15,
    SystemAuditObject = 7,
  }

  [System.FlagsAttribute]
  public enum AuditFlags {
    Failure = 2,
    None = 0,
    Success = 1,
  }

  public abstract partial class AuditRule : System.Security.AccessControl.AuthorizationRule {
    protected AuditRule(System.Security.Principal.IdentityReference identity, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags auditFlags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags)) { }
    public System.Security.AccessControl.AuditFlags AuditFlags { get { return default(System.Security.AccessControl.AuditFlags); } }
  }

  public partial class AuditRule<T> : System.Security.AccessControl.AuditRule where T : struct {
    public AuditRule(System.Security.Principal.IdentityReference identity, T rights, System.Security.AccessControl.AuditFlags flags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
    public AuditRule(System.Security.Principal.IdentityReference identity, T rights, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
    public AuditRule(string identity, T rights, System.Security.AccessControl.AuditFlags flags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
    public AuditRule(string identity, T rights, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
    public T Rights { get { return default(T); } }
  }

  public abstract partial class AuthorizationRule {
    protected internal AuthorizationRule(System.Security.Principal.IdentityReference identity, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags) { }
    protected internal int AccessMask { get { return default(int); } }
    public System.Security.Principal.IdentityReference IdentityReference { get { return default(System.Security.Principal.IdentityReference); } }
    public System.Security.AccessControl.InheritanceFlags InheritanceFlags { get { return default(System.Security.AccessControl.InheritanceFlags); } }
    public bool IsInherited { get { return default(bool); } }
    public System.Security.AccessControl.PropagationFlags PropagationFlags { get { return default(System.Security.AccessControl.PropagationFlags); } }
  }

  public sealed partial class AuthorizationRuleCollection : System.Collections.ReadOnlyCollectionBase {
    internal AuthorizationRuleCollection() { }
    public System.Security.AccessControl.AuthorizationRule this[int index] { get { return default(System.Security.AccessControl.AuthorizationRule); } }
    public void CopyTo(System.Security.AccessControl.AuthorizationRule[] rules, int index) { }
  }

  public sealed partial class CommonAce : System.Security.AccessControl.QualifiedAce {
    public CommonAce(System.Security.AccessControl.AceFlags flags, System.Security.AccessControl.AceQualifier qualifier, int accessMask, System.Security.Principal.SecurityIdentifier sid, bool isCallback, byte[] opaque) { }
    public override int BinaryLength { get { return default(int); } }
    public override void GetBinaryForm(byte[] binaryForm, int offset) { }
    public static int MaxOpaqueLength(bool isCallback) { return default(int); }
  }

  public abstract partial class CommonAcl : System.Security.AccessControl.GenericAcl {
    internal CommonAcl() { }
    public sealed override int BinaryLength { get { return default(int); } }
    public sealed override int Count { get { return default(int); } }
    public bool IsCanonical { get { return default(bool); } }
    public bool IsContainer { get { return default(bool); } }
    public bool IsDS { get { return default(bool); } }
    public sealed override System.Security.AccessControl.GenericAce this[int index] { get { return default(System.Security.AccessControl.GenericAce); } set { } }
    public sealed override byte Revision { get { return default(byte); } }
    public sealed override void GetBinaryForm(byte[] binaryForm, int offset) { }
    public void Purge(System.Security.Principal.SecurityIdentifier sid) { }
    public void RemoveInheritedAces() { }
  }

  public abstract partial class CommonObjectSecurity : System.Security.AccessControl.ObjectSecurity {
    protected CommonObjectSecurity(bool isContainer) : base (default(bool), default(bool)) { }
    protected void AddAccessRule(System.Security.AccessControl.AccessRule rule) { }
    protected void AddAuditRule(System.Security.AccessControl.AuditRule rule) { }
    public System.Security.AccessControl.AuthorizationRuleCollection GetAccessRules(bool includeExplicit, bool includeInherited, System.Type targetType) { return default(System.Security.AccessControl.AuthorizationRuleCollection); }
    public System.Security.AccessControl.AuthorizationRuleCollection GetAuditRules(bool includeExplicit, bool includeInherited, System.Type targetType) { return default(System.Security.AccessControl.AuthorizationRuleCollection); }
    protected override bool ModifyAccess(System.Security.AccessControl.AccessControlModification modification, System.Security.AccessControl.AccessRule rule, out bool modified) { modified = default(bool); return default(bool); }
    protected override bool ModifyAudit(System.Security.AccessControl.AccessControlModification modification, System.Security.AccessControl.AuditRule rule, out bool modified) { modified = default(bool); return default(bool); }
    protected bool RemoveAccessRule(System.Security.AccessControl.AccessRule rule) { return default(bool); }
    protected void RemoveAccessRuleAll(System.Security.AccessControl.AccessRule rule) { }
    protected void RemoveAccessRuleSpecific(System.Security.AccessControl.AccessRule rule) { }
    protected bool RemoveAuditRule(System.Security.AccessControl.AuditRule rule) { return default(bool); }
    protected void RemoveAuditRuleAll(System.Security.AccessControl.AuditRule rule) { }
    protected void RemoveAuditRuleSpecific(System.Security.AccessControl.AuditRule rule) { }
    protected void ResetAccessRule(System.Security.AccessControl.AccessRule rule) { }
    protected void SetAccessRule(System.Security.AccessControl.AccessRule rule) { }
    protected void SetAuditRule(System.Security.AccessControl.AuditRule rule) { }
  }

  public sealed partial class CommonSecurityDescriptor : System.Security.AccessControl.GenericSecurityDescriptor {
    public CommonSecurityDescriptor(bool isContainer, bool isDS, byte[] binaryForm, int offset) { }
    public CommonSecurityDescriptor(bool isContainer, bool isDS, System.Security.AccessControl.ControlFlags flags, System.Security.Principal.SecurityIdentifier owner, System.Security.Principal.SecurityIdentifier group, System.Security.AccessControl.SystemAcl systemAcl, System.Security.AccessControl.DiscretionaryAcl discretionaryAcl) { }
    public CommonSecurityDescriptor(bool isContainer, bool isDS, System.Security.AccessControl.RawSecurityDescriptor rawSecurityDescriptor) { }
    public CommonSecurityDescriptor(bool isContainer, bool isDS, string sddlForm) { }
    public override System.Security.AccessControl.ControlFlags ControlFlags { get { return default(System.Security.AccessControl.ControlFlags); } }
    public System.Security.AccessControl.DiscretionaryAcl DiscretionaryAcl { get { return default(System.Security.AccessControl.DiscretionaryAcl); } set { } }
    public override System.Security.Principal.SecurityIdentifier Group { get { return default(System.Security.Principal.SecurityIdentifier); } set { } }
    public bool IsContainer { get { return default(bool); } }
    public bool IsDiscretionaryAclCanonical { get { return default(bool); } }
    public bool IsDS { get { return default(bool); } }
    public bool IsSystemAclCanonical { get { return default(bool); } }
    public override System.Security.Principal.SecurityIdentifier Owner { get { return default(System.Security.Principal.SecurityIdentifier); } set { } }
    public System.Security.AccessControl.SystemAcl SystemAcl { get { return default(System.Security.AccessControl.SystemAcl); } set { } }
    public void PurgeAccessControl(System.Security.Principal.SecurityIdentifier sid) { }
    public void PurgeAudit(System.Security.Principal.SecurityIdentifier sid) { }
    public void SetDiscretionaryAclProtection(bool isProtected, bool preserveInheritance) { }
    public void SetSystemAclProtection(bool isProtected, bool preserveInheritance) { }
  }

  public sealed partial class CompoundAce : System.Security.AccessControl.KnownAce {
    public CompoundAce(System.Security.AccessControl.AceFlags flags, int accessMask, System.Security.AccessControl.CompoundAceType compoundAceType, System.Security.Principal.SecurityIdentifier sid) { }
    public override int BinaryLength { get { return default(int); } }
    public System.Security.AccessControl.CompoundAceType CompoundAceType { get { return default(System.Security.AccessControl.CompoundAceType); } set { } }
    public override void GetBinaryForm(byte[] binaryForm, int offset) { }
  }

  public enum CompoundAceType {
    Impersonation = 1,
  }

  [System.FlagsAttribute]
  public enum ControlFlags {
    DiscretionaryAclAutoInherited = 1024,
    DiscretionaryAclAutoInheritRequired = 256,
    DiscretionaryAclDefaulted = 8,
    DiscretionaryAclPresent = 4,
    DiscretionaryAclProtected = 4096,
    DiscretionaryAclUntrusted = 64,
    GroupDefaulted = 2,
    None = 0,
    OwnerDefaulted = 1,
    RMControlValid = 16384,
    SelfRelative = 32768,
    ServerSecurity = 128,
    SystemAclAutoInherited = 2048,
    SystemAclAutoInheritRequired = 512,
    SystemAclDefaulted = 32,
    SystemAclPresent = 16,
    SystemAclProtected = 8192,
  }

  public sealed partial class CryptoKeyAccessRule : System.Security.AccessControl.AccessRule {
    public CryptoKeyAccessRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.CryptoKeyRights cryptoKeyRights, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
    public CryptoKeyAccessRule(string identity, System.Security.AccessControl.CryptoKeyRights cryptoKeyRights, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
    public System.Security.AccessControl.CryptoKeyRights CryptoKeyRights { get { return default(System.Security.AccessControl.CryptoKeyRights); } }
  }

  public sealed partial class CryptoKeyAuditRule : System.Security.AccessControl.AuditRule {
    public CryptoKeyAuditRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.CryptoKeyRights cryptoKeyRights, System.Security.AccessControl.AuditFlags flags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
    public CryptoKeyAuditRule(string identity, System.Security.AccessControl.CryptoKeyRights cryptoKeyRights, System.Security.AccessControl.AuditFlags flags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
    public System.Security.AccessControl.CryptoKeyRights CryptoKeyRights { get { return default(System.Security.AccessControl.CryptoKeyRights); } }
  }

  [System.FlagsAttribute]
  public enum CryptoKeyRights {
    ChangePermissions = 262144,
    Delete = 65536,
    FullControl = 2032027,
    GenericAll = 268435456,
    GenericExecute = 536870912,
    GenericRead = -2147483648,
    GenericWrite = 1073741824,
    ReadAttributes = 128,
    ReadData = 1,
    ReadExtendedAttributes = 8,
    ReadPermissions = 131072,
    Synchronize = 1048576,
    TakeOwnership = 524288,
    WriteAttributes = 256,
    WriteData = 2,
    WriteExtendedAttributes = 16,
  }

  public sealed partial class CryptoKeySecurity : System.Security.AccessControl.NativeObjectSecurity {
    public CryptoKeySecurity() : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
    public CryptoKeySecurity(System.Security.AccessControl.CommonSecurityDescriptor securityDescriptor) : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
    public override System.Type AccessRightType { get { return default(System.Type); } }
    public override System.Type AccessRuleType { get { return default(System.Type); } }
    public override System.Type AuditRuleType { get { return default(System.Type); } }
    public sealed override System.Security.AccessControl.AccessRule AccessRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type) { return default(System.Security.AccessControl.AccessRule); }
    public void AddAccessRule(System.Security.AccessControl.CryptoKeyAccessRule rule) { }
    public void AddAuditRule(System.Security.AccessControl.CryptoKeyAuditRule rule) { }
    public sealed override System.Security.AccessControl.AuditRule AuditRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags) { return default(System.Security.AccessControl.AuditRule); }
    public bool RemoveAccessRule(System.Security.AccessControl.CryptoKeyAccessRule rule) { return default(bool); }
    public void RemoveAccessRuleAll(System.Security.AccessControl.CryptoKeyAccessRule rule) { }
    public void RemoveAccessRuleSpecific(System.Security.AccessControl.CryptoKeyAccessRule rule) { }
    public bool RemoveAuditRule(System.Security.AccessControl.CryptoKeyAuditRule rule) { return default(bool); }
    public void RemoveAuditRuleAll(System.Security.AccessControl.CryptoKeyAuditRule rule) { }
    public void RemoveAuditRuleSpecific(System.Security.AccessControl.CryptoKeyAuditRule rule) { }
    public void ResetAccessRule(System.Security.AccessControl.CryptoKeyAccessRule rule) { }
    public void SetAccessRule(System.Security.AccessControl.CryptoKeyAccessRule rule) { }
    public void SetAuditRule(System.Security.AccessControl.CryptoKeyAuditRule rule) { }
  }

  public sealed partial class CustomAce : System.Security.AccessControl.GenericAce {
    public static readonly int MaxOpaqueLength;
    public CustomAce(System.Security.AccessControl.AceType type, System.Security.AccessControl.AceFlags flags, byte[] opaque) { }
    public override int BinaryLength { get { return default(int); } }
    public int OpaqueLength { get { return default(int); } }
    public override void GetBinaryForm(byte[] binaryForm, int offset) { }
    public byte[] GetOpaque() { return default(byte[]); }
    public void SetOpaque(byte[] opaque) { }
  }

  public sealed partial class DiscretionaryAcl : System.Security.AccessControl.CommonAcl {
    public DiscretionaryAcl(bool isContainer, bool isDS, byte revision, int capacity) { }
    public DiscretionaryAcl(bool isContainer, bool isDS, int capacity) { }
    public DiscretionaryAcl(bool isContainer, bool isDS, System.Security.AccessControl.RawAcl rawAcl) { }
    public void AddAccess(System.Security.AccessControl.AccessControlType accessType, System.Security.Principal.SecurityIdentifier sid, int accessMask, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags) { }
    public void AddAccess(System.Security.AccessControl.AccessControlType accessType, System.Security.Principal.SecurityIdentifier sid, int accessMask, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.ObjectAceFlags objectFlags, System.Guid objectType, System.Guid inheritedObjectType) { }
    public bool RemoveAccess(System.Security.AccessControl.AccessControlType accessType, System.Security.Principal.SecurityIdentifier sid, int accessMask, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags) { return default(bool); }
    public bool RemoveAccess(System.Security.AccessControl.AccessControlType accessType, System.Security.Principal.SecurityIdentifier sid, int accessMask, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.ObjectAceFlags objectFlags, System.Guid objectType, System.Guid inheritedObjectType) { return default(bool); }
    public void RemoveAccessSpecific(System.Security.AccessControl.AccessControlType accessType, System.Security.Principal.SecurityIdentifier sid, int accessMask, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags) { }
    public void RemoveAccessSpecific(System.Security.AccessControl.AccessControlType accessType, System.Security.Principal.SecurityIdentifier sid, int accessMask, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.ObjectAceFlags objectFlags, System.Guid objectType, System.Guid inheritedObjectType) { }
    public void SetAccess(System.Security.AccessControl.AccessControlType accessType, System.Security.Principal.SecurityIdentifier sid, int accessMask, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags) { }
    public void SetAccess(System.Security.AccessControl.AccessControlType accessType, System.Security.Principal.SecurityIdentifier sid, int accessMask, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.ObjectAceFlags objectFlags, System.Guid objectType, System.Guid inheritedObjectType) { }
  }

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

  public abstract partial class GenericAce {
    internal GenericAce() { }
    public System.Security.AccessControl.AceFlags AceFlags { get { return default(System.Security.AccessControl.AceFlags); } set { } }
    public System.Security.AccessControl.AceType AceType { get { return default(System.Security.AccessControl.AceType); } }
    public System.Security.AccessControl.AuditFlags AuditFlags { get { return default(System.Security.AccessControl.AuditFlags); } }
    public abstract int BinaryLength { get; }
    public System.Security.AccessControl.InheritanceFlags InheritanceFlags { get { return default(System.Security.AccessControl.InheritanceFlags); } }
    public bool IsInherited { get { return default(bool); } }
    public System.Security.AccessControl.PropagationFlags PropagationFlags { get { return default(System.Security.AccessControl.PropagationFlags); } }
    public System.Security.AccessControl.GenericAce Copy() { return default(System.Security.AccessControl.GenericAce); }
    public static System.Security.AccessControl.GenericAce CreateFromBinaryForm(byte[] binaryForm, int offset) { return default(System.Security.AccessControl.GenericAce); }
    public sealed override bool Equals(object o) { return default(bool); }
    public abstract void GetBinaryForm(byte[] binaryForm, int offset);
    public sealed override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Security.AccessControl.GenericAce left, System.Security.AccessControl.GenericAce right) { return default(bool); }
    public static bool operator !=(System.Security.AccessControl.GenericAce left, System.Security.AccessControl.GenericAce right) { return default(bool); }
  }

  public abstract partial class GenericAcl : System.Collections.ICollection, System.Collections.IEnumerable {
    public static readonly byte AclRevision;
    public static readonly byte AclRevisionDS;
    public static readonly int MaxBinaryLength;
    protected GenericAcl() { }
    public abstract int BinaryLength { get; }
    public abstract int Count { get; }
    public bool IsSynchronized { get { return default(bool); } }
    public abstract System.Security.AccessControl.GenericAce this[int index] { get; set; }
    public abstract byte Revision { get; }
    public virtual object SyncRoot { get { return default(object); } }
    public void CopyTo(System.Security.AccessControl.GenericAce[] array, int index) { }
    public abstract void GetBinaryForm(byte[] binaryForm, int offset);
    public System.Security.AccessControl.AceEnumerator GetEnumerator() { return default(System.Security.AccessControl.AceEnumerator); }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }

  public abstract partial class GenericSecurityDescriptor {
    protected GenericSecurityDescriptor() { }
    public int BinaryLength { get { return default(int); } }
    public abstract System.Security.AccessControl.ControlFlags ControlFlags { get; }
    public abstract System.Security.Principal.SecurityIdentifier Group { get; set; }
    public abstract System.Security.Principal.SecurityIdentifier Owner { get; set; }
    public static byte Revision { get { return default(byte); } }
    public void GetBinaryForm(byte[] binaryForm, int offset) { }
    public string GetSddlForm(System.Security.AccessControl.AccessControlSections includeSections) { return default(string); }
    public static bool IsSddlConversionSupported() { return default(bool); }
  }

  [System.FlagsAttribute]
  public enum InheritanceFlags {
    ContainerInherit = 1,
    None = 0,
    ObjectInherit = 2,
  }

  public abstract partial class KnownAce : System.Security.AccessControl.GenericAce {
    internal KnownAce() { }
    public int AccessMask { get { return default(int); } set { } }
    public System.Security.Principal.SecurityIdentifier SecurityIdentifier { get { return default(System.Security.Principal.SecurityIdentifier); } set { } }
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

  public abstract partial class NativeObjectSecurity : System.Security.AccessControl.CommonObjectSecurity {
    protected NativeObjectSecurity(bool isContainer, System.Security.AccessControl.ResourceType resourceType) : base (default(bool)) { }
    protected NativeObjectSecurity(bool isContainer, System.Security.AccessControl.ResourceType resourceType, System.Runtime.InteropServices.SafeHandle handle, System.Security.AccessControl.AccessControlSections includeSections) : base (default(bool)) { }
    protected NativeObjectSecurity(bool isContainer, System.Security.AccessControl.ResourceType resourceType, System.Runtime.InteropServices.SafeHandle handle, System.Security.AccessControl.AccessControlSections includeSections, System.Security.AccessControl.NativeObjectSecurity.ExceptionFromErrorCode exceptionFromErrorCode, object exceptionContext) : base (default(bool)) { }
    protected NativeObjectSecurity(bool isContainer, System.Security.AccessControl.ResourceType resourceType, System.Security.AccessControl.NativeObjectSecurity.ExceptionFromErrorCode exceptionFromErrorCode, object exceptionContext) : base (default(bool)) { }
    protected NativeObjectSecurity(bool isContainer, System.Security.AccessControl.ResourceType resourceType, string name, System.Security.AccessControl.AccessControlSections includeSections) : base (default(bool)) { }
    protected NativeObjectSecurity(bool isContainer, System.Security.AccessControl.ResourceType resourceType, string name, System.Security.AccessControl.AccessControlSections includeSections, System.Security.AccessControl.NativeObjectSecurity.ExceptionFromErrorCode exceptionFromErrorCode, object exceptionContext) : base (default(bool)) { }
    protected sealed override void Persist(System.Runtime.InteropServices.SafeHandle handle, System.Security.AccessControl.AccessControlSections includeSections) { }
    protected void Persist(System.Runtime.InteropServices.SafeHandle handle, System.Security.AccessControl.AccessControlSections includeSections, object exceptionContext) { }
    protected sealed override void Persist(string name, System.Security.AccessControl.AccessControlSections includeSections) { }
    protected void Persist(string name, System.Security.AccessControl.AccessControlSections includeSections, object exceptionContext) { }
    protected internal delegate System.Exception ExceptionFromErrorCode(int errorCode, string name, System.Runtime.InteropServices.SafeHandle handle, object context);
  }

  public abstract partial class ObjectAccessRule : System.Security.AccessControl.AccessRule {
    protected ObjectAccessRule(System.Security.Principal.IdentityReference identity, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Guid objectType, System.Guid inheritedObjectType, System.Security.AccessControl.AccessControlType type) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
    public System.Guid InheritedObjectType { get { return default(System.Guid); } }
    public System.Security.AccessControl.ObjectAceFlags ObjectFlags { get { return default(System.Security.AccessControl.ObjectAceFlags); } }
    public System.Guid ObjectType { get { return default(System.Guid); } }
  }

  public sealed partial class ObjectAce : System.Security.AccessControl.QualifiedAce {
    public ObjectAce(System.Security.AccessControl.AceFlags aceFlags, System.Security.AccessControl.AceQualifier qualifier, int accessMask, System.Security.Principal.SecurityIdentifier sid, System.Security.AccessControl.ObjectAceFlags flags, System.Guid type, System.Guid inheritedType, bool isCallback, byte[] opaque) { }
    public override int BinaryLength { get { return default(int); } }
    public System.Guid InheritedObjectAceType { get { return default(System.Guid); } set { } }
    public System.Security.AccessControl.ObjectAceFlags ObjectAceFlags { get { return default(System.Security.AccessControl.ObjectAceFlags); } set { } }
    public System.Guid ObjectAceType { get { return default(System.Guid); } set { } }
    public override void GetBinaryForm(byte[] binaryForm, int offset) { }
    public static int MaxOpaqueLength(bool isCallback) { return default(int); }
  }

  [System.FlagsAttribute]
  public enum ObjectAceFlags {
    InheritedObjectAceTypePresent = 2,
    None = 0,
    ObjectAceTypePresent = 1,
  }

  public abstract partial class ObjectAuditRule : System.Security.AccessControl.AuditRule {
    protected ObjectAuditRule(System.Security.Principal.IdentityReference identity, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Guid objectType, System.Guid inheritedObjectType, System.Security.AccessControl.AuditFlags auditFlags) : base (default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
    public System.Guid InheritedObjectType { get { return default(System.Guid); } }
    public System.Security.AccessControl.ObjectAceFlags ObjectFlags { get { return default(System.Security.AccessControl.ObjectAceFlags); } }
    public System.Guid ObjectType { get { return default(System.Guid); } }
  }

  public abstract partial class ObjectSecurity {
    protected ObjectSecurity(bool isContainer, bool isDS) { }
    public abstract System.Type AccessRightType { get; }
    protected bool AccessRulesModified { get { return default(bool); } set { } }
    public abstract System.Type AccessRuleType { get; }
    public bool AreAccessRulesCanonical { get { return default(bool); } }
    public bool AreAccessRulesProtected { get { return default(bool); } }
    public bool AreAuditRulesCanonical { get { return default(bool); } }
    public bool AreAuditRulesProtected { get { return default(bool); } }
    protected bool AuditRulesModified { get { return default(bool); } set { } }
    public abstract System.Type AuditRuleType { get; }
    protected bool GroupModified { get { return default(bool); } set { } }
    protected bool IsContainer { get { return default(bool); } }
    protected bool IsDS { get { return default(bool); } }
    protected bool OwnerModified { get { return default(bool); } set { } }
    public abstract System.Security.AccessControl.AccessRule AccessRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type);
    public abstract System.Security.AccessControl.AuditRule AuditRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags);
    public System.Security.Principal.IdentityReference GetGroup(System.Type targetType) { return default(System.Security.Principal.IdentityReference); }
    public System.Security.Principal.IdentityReference GetOwner(System.Type targetType) { return default(System.Security.Principal.IdentityReference); }
    public byte[] GetSecurityDescriptorBinaryForm() { return default(byte[]); }
    public string GetSecurityDescriptorSddlForm(System.Security.AccessControl.AccessControlSections includeSections) { return default(string); }
    public static bool IsSddlConversionSupported() { return default(bool); }
    protected abstract bool ModifyAccess(System.Security.AccessControl.AccessControlModification modification, System.Security.AccessControl.AccessRule rule, out bool modified);
    public virtual bool ModifyAccessRule(System.Security.AccessControl.AccessControlModification modification, System.Security.AccessControl.AccessRule rule, out bool modified) { modified = default(bool); return default(bool); }
    protected abstract bool ModifyAudit(System.Security.AccessControl.AccessControlModification modification, System.Security.AccessControl.AuditRule rule, out bool modified);
    public virtual bool ModifyAuditRule(System.Security.AccessControl.AccessControlModification modification, System.Security.AccessControl.AuditRule rule, out bool modified) { modified = default(bool); return default(bool); }
    [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
    protected virtual void Persist(bool enableOwnershipPrivilege, string name, System.Security.AccessControl.AccessControlSections includeSections) { }
    protected virtual void Persist(System.Runtime.InteropServices.SafeHandle handle, System.Security.AccessControl.AccessControlSections includeSections) { }
    protected virtual void Persist(string name, System.Security.AccessControl.AccessControlSections includeSections) { }
    public virtual void PurgeAccessRules(System.Security.Principal.IdentityReference identity) { }
    public virtual void PurgeAuditRules(System.Security.Principal.IdentityReference identity) { }
    protected void ReadLock() { }
    protected void ReadUnlock() { }
    public void SetAccessRuleProtection(bool isProtected, bool preserveInheritance) { }
    public void SetAuditRuleProtection(bool isProtected, bool preserveInheritance) { }
    public void SetGroup(System.Security.Principal.IdentityReference identity) { }
    public void SetOwner(System.Security.Principal.IdentityReference identity) { }
    public void SetSecurityDescriptorBinaryForm(byte[] binaryForm) { }
    public void SetSecurityDescriptorBinaryForm(byte[] binaryForm, System.Security.AccessControl.AccessControlSections includeSections) { }
    public void SetSecurityDescriptorSddlForm(string sddlForm) { }
    public void SetSecurityDescriptorSddlForm(string sddlForm, System.Security.AccessControl.AccessControlSections includeSections) { }
    protected void WriteLock() { }
    protected void WriteUnlock() { }
  }

  public abstract partial class ObjectSecurity<T> : System.Security.AccessControl.NativeObjectSecurity where T : struct {
    protected ObjectSecurity(bool isContainer, System.Security.AccessControl.ResourceType resourceType) : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
    protected ObjectSecurity(bool isContainer, System.Security.AccessControl.ResourceType resourceType, System.Runtime.InteropServices.SafeHandle safeHandle, System.Security.AccessControl.AccessControlSections includeSections) : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
    protected ObjectSecurity(bool isContainer, System.Security.AccessControl.ResourceType resourceType, System.Runtime.InteropServices.SafeHandle safeHandle, System.Security.AccessControl.AccessControlSections includeSections, System.Security.AccessControl.NativeObjectSecurity.ExceptionFromErrorCode exceptionFromErrorCode, object exceptionContext) : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
    protected ObjectSecurity(bool isContainer, System.Security.AccessControl.ResourceType resourceType, string name, System.Security.AccessControl.AccessControlSections includeSections) : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
    protected ObjectSecurity(bool isContainer, System.Security.AccessControl.ResourceType resourceType, string name, System.Security.AccessControl.AccessControlSections includeSections, System.Security.AccessControl.NativeObjectSecurity.ExceptionFromErrorCode exceptionFromErrorCode, object exceptionContext) : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
    public override System.Type AccessRightType { get { return default(System.Type); } }
    public override System.Type AccessRuleType { get { return default(System.Type); } }
    public override System.Type AuditRuleType { get { return default(System.Type); } }
    public override System.Security.AccessControl.AccessRule AccessRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type) { return default(System.Security.AccessControl.AccessRule); }
    public virtual void AddAccessRule(System.Security.AccessControl.AccessRule<T> rule) { }
    public virtual void AddAuditRule(System.Security.AccessControl.AuditRule<T> rule) { }
    public override System.Security.AccessControl.AuditRule AuditRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags) { return default(System.Security.AccessControl.AuditRule); }
    protected void Persist(System.Runtime.InteropServices.SafeHandle handle) { }
    protected void Persist(string name) { }
    public virtual bool RemoveAccessRule(System.Security.AccessControl.AccessRule<T> rule) { return default(bool); }
    public virtual void RemoveAccessRuleAll(System.Security.AccessControl.AccessRule<T> rule) { }
    public virtual void RemoveAccessRuleSpecific(System.Security.AccessControl.AccessRule<T> rule) { }
    public virtual bool RemoveAuditRule(System.Security.AccessControl.AuditRule<T> rule) { return default(bool); }
    public virtual void RemoveAuditRuleAll(System.Security.AccessControl.AuditRule<T> rule) { }
    public virtual void RemoveAuditRuleSpecific(System.Security.AccessControl.AuditRule<T> rule) { }
    public virtual void ResetAccessRule(System.Security.AccessControl.AccessRule<T> rule) { }
    public virtual void SetAccessRule(System.Security.AccessControl.AccessRule<T> rule) { }
    public virtual void SetAuditRule(System.Security.AccessControl.AuditRule<T> rule) { }
  }

  public sealed partial class PrivilegeNotHeldException : System.UnauthorizedAccessException, System.Runtime.Serialization.ISerializable {
    public PrivilegeNotHeldException() { }
    public PrivilegeNotHeldException(string privilege) { }
    public PrivilegeNotHeldException(string privilege, System.Exception inner) { }
    public string PrivilegeName { get { return default(string); } }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }

  [System.FlagsAttribute]
  public enum PropagationFlags {
    InheritOnly = 2,
    None = 0,
    NoPropagateInherit = 1,
  }

  public abstract partial class QualifiedAce : System.Security.AccessControl.KnownAce {
    internal QualifiedAce() { }
    public System.Security.AccessControl.AceQualifier AceQualifier { get { return default(System.Security.AccessControl.AceQualifier); } }
    public bool IsCallback { get { return default(bool); } }
    public int OpaqueLength { get { return default(int); } }
    public byte[] GetOpaque() { return default(byte[]); }
    public void SetOpaque(byte[] opaque) { }
  }

  public sealed partial class RawAcl : System.Security.AccessControl.GenericAcl {
    public RawAcl(byte revision, int capacity) { }
    public RawAcl(byte[] binaryForm, int offset) { }
    public override int BinaryLength { get { return default(int); } }
    public override int Count { get { return default(int); } }
    public override System.Security.AccessControl.GenericAce this[int index] { get { return default(System.Security.AccessControl.GenericAce); } set { } }
    public override byte Revision { get { return default(byte); } }
    public override void GetBinaryForm(byte[] binaryForm, int offset) { }
    public void InsertAce(int index, System.Security.AccessControl.GenericAce ace) { }
    public void RemoveAce(int index) { }
  }

  public sealed partial class RawSecurityDescriptor : System.Security.AccessControl.GenericSecurityDescriptor {
    public RawSecurityDescriptor(byte[] binaryForm, int offset) { }
    public RawSecurityDescriptor(System.Security.AccessControl.ControlFlags flags, System.Security.Principal.SecurityIdentifier owner, System.Security.Principal.SecurityIdentifier group, System.Security.AccessControl.RawAcl systemAcl, System.Security.AccessControl.RawAcl discretionaryAcl) { }
    public RawSecurityDescriptor(string sddlForm) { }
    public override System.Security.AccessControl.ControlFlags ControlFlags { get { return default(System.Security.AccessControl.ControlFlags); } }
    public System.Security.AccessControl.RawAcl DiscretionaryAcl { get { return default(System.Security.AccessControl.RawAcl); } set { } }
    public override System.Security.Principal.SecurityIdentifier Group { get { return default(System.Security.Principal.SecurityIdentifier); } set { } }
    public override System.Security.Principal.SecurityIdentifier Owner { get { return default(System.Security.Principal.SecurityIdentifier); } set { } }
    public byte ResourceManagerControl { get { return default(byte); } set { } }
    public System.Security.AccessControl.RawAcl SystemAcl { get { return default(System.Security.AccessControl.RawAcl); } set { } }
    public void SetFlags(System.Security.AccessControl.ControlFlags flags) { }
  }

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

  public enum ResourceType {
    DSObject = 8,
    DSObjectAll = 9,
    FileObject = 1,
    KernelObject = 6,
    LMShare = 5,
    Printer = 3,
    ProviderDefined = 10,
    RegistryKey = 4,
    RegistryWow6432Key = 12,
    Service = 2,
    Unknown = 0,
    WindowObject = 7,
    WmiGuidObject = 11,
  }

  [System.FlagsAttribute]
  public enum SecurityInfos {
    DiscretionaryAcl = 4,
    Group = 2,
    Owner = 1,
    SystemAcl = 8,
  }

  public sealed partial class SystemAcl : System.Security.AccessControl.CommonAcl {
    public SystemAcl(bool isContainer, bool isDS, byte revision, int capacity) { }
    public SystemAcl(bool isContainer, bool isDS, int capacity) { }
    public SystemAcl(bool isContainer, bool isDS, System.Security.AccessControl.RawAcl rawAcl) { }
    public void AddAudit(System.Security.AccessControl.AuditFlags auditFlags, System.Security.Principal.SecurityIdentifier sid, int accessMask, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags) { }
    public void AddAudit(System.Security.AccessControl.AuditFlags auditFlags, System.Security.Principal.SecurityIdentifier sid, int accessMask, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.ObjectAceFlags objectFlags, System.Guid objectType, System.Guid inheritedObjectType) { }
    public bool RemoveAudit(System.Security.AccessControl.AuditFlags auditFlags, System.Security.Principal.SecurityIdentifier sid, int accessMask, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags) { return default(bool); }
    public bool RemoveAudit(System.Security.AccessControl.AuditFlags auditFlags, System.Security.Principal.SecurityIdentifier sid, int accessMask, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.ObjectAceFlags objectFlags, System.Guid objectType, System.Guid inheritedObjectType) { return default(bool); }
    public void RemoveAuditSpecific(System.Security.AccessControl.AuditFlags auditFlags, System.Security.Principal.SecurityIdentifier sid, int accessMask, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags) { }
    public void RemoveAuditSpecific(System.Security.AccessControl.AuditFlags auditFlags, System.Security.Principal.SecurityIdentifier sid, int accessMask, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.ObjectAceFlags objectFlags, System.Guid objectType, System.Guid inheritedObjectType) { }
    public void SetAudit(System.Security.AccessControl.AuditFlags auditFlags, System.Security.Principal.SecurityIdentifier sid, int accessMask, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags) { }
    public void SetAudit(System.Security.AccessControl.AuditFlags auditFlags, System.Security.Principal.SecurityIdentifier sid, int accessMask, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.ObjectAceFlags objectFlags, System.Guid objectType, System.Guid inheritedObjectType) { }
  }

} // end of System.Security.AccessControl
namespace System.Security.Principal {
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public abstract partial class IdentityReference {
    internal IdentityReference() { }
    public abstract string Value { get; }
    public abstract override bool Equals(object o);
    public abstract override int GetHashCode();
    public abstract bool IsValidTargetType(System.Type targetType);
    public static bool operator ==(System.Security.Principal.IdentityReference left, System.Security.Principal.IdentityReference right) { return default(bool); }
    public static bool operator !=(System.Security.Principal.IdentityReference left, System.Security.Principal.IdentityReference right) { return default(bool); }
    public abstract override string ToString();
    public abstract System.Security.Principal.IdentityReference Translate(System.Type targetType);
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public partial class IdentityReferenceCollection : System.Collections.Generic.ICollection<System.Security.Principal.IdentityReference>, System.Collections.Generic.IEnumerable<System.Security.Principal.IdentityReference>, System.Collections.IEnumerable {
    public IdentityReferenceCollection() { }
    public IdentityReferenceCollection(int capacity) { }
    public int Count { get { return default(int); } }
    public bool IsReadOnly { get { return default(bool); } }
    public System.Security.Principal.IdentityReference this[int index] { get { return default(System.Security.Principal.IdentityReference); } set { } }
    public void Add(System.Security.Principal.IdentityReference identity) { }
    public void Clear() { }
    public bool Contains(System.Security.Principal.IdentityReference identity) { return default(bool); }
    public void CopyTo(System.Security.Principal.IdentityReference[] array, int offset) { }
    public System.Collections.Generic.IEnumerator<System.Security.Principal.IdentityReference> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Security.Principal.IdentityReference>); }
    public bool Remove(System.Security.Principal.IdentityReference identity) { return default(bool); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public System.Security.Principal.IdentityReferenceCollection Translate(System.Type targetType) { return default(System.Security.Principal.IdentityReferenceCollection); }
    public System.Security.Principal.IdentityReferenceCollection Translate(System.Type targetType, bool forceSuccess) { return default(System.Security.Principal.IdentityReferenceCollection); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class NTAccount : System.Security.Principal.IdentityReference {
    public NTAccount(string name) { }
    public NTAccount(string domainName, string accountName) { }
    public override string Value { get { return default(string); } }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsValidTargetType(System.Type targetType) { return default(bool); }
    public static bool operator ==(System.Security.Principal.NTAccount left, System.Security.Principal.NTAccount right) { return default(bool); }
    public static bool operator !=(System.Security.Principal.NTAccount left, System.Security.Principal.NTAccount right) { return default(bool); }
    public override string ToString() { return default(string); }
    public override System.Security.Principal.IdentityReference Translate(System.Type targetType) { return default(System.Security.Principal.IdentityReference); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public sealed partial class SecurityIdentifier : System.Security.Principal.IdentityReference, System.IComparable<System.Security.Principal.SecurityIdentifier> {
    public static readonly int MaxBinaryLength;
    public static readonly int MinBinaryLength;
    public SecurityIdentifier(byte[] binaryForm, int offset) { }
    public SecurityIdentifier(System.IntPtr binaryForm) { }
    public SecurityIdentifier(System.Security.Principal.WellKnownSidType sidType, System.Security.Principal.SecurityIdentifier domainSid) { }
    public SecurityIdentifier(string sddlForm) { }
    public System.Security.Principal.SecurityIdentifier AccountDomainSid { get { return default(System.Security.Principal.SecurityIdentifier); } }
    public int BinaryLength { get { return default(int); } }
    public override string Value { get { return default(string); } }
    public int CompareTo(System.Security.Principal.SecurityIdentifier sid) { return default(int); }
    public override bool Equals(object o) { return default(bool); }
    public bool Equals(System.Security.Principal.SecurityIdentifier sid) { return default(bool); }
    public void GetBinaryForm(byte[] binaryForm, int offset) { }
    public override int GetHashCode() { return default(int); }
    public bool IsAccountSid() { return default(bool); }
    public bool IsEqualDomainSid(System.Security.Principal.SecurityIdentifier sid) { return default(bool); }
    public override bool IsValidTargetType(System.Type targetType) { return default(bool); }
    public bool IsWellKnown(System.Security.Principal.WellKnownSidType type) { return default(bool); }
    public static bool operator ==(System.Security.Principal.SecurityIdentifier left, System.Security.Principal.SecurityIdentifier right) { return default(bool); }
    public static bool operator !=(System.Security.Principal.SecurityIdentifier left, System.Security.Principal.SecurityIdentifier right) { return default(bool); }
    public override string ToString() { return default(string); }
    public override System.Security.Principal.IdentityReference Translate(System.Type targetType) { return default(System.Security.Principal.IdentityReference); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public enum WellKnownSidType {
    AccountAdministratorSid = 38,
    AccountCertAdminsSid = 46,
    AccountComputersSid = 44,
    AccountControllersSid = 45,
    AccountDomainAdminsSid = 41,
    AccountDomainGuestsSid = 43,
    AccountDomainUsersSid = 42,
    AccountEnterpriseAdminsSid = 48,
    AccountGuestSid = 39,
    AccountKrbtgtSid = 40,
    AccountPolicyAdminsSid = 49,
    AccountRasAndIasServersSid = 50,
    AccountSchemaAdminsSid = 47,
    AnonymousSid = 13,
    AuthenticatedUserSid = 17,
    BatchSid = 10,
    BuiltinAccountOperatorsSid = 30,
    BuiltinAdministratorsSid = 26,
    BuiltinAuthorizationAccessSid = 59,
    BuiltinBackupOperatorsSid = 33,
    BuiltinDomainSid = 25,
    BuiltinGuestsSid = 28,
    BuiltinIncomingForestTrustBuildersSid = 56,
    BuiltinNetworkConfigurationOperatorsSid = 37,
    BuiltinPerformanceLoggingUsersSid = 58,
    BuiltinPerformanceMonitoringUsersSid = 57,
    BuiltinPowerUsersSid = 29,
    BuiltinPreWindows2000CompatibleAccessSid = 35,
    BuiltinPrintOperatorsSid = 32,
    BuiltinRemoteDesktopUsersSid = 36,
    BuiltinReplicatorSid = 34,
    BuiltinSystemOperatorsSid = 31,
    BuiltinUsersSid = 27,
    CreatorGroupServerSid = 6,
    CreatorGroupSid = 4,
    CreatorOwnerServerSid = 5,
    CreatorOwnerSid = 3,
    DialupSid = 8,
    DigestAuthenticationSid = 52,
    EnterpriseControllersSid = 15,
    InteractiveSid = 11,
    LocalServiceSid = 23,
    LocalSid = 2,
    LocalSystemSid = 22,
    LogonIdsSid = 21,
    MaxDefined = 60,
    NetworkServiceSid = 24,
    NetworkSid = 9,
    NTAuthoritySid = 7,
    NtlmAuthenticationSid = 51,
    NullSid = 0,
    OtherOrganizationSid = 55,
    ProxySid = 14,
    RemoteLogonIdSid = 20,
    RestrictedCodeSid = 18,
    SChannelAuthenticationSid = 53,
    SelfSid = 16,
    ServiceSid = 12,
    TerminalServerSid = 19,
    ThisOrganizationSid = 54,
    WinBuiltinTerminalServerLicenseServersSid = 60,
    WorldSid = 1,
  }

} // end of System.Security.Principal
