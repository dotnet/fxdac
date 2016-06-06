[assembly:System.CLSCompliant(true)]
namespace System.Security.Cryptography {
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class AsymmetricAlgorithm : System.IDisposable {
    protected int KeySizeValue;
    protected System.Security.Cryptography.KeySizes[] LegalKeySizesValue;
    protected AsymmetricAlgorithm() { }
    public abstract string KeyExchangeAlgorithm { get; }
    public virtual int KeySize { get { return default(int); } set { } }
    public virtual System.Security.Cryptography.KeySizes[] LegalKeySizes { get { return default(System.Security.Cryptography.KeySizes[]); } }
    public abstract string SignatureAlgorithm { get; }
    public void Clear() { }
    public static System.Security.Cryptography.AsymmetricAlgorithm Create() { return default(System.Security.Cryptography.AsymmetricAlgorithm); }
    public static System.Security.Cryptography.AsymmetricAlgorithm Create(string algName) { return default(System.Security.Cryptography.AsymmetricAlgorithm); }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public abstract void FromXmlString(string xmlString);
    public abstract string ToXmlString(bool includePrivateParameters);
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum CipherMode {
    CBC = 1,
    CFB = 4,
    CTS = 5,
    ECB = 2,
    OFB = 3,
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CryptographicException : System.SystemException {
    public CryptographicException() { }
    [System.Security.SecuritySafeCriticalAttribute]
    public CryptographicException(int hr) { }
    protected CryptographicException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public CryptographicException(string message) { }
    public CryptographicException(string message, System.Exception inner) { }
    public CryptographicException(string format, string insert) { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CryptographicUnexpectedOperationException : System.Security.Cryptography.CryptographicException {
    public CryptographicUnexpectedOperationException() { }
    protected CryptographicUnexpectedOperationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public CryptographicUnexpectedOperationException(string message) { }
    public CryptographicUnexpectedOperationException(string message, System.Exception inner) { }
    public CryptographicUnexpectedOperationException(string format, string insert) { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CryptoStream : System.IO.Stream, System.IDisposable {
    public CryptoStream(System.IO.Stream stream, System.Security.Cryptography.ICryptoTransform transform, System.Security.Cryptography.CryptoStreamMode mode) { }
    public override bool CanRead { get { return default(bool); } }
    public override bool CanSeek { get { return default(bool); } }
    public override bool CanWrite { get { return default(bool); } }
    public bool HasFlushedFinalBlock { get { return default(bool); } }
    public override long Length { get { return default(long); } }
    public override long Position { get { return default(long); } set { } }
    public void Clear() { }
    protected override void Dispose(bool disposing) { }
    public override void Flush() { }
    public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
    public void FlushFinalBlock() { }
    public override int Read(byte[] buffer, int offset, int count) { buffer = default(byte[]); return default(int); }
    public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<int>); }
    public override long Seek(long offset, System.IO.SeekOrigin origin) { return default(long); }
    public override void SetLength(long value) { }
    public override void Write(byte[] buffer, int offset, int count) { }
    public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum CryptoStreamMode {
    Read = 0,
    Write = 1,
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class HashAlgorithm : System.IDisposable, System.Security.Cryptography.ICryptoTransform {
    protected int HashSizeValue;
    protected internal byte[] HashValue;
    protected int State;
    protected HashAlgorithm() { }
    public virtual bool CanReuseTransform { get { return default(bool); } }
    public virtual bool CanTransformMultipleBlocks { get { return default(bool); } }
    public virtual byte[] Hash { get { return default(byte[]); } }
    public virtual int HashSize { get { return default(int); } }
    public virtual int InputBlockSize { get { return default(int); } }
    public virtual int OutputBlockSize { get { return default(int); } }
    public void Clear() { }
    public byte[] ComputeHash(byte[] buffer) { return default(byte[]); }
    public byte[] ComputeHash(byte[] buffer, int offset, int count) { return default(byte[]); }
    public byte[] ComputeHash(System.IO.Stream inputStream) { return default(byte[]); }
    public static System.Security.Cryptography.HashAlgorithm Create() { return default(System.Security.Cryptography.HashAlgorithm); }
    public static System.Security.Cryptography.HashAlgorithm Create(string hashName) { return default(System.Security.Cryptography.HashAlgorithm); }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    protected abstract void HashCore(byte[] array, int ibStart, int cbSize);
    protected abstract byte[] HashFinal();
    public abstract void Initialize();
    public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { return default(int); }
    public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { return default(byte[]); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class HMAC : System.Security.Cryptography.KeyedHashAlgorithm {
    protected HMAC() { }
    protected int BlockSizeValue { get { return default(int); } set { } }
    public string HashName { get { return default(string); } set { } }
    public override byte[] Key { get { return default(byte[]); } set { } }
    public static new System.Security.Cryptography.HMAC Create() { return default(System.Security.Cryptography.HMAC); }
    public static new System.Security.Cryptography.HMAC Create(string algorithmName) { return default(System.Security.Cryptography.HMAC); }
    protected override void Dispose(bool disposing) { }
    protected override void HashCore(byte[] rgb, int ib, int cb) { }
    protected override byte[] HashFinal() { return default(byte[]); }
    public override void Initialize() { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface ICryptoTransform : System.IDisposable {
    bool CanReuseTransform { get; }
    bool CanTransformMultipleBlocks { get; }
    int InputBlockSize { get; }
    int OutputBlockSize { get; }
    int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset);
    byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount);
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class KeyedHashAlgorithm : System.Security.Cryptography.HashAlgorithm {
    protected byte[] KeyValue;
    protected KeyedHashAlgorithm() { }
    public virtual byte[] Key { get { return default(byte[]); } set { } }
    public static new System.Security.Cryptography.KeyedHashAlgorithm Create() { return default(System.Security.Cryptography.KeyedHashAlgorithm); }
    public static new System.Security.Cryptography.KeyedHashAlgorithm Create(string algName) { return default(System.Security.Cryptography.KeyedHashAlgorithm); }
    protected override void Dispose(bool disposing) { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class KeySizes {
    public KeySizes(int minSize, int maxSize, int skipSize) { }
    public int MaxSize { get { return default(int); } }
    public int MinSize { get { return default(int); } }
    public int SkipSize { get { return default(int); } }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum PaddingMode {
    ANSIX923 = 4,
    ISO10126 = 5,
    None = 1,
    PKCS7 = 2,
    Zeros = 3,
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class SymmetricAlgorithm : System.IDisposable {
    protected int BlockSizeValue;
    protected int FeedbackSizeValue;
    protected byte[] IVValue;
    protected int KeySizeValue;
    protected byte[] KeyValue;
    protected System.Security.Cryptography.KeySizes[] LegalBlockSizesValue;
    protected System.Security.Cryptography.KeySizes[] LegalKeySizesValue;
    protected System.Security.Cryptography.CipherMode ModeValue;
    protected System.Security.Cryptography.PaddingMode PaddingValue;
    protected SymmetricAlgorithm() { }
    public virtual int BlockSize { get { return default(int); } set { } }
    public virtual int FeedbackSize { get { return default(int); } set { } }
    public virtual byte[] IV { get { return default(byte[]); } set { } }
    public virtual byte[] Key { get { return default(byte[]); } set { } }
    public virtual int KeySize { get { return default(int); } set { } }
    public virtual System.Security.Cryptography.KeySizes[] LegalBlockSizes { get { return default(System.Security.Cryptography.KeySizes[]); } }
    public virtual System.Security.Cryptography.KeySizes[] LegalKeySizes { get { return default(System.Security.Cryptography.KeySizes[]); } }
    public virtual System.Security.Cryptography.CipherMode Mode { get { return default(System.Security.Cryptography.CipherMode); } set { } }
    public virtual System.Security.Cryptography.PaddingMode Padding { get { return default(System.Security.Cryptography.PaddingMode); } set { } }
    public void Clear() { }
    public static System.Security.Cryptography.SymmetricAlgorithm Create() { return default(System.Security.Cryptography.SymmetricAlgorithm); }
    public static System.Security.Cryptography.SymmetricAlgorithm Create(string algName) { return default(System.Security.Cryptography.SymmetricAlgorithm); }
    public virtual System.Security.Cryptography.ICryptoTransform CreateDecryptor() { return default(System.Security.Cryptography.ICryptoTransform); }
    public abstract System.Security.Cryptography.ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV);
    public virtual System.Security.Cryptography.ICryptoTransform CreateEncryptor() { return default(System.Security.Cryptography.ICryptoTransform); }
    public abstract System.Security.Cryptography.ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV);
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public abstract void GenerateIV();
    public abstract void GenerateKey();
    public bool ValidKeySize(int bitLength) { return default(bool); }
  }

} // end of System.Security.Cryptography
namespace System.Security.Cryptography.X509Certificates {
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class X509Certificate : System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable {
    public X509Certificate() { }
    public X509Certificate(byte[] data) { }
    public X509Certificate(byte[] rawData, System.Security.SecureString password) { }
    public X509Certificate(byte[] rawData, System.Security.SecureString password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags) { }
    public X509Certificate(byte[] rawData, string password) { }
    public X509Certificate(byte[] rawData, string password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags) { }
    public X509Certificate(System.IntPtr handle) { }
    public X509Certificate(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public X509Certificate(System.Security.Cryptography.X509Certificates.X509Certificate cert) { }
    public X509Certificate(string fileName) { }
    public X509Certificate(string fileName, System.Security.SecureString password) { }
    public X509Certificate(string fileName, System.Security.SecureString password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags) { }
    public X509Certificate(string fileName, string password) { }
    public X509Certificate(string fileName, string password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public System.IntPtr Handle { get { return default(System.IntPtr); } }
    public string Issuer { get { return default(string); } }
    public string Subject { get { return default(string); } }
    public static System.Security.Cryptography.X509Certificates.X509Certificate CreateFromCertFile(string filename) { return default(System.Security.Cryptography.X509Certificates.X509Certificate); }
    public static System.Security.Cryptography.X509Certificates.X509Certificate CreateFromSignedFile(string filename) { return default(System.Security.Cryptography.X509Certificates.X509Certificate); }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public override bool Equals(object obj) { return default(bool); }
    public virtual bool Equals(System.Security.Cryptography.X509Certificates.X509Certificate other) { return default(bool); }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public virtual byte[] Export(System.Security.Cryptography.X509Certificates.X509ContentType contentType) { return default(byte[]); }
    public virtual byte[] Export(System.Security.Cryptography.X509Certificates.X509ContentType contentType, System.Security.SecureString password) { return default(byte[]); }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public virtual byte[] Export(System.Security.Cryptography.X509Certificates.X509ContentType contentType, string password) { return default(byte[]); }
    protected static string FormatDate(System.DateTime date) { return default(string); }
    public virtual byte[] GetCertHash() { return default(byte[]); }
    public virtual string GetCertHashString() { return default(string); }
    public virtual string GetEffectiveDateString() { return default(string); }
    public virtual string GetExpirationDateString() { return default(string); }
    public virtual string GetFormat() { return default(string); }
    public override int GetHashCode() { return default(int); }
    [System.ObsoleteAttribute("Use the Issuer property.")]
    public virtual string GetIssuerName() { return default(string); }
    public virtual string GetKeyAlgorithm() { return default(string); }
    public virtual byte[] GetKeyAlgorithmParameters() { return default(byte[]); }
    public virtual string GetKeyAlgorithmParametersString() { return default(string); }
    [System.ObsoleteAttribute("Use the Subject property.")]
    public virtual string GetName() { return default(string); }
    public virtual byte[] GetPublicKey() { return default(byte[]); }
    public virtual string GetPublicKeyString() { return default(string); }
    public virtual byte[] GetRawCertData() { return default(byte[]); }
    public virtual string GetRawCertDataString() { return default(string); }
    public virtual byte[] GetSerialNumber() { return default(byte[]); }
    public virtual string GetSerialNumberString() { return default(string); }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public virtual void Import(byte[] rawData) { }
    public virtual void Import(byte[] rawData, System.Security.SecureString password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public virtual void Import(byte[] rawData, string password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public virtual void Import(string fileName) { }
    public virtual void Import(string fileName, System.Security.SecureString password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public virtual void Import(string fileName, string password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags) { }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public virtual void Reset() { }
    void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public override string ToString() { return default(string); }
    public virtual string ToString(bool fVerbose) { return default(string); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum X509ContentType {
    Authenticode = 6,
    Cert = 1,
    Pfx = 3,
    Pkcs12 = 3,
    Pkcs7 = 5,
    SerializedCert = 2,
    SerializedStore = 4,
    Unknown = 0,
  }

  [System.FlagsAttribute]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum X509KeyStorageFlags {
    DefaultKeySet = 0,
    Exportable = 4,
    MachineKeySet = 2,
    PersistKeySet = 16,
    UserKeySet = 1,
    UserProtected = 8,
  }

} // end of System.Security.Cryptography.X509Certificates
