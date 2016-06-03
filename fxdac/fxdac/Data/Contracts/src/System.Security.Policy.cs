[assembly:System.CLSCompliant(true)]
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
