[assembly:System.CLSCompliant(true)]
namespace System.Security {
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class HostProtectionException : System.SystemException {
    public HostProtectionException() { }
    protected HostProtectionException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public HostProtectionException(string message) { }
    public HostProtectionException(string message, System.Exception e) { }
    public HostProtectionException(string message, System.Security.Permissions.HostProtectionResource protectedResources, System.Security.Permissions.HostProtectionResource demandedResources) { }
    public System.Security.Permissions.HostProtectionResource DemandedResources { get { return default(System.Security.Permissions.HostProtectionResource); } }
    public System.Security.Permissions.HostProtectionResource ProtectedResources { get { return default(System.Security.Permissions.HostProtectionResource); } }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public override string ToString() { return default(string); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface IEvidenceFactory {
    System.Security.Policy.Evidence Evidence { get; }
  }

  public sealed partial class SecurityContext : System.IDisposable {
    internal SecurityContext() { }
    public static System.Security.SecurityContext Capture() { return default(System.Security.SecurityContext); }
    public System.Security.SecurityContext CreateCopy() { return default(System.Security.SecurityContext); }
    public void Dispose() { }
    public static bool IsFlowSuppressed() { return default(bool); }
    public static bool IsWindowsIdentityFlowSuppressed() { return default(bool); }
    public static void RestoreFlow() { }
    public static void Run(System.Security.SecurityContext securityContext, System.Threading.ContextCallback callback, object state) { }
    public static System.Threading.AsyncFlowControl SuppressFlow() { return default(System.Threading.AsyncFlowControl); }
    public static System.Threading.AsyncFlowControl SuppressFlowWindowsIdentity() { return default(System.Threading.AsyncFlowControl); }
  }

  [System.ObsoleteAttribute("SecurityCriticalScope is only used for .NET 2.0 transparency compatibility.")]
  public enum SecurityCriticalScope {
    Everything = 1,
    Explicit = 0,
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public static partial class SecurityManager {
    [System.ObsoleteAttribute]
    public static bool CheckExecutionRights { get { return default(bool); } set { } }
    [System.ObsoleteAttribute("The security manager cannot be turned off on MS runtime")]
    public static bool SecurityEnabled { get { return default(bool); } set { } }
    public static bool CurrentThreadRequiresSecurityContextCapture() { return default(bool); }
    public static System.Security.PermissionSet GetStandardSandbox(System.Security.Policy.Evidence evidence) { return default(System.Security.PermissionSet); }
    public static void GetZoneAndOrigin(out System.Collections.ArrayList zone, out System.Collections.ArrayList origin) { zone = default(System.Collections.ArrayList); origin = default(System.Collections.ArrayList); }
    [System.ObsoleteAttribute]
    public static bool IsGranted(System.Security.IPermission perm) { return default(bool); }
    [System.ObsoleteAttribute]
    public static System.Security.Policy.PolicyLevel LoadPolicyLevelFromFile(string path, System.Security.PolicyLevelType type) { return default(System.Security.Policy.PolicyLevel); }
    [System.ObsoleteAttribute]
    public static System.Security.Policy.PolicyLevel LoadPolicyLevelFromString(string str, System.Security.PolicyLevelType type) { return default(System.Security.Policy.PolicyLevel); }
    [System.ObsoleteAttribute]
    public static System.Collections.IEnumerator PolicyHierarchy() { return default(System.Collections.IEnumerator); }
    [System.ObsoleteAttribute]
    public static System.Security.PermissionSet ResolvePolicy(System.Security.Policy.Evidence evidence) { return default(System.Security.PermissionSet); }
    [System.ObsoleteAttribute]
    public static System.Security.PermissionSet ResolvePolicy(System.Security.Policy.Evidence evidence, System.Security.PermissionSet reqdPset, System.Security.PermissionSet optPset, System.Security.PermissionSet denyPset, out System.Security.PermissionSet denied) { denied = default(System.Security.PermissionSet); return default(System.Security.PermissionSet); }
    [System.ObsoleteAttribute]
    public static System.Security.PermissionSet ResolvePolicy(System.Security.Policy.Evidence[] evidences) { return default(System.Security.PermissionSet); }
    [System.ObsoleteAttribute]
    public static System.Collections.IEnumerator ResolvePolicyGroups(System.Security.Policy.Evidence evidence) { return default(System.Collections.IEnumerator); }
    [System.ObsoleteAttribute]
    public static System.Security.PermissionSet ResolveSystemPolicy(System.Security.Policy.Evidence evidence) { return default(System.Security.PermissionSet); }
    [System.ObsoleteAttribute]
    public static void SavePolicy() { }
    [System.ObsoleteAttribute]
    public static void SavePolicyLevel(System.Security.Policy.PolicyLevel level) { }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(1), AllowMultiple=false)]
  public sealed partial class SecurityRulesAttribute : System.Attribute {
    public SecurityRulesAttribute(System.Security.SecurityRuleSet ruleSet) { }
    public System.Security.SecurityRuleSet RuleSet { get { return default(System.Security.SecurityRuleSet); } }
    public bool SkipVerificationInFullTrust { get { return default(bool); } set { } }
  }

  public enum SecurityRuleSet : byte {
    Level1 = (byte)1,
    Level2 = (byte)2,
    None = (byte)0,
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(5501), AllowMultiple=false, Inherited=false)]
  [System.ObsoleteAttribute("SecurityTreatAsSafe is only used for .NET 2.0 transparency compatibility.  Please use the SecuritySafeCriticalAttribute instead.")]
  public sealed partial class SecurityTreatAsSafeAttribute : System.Attribute {
    public SecurityTreatAsSafeAttribute() { }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(2), AllowMultiple=true, Inherited=false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class UnverifiableCodeAttribute : System.Attribute {
    public UnverifiableCodeAttribute() { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class XmlSyntaxException : System.SystemException {
    public XmlSyntaxException() { }
    public XmlSyntaxException(int lineNumber) { }
    public XmlSyntaxException(int lineNumber, string message) { }
    public XmlSyntaxException(string message) { }
    public XmlSyntaxException(string message, System.Exception inner) { }
  }

} // end of System.Security
namespace System.Security.Cryptography {
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class CryptoAPITransform : System.IDisposable, System.Security.Cryptography.ICryptoTransform {
    internal CryptoAPITransform() { }
    public bool CanReuseTransform { get { return default(bool); } }
    public bool CanTransformMultipleBlocks { get { return default(bool); } }
    public int InputBlockSize { get { return default(int); } }
    public System.IntPtr KeyHandle { get { return default(System.IntPtr); } }
    public int OutputBlockSize { get { return default(int); } }
    public void Clear() { }
    public void Dispose() { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public void Reset() { }
    public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { return default(int); }
    public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { return default(byte[]); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CryptoConfig {
    public CryptoConfig() { }
    public static bool AllowOnlyFipsAlgorithms { get { return default(bool); } }
    public static object CreateFromName(string name) { return default(object); }
    public static object CreateFromName(string name, params object[] args) { return default(object); }
    public static byte[] EncodeOID(string str) { return default(byte[]); }
    public static string MapNameToOID(string name) { return default(string); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class FromBase64Transform : System.IDisposable, System.Security.Cryptography.ICryptoTransform {
    public FromBase64Transform() { }
    public FromBase64Transform(System.Security.Cryptography.FromBase64TransformMode whitespaces) { }
    public virtual bool CanReuseTransform { get { return default(bool); } }
    public bool CanTransformMultipleBlocks { get { return default(bool); } }
    public int InputBlockSize { get { return default(int); } }
    public int OutputBlockSize { get { return default(int); } }
    public void Clear() { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    ~FromBase64Transform() { }
    public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { return default(int); }
    public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { return default(byte[]); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum FromBase64TransformMode {
    DoNotIgnoreWhiteSpaces = 1,
    IgnoreWhiteSpaces = 0,
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class MaskGenerationMethod {
    protected MaskGenerationMethod() { }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract byte[] GenerateMask(byte[] rgbSeed, int cbReturn);
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class PKCS1MaskGenerationMethod : System.Security.Cryptography.MaskGenerationMethod {
    public PKCS1MaskGenerationMethod() { }
    public string HashName { get { return default(string); } set { } }
    public override byte[] GenerateMask(byte[] rgbSeed, int cbReturn) { return default(byte[]); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class ToBase64Transform : System.IDisposable, System.Security.Cryptography.ICryptoTransform {
    public ToBase64Transform() { }
    public virtual bool CanReuseTransform { get { return default(bool); } }
    public bool CanTransformMultipleBlocks { get { return default(bool); } }
    public int InputBlockSize { get { return default(int); } }
    public int OutputBlockSize { get { return default(int); } }
    public void Clear() { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    ~ToBase64Transform() { }
    public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { return default(int); }
    public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { return default(byte[]); }
  }

} // end of System.Security.Cryptography
