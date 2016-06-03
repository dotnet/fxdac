[assembly:System.CLSCompliant(true)]
namespace System.Security {
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class CodeAccessPermission : System.Security.IPermission, System.Security.ISecurityEncodable, System.Security.IStackWalk {
    protected CodeAccessPermission() { }
    public void Assert() { }
    public abstract System.Security.IPermission Copy();
    public void Demand() { }
    public void Deny() { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public override bool Equals(object obj) { return default(bool); }
    public abstract void FromXml(System.Security.SecurityElement elem);
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public override int GetHashCode() { return default(int); }
    public abstract System.Security.IPermission Intersect(System.Security.IPermission target);
    public abstract bool IsSubsetOf(System.Security.IPermission target);
    public void PermitOnly() { }
    public static void RevertAll() { }
    public static void RevertAssert() { }
    public static void RevertDeny() { }
    public static void RevertPermitOnly() { }
    public override string ToString() { return default(string); }
    public abstract System.Security.SecurityElement ToXml();
    public virtual System.Security.IPermission Union(System.Security.IPermission other) { return default(System.Security.IPermission); }
  }

} // end of System.Security
namespace System.Security.Permissions {
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class EnvironmentPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission {
    public EnvironmentPermission(System.Security.Permissions.EnvironmentPermissionAccess flag, string pathList) { }
    public EnvironmentPermission(System.Security.Permissions.PermissionState state) { }
    public void AddPathList(System.Security.Permissions.EnvironmentPermissionAccess flag, string pathList) { }
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    public override void FromXml(System.Security.SecurityElement esd) { }
    public string GetPathList(System.Security.Permissions.EnvironmentPermissionAccess flag) { return default(string); }
    public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public bool IsUnrestricted() { return default(bool); }
    public void SetPathList(System.Security.Permissions.EnvironmentPermissionAccess flag, string pathList) { }
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public override System.Security.IPermission Union(System.Security.IPermission other) { return default(System.Security.IPermission); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class FileDialogPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission {
    public FileDialogPermission(System.Security.Permissions.FileDialogPermissionAccess access) { }
    public FileDialogPermission(System.Security.Permissions.PermissionState state) { }
    public System.Security.Permissions.FileDialogPermissionAccess Access { get { return default(System.Security.Permissions.FileDialogPermissionAccess); } set { } }
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    public override void FromXml(System.Security.SecurityElement esd) { }
    public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public bool IsUnrestricted() { return default(bool); }
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
  }

  [System.FlagsAttribute]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum FileDialogPermissionAccess {
    None = 0,
    Open = 1,
    OpenSave = 3,
    Save = 2,
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class FileDialogPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    public FileDialogPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public bool Open { get { return default(bool); } set { } }
    public bool Save { get { return default(bool); } set { } }
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class FileIOPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission {
    public FileIOPermission(System.Security.Permissions.FileIOPermissionAccess access, System.Security.AccessControl.AccessControlActions control, string path) { }
    public FileIOPermission(System.Security.Permissions.FileIOPermissionAccess access, System.Security.AccessControl.AccessControlActions control, string[] pathList) { }
    public FileIOPermission(System.Security.Permissions.FileIOPermissionAccess access, string path) { }
    public FileIOPermission(System.Security.Permissions.FileIOPermissionAccess access, string[] pathList) { }
    public FileIOPermission(System.Security.Permissions.PermissionState state) { }
    public System.Security.Permissions.FileIOPermissionAccess AllFiles { get { return default(System.Security.Permissions.FileIOPermissionAccess); } set { } }
    public System.Security.Permissions.FileIOPermissionAccess AllLocalFiles { get { return default(System.Security.Permissions.FileIOPermissionAccess); } set { } }
    public void AddPathList(System.Security.Permissions.FileIOPermissionAccess access, string path) { }
    public void AddPathList(System.Security.Permissions.FileIOPermissionAccess access, string[] pathList) { }
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public override bool Equals(object obj) { return default(bool); }
    public override void FromXml(System.Security.SecurityElement esd) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public override int GetHashCode() { return default(int); }
    public string[] GetPathList(System.Security.Permissions.FileIOPermissionAccess access) { return default(string[]); }
    public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public bool IsUnrestricted() { return default(bool); }
    public void SetPathList(System.Security.Permissions.FileIOPermissionAccess access, string path) { }
    public void SetPathList(System.Security.Permissions.FileIOPermissionAccess access, string[] pathList) { }
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public override System.Security.IPermission Union(System.Security.IPermission other) { return default(System.Security.IPermission); }
  }

  [System.FlagsAttribute]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum FileIOPermissionAccess {
    AllAccess = 15,
    Append = 4,
    NoAccess = 0,
    PathDiscovery = 8,
    Read = 1,
    Write = 2,
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class GacIdentityPermission : System.Security.CodeAccessPermission {
    public GacIdentityPermission() { }
    public GacIdentityPermission(System.Security.Permissions.PermissionState state) { }
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    public override void FromXml(System.Security.SecurityElement securityElement) { }
    public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class GacIdentityPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    public GacIdentityPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface IUnrestrictedPermission {
    bool IsUnrestricted();
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class PrincipalPermission : System.Security.IPermission, System.Security.ISecurityEncodable, System.Security.Permissions.IUnrestrictedPermission {
    public PrincipalPermission(System.Security.Permissions.PermissionState state) { }
    public PrincipalPermission(string name, string role) { }
    public PrincipalPermission(string name, string role, bool isAuthenticated) { }
    public System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    public void Demand() { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public override bool Equals(object obj) { return default(bool); }
    public void FromXml(System.Security.SecurityElement elem) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public override int GetHashCode() { return default(int); }
    public System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public bool IsUnrestricted() { return default(bool); }
    public override string ToString() { return default(string); }
    public System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public System.Security.IPermission Union(System.Security.IPermission other) { return default(System.Security.IPermission); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(68), AllowMultiple=true, Inherited=false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class PrincipalPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    public PrincipalPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public bool Authenticated { get { return default(bool); } set { } }
    public string Name { get { return default(string); } set { } }
    public string Role { get { return default(string); } set { } }
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class PublisherIdentityPermission : System.Security.CodeAccessPermission {
    public PublisherIdentityPermission(System.Security.Cryptography.X509Certificates.X509Certificate certificate) { }
    public PublisherIdentityPermission(System.Security.Permissions.PermissionState state) { }
    public System.Security.Cryptography.X509Certificates.X509Certificate Certificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate); } set { } }
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    public override void FromXml(System.Security.SecurityElement esd) { }
    public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class PublisherIdentityPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    public PublisherIdentityPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public string CertFile { get { return default(string); } set { } }
    public string SignedFile { get { return default(string); } set { } }
    public string X509Certificate { get { return default(string); } set { } }
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class ReflectionPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission {
    public ReflectionPermission(System.Security.Permissions.PermissionState state) { }
    public ReflectionPermission(System.Security.Permissions.ReflectionPermissionFlag flag) { }
    public System.Security.Permissions.ReflectionPermissionFlag Flags { get { return default(System.Security.Permissions.ReflectionPermissionFlag); } set { } }
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    public override void FromXml(System.Security.SecurityElement esd) { }
    public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public bool IsUnrestricted() { return default(bool); }
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public override System.Security.IPermission Union(System.Security.IPermission other) { return default(System.Security.IPermission); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class RegistryPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission {
    public RegistryPermission(System.Security.Permissions.PermissionState state) { }
    public RegistryPermission(System.Security.Permissions.RegistryPermissionAccess access, System.Security.AccessControl.AccessControlActions control, string pathList) { }
    public RegistryPermission(System.Security.Permissions.RegistryPermissionAccess access, string pathList) { }
    public void AddPathList(System.Security.Permissions.RegistryPermissionAccess access, System.Security.AccessControl.AccessControlActions control, string pathList) { }
    public void AddPathList(System.Security.Permissions.RegistryPermissionAccess access, string pathList) { }
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    public override void FromXml(System.Security.SecurityElement esd) { }
    public string GetPathList(System.Security.Permissions.RegistryPermissionAccess access) { return default(string); }
    public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public bool IsUnrestricted() { return default(bool); }
    public void SetPathList(System.Security.Permissions.RegistryPermissionAccess access, string pathList) { }
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public override System.Security.IPermission Union(System.Security.IPermission other) { return default(System.Security.IPermission); }
  }

  [System.FlagsAttribute]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum RegistryPermissionAccess {
    AllAccess = 7,
    Create = 4,
    NoAccess = 0,
    Read = 1,
    Write = 2,
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class RegistryPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    public RegistryPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    [System.ObsoleteAttribute("use newer properties")]
    public string All { get { return default(string); } set { } }
    public string ChangeAccessControl { get { return default(string); } set { } }
    public string Create { get { return default(string); } set { } }
    public string Read { get { return default(string); } set { } }
    public string ViewAccessControl { get { return default(string); } set { } }
    public string ViewAndModify { get { return default(string); } set { } }
    public string Write { get { return default(string); } set { } }
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class SecurityPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission {
    public SecurityPermission(System.Security.Permissions.PermissionState state) { }
    public SecurityPermission(System.Security.Permissions.SecurityPermissionFlag flag) { }
    public System.Security.Permissions.SecurityPermissionFlag Flags { get { return default(System.Security.Permissions.SecurityPermissionFlag); } set { } }
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    public override void FromXml(System.Security.SecurityElement esd) { }
    public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public bool IsUnrestricted() { return default(bool); }
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class SiteIdentityPermission : System.Security.CodeAccessPermission {
    public SiteIdentityPermission(System.Security.Permissions.PermissionState state) { }
    public SiteIdentityPermission(string site) { }
    public string Site { get { return default(string); } set { } }
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    public override void FromXml(System.Security.SecurityElement esd) { }
    public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class SiteIdentityPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    public SiteIdentityPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public string Site { get { return default(string); } set { } }
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class StrongNameIdentityPermission : System.Security.CodeAccessPermission {
    public StrongNameIdentityPermission(System.Security.Permissions.PermissionState state) { }
    public StrongNameIdentityPermission(System.Security.Permissions.StrongNamePublicKeyBlob blob, string name, System.Version version) { }
    public string Name { get { return default(string); } set { } }
    public System.Security.Permissions.StrongNamePublicKeyBlob PublicKey { get { return default(System.Security.Permissions.StrongNamePublicKeyBlob); } set { } }
    public System.Version Version { get { return default(System.Version); } set { } }
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    public override void FromXml(System.Security.SecurityElement e) { }
    public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class UIPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission {
    public UIPermission(System.Security.Permissions.PermissionState state) { }
    public UIPermission(System.Security.Permissions.UIPermissionClipboard clipboardFlag) { }
    public UIPermission(System.Security.Permissions.UIPermissionWindow windowFlag) { }
    public UIPermission(System.Security.Permissions.UIPermissionWindow windowFlag, System.Security.Permissions.UIPermissionClipboard clipboardFlag) { }
    public System.Security.Permissions.UIPermissionClipboard Clipboard { get { return default(System.Security.Permissions.UIPermissionClipboard); } set { } }
    public System.Security.Permissions.UIPermissionWindow Window { get { return default(System.Security.Permissions.UIPermissionWindow); } set { } }
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    public override void FromXml(System.Security.SecurityElement esd) { }
    public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public bool IsUnrestricted() { return default(bool); }
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class UIPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    public UIPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public System.Security.Permissions.UIPermissionClipboard Clipboard { get { return default(System.Security.Permissions.UIPermissionClipboard); } set { } }
    public System.Security.Permissions.UIPermissionWindow Window { get { return default(System.Security.Permissions.UIPermissionWindow); } set { } }
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum UIPermissionClipboard {
    AllClipboard = 2,
    NoClipboard = 0,
    OwnClipboard = 1,
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum UIPermissionWindow {
    AllWindows = 3,
    NoWindows = 0,
    SafeSubWindows = 1,
    SafeTopLevelWindows = 2,
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class UrlIdentityPermission : System.Security.CodeAccessPermission {
    public UrlIdentityPermission(System.Security.Permissions.PermissionState state) { }
    public UrlIdentityPermission(string site) { }
    public string Url { get { return default(string); } set { } }
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    public override void FromXml(System.Security.SecurityElement esd) { }
    public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class UrlIdentityPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    public UrlIdentityPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public string Url { get { return default(string); } set { } }
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class ZoneIdentityPermission : System.Security.CodeAccessPermission {
    public ZoneIdentityPermission(System.Security.Permissions.PermissionState state) { }
    public ZoneIdentityPermission(System.Security.SecurityZone zone) { }
    public System.Security.SecurityZone SecurityZone { get { return default(System.Security.SecurityZone); } set { } }
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    public override void FromXml(System.Security.SecurityElement esd) { }
    public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class ZoneIdentityPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    public ZoneIdentityPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public System.Security.SecurityZone Zone { get { return default(System.Security.SecurityZone); } set { } }
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
  }

} // end of System.Security.Permissions
namespace System.Security.Policy {
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class FileCodeGroup : System.Security.Policy.CodeGroup {
    public FileCodeGroup(System.Security.Policy.IMembershipCondition membershipCondition, System.Security.Permissions.FileIOPermissionAccess access) : base (default(System.Security.Policy.IMembershipCondition), default(System.Security.Policy.PolicyStatement)) { }
    public override string AttributeString { get { return default(string); } }
    public override string MergeLogic { get { return default(string); } }
    public override string PermissionSetName { get { return default(string); } }
    public override System.Security.Policy.CodeGroup Copy() { return default(System.Security.Policy.CodeGroup); }
    protected override void CreateXml(System.Security.SecurityElement element, System.Security.Policy.PolicyLevel level) { }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    protected override void ParseXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
    public override System.Security.Policy.PolicyStatement Resolve(System.Security.Policy.Evidence evidence) { return default(System.Security.Policy.PolicyStatement); }
    public override System.Security.Policy.CodeGroup ResolveMatchingCodeGroups(System.Security.Policy.Evidence evidence) { return default(System.Security.Policy.CodeGroup); }
  }

} // end of System.Security.Policy
