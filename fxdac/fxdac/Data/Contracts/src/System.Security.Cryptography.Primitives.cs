[assembly:System.CLSCompliant(true)]
namespace System.Security.Cryptography {

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class AsymmetricAlgorithm : System.IDisposable
    {
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
    public enum CipherMode
    {
        CBC = 1,
        CFB = 4,
        CTS = 5,
        ECB = 2,
        OFB = 3,
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class CryptographicException : System.SystemException
    {
        public CryptographicException() { }
        [System.Security.SecuritySafeCriticalAttribute]
        public CryptographicException(int hr) { }
        protected CryptographicException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public CryptographicException(string message) { }
        public CryptographicException(string message, System.Exception inner) { }
        public CryptographicException(string format, string insert) { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class CryptographicUnexpectedOperationException : System.Security.Cryptography.CryptographicException
    {
        public CryptographicUnexpectedOperationException() { }
        protected CryptographicUnexpectedOperationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public CryptographicUnexpectedOperationException(string message) { }
        public CryptographicUnexpectedOperationException(string message, System.Exception inner) { }
        public CryptographicUnexpectedOperationException(string format, string insert) { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class CryptoStream : System.IO.Stream, System.IDisposable
    {
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
    public enum CryptoStreamMode
    {
        Read = 0,
        Write = 1,
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class HashAlgorithm : System.IDisposable, System.Security.Cryptography.ICryptoTransform
    {
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
    public abstract partial class HMAC : System.Security.Cryptography.KeyedHashAlgorithm
    {
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
    public partial interface ICryptoTransform : System.IDisposable
    {
        bool CanReuseTransform { get; }
        bool CanTransformMultipleBlocks { get; }
        int InputBlockSize { get; }
        int OutputBlockSize { get; }
        int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset);
        byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount);
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class KeyedHashAlgorithm : System.Security.Cryptography.HashAlgorithm
    {
        protected byte[] KeyValue;
        protected KeyedHashAlgorithm() { }
        public virtual byte[] Key { get { return default(byte[]); } set { } }
        public static new System.Security.Cryptography.KeyedHashAlgorithm Create() { return default(System.Security.Cryptography.KeyedHashAlgorithm); }
        public static new System.Security.Cryptography.KeyedHashAlgorithm Create(string algName) { return default(System.Security.Cryptography.KeyedHashAlgorithm); }
        protected override void Dispose(bool disposing) { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class KeySizes
    {
        public KeySizes(int minSize, int maxSize, int skipSize) { }
        public int MaxSize { get { return default(int); } }
        public int MinSize { get { return default(int); } }
        public int SkipSize { get { return default(int); } }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum PaddingMode
    {
        ANSIX923 = 4,
        ISO10126 = 5,
        None = 1,
        PKCS7 = 2,
        Zeros = 3,
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class SymmetricAlgorithm : System.IDisposable
    {
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
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct HashAlgorithmName : System.IEquatable<System.Security.Cryptography.HashAlgorithmName> {
    public HashAlgorithmName(string name) { throw new System.NotImplementedException(); }
    public static System.Security.Cryptography.HashAlgorithmName MD5 { get { return default(System.Security.Cryptography.HashAlgorithmName); } }
    public string Name { get { return default(string); } }
    public static System.Security.Cryptography.HashAlgorithmName SHA1 { get { return default(System.Security.Cryptography.HashAlgorithmName); } }
    public static System.Security.Cryptography.HashAlgorithmName SHA256 { get { return default(System.Security.Cryptography.HashAlgorithmName); } }
    public static System.Security.Cryptography.HashAlgorithmName SHA384 { get { return default(System.Security.Cryptography.HashAlgorithmName); } }
    public static System.Security.Cryptography.HashAlgorithmName SHA512 { get { return default(System.Security.Cryptography.HashAlgorithmName); } }
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.Security.Cryptography.HashAlgorithmName other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Security.Cryptography.HashAlgorithmName left, System.Security.Cryptography.HashAlgorithmName right) { return default(bool); }
    public static bool operator !=(System.Security.Cryptography.HashAlgorithmName left, System.Security.Cryptography.HashAlgorithmName right) { return default(bool); }
    public override string ToString() { return default(string); }
  }
} // end of System.Security.Cryptography
