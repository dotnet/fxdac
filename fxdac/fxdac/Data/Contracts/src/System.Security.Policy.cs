[assembly:System.CLSCompliant(true)]
namespace System.Security {
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class HostSecurityManager {
    public HostSecurityManager() { }
    public virtual System.Security.Policy.PolicyLevel DomainPolicy { get { return default(System.Security.Policy.PolicyLevel); } }
    public virtual System.Security.HostSecurityManagerOptions Flags { get { return default(System.Security.HostSecurityManagerOptions); } }
    public virtual System.Security.Policy.ApplicationTrust DetermineApplicationTrust(System.Security.Policy.Evidence applicationEvidence, System.Security.Policy.Evidence activatorEvidence, System.Security.Policy.TrustManagerContext context) { return default(System.Security.Policy.ApplicationTrust); }
    public virtual System.Security.Policy.Evidence ProvideAppDomainEvidence(System.Security.Policy.Evidence inputEvidence) { return default(System.Security.Policy.Evidence); }
    public virtual System.Security.Policy.Evidence ProvideAssemblyEvidence(System.Reflection.Assembly loadedAssembly, System.Security.Policy.Evidence inputEvidence) { return default(System.Security.Policy.Evidence); }
    public virtual System.Security.PermissionSet ResolvePolicy(System.Security.Policy.Evidence evidence) { return default(System.Security.PermissionSet); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface IPermission : System.Security.ISecurityEncodable {
    System.Security.IPermission Copy();
    void Demand();
    System.Security.IPermission Intersect(System.Security.IPermission target);
    bool IsSubsetOf(System.Security.IPermission target);
    System.Security.IPermission Union(System.Security.IPermission target);
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface ISecurityEncodable {
    void FromXml(System.Security.SecurityElement e);
    System.Security.SecurityElement ToXml();
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface ISecurityPolicyEncodable {
    void FromXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level);
    System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level);
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class NamedPermissionSet : System.Security.PermissionSet {
    public NamedPermissionSet(System.Security.NamedPermissionSet permSet) : base (default(System.Security.Permissions.PermissionState)) { }
    public NamedPermissionSet(string name) : base (default(System.Security.Permissions.PermissionState)) { }
    public NamedPermissionSet(string name, System.Security.Permissions.PermissionState state) : base (default(System.Security.Permissions.PermissionState)) { }
    public NamedPermissionSet(string name, System.Security.PermissionSet permSet) : base (default(System.Security.Permissions.PermissionState)) { }
    public string Description { get { return default(string); } set { } }
    public string Name { get { return default(string); } set { } }
    public override System.Security.PermissionSet Copy() { return default(System.Security.PermissionSet); }
    public System.Security.NamedPermissionSet Copy(string name) { return default(System.Security.NamedPermissionSet); }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public override bool Equals(object obj) { return default(bool); }
    public override void FromXml(System.Security.SecurityElement et) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public override int GetHashCode() { return default(int); }
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class PermissionSet : System.Collections.ICollection, System.Collections.IEnumerable, System.Runtime.Serialization.IDeserializationCallback, System.Security.ISecurityEncodable, System.Security.IStackWalk {
    public PermissionSet(System.Security.Permissions.PermissionState state) { }
    public PermissionSet(System.Security.PermissionSet permSet) { }
    public virtual int Count { get { return default(int); } }
    public virtual bool IsReadOnly { get { return default(bool); } }
    public virtual bool IsSynchronized { get { return default(bool); } }
    public virtual object SyncRoot { get { return default(object); } }
    public System.Security.IPermission AddPermission(System.Security.IPermission perm) { return default(System.Security.IPermission); }
    public void Assert() { }
    public bool ContainsNonCodeAccessPermissions() { return default(bool); }
    public static byte[] ConvertPermissionSet(string inFormat, byte[] inData, string outFormat) { return default(byte[]); }
    public virtual System.Security.PermissionSet Copy() { return default(System.Security.PermissionSet); }
    public virtual void CopyTo(System.Array array, int index) { }
    public void Demand() { }
    public void Deny() { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public override bool Equals(object obj) { return default(bool); }
    public virtual void FromXml(System.Security.SecurityElement et) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public override int GetHashCode() { return default(int); }
    public System.Security.IPermission GetPermission(System.Type permClass) { return default(System.Security.IPermission); }
    public System.Security.PermissionSet Intersect(System.Security.PermissionSet other) { return default(System.Security.PermissionSet); }
    public bool IsEmpty() { return default(bool); }
    public bool IsSubsetOf(System.Security.PermissionSet target) { return default(bool); }
    public bool IsUnrestricted() { return default(bool); }
    public void PermitOnly() { }
    public System.Security.IPermission RemovePermission(System.Type permClass) { return default(System.Security.IPermission); }
    public static void RevertAssert() { }
    public System.Security.IPermission SetPermission(System.Security.IPermission perm) { return default(System.Security.IPermission); }
    void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
    public override string ToString() { return default(string); }
    public virtual System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public System.Security.PermissionSet Union(System.Security.PermissionSet other) { return default(System.Security.PermissionSet); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class SecurityElement {
    public SecurityElement(string tag) { }
    public SecurityElement(string tag, string text) { }
    public System.Collections.Hashtable Attributes { get { return default(System.Collections.Hashtable); } set { } }
    public System.Collections.ArrayList Children { get { return default(System.Collections.ArrayList); } set { } }
    public string Tag { get { return default(string); } set { } }
    public string Text { get { return default(string); } set { } }
    public void AddAttribute(string name, string value) { }
    public void AddChild(System.Security.SecurityElement child) { }
    public string Attribute(string name) { return default(string); }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.Security.SecurityElement Copy() { return default(System.Security.SecurityElement); }
    public bool Equal(System.Security.SecurityElement other) { return default(bool); }
    public static string Escape(string str) { return default(string); }
    public static System.Security.SecurityElement FromString(string xml) { return default(System.Security.SecurityElement); }
    public static bool IsValidAttributeName(string name) { return default(bool); }
    public static bool IsValidAttributeValue(string value) { return default(bool); }
    public static bool IsValidTag(string tag) { return default(bool); }
    public static bool IsValidText(string text) { return default(bool); }
    public System.Security.SecurityElement SearchForChildByTag(string tag) { return default(System.Security.SecurityElement); }
    public string SearchForTextOfTag(string tag) { return default(string); }
    public override string ToString() { return default(string); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class SecurityException : System.SystemException {
    public SecurityException() { }
    protected SecurityException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public SecurityException(string message) { }
    public SecurityException(string message, System.Exception inner) { }
    public SecurityException(string message, object deny, object permitOnly, System.Reflection.MethodInfo method, object demanded, System.Security.IPermission permThatFailed) { }
    public SecurityException(string message, System.Type type) { }
    public SecurityException(string message, System.Type type, string state) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.Security.Permissions.SecurityAction Action { get { return default(System.Security.Permissions.SecurityAction); } set { } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public object Demanded { get { return default(object); } set { } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public object DenySetInstance { get { return default(object); } set { } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.Reflection.AssemblyName FailedAssemblyInfo { get { return default(System.Reflection.AssemblyName); } set { } }
    public System.Security.IPermission FirstPermissionThatFailed { get { return default(System.Security.IPermission); } set { } }
    public string GrantedSet { get { return default(string); } set { } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.Reflection.MethodInfo Method { get { return default(System.Reflection.MethodInfo); } set { } }
    public string PermissionState { get { return default(string); } set { } }
    public System.Type PermissionType { get { return default(System.Type); } set { } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public object PermitOnlySetInstance { get { return default(object); } set { } }
    public string RefusedSet { get { return default(string); } set { } }
    public string Url { get { return default(string); } set { } }
    public System.Security.SecurityZone Zone { get { return default(System.Security.SecurityZone); } set { } }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public override string ToString() { return default(string); }
  }

} // end of System.Security
namespace System.Security.Permissions {
  [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class CodeAccessSecurityAttribute : System.Security.Permissions.SecurityAttribute {
    protected CodeAccessSecurityAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class EnvironmentPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    public EnvironmentPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public string All { get { return default(string); } set { } }
    public string Read { get { return default(string); } set { } }
    public string Write { get { return default(string); } set { } }
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(4205), AllowMultiple=true, Inherited=false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class HostProtectionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    public HostProtectionAttribute() : base (default(System.Security.Permissions.SecurityAction)) { }
    public HostProtectionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public bool ExternalProcessMgmt { get { return default(bool); } set { } }
    public bool ExternalThreading { get { return default(bool); } set { } }
    public bool MayLeakOnAbort { get { return default(bool); } set { } }
    public System.Security.Permissions.HostProtectionResource Resources { get { return default(System.Security.Permissions.HostProtectionResource); } set { } }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public bool SecurityInfrastructure { get { return default(bool); } set { } }
    public bool SelfAffectingProcessMgmt { get { return default(bool); } set { } }
    public bool SelfAffectingThreading { get { return default(bool); } set { } }
    public bool SharedState { get { return default(bool); } set { } }
    public bool Synchronization { get { return default(bool); } set { } }
    public bool UI { get { return default(bool); } set { } }
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class PermissionSetAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    public PermissionSetAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public string File { get { return default(string); } set { } }
    public string Hex { get { return default(string); } set { } }
    public string Name { get { return default(string); } set { } }
    public bool UnicodeEncoded { get { return default(bool); } set { } }
    public string XML { get { return default(string); } set { } }
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
    public System.Security.PermissionSet CreatePermissionSet() { return default(System.Security.PermissionSet); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class ReflectionPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    public ReflectionPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public System.Security.Permissions.ReflectionPermissionFlag Flags { get { return default(System.Security.Permissions.ReflectionPermissionFlag); } set { } }
    public bool MemberAccess { get { return default(bool); } set { } }
    [System.ObsoleteAttribute]
    public bool ReflectionEmit { get { return default(bool); } set { } }
    public bool RestrictedMemberAccess { get { return default(bool); } set { } }
    [System.ObsoleteAttribute("not enforced in 2.0+")]
    public bool TypeInformation { get { return default(bool); } set { } }
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class SecurityAttribute : System.Attribute {
    protected SecurityAttribute(System.Security.Permissions.SecurityAction action) { }
    public System.Security.Permissions.SecurityAction Action { get { return default(System.Security.Permissions.SecurityAction); } set { } }
    public bool Unrestricted { get { return default(bool); } set { } }
    public abstract System.Security.IPermission CreatePermission();
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class StrongNameIdentityPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    public StrongNameIdentityPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public string Name { get { return default(string); } set { } }
    public string PublicKey { get { return default(string); } set { } }
    public string Version { get { return default(string); } set { } }
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
  }

} // end of System.Security.Permissions
namespace System.Security.Policy {
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class AllMembershipCondition : System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable, System.Security.Policy.IMembershipCondition {
    public AllMembershipCondition() { }
    public bool Check(System.Security.Policy.Evidence evidence) { return default(bool); }
    public System.Security.Policy.IMembershipCondition Copy() { return default(System.Security.Policy.IMembershipCondition); }
    public override bool Equals(object o) { return default(bool); }
    public void FromXml(System.Security.SecurityElement e) { }
    public void FromXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
    public System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { return default(System.Security.SecurityElement); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class ApplicationDirectory : System.Security.Policy.EvidenceBase {
    public ApplicationDirectory(string name) { }
    public string Directory { get { return default(string); } }
    public object Copy() { return default(object); }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class ApplicationDirectoryMembershipCondition : System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable, System.Security.Policy.IMembershipCondition {
    public ApplicationDirectoryMembershipCondition() { }
    public bool Check(System.Security.Policy.Evidence evidence) { return default(bool); }
    public System.Security.Policy.IMembershipCondition Copy() { return default(System.Security.Policy.IMembershipCondition); }
    public override bool Equals(object o) { return default(bool); }
    public void FromXml(System.Security.SecurityElement e) { }
    public void FromXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
    public System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { return default(System.Security.SecurityElement); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class ApplicationSecurityInfo {
    public ApplicationSecurityInfo(System.ActivationContext activationContext) { }
    public System.Security.Policy.Evidence ApplicationEvidence { get { return default(System.Security.Policy.Evidence); } set { } }
    public System.ApplicationId ApplicationId { get { return default(System.ApplicationId); } set { } }
    public System.Security.PermissionSet DefaultRequestSet { get { return default(System.Security.PermissionSet); } set { } }
    public System.ApplicationId DeploymentId { get { return default(System.ApplicationId); } set { } }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public static partial class ApplicationSecurityManager {
    public static System.Security.Policy.IApplicationTrustManager ApplicationTrustManager { get { return default(System.Security.Policy.IApplicationTrustManager); } }
    public static System.Security.Policy.ApplicationTrustCollection UserApplicationTrusts { get { return default(System.Security.Policy.ApplicationTrustCollection); } }
    public static bool DetermineApplicationTrust(System.ActivationContext activationContext, System.Security.Policy.TrustManagerContext context) { return default(bool); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class ApplicationTrust : System.Security.Policy.EvidenceBase, System.Security.ISecurityEncodable {
    public ApplicationTrust() { }
    public ApplicationTrust(System.ApplicationIdentity applicationIdentity) { }
    public ApplicationTrust(System.Security.PermissionSet defaultGrantSet, System.Collections.Generic.IEnumerable<System.Security.Policy.StrongName> fullTrustAssemblies) { }
    public System.ApplicationIdentity ApplicationIdentity { get { return default(System.ApplicationIdentity); } set { } }
    public System.Security.Policy.PolicyStatement DefaultGrantSet { get { return default(System.Security.Policy.PolicyStatement); } set { } }
    public object ExtraInfo { get { return default(object); } set { } }
    public System.Collections.Generic.IList<System.Security.Policy.StrongName> FullTrustAssemblies { get { return default(System.Collections.Generic.IList<System.Security.Policy.StrongName>); } }
    public bool IsApplicationTrustedToRun { get { return default(bool); } set { } }
    public bool Persist { get { return default(bool); } set { } }
    public void FromXml(System.Security.SecurityElement element) { }
    public System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class ApplicationTrustCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    internal ApplicationTrustCollection() { }
    public int Count { get { return default(int); } }
    public bool IsSynchronized { get { return default(bool); } }
    public System.Security.Policy.ApplicationTrust this[int index] { get { return default(System.Security.Policy.ApplicationTrust); } }
    public System.Security.Policy.ApplicationTrust this[string appFullName] { get { return default(System.Security.Policy.ApplicationTrust); } }
    public object SyncRoot { get { return default(object); } }
    public int Add(System.Security.Policy.ApplicationTrust trust) { return default(int); }
    public void AddRange(System.Security.Policy.ApplicationTrust[] trusts) { }
    public void AddRange(System.Security.Policy.ApplicationTrustCollection trusts) { }
    public void Clear() { }
    public void CopyTo(System.Security.Policy.ApplicationTrust[] array, int index) { }
    public System.Security.Policy.ApplicationTrustCollection Find(System.ApplicationIdentity applicationIdentity, System.Security.Policy.ApplicationVersionMatch versionMatch) { return default(System.Security.Policy.ApplicationTrustCollection); }
    public System.Security.Policy.ApplicationTrustEnumerator GetEnumerator() { return default(System.Security.Policy.ApplicationTrustEnumerator); }
    public void Remove(System.ApplicationIdentity applicationIdentity, System.Security.Policy.ApplicationVersionMatch versionMatch) { }
    public void Remove(System.Security.Policy.ApplicationTrust trust) { }
    public void RemoveRange(System.Security.Policy.ApplicationTrust[] trusts) { }
    public void RemoveRange(System.Security.Policy.ApplicationTrustCollection trusts) { }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class ApplicationTrustEnumerator : System.Collections.IEnumerator {
    internal ApplicationTrustEnumerator() { }
    public System.Security.Policy.ApplicationTrust Current { get { return default(System.Security.Policy.ApplicationTrust); } }
    object System.Collections.IEnumerator.Current { get { return default(object); } }
    public bool MoveNext() { return default(bool); }
    public void Reset() { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum ApplicationVersionMatch {
    MatchAllVersions = 1,
    MatchExactVersion = 0,
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CodeConnectAccess {
    public static readonly string AnyScheme;
    public static readonly int DefaultPort;
    public static readonly int OriginPort;
    public static readonly string OriginScheme;
    public CodeConnectAccess(string allowScheme, int allowPort) { }
    public int Port { get { return default(int); } }
    public string Scheme { get { return default(string); } }
    public static System.Security.Policy.CodeConnectAccess CreateAnySchemeAccess(int allowPort) { return default(System.Security.Policy.CodeConnectAccess); }
    public static System.Security.Policy.CodeConnectAccess CreateOriginSchemeAccess(int allowPort) { return default(System.Security.Policy.CodeConnectAccess); }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class CodeGroup {
    protected CodeGroup(System.Security.Policy.IMembershipCondition membershipCondition, System.Security.Policy.PolicyStatement policy) { }
    public virtual string AttributeString { get { return default(string); } }
    public System.Collections.IList Children { get { return default(System.Collections.IList); } set { } }
    public string Description { get { return default(string); } set { } }
    public System.Security.Policy.IMembershipCondition MembershipCondition { get { return default(System.Security.Policy.IMembershipCondition); } set { } }
    public abstract string MergeLogic { get; }
    public string Name { get { return default(string); } set { } }
    public virtual string PermissionSetName { get { return default(string); } }
    public System.Security.Policy.PolicyStatement PolicyStatement { get { return default(System.Security.Policy.PolicyStatement); } set { } }
    public void AddChild(System.Security.Policy.CodeGroup group) { }
    public abstract System.Security.Policy.CodeGroup Copy();
    protected virtual void CreateXml(System.Security.SecurityElement element, System.Security.Policy.PolicyLevel level) { }
    public override bool Equals(object o) { return default(bool); }
    public bool Equals(System.Security.Policy.CodeGroup cg, bool compareChildren) { return default(bool); }
    public void FromXml(System.Security.SecurityElement e) { }
    public void FromXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
    public override int GetHashCode() { return default(int); }
    protected virtual void ParseXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
    public void RemoveChild(System.Security.Policy.CodeGroup group) { }
    public abstract System.Security.Policy.PolicyStatement Resolve(System.Security.Policy.Evidence evidence);
    public abstract System.Security.Policy.CodeGroup ResolveMatchingCodeGroups(System.Security.Policy.Evidence evidence);
    public System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { return default(System.Security.SecurityElement); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class FirstMatchCodeGroup : System.Security.Policy.CodeGroup {
    public FirstMatchCodeGroup(System.Security.Policy.IMembershipCondition membershipCondition, System.Security.Policy.PolicyStatement policy) : base (default(System.Security.Policy.IMembershipCondition), default(System.Security.Policy.PolicyStatement)) { }
    public override string MergeLogic { get { return default(string); } }
    public override System.Security.Policy.CodeGroup Copy() { return default(System.Security.Policy.CodeGroup); }
    public override System.Security.Policy.PolicyStatement Resolve(System.Security.Policy.Evidence evidence) { return default(System.Security.Policy.PolicyStatement); }
    public override System.Security.Policy.CodeGroup ResolveMatchingCodeGroups(System.Security.Policy.Evidence evidence) { return default(System.Security.Policy.CodeGroup); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class GacInstalled : System.Security.Policy.EvidenceBase, System.Security.Policy.IIdentityPermissionFactory {
    public GacInstalled() { }
    public object Copy() { return default(object); }
    public System.Security.IPermission CreateIdentityPermission(System.Security.Policy.Evidence evidence) { return default(System.Security.IPermission); }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class GacMembershipCondition : System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable, System.Security.Policy.IMembershipCondition {
    public GacMembershipCondition() { }
    public bool Check(System.Security.Policy.Evidence evidence) { return default(bool); }
    public System.Security.Policy.IMembershipCondition Copy() { return default(System.Security.Policy.IMembershipCondition); }
    public override bool Equals(object o) { return default(bool); }
    public void FromXml(System.Security.SecurityElement e) { }
    public void FromXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
    public System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { return default(System.Security.SecurityElement); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class Hash : System.Security.Policy.EvidenceBase, System.Runtime.Serialization.ISerializable {
    public Hash(System.Reflection.Assembly assembly) { }
    public byte[] MD5 { get { return default(byte[]); } }
    public byte[] SHA1 { get { return default(byte[]); } }
    public static System.Security.Policy.Hash CreateMD5(byte[] md5) { return default(System.Security.Policy.Hash); }
    public static System.Security.Policy.Hash CreateSHA1(byte[] sha1) { return default(System.Security.Policy.Hash); }
    public byte[] GenerateHash(System.Security.Cryptography.HashAlgorithm hashAlg) { return default(byte[]); }
    public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public override string ToString() { return default(string); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class HashMembershipCondition : System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable, System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable, System.Security.Policy.IMembershipCondition {
    public HashMembershipCondition(System.Security.Cryptography.HashAlgorithm hashAlg, byte[] value) { }
    public System.Security.Cryptography.HashAlgorithm HashAlgorithm { get { return default(System.Security.Cryptography.HashAlgorithm); } set { } }
    public byte[] HashValue { get { return default(byte[]); } set { } }
    public bool Check(System.Security.Policy.Evidence evidence) { return default(bool); }
    public System.Security.Policy.IMembershipCondition Copy() { return default(System.Security.Policy.IMembershipCondition); }
    public override bool Equals(object o) { return default(bool); }
    public void FromXml(System.Security.SecurityElement e) { }
    public void FromXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
    public override int GetHashCode() { return default(int); }
    void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public override string ToString() { return default(string); }
    public System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { return default(System.Security.SecurityElement); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface IApplicationTrustManager : System.Security.ISecurityEncodable {
    System.Security.Policy.ApplicationTrust DetermineApplicationTrust(System.ActivationContext activationContext, System.Security.Policy.TrustManagerContext context);
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface IIdentityPermissionFactory {
    System.Security.IPermission CreateIdentityPermission(System.Security.Policy.Evidence evidence);
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface IMembershipCondition : System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable {
    bool Check(System.Security.Policy.Evidence evidence);
    System.Security.Policy.IMembershipCondition Copy();
    bool Equals(object obj);
    string ToString();
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class NetCodeGroup : System.Security.Policy.CodeGroup {
    public static readonly string AbsentOriginScheme;
    public static readonly string AnyOtherOriginScheme;
    public NetCodeGroup(System.Security.Policy.IMembershipCondition membershipCondition) : base (default(System.Security.Policy.IMembershipCondition), default(System.Security.Policy.PolicyStatement)) { }
    public override string AttributeString { get { return default(string); } }
    public override string MergeLogic { get { return default(string); } }
    public override string PermissionSetName { get { return default(string); } }
    public void AddConnectAccess(string originScheme, System.Security.Policy.CodeConnectAccess connectAccess) { }
    public override System.Security.Policy.CodeGroup Copy() { return default(System.Security.Policy.CodeGroup); }
    protected override void CreateXml(System.Security.SecurityElement element, System.Security.Policy.PolicyLevel level) { }
    public override bool Equals(object o) { return default(bool); }
    public System.Collections.DictionaryEntry[] GetConnectAccessRules() { return default(System.Collections.DictionaryEntry[]); }
    public override int GetHashCode() { return default(int); }
    protected override void ParseXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
    public void ResetConnectAccess() { }
    public override System.Security.Policy.PolicyStatement Resolve(System.Security.Policy.Evidence evidence) { return default(System.Security.Policy.PolicyStatement); }
    public override System.Security.Policy.CodeGroup ResolveMatchingCodeGroups(System.Security.Policy.Evidence evidence) { return default(System.Security.Policy.CodeGroup); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class PermissionRequestEvidence : System.Security.Policy.EvidenceBase {
    public PermissionRequestEvidence(System.Security.PermissionSet request, System.Security.PermissionSet optional, System.Security.PermissionSet denied) { }
    public System.Security.PermissionSet DeniedPermissions { get { return default(System.Security.PermissionSet); } }
    public System.Security.PermissionSet OptionalPermissions { get { return default(System.Security.PermissionSet); } }
    public System.Security.PermissionSet RequestedPermissions { get { return default(System.Security.PermissionSet); } }
    public System.Security.Policy.PermissionRequestEvidence Copy() { return default(System.Security.Policy.PermissionRequestEvidence); }
    public override string ToString() { return default(string); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class PolicyException :System.SystemException{
    public PolicyException() { }
    protected PolicyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public PolicyException(string message) { }
    public PolicyException(string message, System.Exception exception) { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class PolicyLevel {
    internal PolicyLevel() { }
    [System.ObsoleteAttribute("All GACed assemblies are now fully trusted and all permissions now succeed on fully trusted code.")]
    public System.Collections.IList FullTrustAssemblies { get { return default(System.Collections.IList); } }
    public string Label { get { return default(string); } }
    public System.Collections.IList NamedPermissionSets { get { return default(System.Collections.IList); } }
    public System.Security.Policy.CodeGroup RootCodeGroup { get { return default(System.Security.Policy.CodeGroup); } set { } }
    public string StoreLocation { get { return default(string); } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.Security.PolicyLevelType Type { get { return default(System.Security.PolicyLevelType); } }
    [System.ObsoleteAttribute("All GACed assemblies are now fully trusted and all permissions now succeed on fully trusted code.")]
    public void AddFullTrustAssembly(System.Security.Policy.StrongName sn) { }
    [System.ObsoleteAttribute("All GACed assemblies are now fully trusted and all permissions now succeed on fully trusted code.")]
    public void AddFullTrustAssembly(System.Security.Policy.StrongNameMembershipCondition snMC) { }
    public void AddNamedPermissionSet(System.Security.NamedPermissionSet permSet) { }
    public System.Security.NamedPermissionSet ChangeNamedPermissionSet(string name, System.Security.PermissionSet pSet) { return default(System.Security.NamedPermissionSet); }
    public static System.Security.Policy.PolicyLevel CreateAppDomainLevel() { return default(System.Security.Policy.PolicyLevel); }
    public void FromXml(System.Security.SecurityElement e) { }
    public System.Security.NamedPermissionSet GetNamedPermissionSet(string name) { return default(System.Security.NamedPermissionSet); }
    public void Recover() { }
    [System.ObsoleteAttribute("All GACed assemblies are now fully trusted and all permissions now succeed on fully trusted code.")]
    public void RemoveFullTrustAssembly(System.Security.Policy.StrongName sn) { }
    [System.ObsoleteAttribute("All GACed assemblies are now fully trusted and all permissions now succeed on fully trusted code.")]
    public void RemoveFullTrustAssembly(System.Security.Policy.StrongNameMembershipCondition snMC) { }
    public System.Security.NamedPermissionSet RemoveNamedPermissionSet(System.Security.NamedPermissionSet permSet) { return default(System.Security.NamedPermissionSet); }
    public System.Security.NamedPermissionSet RemoveNamedPermissionSet(string name) { return default(System.Security.NamedPermissionSet); }
    public void Reset() { }
    public System.Security.Policy.PolicyStatement Resolve(System.Security.Policy.Evidence evidence) { return default(System.Security.Policy.PolicyStatement); }
    public System.Security.Policy.CodeGroup ResolveMatchingCodeGroups(System.Security.Policy.Evidence evidence) { return default(System.Security.Policy.CodeGroup); }
    public System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class PolicyStatement : System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable {
    public PolicyStatement(System.Security.PermissionSet permSet) { }
    public PolicyStatement(System.Security.PermissionSet permSet, System.Security.Policy.PolicyStatementAttribute attributes) { }
    public System.Security.Policy.PolicyStatementAttribute Attributes { get { return default(System.Security.Policy.PolicyStatementAttribute); } set { } }
    public string AttributeString { get { return default(string); } }
    public System.Security.PermissionSet PermissionSet { get { return default(System.Security.PermissionSet); } set { } }
    public System.Security.Policy.PolicyStatement Copy() { return default(System.Security.Policy.PolicyStatement); }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public override bool Equals(object obj) { return default(bool); }
    public void FromXml(System.Security.SecurityElement et) { }
    public void FromXml(System.Security.SecurityElement et, System.Security.Policy.PolicyLevel level) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public override int GetHashCode() { return default(int); }
    public System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { return default(System.Security.SecurityElement); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class Publisher : System.Security.Policy.EvidenceBase, System.Security.Policy.IIdentityPermissionFactory {
    public Publisher(System.Security.Cryptography.X509Certificates.X509Certificate cert) { }
    public System.Security.Cryptography.X509Certificates.X509Certificate Certificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate); } }
    public object Copy() { return default(object); }
    public System.Security.IPermission CreateIdentityPermission(System.Security.Policy.Evidence evidence) { return default(System.Security.IPermission); }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class PublisherMembershipCondition : System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable, System.Security.Policy.IMembershipCondition {
    public PublisherMembershipCondition(System.Security.Cryptography.X509Certificates.X509Certificate certificate) { }
    public System.Security.Cryptography.X509Certificates.X509Certificate Certificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate); } set { } }
    public bool Check(System.Security.Policy.Evidence evidence) { return default(bool); }
    public System.Security.Policy.IMembershipCondition Copy() { return default(System.Security.Policy.IMembershipCondition); }
    public override bool Equals(object o) { return default(bool); }
    public void FromXml(System.Security.SecurityElement e) { }
    public void FromXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
    public System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { return default(System.Security.SecurityElement); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class Site : System.Security.Policy.EvidenceBase, System.Security.Policy.IIdentityPermissionFactory {
    public Site(string name) { }
    public string Name { get { return default(string); } }
    public object Copy() { return default(object); }
    public static System.Security.Policy.Site CreateFromUrl(string url) { return default(System.Security.Policy.Site); }
    public System.Security.IPermission CreateIdentityPermission(System.Security.Policy.Evidence evidence) { return default(System.Security.IPermission); }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class SiteMembershipCondition : System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable, System.Security.Policy.IMembershipCondition {
    public SiteMembershipCondition(string site) { }
    public string Site { get { return default(string); } set { } }
    public bool Check(System.Security.Policy.Evidence evidence) { return default(bool); }
    public System.Security.Policy.IMembershipCondition Copy() { return default(System.Security.Policy.IMembershipCondition); }
    public override bool Equals(object o) { return default(bool); }
    public void FromXml(System.Security.SecurityElement e) { }
    public void FromXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
    public System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { return default(System.Security.SecurityElement); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class StrongName : System.Security.Policy.EvidenceBase, System.Security.Policy.IIdentityPermissionFactory {
    public StrongName(System.Security.Permissions.StrongNamePublicKeyBlob blob, string name, System.Version version) { }
    public string Name { get { return default(string); } }
    public System.Security.Permissions.StrongNamePublicKeyBlob PublicKey { get { return default(System.Security.Permissions.StrongNamePublicKeyBlob); } }
    public System.Version Version { get { return default(System.Version); } }
    public object Copy() { return default(object); }
    public System.Security.IPermission CreateIdentityPermission(System.Security.Policy.Evidence evidence) { return default(System.Security.IPermission); }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class StrongNameMembershipCondition : System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable, System.Security.Policy.IMembershipCondition {
    public StrongNameMembershipCondition(System.Security.Permissions.StrongNamePublicKeyBlob blob, string name, System.Version version) { }
    public string Name { get { return default(string); } set { } }
    public System.Security.Permissions.StrongNamePublicKeyBlob PublicKey { get { return default(System.Security.Permissions.StrongNamePublicKeyBlob); } set { } }
    public System.Version Version { get { return default(System.Version); } set { } }
    public bool Check(System.Security.Policy.Evidence evidence) { return default(bool); }
    public System.Security.Policy.IMembershipCondition Copy() { return default(System.Security.Policy.IMembershipCondition); }
    public override bool Equals(object o) { return default(bool); }
    public void FromXml(System.Security.SecurityElement e) { }
    public void FromXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
    public System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { return default(System.Security.SecurityElement); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class UnionCodeGroup : System.Security.Policy.CodeGroup {
    public UnionCodeGroup(System.Security.Policy.IMembershipCondition membershipCondition, System.Security.Policy.PolicyStatement policy) : base (default(System.Security.Policy.IMembershipCondition), default(System.Security.Policy.PolicyStatement)) { }
    public override string MergeLogic { get { return default(string); } }
    public override System.Security.Policy.CodeGroup Copy() { return default(System.Security.Policy.CodeGroup); }
    public override System.Security.Policy.PolicyStatement Resolve(System.Security.Policy.Evidence evidence) { return default(System.Security.Policy.PolicyStatement); }
    public override System.Security.Policy.CodeGroup ResolveMatchingCodeGroups(System.Security.Policy.Evidence evidence) { return default(System.Security.Policy.CodeGroup); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class Url : System.Security.Policy.EvidenceBase, System.Security.Policy.IIdentityPermissionFactory {
    public Url(string name) { }
    public string Value { get { return default(string); } }
    public object Copy() { return default(object); }
    public System.Security.IPermission CreateIdentityPermission(System.Security.Policy.Evidence evidence) { return default(System.Security.IPermission); }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class UrlMembershipCondition : System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable, System.Security.Policy.IMembershipCondition {
    public UrlMembershipCondition(string url) { }
    public string Url { get { return default(string); } set { } }
    public bool Check(System.Security.Policy.Evidence evidence) { return default(bool); }
    public System.Security.Policy.IMembershipCondition Copy() { return default(System.Security.Policy.IMembershipCondition); }
    public override bool Equals(object o) { return default(bool); }
    public void FromXml(System.Security.SecurityElement e) { }
    public void FromXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
    public System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { return default(System.Security.SecurityElement); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class Zone : System.Security.Policy.EvidenceBase, System.Security.Policy.IIdentityPermissionFactory {
    public Zone(System.Security.SecurityZone zone) { }
    public System.Security.SecurityZone SecurityZone { get { return default(System.Security.SecurityZone); } }
    public object Copy() { return default(object); }
    public static System.Security.Policy.Zone CreateFromUrl(string url) { return default(System.Security.Policy.Zone); }
    public System.Security.IPermission CreateIdentityPermission(System.Security.Policy.Evidence evidence) { return default(System.Security.IPermission); }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class ZoneMembershipCondition : System.Security.ISecurityEncodable, System.Security.ISecurityPolicyEncodable, System.Security.Policy.IMembershipCondition {
    public ZoneMembershipCondition(System.Security.SecurityZone zone) { }
    public System.Security.SecurityZone SecurityZone { get { return default(System.Security.SecurityZone); } set { } }
    public bool Check(System.Security.Policy.Evidence evidence) { return default(bool); }
    public System.Security.Policy.IMembershipCondition Copy() { return default(System.Security.Policy.IMembershipCondition); }
    public override bool Equals(object o) { return default(bool); }
    public void FromXml(System.Security.SecurityElement e) { }
    public void FromXml(System.Security.SecurityElement e, System.Security.Policy.PolicyLevel level) { }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
    public System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel level) { return default(System.Security.SecurityElement); }
  }

} // end of System.Security.Policy
