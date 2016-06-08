[assembly:System.CLSCompliant(true)]
namespace System.Security.Cryptography {
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
  public abstract partial class Aes : System.Security.Cryptography.SymmetricAlgorithm {
    protected Aes() { }
    public static new System.Security.Cryptography.Aes Create() { return default(System.Security.Cryptography.Aes); }
    public static new System.Security.Cryptography.Aes Create(string algorithmName) { return default(System.Security.Cryptography.Aes); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class AsymmetricKeyExchangeDeformatter {
    protected AsymmetricKeyExchangeDeformatter() { }
    public abstract string Parameters { get; set; }
    public abstract byte[] DecryptKeyExchange(byte[] rgb);
    public abstract void SetKey(System.Security.Cryptography.AsymmetricAlgorithm key);
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class AsymmetricKeyExchangeFormatter {
    protected AsymmetricKeyExchangeFormatter() { }
    public abstract string Parameters { get; }
    public abstract byte[] CreateKeyExchange(byte[] data);
    public abstract byte[] CreateKeyExchange(byte[] data, System.Type symAlgType);
    public abstract void SetKey(System.Security.Cryptography.AsymmetricAlgorithm key);
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class AsymmetricSignatureDeformatter {
    protected AsymmetricSignatureDeformatter() { }
    public abstract void SetHashAlgorithm(string strName);
    public abstract void SetKey(System.Security.Cryptography.AsymmetricAlgorithm key);
    public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature);
    public virtual bool VerifySignature(System.Security.Cryptography.HashAlgorithm hash, byte[] rgbSignature) { return default(bool); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class AsymmetricSignatureFormatter {
    protected AsymmetricSignatureFormatter() { }
    public abstract byte[] CreateSignature(byte[] rgbHash);
    public virtual byte[] CreateSignature(System.Security.Cryptography.HashAlgorithm hash) { return default(byte[]); }
    public abstract void SetHashAlgorithm(string strName);
    public abstract void SetKey(System.Security.Cryptography.AsymmetricAlgorithm key);
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class DeriveBytes : System.IDisposable {
    protected DeriveBytes() { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public abstract byte[] GetBytes(int cb);
    public abstract void Reset();
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class DES : System.Security.Cryptography.SymmetricAlgorithm {
    protected DES() { }
    public override byte[] Key { get { return default(byte[]); } set { } }
    public static new System.Security.Cryptography.DES Create() { return default(System.Security.Cryptography.DES); }
    public static new System.Security.Cryptography.DES Create(string algName) { return default(System.Security.Cryptography.DES); }
    public static bool IsSemiWeakKey(byte[] rgbKey) { return default(bool); }
    public static bool IsWeakKey(byte[] rgbKey) { return default(bool); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class DSA : System.Security.Cryptography.AsymmetricAlgorithm {
    protected DSA() { }
    public static new System.Security.Cryptography.DSA Create() { return default(System.Security.Cryptography.DSA); }
    public static new System.Security.Cryptography.DSA Create(string algName) { return default(System.Security.Cryptography.DSA); }
    public abstract byte[] CreateSignature(byte[] rgbHash);
    public abstract System.Security.Cryptography.DSAParameters ExportParameters(bool includePrivateParameters);
    public override void FromXmlString(string xmlString) { }
    public abstract void ImportParameters(System.Security.Cryptography.DSAParameters parameters);
    public override string ToXmlString(bool includePrivateParameters) { return default(string); }
    public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature);
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct DSAParameters {
    public int Counter;
    public byte[] G;
    public byte[] J;
    public byte[] P;
    public byte[] Q;
    public byte[] Seed;
    public byte[] X;
    public byte[] Y;
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class DSASignatureDeformatter : System.Security.Cryptography.AsymmetricSignatureDeformatter {
    public DSASignatureDeformatter() { }
    public DSASignatureDeformatter(System.Security.Cryptography.AsymmetricAlgorithm key) { }
    public override void SetHashAlgorithm(string strName) { }
    public override void SetKey(System.Security.Cryptography.AsymmetricAlgorithm key) { }
    public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { return default(bool); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class DSASignatureFormatter : System.Security.Cryptography.AsymmetricSignatureFormatter {
    public DSASignatureFormatter() { }
    public DSASignatureFormatter(System.Security.Cryptography.AsymmetricAlgorithm key) { }
    public override byte[] CreateSignature(byte[] rgbHash) { return default(byte[]); }
    public override void SetHashAlgorithm(string strName) { }
    public override void SetKey(System.Security.Cryptography.AsymmetricAlgorithm key) { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class HMACMD5 : System.Security.Cryptography.HMAC {
    public HMACMD5() { }
    public HMACMD5(byte[] key) { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class HMACRIPEMD160 : System.Security.Cryptography.HMAC {
    public HMACRIPEMD160() { }
    public HMACRIPEMD160(byte[] key) { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class HMACSHA1 : System.Security.Cryptography.HMAC {
    public HMACSHA1() { }
    public HMACSHA1(byte[] key) { }
    public HMACSHA1(byte[] key, bool useManagedSha1) { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class HMACSHA256 : System.Security.Cryptography.HMAC {
    public HMACSHA256() { }
    public HMACSHA256(byte[] key) { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class HMACSHA384 : System.Security.Cryptography.HMAC {
    public HMACSHA384() { }
    [System.Security.SecuritySafeCriticalAttribute]
    public HMACSHA384(byte[] key) { }
    public bool ProduceLegacyHmacValues { get { return default(bool); } set { } }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class HMACSHA512 : System.Security.Cryptography.HMAC {
    public HMACSHA512() { }
    [System.Security.SecuritySafeCriticalAttribute]
    public HMACSHA512(byte[] key) { }
    public bool ProduceLegacyHmacValues { get { return default(bool); } set { } }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class MACTripleDES : System.Security.Cryptography.KeyedHashAlgorithm {
    public MACTripleDES() { }
    public MACTripleDES(byte[] rgbKey) { }
    public MACTripleDES(string strTripleDES, byte[] rgbKey) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.Security.Cryptography.PaddingMode Padding { get { return default(System.Security.Cryptography.PaddingMode); } set { } }
    protected override void Dispose(bool disposing) { }
    protected override void HashCore(byte[] rgbData, int ibStart, int cbSize) { }
    protected override byte[] HashFinal() { return default(byte[]); }
    public override void Initialize() { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class MD5 : System.Security.Cryptography.HashAlgorithm {
    protected MD5() { }
    public static new System.Security.Cryptography.MD5 Create() { return default(System.Security.Cryptography.MD5); }
    public static new System.Security.Cryptography.MD5 Create(string algName) { return default(System.Security.Cryptography.MD5); }
  }

  public sealed partial class MD5CryptoServiceProvider : System.Security.Cryptography.MD5 {
    public MD5CryptoServiceProvider() { }
    protected override void Dispose(bool disposing) { }
    ~MD5CryptoServiceProvider() { }
    protected override void HashCore(byte[] data, int start, int length) { }
    protected override byte[] HashFinal() { return default(byte[]); }
    public override void Initialize() { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class RandomNumberGenerator : System.IDisposable {
    protected RandomNumberGenerator() { }
    public static System.Security.Cryptography.RandomNumberGenerator Create() { return default(System.Security.Cryptography.RandomNumberGenerator); }
    public static System.Security.Cryptography.RandomNumberGenerator Create(string rngName) { return default(System.Security.Cryptography.RandomNumberGenerator); }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public abstract void GetBytes(byte[] data);
    public virtual void GetNonZeroBytes(byte[] data) { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class RC2 : System.Security.Cryptography.SymmetricAlgorithm {
    protected int EffectiveKeySizeValue;
    protected RC2() { }
    public virtual int EffectiveKeySize { get { return default(int); } set { } }
    public override int KeySize { get { return default(int); } set { } }
    public static new System.Security.Cryptography.RC2 Create() { return default(System.Security.Cryptography.RC2); }
    public static new System.Security.Cryptography.RC2 Create(string AlgName) { return default(System.Security.Cryptography.RC2); }
  }

  public sealed partial class RC2CryptoServiceProvider : System.Security.Cryptography.RC2 {
    public RC2CryptoServiceProvider() { }
    public override int EffectiveKeySize { get { return default(int); } set { } }
    public override System.Security.Cryptography.ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { return default(System.Security.Cryptography.ICryptoTransform); }
    public override System.Security.Cryptography.ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { return default(System.Security.Cryptography.ICryptoTransform); }
    public override void GenerateIV() { }
    public override void GenerateKey() { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class Rfc2898DeriveBytes : System.Security.Cryptography.DeriveBytes {
    public Rfc2898DeriveBytes(byte[] password, byte[] salt, int iterations) { }
    public Rfc2898DeriveBytes(string password, byte[] salt) { }
    public Rfc2898DeriveBytes(string password, byte[] salt, int iterations) { }
    public Rfc2898DeriveBytes(string password, int saltSize) { }
    public Rfc2898DeriveBytes(string password, int saltSize, int iterations) { }
    public int IterationCount { get { return default(int); } set { } }
    public byte[] Salt { get { return default(byte[]); } set { } }
    protected override void Dispose(bool disposing) { }
    public override byte[] GetBytes(int cb) { return default(byte[]); }
    public override void Reset() { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class Rijndael : System.Security.Cryptography.SymmetricAlgorithm {
    protected Rijndael() { }
    public static new System.Security.Cryptography.Rijndael Create() { return default(System.Security.Cryptography.Rijndael); }
    public static new System.Security.Cryptography.Rijndael Create(string algName) { return default(System.Security.Cryptography.Rijndael); }
  }

  public sealed partial class RijndaelManaged : System.Security.Cryptography.Rijndael {
    public RijndaelManaged() { }
    public override System.Security.Cryptography.ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { return default(System.Security.Cryptography.ICryptoTransform); }
    public override System.Security.Cryptography.ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { return default(System.Security.Cryptography.ICryptoTransform); }
    public override void GenerateIV() { }
    public override void GenerateKey() { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class RijndaelManagedTransform : System.IDisposable, System.Security.Cryptography.ICryptoTransform {
    internal RijndaelManagedTransform() { }
    public int BlockSizeValue { get { return default(int); } }
    public bool CanReuseTransform { get { return default(bool); } }
    public bool CanTransformMultipleBlocks { get { return default(bool); } }
    public int InputBlockSize { get { return default(int); } }
    public int OutputBlockSize { get { return default(int); } }
    public void Clear() { }
    public void Dispose() { }
    public void Reset() { }
    public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { return default(int); }
    public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { return default(byte[]); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class RIPEMD160 : System.Security.Cryptography.HashAlgorithm {
    protected RIPEMD160() { }
    public static new System.Security.Cryptography.RIPEMD160 Create() { return default(System.Security.Cryptography.RIPEMD160); }
    public static new System.Security.Cryptography.RIPEMD160 Create(string hashName) { return default(System.Security.Cryptography.RIPEMD160); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class RIPEMD160Managed : System.Security.Cryptography.RIPEMD160 {
    public RIPEMD160Managed() { }
    [System.Security.SecuritySafeCriticalAttribute]
    protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }
    [System.Security.SecuritySafeCriticalAttribute]
    protected override byte[] HashFinal() { return default(byte[]); }
    public override void Initialize() { }
  }

  public partial class RNGCryptoServiceProvider : System.Security.Cryptography.RandomNumberGenerator {
    public RNGCryptoServiceProvider() { }
    ~RNGCryptoServiceProvider() { }
    public override void GetBytes(byte[] data) { }
    public override void GetNonZeroBytes(byte[] data) { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class RSA : System.Security.Cryptography.AsymmetricAlgorithm {
    protected RSA() { }
    public static new System.Security.Cryptography.RSA Create() { return default(System.Security.Cryptography.RSA); }
    public static new System.Security.Cryptography.RSA Create(string algName) { return default(System.Security.Cryptography.RSA); }
    public abstract byte[] DecryptValue(byte[] rgb);
    public abstract byte[] EncryptValue(byte[] rgb);
    public abstract System.Security.Cryptography.RSAParameters ExportParameters(bool includePrivateParameters);
    public override void FromXmlString(string xmlString) { }
    public abstract void ImportParameters(System.Security.Cryptography.RSAParameters parameters);
    public override string ToXmlString(bool includePrivateParameters) { return default(string); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class RSAOAEPKeyExchangeDeformatter : System.Security.Cryptography.AsymmetricKeyExchangeDeformatter {
    public RSAOAEPKeyExchangeDeformatter() { }
    public RSAOAEPKeyExchangeDeformatter(System.Security.Cryptography.AsymmetricAlgorithm key) { }
    public override string Parameters { get { return default(string); } set { } }
    [System.Security.SecuritySafeCriticalAttribute]
    public override byte[] DecryptKeyExchange(byte[] rgbData) { return default(byte[]); }
    public override void SetKey(System.Security.Cryptography.AsymmetricAlgorithm key) { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class RSAOAEPKeyExchangeFormatter : System.Security.Cryptography.AsymmetricKeyExchangeFormatter {
    public RSAOAEPKeyExchangeFormatter() { }
    public RSAOAEPKeyExchangeFormatter(System.Security.Cryptography.AsymmetricAlgorithm key) { }
    public byte[] Parameter { get { return default(byte[]); } set { } }
    public override string Parameters { get { return default(string); } }
    public System.Security.Cryptography.RandomNumberGenerator Rng { get { return default(System.Security.Cryptography.RandomNumberGenerator); } set { } }
    [System.Security.SecuritySafeCriticalAttribute]
    public override byte[] CreateKeyExchange(byte[] rgbData) { return default(byte[]); }
    public override byte[] CreateKeyExchange(byte[] rgbData, System.Type symAlgType) { return default(byte[]); }
    public override void SetKey(System.Security.Cryptography.AsymmetricAlgorithm key) { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct RSAParameters {
    public byte[] D;
    public byte[] DP;
    public byte[] DQ;
    public byte[] Exponent;
    public byte[] InverseQ;
    public byte[] Modulus;
    public byte[] P;
    public byte[] Q;
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class RSAPKCS1KeyExchangeDeformatter : System.Security.Cryptography.AsymmetricKeyExchangeDeformatter {
    public RSAPKCS1KeyExchangeDeformatter() { }
    public RSAPKCS1KeyExchangeDeformatter(System.Security.Cryptography.AsymmetricAlgorithm key) { }
    public override string Parameters { get { return default(string); } set { } }
    public System.Security.Cryptography.RandomNumberGenerator RNG { get { return default(System.Security.Cryptography.RandomNumberGenerator); } set { } }
    public override byte[] DecryptKeyExchange(byte[] rgbIn) { return default(byte[]); }
    public override void SetKey(System.Security.Cryptography.AsymmetricAlgorithm key) { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class RSAPKCS1KeyExchangeFormatter : System.Security.Cryptography.AsymmetricKeyExchangeFormatter {
    public RSAPKCS1KeyExchangeFormatter() { }
    public RSAPKCS1KeyExchangeFormatter(System.Security.Cryptography.AsymmetricAlgorithm key) { }
    public override string Parameters { get { return default(string); } }
    public System.Security.Cryptography.RandomNumberGenerator Rng { get { return default(System.Security.Cryptography.RandomNumberGenerator); } set { } }
    public override byte[] CreateKeyExchange(byte[] rgbData) { return default(byte[]); }
    public override byte[] CreateKeyExchange(byte[] rgbData, System.Type symAlgType) { return default(byte[]); }
    public override void SetKey(System.Security.Cryptography.AsymmetricAlgorithm key) { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class RSAPKCS1SignatureDeformatter : System.Security.Cryptography.AsymmetricSignatureDeformatter {
    public RSAPKCS1SignatureDeformatter() { }
    public RSAPKCS1SignatureDeformatter(System.Security.Cryptography.AsymmetricAlgorithm key) { }
    public override void SetHashAlgorithm(string strName) { }
    public override void SetKey(System.Security.Cryptography.AsymmetricAlgorithm key) { }
    public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { return default(bool); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class RSAPKCS1SignatureFormatter : System.Security.Cryptography.AsymmetricSignatureFormatter {
    public RSAPKCS1SignatureFormatter() { }
    public RSAPKCS1SignatureFormatter(System.Security.Cryptography.AsymmetricAlgorithm key) { }
    public override byte[] CreateSignature(byte[] rgbHash) { return default(byte[]); }
    public override void SetHashAlgorithm(string strName) { }
    public override void SetKey(System.Security.Cryptography.AsymmetricAlgorithm key) { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class SHA1 : System.Security.Cryptography.HashAlgorithm {
    protected SHA1() { }
    public static new System.Security.Cryptography.SHA1 Create() { return default(System.Security.Cryptography.SHA1); }
    public static new System.Security.Cryptography.SHA1 Create(string hashName) { return default(System.Security.Cryptography.SHA1); }
  }

  public sealed partial class SHA1CryptoServiceProvider : System.Security.Cryptography.SHA1 {
    public SHA1CryptoServiceProvider() { }
    protected override void Dispose(bool disposing) { }
    ~SHA1CryptoServiceProvider() { }
    protected override void HashCore(byte[] data, int start, int length) { }
    protected override byte[] HashFinal() { return default(byte[]); }
    public override void Initialize() { }
  }

  public sealed partial class SHA1Managed : System.Security.Cryptography.SHA1 {
    public SHA1Managed() { }
    protected override void Dispose(bool disposing) { }
    ~SHA1Managed() { }
    protected override void HashCore(byte[] data, int start, int length) { }
    protected override byte[] HashFinal() { return default(byte[]); }
    public override void Initialize() { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class SHA256 : System.Security.Cryptography.HashAlgorithm {
    protected SHA256() { }
    public static new System.Security.Cryptography.SHA256 Create() { return default(System.Security.Cryptography.SHA256); }
    public static new System.Security.Cryptography.SHA256 Create(string hashName) { return default(System.Security.Cryptography.SHA256); }
  }

  public sealed partial class SHA256Managed : System.Security.Cryptography.SHA256 {
    public SHA256Managed() { }
    protected override void Dispose(bool disposing) { }
    ~SHA256Managed() { }
    protected override void HashCore(byte[] data, int start, int length) { }
    protected override byte[] HashFinal() { return default(byte[]); }
    public override void Initialize() { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class SHA384 : System.Security.Cryptography.HashAlgorithm {
    protected SHA384() { }
    public static new System.Security.Cryptography.SHA384 Create() { return default(System.Security.Cryptography.SHA384); }
    public static new System.Security.Cryptography.SHA384 Create(string hashName) { return default(System.Security.Cryptography.SHA384); }
  }

  public sealed partial class SHA384Managed : System.Security.Cryptography.SHA384 {
    public SHA384Managed() { }
    protected override void Dispose(bool disposing) { }
    ~SHA384Managed() { }
    protected override void HashCore(byte[] data, int start, int length) { }
    protected override byte[] HashFinal() { return default(byte[]); }
    public override void Initialize() { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class SHA512 : System.Security.Cryptography.HashAlgorithm {
    protected SHA512() { }
    public static new System.Security.Cryptography.SHA512 Create() { return default(System.Security.Cryptography.SHA512); }
    public static new System.Security.Cryptography.SHA512 Create(string hashName) { return default(System.Security.Cryptography.SHA512); }
  }

  public sealed partial class SHA512Managed : System.Security.Cryptography.SHA512 {
    public SHA512Managed() { }
    protected override void Dispose(bool disposing) { }
    ~SHA512Managed() { }
    protected override void HashCore(byte[] data, int start, int length) { }
    protected override byte[] HashFinal() { return default(byte[]); }
    public override void Initialize() { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class SignatureDescription {
    public SignatureDescription() { }
    public SignatureDescription(System.Security.SecurityElement el) { }
    public string DeformatterAlgorithm { get { return default(string); } set { } }
    public string DigestAlgorithm { get { return default(string); } set { } }
    public string FormatterAlgorithm { get { return default(string); } set { } }
    public string KeyAlgorithm { get { return default(string); } set { } }
    public virtual System.Security.Cryptography.AsymmetricSignatureDeformatter CreateDeformatter(System.Security.Cryptography.AsymmetricAlgorithm key) { return default(System.Security.Cryptography.AsymmetricSignatureDeformatter); }
    public virtual System.Security.Cryptography.HashAlgorithm CreateDigest() { return default(System.Security.Cryptography.HashAlgorithm); }
    public virtual System.Security.Cryptography.AsymmetricSignatureFormatter CreateFormatter(System.Security.Cryptography.AsymmetricAlgorithm key) { return default(System.Security.Cryptography.AsymmetricSignatureFormatter); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class TripleDES : System.Security.Cryptography.SymmetricAlgorithm {
    protected TripleDES() { }
    public override byte[] Key { get { return default(byte[]); } set { } }
    public static new System.Security.Cryptography.TripleDES Create() { return default(System.Security.Cryptography.TripleDES); }
    public static new System.Security.Cryptography.TripleDES Create(string str) { return default(System.Security.Cryptography.TripleDES); }
    public static bool IsWeakKey(byte[] rgbKey) { return default(bool); }
  }

  public sealed partial class TripleDESCryptoServiceProvider : System.Security.Cryptography.TripleDES {
    public TripleDESCryptoServiceProvider() { }
    public override System.Security.Cryptography.ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { return default(System.Security.Cryptography.ICryptoTransform); }
    public override System.Security.Cryptography.ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { return default(System.Security.Cryptography.ICryptoTransform); }
    public override void GenerateIV() { }
    public override void GenerateKey() { }
  }

  public sealed partial class IncrementalHash : System.IDisposable {
    internal IncrementalHash() { }
    public System.Security.Cryptography.HashAlgorithmName AlgorithmName { get { return default(System.Security.Cryptography.HashAlgorithmName); } }
    public void AppendData(byte[] data) { }
    public void AppendData(byte[] data, int offset, int count) { }
    public static System.Security.Cryptography.IncrementalHash CreateHash(System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { return default(System.Security.Cryptography.IncrementalHash); }
    public static System.Security.Cryptography.IncrementalHash CreateHMAC(System.Security.Cryptography.HashAlgorithmName hashAlgorithm, byte[] key) { return default(System.Security.Cryptography.IncrementalHash); }
    public void Dispose() { }
    public byte[] GetHashAndReset() { return default(byte[]); }
  }

  public sealed partial class RSAEncryptionPadding : System.IEquatable<System.Security.Cryptography.RSAEncryptionPadding> {
    internal RSAEncryptionPadding() { }
    public System.Security.Cryptography.RSAEncryptionPaddingMode Mode { get { return default(System.Security.Cryptography.RSAEncryptionPaddingMode); } }
    public System.Security.Cryptography.HashAlgorithmName OaepHashAlgorithm { get { return default(System.Security.Cryptography.HashAlgorithmName); } }
    public static System.Security.Cryptography.RSAEncryptionPadding OaepSHA1 { get { return default(System.Security.Cryptography.RSAEncryptionPadding); } }
    public static System.Security.Cryptography.RSAEncryptionPadding OaepSHA256 { get { return default(System.Security.Cryptography.RSAEncryptionPadding); } }
    public static System.Security.Cryptography.RSAEncryptionPadding OaepSHA384 { get { return default(System.Security.Cryptography.RSAEncryptionPadding); } }
    public static System.Security.Cryptography.RSAEncryptionPadding OaepSHA512 { get { return default(System.Security.Cryptography.RSAEncryptionPadding); } }
    public static System.Security.Cryptography.RSAEncryptionPadding Pkcs1 { get { return default(System.Security.Cryptography.RSAEncryptionPadding); } }
    public static System.Security.Cryptography.RSAEncryptionPadding CreateOaep(System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { return default(System.Security.Cryptography.RSAEncryptionPadding); }
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.Security.Cryptography.RSAEncryptionPadding other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Security.Cryptography.RSAEncryptionPadding left, System.Security.Cryptography.RSAEncryptionPadding right) { return default(bool); }
    public static bool operator !=(System.Security.Cryptography.RSAEncryptionPadding left, System.Security.Cryptography.RSAEncryptionPadding right) { return default(bool); }
    public override string ToString() { return default(string); }
  }

  public enum RSAEncryptionPaddingMode {
    Oaep = 1,
    Pkcs1 = 0,
  }

  public sealed partial class RSASignaturePadding : System.IEquatable<System.Security.Cryptography.RSASignaturePadding> {
    internal RSASignaturePadding() { }
    public System.Security.Cryptography.RSASignaturePaddingMode Mode { get { return default(System.Security.Cryptography.RSASignaturePaddingMode); } }
    public static System.Security.Cryptography.RSASignaturePadding Pkcs1 { get { return default(System.Security.Cryptography.RSASignaturePadding); } }
    public static System.Security.Cryptography.RSASignaturePadding Pss { get { return default(System.Security.Cryptography.RSASignaturePadding); } }
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.Security.Cryptography.RSASignaturePadding other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Security.Cryptography.RSASignaturePadding left, System.Security.Cryptography.RSASignaturePadding right) { return default(bool); }
    public static bool operator !=(System.Security.Cryptography.RSASignaturePadding left, System.Security.Cryptography.RSASignaturePadding right) { return default(bool); }
    public override string ToString() { return default(string); }
  }

  public enum RSASignaturePaddingMode {
    Pkcs1 = 0,
    Pss = 1,
  }

} // end of System.Security.Cryptography
