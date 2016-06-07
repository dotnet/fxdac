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

  public static partial class Registry {
    public static readonly Microsoft.Win32.RegistryKey ClassesRoot;
    public static readonly Microsoft.Win32.RegistryKey CurrentConfig;
    public static readonly Microsoft.Win32.RegistryKey CurrentUser;
    public static readonly Microsoft.Win32.RegistryKey LocalMachine;
    public static readonly Microsoft.Win32.RegistryKey PerformanceData;
    public static readonly Microsoft.Win32.RegistryKey Users;
    public static object GetValue(string keyName, string valueName, object defaultValue) { return default(object); }
    public static void SetValue(string keyName, string valueName, object value) { }
    public static void SetValue(string keyName, string valueName, object value, Microsoft.Win32.RegistryValueKind valueKind) { }
  }

  public enum RegistryHive {
    ClassesRoot = -2147483648,
    CurrentConfig = -2147483643,
    CurrentUser = -2147483647,
    LocalMachine = -2147483646,
    PerformanceData = -2147483644,
    Users = -2147483645,
  }

  public sealed partial class RegistryKey : System.IDisposable {
    internal RegistryKey() { }
    public Microsoft.Win32.SafeHandles.SafeRegistryHandle Handle { [System.Security.SecurityCriticalAttribute]get { return default(Microsoft.Win32.SafeHandles.SafeRegistryHandle); } }
    public string Name { get { return default(string); } }
    public int SubKeyCount { get { return default(int); } }
    public int ValueCount { get { return default(int); } }
    public Microsoft.Win32.RegistryView View { get { return default(Microsoft.Win32.RegistryView); } }
    public Microsoft.Win32.RegistryKey CreateSubKey(string subkey) { return default(Microsoft.Win32.RegistryKey); }
    public Microsoft.Win32.RegistryKey CreateSubKey(string subkey, bool writable) { return default(Microsoft.Win32.RegistryKey); }
    public Microsoft.Win32.RegistryKey CreateSubKey(string subkey, bool writable, Microsoft.Win32.RegistryOptions options) { return default(Microsoft.Win32.RegistryKey); }
    public void DeleteSubKey(string subkey) { }
    public void DeleteSubKey(string subkey, bool throwOnMissingSubKey) { }
    public void DeleteSubKeyTree(string subkey) { }
    public void DeleteSubKeyTree(string subkey, bool throwOnMissingSubKey) { }
    public void DeleteValue(string name) { }
    public void DeleteValue(string name, bool throwOnMissingValue) { }
    public void Dispose() { }
    public void Flush() { }
    [System.Security.SecurityCriticalAttribute]
    public static Microsoft.Win32.RegistryKey FromHandle(Microsoft.Win32.SafeHandles.SafeRegistryHandle handle) { return default(Microsoft.Win32.RegistryKey); }
    [System.Security.SecurityCriticalAttribute]
    public static Microsoft.Win32.RegistryKey FromHandle(Microsoft.Win32.SafeHandles.SafeRegistryHandle handle, Microsoft.Win32.RegistryView view) { return default(Microsoft.Win32.RegistryKey); }
    public string[] GetSubKeyNames() { return default(string[]); }
    public object GetValue(string name) { return default(object); }
    public object GetValue(string name, object defaultValue) { return default(object); }
    public object GetValue(string name, object defaultValue, Microsoft.Win32.RegistryValueOptions options) { return default(object); }
    public Microsoft.Win32.RegistryValueKind GetValueKind(string name) { return default(Microsoft.Win32.RegistryValueKind); }
    public string[] GetValueNames() { return default(string[]); }
    public static Microsoft.Win32.RegistryKey OpenBaseKey(Microsoft.Win32.RegistryHive hKey, Microsoft.Win32.RegistryView view) { return default(Microsoft.Win32.RegistryKey); }
    public Microsoft.Win32.RegistryKey OpenSubKey(string name) { return default(Microsoft.Win32.RegistryKey); }
    public Microsoft.Win32.RegistryKey OpenSubKey(string name, bool writable) { return default(Microsoft.Win32.RegistryKey); }
    public Microsoft.Win32.RegistryKey OpenSubKey(string name, System.Security.AccessControl.RegistryRights rights) { return default(Microsoft.Win32.RegistryKey); }
    public void SetValue(string name, object value) { }
    public void SetValue(string name, object value, Microsoft.Win32.RegistryValueKind valueKind) { }
    public override string ToString() { return default(string); }
  }

  public enum RegistryValueKind {
    Binary = 3,
    DWord = 4,
    ExpandString = 2,
    MultiString = 7,
    None = -1,
    QWord = 11,
    String = 1,
    Unknown = 0,
  }

  [System.FlagsAttribute]
  public enum RegistryValueOptions {
    DoNotExpandEnvironmentNames = 1,
    None = 0,
  }

  [System.Security.SecurityCriticalAttribute]
  public static partial class RegistryAclExtensions {
    public static System.Security.AccessControl.RegistrySecurity GetAccessControl(this Microsoft.Win32.RegistryKey key) { return default(System.Security.AccessControl.RegistrySecurity); }
    public static System.Security.AccessControl.RegistrySecurity GetAccessControl(this Microsoft.Win32.RegistryKey key, System.Security.AccessControl.AccessControlSections includeSections) { return default(System.Security.AccessControl.RegistrySecurity); }
    public static void SetAccessControl(this Microsoft.Win32.RegistryKey key, System.Security.AccessControl.RegistrySecurity registrySecurity) { }
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
