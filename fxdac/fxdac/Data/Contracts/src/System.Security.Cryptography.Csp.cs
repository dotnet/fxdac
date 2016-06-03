[assembly:System.CLSCompliant(true)]
namespace System.Security.Cryptography {
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class CspKeyContainerInfo {
    public CspKeyContainerInfo(System.Security.Cryptography.CspParameters parameters) { }
    public bool Accessible { get { return default(bool); } }
    public System.Security.AccessControl.CryptoKeySecurity CryptoKeySecurity { get { return default(System.Security.AccessControl.CryptoKeySecurity); } }
    public bool Exportable { get { return default(bool); } }
    public bool HardwareDevice { get { return default(bool); } }
    public string KeyContainerName { get { return default(string); } }
    public System.Security.Cryptography.KeyNumber KeyNumber { get { return default(System.Security.Cryptography.KeyNumber); } }
    public bool MachineKeyStore { get { return default(bool); } }
    public bool Protected { get { return default(bool); } }
    public string ProviderName { get { return default(string); } }
    public int ProviderType { get { return default(int); } }
    public bool RandomlyGenerated { get { return default(bool); } }
    public bool Removable { get { return default(bool); } }
    public string UniqueKeyContainerName { get { return default(string); } }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class CspParameters {
    public string KeyContainerName;
    public int KeyNumber;
    public string ProviderName;
    public int ProviderType;
    public CspParameters() { }
    public CspParameters(int dwTypeIn) { }
    public CspParameters(int dwTypeIn, string strProviderNameIn) { }
    public CspParameters(int dwTypeIn, string strProviderNameIn, string strContainerNameIn) { }
    public CspParameters(int providerType, string providerName, string keyContainerName, System.Security.AccessControl.CryptoKeySecurity cryptoKeySecurity, System.IntPtr parentWindowHandle) { }
    public CspParameters(int providerType, string providerName, string keyContainerName, System.Security.AccessControl.CryptoKeySecurity cryptoKeySecurity, System.Security.SecureString keyPassword) { }
    public System.Security.AccessControl.CryptoKeySecurity CryptoKeySecurity { get { return default(System.Security.AccessControl.CryptoKeySecurity); } set { } }
    public System.Security.Cryptography.CspProviderFlags Flags { get { return default(System.Security.Cryptography.CspProviderFlags); } set { } }
    public System.Security.SecureString KeyPassword { get { return default(System.Security.SecureString); } set { } }
    public System.IntPtr ParentWindowHandle { get { return default(System.IntPtr); } set { } }
  }

  [System.FlagsAttribute]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum CspProviderFlags {
    CreateEphemeralKey = 128,
    NoFlags = 0,
    NoPrompt = 64,
    UseArchivableKey = 16,
    UseDefaultKeyContainer = 2,
    UseExistingKey = 8,
    UseMachineKeyStore = 1,
    UseNonExportableKey = 4,
    UseUserProtectedKey = 32,
  }

  public sealed partial class DESCryptoServiceProvider : System.Security.Cryptography.DES {
    public DESCryptoServiceProvider() { }
    public override System.Security.Cryptography.ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { return default(System.Security.Cryptography.ICryptoTransform); }
    public override System.Security.Cryptography.ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { return default(System.Security.Cryptography.ICryptoTransform); }
    public override void GenerateIV() { }
    public override void GenerateKey() { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class DSACryptoServiceProvider : System.Security.Cryptography.DSA, System.Security.Cryptography.ICspAsymmetricAlgorithm {
    public DSACryptoServiceProvider() { }
    public DSACryptoServiceProvider(int dwKeySize) { }
    public DSACryptoServiceProvider(int dwKeySize, System.Security.Cryptography.CspParameters parameters) { }
    public DSACryptoServiceProvider(System.Security.Cryptography.CspParameters parameters) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.Security.Cryptography.CspKeyContainerInfo CspKeyContainerInfo { get { return default(System.Security.Cryptography.CspKeyContainerInfo); } }
    public override string KeyExchangeAlgorithm { get { return default(string); } }
    public override int KeySize { get { return default(int); } }
    public bool PersistKeyInCsp { get { return default(bool); } set { } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public bool PublicOnly { get { return default(bool); } }
    public override string SignatureAlgorithm { get { return default(string); } }
    public static bool UseMachineKeyStore { get { return default(bool); } set { } }
    public override byte[] CreateSignature(byte[] rgbHash) { return default(byte[]); }
    protected override void Dispose(bool disposing) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public byte[] ExportCspBlob(bool includePrivateParameters) { return default(byte[]); }
    public override System.Security.Cryptography.DSAParameters ExportParameters(bool includePrivateParameters) { return default(System.Security.Cryptography.DSAParameters); }
    ~DSACryptoServiceProvider() { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public void ImportCspBlob(byte[] keyBlob) { }
    public override void ImportParameters(System.Security.Cryptography.DSAParameters parameters) { }
    public byte[] SignData(byte[] buffer) { return default(byte[]); }
    public byte[] SignData(byte[] buffer, int offset, int count) { return default(byte[]); }
    public byte[] SignData(System.IO.Stream inputStream) { return default(byte[]); }
    public byte[] SignHash(byte[] rgbHash, string str) { return default(byte[]); }
    public bool VerifyData(byte[] rgbData, byte[] rgbSignature) { return default(bool); }
    public bool VerifyHash(byte[] rgbHash, string str, byte[] rgbSignature) { return default(bool); }
    public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { return default(bool); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface ICspAsymmetricAlgorithm {
    System.Security.Cryptography.CspKeyContainerInfo CspKeyContainerInfo { get; }
    byte[] ExportCspBlob(bool includePrivateParameters);
    void ImportCspBlob(byte[] rawData);
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum KeyNumber {
    Exchange = 1,
    Signature = 2,
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class PasswordDeriveBytes : System.Security.Cryptography.DeriveBytes {
    public PasswordDeriveBytes(byte[] password, byte[] salt) { }
    public PasswordDeriveBytes(byte[] password, byte[] salt, System.Security.Cryptography.CspParameters cspParams) { }
    public PasswordDeriveBytes(byte[] password, byte[] salt, string hashName, int iterations) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public PasswordDeriveBytes(byte[] password, byte[] salt, string hashName, int iterations, System.Security.Cryptography.CspParameters cspParams) { }
    public PasswordDeriveBytes(string strPassword, byte[] rgbSalt) { }
    public PasswordDeriveBytes(string strPassword, byte[] rgbSalt, System.Security.Cryptography.CspParameters cspParams) { }
    public PasswordDeriveBytes(string strPassword, byte[] rgbSalt, string strHashName, int iterations) { }
    public PasswordDeriveBytes(string strPassword, byte[] rgbSalt, string strHashName, int iterations, System.Security.Cryptography.CspParameters cspParams) { }
    public string HashName { get { return default(string); } set { } }
    public int IterationCount { get { return default(int); } set { } }
    public byte[] Salt { get { return default(byte[]); } set { } }
    [System.Security.SecuritySafeCriticalAttribute]
    public byte[] CryptDeriveKey(string algname, string alghashname, int keySize, byte[] rgbIV) { return default(byte[]); }
    protected override void Dispose(bool disposing) { }
    [System.ObsoleteAttribute("Rfc2898DeriveBytes replaces PasswordDeriveBytes for deriving key material from a password and is preferred in new applications.")]
    [System.Security.SecuritySafeCriticalAttribute]
    public override byte[] GetBytes(int cb) { return default(byte[]); }
    public override void Reset() { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class RSACryptoServiceProvider : System.Security.Cryptography.RSA, System.Security.Cryptography.ICspAsymmetricAlgorithm {
    public RSACryptoServiceProvider() { }
    public RSACryptoServiceProvider(int dwKeySize) { }
    public RSACryptoServiceProvider(int dwKeySize, System.Security.Cryptography.CspParameters parameters) { }
    public RSACryptoServiceProvider(System.Security.Cryptography.CspParameters parameters) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.Security.Cryptography.CspKeyContainerInfo CspKeyContainerInfo { get { return default(System.Security.Cryptography.CspKeyContainerInfo); } }
    public override string KeyExchangeAlgorithm { get { return default(string); } }
    public override int KeySize { get { return default(int); } }
    public bool PersistKeyInCsp { get { return default(bool); } set { } }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public bool PublicOnly { get { return default(bool); } }
    public override string SignatureAlgorithm { get { return default(string); } }
    public static bool UseMachineKeyStore { get { return default(bool); } set { } }
    public byte[] Decrypt(byte[] rgb, bool fOAEP) { return default(byte[]); }
    public override byte[] DecryptValue(byte[] rgb) { return default(byte[]); }
    protected override void Dispose(bool disposing) { }
    public byte[] Encrypt(byte[] rgb, bool fOAEP) { return default(byte[]); }
    public override byte[] EncryptValue(byte[] rgb) { return default(byte[]); }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public byte[] ExportCspBlob(bool includePrivateParameters) { return default(byte[]); }
    public override System.Security.Cryptography.RSAParameters ExportParameters(bool includePrivateParameters) { return default(System.Security.Cryptography.RSAParameters); }
    ~RSACryptoServiceProvider() { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public void ImportCspBlob(byte[] keyBlob) { }
    public override void ImportParameters(System.Security.Cryptography.RSAParameters parameters) { }
    public byte[] SignData(byte[] buffer, int offset, int count, object halg) { return default(byte[]); }
    public byte[] SignData(byte[] buffer, object halg) { return default(byte[]); }
    public byte[] SignData(System.IO.Stream inputStream, object halg) { return default(byte[]); }
    public byte[] SignHash(byte[] rgbHash, string str) { return default(byte[]); }
    public bool VerifyData(byte[] buffer, object halg, byte[] signature) { return default(bool); }
    public bool VerifyHash(byte[] rgbHash, string str, byte[] rgbSignature) { return default(bool); }
  }

} // end of System.Security.Cryptography
namespace System.Security.Permissions {
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class KeyContainerPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission {
    public KeyContainerPermission(System.Security.Permissions.KeyContainerPermissionFlags flags) { }
    public KeyContainerPermission(System.Security.Permissions.KeyContainerPermissionFlags flags, System.Security.Permissions.KeyContainerPermissionAccessEntry[] accessList) { }
    public KeyContainerPermission(System.Security.Permissions.PermissionState state) { }
    public System.Security.Permissions.KeyContainerPermissionAccessEntryCollection AccessEntries { get { return default(System.Security.Permissions.KeyContainerPermissionAccessEntryCollection); } }
    public System.Security.Permissions.KeyContainerPermissionFlags Flags { get { return default(System.Security.Permissions.KeyContainerPermissionFlags); } }
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    public override void FromXml(System.Security.SecurityElement securityElement) { }
    public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public bool IsUnrestricted() { return default(bool); }
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class KeyContainerPermissionAccessEntry {
    public KeyContainerPermissionAccessEntry(System.Security.Cryptography.CspParameters parameters, System.Security.Permissions.KeyContainerPermissionFlags flags) { }
    public KeyContainerPermissionAccessEntry(string keyContainerName, System.Security.Permissions.KeyContainerPermissionFlags flags) { }
    public KeyContainerPermissionAccessEntry(string keyStore, string providerName, int providerType, string keyContainerName, int keySpec, System.Security.Permissions.KeyContainerPermissionFlags flags) { }
    public System.Security.Permissions.KeyContainerPermissionFlags Flags { get { return default(System.Security.Permissions.KeyContainerPermissionFlags); } set { } }
    public string KeyContainerName { get { return default(string); } set { } }
    public int KeySpec { get { return default(int); } set { } }
    public string KeyStore { get { return default(string); } set { } }
    public string ProviderName { get { return default(string); } set { } }
    public int ProviderType { get { return default(int); } set { } }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class KeyContainerPermissionAccessEntryCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    internal KeyContainerPermissionAccessEntryCollection() { }
    public int Count { get { return default(int); } }
    public bool IsSynchronized { get { return default(bool); } }
    public System.Security.Permissions.KeyContainerPermissionAccessEntry this[int index] { get { return default(System.Security.Permissions.KeyContainerPermissionAccessEntry); } }
    public object SyncRoot { get { return default(object); } }
    public int Add(System.Security.Permissions.KeyContainerPermissionAccessEntry accessEntry) { return default(int); }
    public void Clear() { }
    public void CopyTo(System.Security.Permissions.KeyContainerPermissionAccessEntry[] array, int index) { }
    public System.Security.Permissions.KeyContainerPermissionAccessEntryEnumerator GetEnumerator() { return default(System.Security.Permissions.KeyContainerPermissionAccessEntryEnumerator); }
    public int IndexOf(System.Security.Permissions.KeyContainerPermissionAccessEntry accessEntry) { return default(int); }
    public void Remove(System.Security.Permissions.KeyContainerPermissionAccessEntry accessEntry) { }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class KeyContainerPermissionAccessEntryEnumerator : System.Collections.IEnumerator {
    internal KeyContainerPermissionAccessEntryEnumerator() { }
    public System.Security.Permissions.KeyContainerPermissionAccessEntry Current { get { return default(System.Security.Permissions.KeyContainerPermissionAccessEntry); } }
    object System.Collections.IEnumerator.Current { get { return default(object); } }
    public bool MoveNext() { return default(bool); }
    public void Reset() { }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class KeyContainerPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    public KeyContainerPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public System.Security.Permissions.KeyContainerPermissionFlags Flags { get { return default(System.Security.Permissions.KeyContainerPermissionFlags); } set { } }
    public string KeyContainerName { get { return default(string); } set { } }
    public int KeySpec { get { return default(int); } set { } }
    public string KeyStore { get { return default(string); } set { } }
    public string ProviderName { get { return default(string); } set { } }
    public int ProviderType { get { return default(int); } set { } }
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
  }

  [System.FlagsAttribute]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum KeyContainerPermissionFlags {
    AllFlags = 13111,
    ChangeAcl = 8192,
    Create = 1,
    Decrypt = 512,
    Delete = 4,
    Export = 32,
    Import = 16,
    NoFlags = 0,
    Open = 2,
    Sign = 256,
    ViewAcl = 4096,
  }

} // end of System.Security.Permissions
