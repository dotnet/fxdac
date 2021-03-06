[assembly:System.CLSCompliant(true)]
namespace System.Net {

    public partial class ServicePointManager
    {
        internal ServicePointManager() { }
        public const int DefaultNonPersistentConnectionLimit = 4;
        public const int DefaultPersistentConnectionLimit = 10;
        [System.ObsoleteAttribute("Use ServerCertificateValidationCallback instead", false)]
        public static System.Net.ICertificatePolicy CertificatePolicy { get { return default(System.Net.ICertificatePolicy); } set { } }
        public static bool CheckCertificateRevocationList { get { return default(bool); } set { } }
        public static System.Net.CipherSuitesCallback ClientCipherSuitesCallback { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.CipherSuitesCallback); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public static int DefaultConnectionLimit { get { return default(int); } set { } }
        public static int DnsRefreshTimeout { get { return default(int); } set { } }
        public static bool EnableDnsRoundRobin { get { return default(bool); } set { } }
        public static bool Expect100Continue { get { return default(bool); } set { } }
        public static int MaxServicePointIdleTime { get { return default(int); } set { } }
        public static int MaxServicePoints { get { return default(int); } set { } }
        public static System.Net.SecurityProtocolType SecurityProtocol { get { return default(System.Net.SecurityProtocolType); } set { } }
        public static System.Net.Security.RemoteCertificateValidationCallback ServerCertificateValidationCallback { get { return default(System.Net.Security.RemoteCertificateValidationCallback); } set { } }
        public static System.Net.CipherSuitesCallback ServerCipherSuitesCallback { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.CipherSuitesCallback); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public static bool UseNagleAlgorithm { get { return default(bool); } set { } }
        public static System.Net.ServicePoint FindServicePoint(string uriString, System.Net.IWebProxy proxy) { return default(System.Net.ServicePoint); }
        public static System.Net.ServicePoint FindServicePoint(System.Uri address) { return default(System.Net.ServicePoint); }
        public static System.Net.ServicePoint FindServicePoint(System.Uri address, System.Net.IWebProxy proxy) { return default(System.Net.ServicePoint); }
        public static void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval) { }
    }
} // end of System.Net
namespace System.Net.Security {
    public abstract partial class AuthenticatedStream : System.IO.Stream
    {
        protected AuthenticatedStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen) { }
        protected System.IO.Stream InnerStream { get { return default(System.IO.Stream); } }
        public abstract bool IsAuthenticated { get; }
        public abstract bool IsEncrypted { get; }
        public abstract bool IsMutuallyAuthenticated { get; }
        public abstract bool IsServer { get; }
        public abstract bool IsSigned { get; }
        public bool LeaveInnerStreamOpen { get { return default(bool); } }
        protected override void Dispose(bool disposing) { }
    }

    public delegate System.Security.Cryptography.X509Certificates.X509Certificate LocalCertificateSelectionCallback(object sender, string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers);

    public partial class NegotiateStream : System.Net.Security.AuthenticatedStream
    {
        public NegotiateStream(System.IO.Stream innerStream) : base(default(System.IO.Stream), default(bool)) { }
        public NegotiateStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen) : base(default(System.IO.Stream), default(bool)) { }
        public override bool CanRead { get { return default(bool); } }
        public override bool CanSeek { get { return default(bool); } }
        public override bool CanTimeout { get { return default(bool); } }
        public override bool CanWrite { get { return default(bool); } }
        public virtual System.Security.Principal.TokenImpersonationLevel ImpersonationLevel { get { return default(System.Security.Principal.TokenImpersonationLevel); } }
        public override bool IsAuthenticated { get { return default(bool); } }
        public override bool IsEncrypted { get { return default(bool); } }
        public override bool IsMutuallyAuthenticated { get { return default(bool); } }
        public override bool IsServer { get { return default(bool); } }
        public override bool IsSigned { get { return default(bool); } }
        public override long Length { get { return default(long); } }
        public override long Position { get { return default(long); } set { } }
        public override int ReadTimeout { get { return default(int); } set { } }
        public virtual System.Security.Principal.IIdentity RemoteIdentity { get { return default(System.Security.Principal.IIdentity); } }
        public override int WriteTimeout { get { return default(int); } set { } }
        public virtual void AuthenticateAsClient() { }
        public virtual void AuthenticateAsClient(System.Net.NetworkCredential credential, string targetName) { }
        public virtual void AuthenticateAsClient(System.Net.NetworkCredential credential, string targetName, System.Net.Security.ProtectionLevel requiredProtectionLevel, System.Security.Principal.TokenImpersonationLevel allowedImpersonationLevel) { }
        public virtual void AuthenticateAsServer() { }
        public virtual void AuthenticateAsServer(System.Net.NetworkCredential credential, System.Net.Security.ProtectionLevel requiredProtectionLevel, System.Security.Principal.TokenImpersonationLevel requiredImpersonationLevel) { }
        public virtual System.IAsyncResult BeginAuthenticateAsClient(System.AsyncCallback asyncCallback, object asyncState) { return default(System.IAsyncResult); }
        public virtual System.IAsyncResult BeginAuthenticateAsClient(System.Net.NetworkCredential credential, string targetName, System.AsyncCallback asyncCallback, object asyncState) { return default(System.IAsyncResult); }
        public virtual System.IAsyncResult BeginAuthenticateAsClient(System.Net.NetworkCredential credential, string targetName, System.Net.Security.ProtectionLevel requiredProtectionLevel, System.Security.Principal.TokenImpersonationLevel allowedImpersonationLevel, System.AsyncCallback asyncCallback, object asyncState) { return default(System.IAsyncResult); }
        public virtual System.IAsyncResult BeginAuthenticateAsServer(System.AsyncCallback asyncCallback, object asyncState) { return default(System.IAsyncResult); }
        public virtual System.IAsyncResult BeginAuthenticateAsServer(System.Net.NetworkCredential credential, System.Net.Security.ProtectionLevel requiredProtectionLevel, System.Security.Principal.TokenImpersonationLevel requiredImpersonationLevel, System.AsyncCallback asyncCallback, object asyncState) { return default(System.IAsyncResult); }
        public override System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback asyncCallback, object asyncState) { return default(System.IAsyncResult); }
        public override System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback asyncCallback, object asyncState) { return default(System.IAsyncResult); }
        protected override void Dispose(bool disposing) { }
        public virtual void EndAuthenticateAsClient(System.IAsyncResult asyncResult) { }
        public virtual void EndAuthenticateAsServer(System.IAsyncResult asyncResult) { }
        public override int EndRead(System.IAsyncResult asyncResult) { return default(int); }
        public override void EndWrite(System.IAsyncResult asyncResult) { }
        public override void Flush() { }
        public override int Read(byte[] buffer, int offset, int count) { return default(int); }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { return default(long); }
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
        public virtual System.Threading.Tasks.Task AuthenticateAsClientAsync() { return default(System.Threading.Tasks.Task); }
        public virtual System.Threading.Tasks.Task AuthenticateAsClientAsync(System.Net.NetworkCredential credential, System.Security.Authentication.ExtendedProtection.ChannelBinding binding, string targetName) { return default(System.Threading.Tasks.Task); }
        public virtual System.Threading.Tasks.Task AuthenticateAsClientAsync(System.Net.NetworkCredential credential, System.Security.Authentication.ExtendedProtection.ChannelBinding binding, string targetName, System.Net.Security.ProtectionLevel requiredProtectionLevel, System.Security.Principal.TokenImpersonationLevel allowedImpersonationLevel) { return default(System.Threading.Tasks.Task); }
        public virtual System.Threading.Tasks.Task AuthenticateAsClientAsync(System.Net.NetworkCredential credential, string targetName) { return default(System.Threading.Tasks.Task); }
        public virtual System.Threading.Tasks.Task AuthenticateAsClientAsync(System.Net.NetworkCredential credential, string targetName, System.Net.Security.ProtectionLevel requiredProtectionLevel, System.Security.Principal.TokenImpersonationLevel allowedImpersonationLevel) { return default(System.Threading.Tasks.Task); }
        public virtual System.Threading.Tasks.Task AuthenticateAsServerAsync() { return default(System.Threading.Tasks.Task); }
        public virtual System.Threading.Tasks.Task AuthenticateAsServerAsync(System.Net.NetworkCredential credential, System.Net.Security.ProtectionLevel requiredProtectionLevel, System.Security.Principal.TokenImpersonationLevel requiredImpersonationLevel) { return default(System.Threading.Tasks.Task); }
        public virtual System.Threading.Tasks.Task AuthenticateAsServerAsync(System.Net.NetworkCredential credential, System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy policy, System.Net.Security.ProtectionLevel requiredProtectionLevel, System.Security.Principal.TokenImpersonationLevel requiredImpersonationLevel) { return default(System.Threading.Tasks.Task); }
        public virtual System.Threading.Tasks.Task AuthenticateAsServerAsync(System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy policy) { return default(System.Threading.Tasks.Task); }
    }

    public enum ProtectionLevel
    {
        EncryptAndSign = 2,
        None = 0,
        Sign = 1,
    }

    public delegate bool RemoteCertificateValidationCallback(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors);
    public partial class SslStream : System.Net.Security.AuthenticatedStream
    {
        public SslStream(System.IO.Stream innerStream) : base(default(System.IO.Stream), default(bool)) { }
        public SslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen) : base(default(System.IO.Stream), default(bool)) { }
        public SslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, System.Net.Security.RemoteCertificateValidationCallback userCertificateValidationCallback) : base(default(System.IO.Stream), default(bool)) { }
        public SslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, System.Net.Security.RemoteCertificateValidationCallback userCertificateValidationCallback, System.Net.Security.LocalCertificateSelectionCallback userCertificateSelectionCallback) : base(default(System.IO.Stream), default(bool)) { }
        public override bool CanRead { get { return default(bool); } }
        public override bool CanSeek { get { return default(bool); } }
        public override bool CanTimeout { get { return default(bool); } }
        public override bool CanWrite { get { return default(bool); } }
        public virtual bool CheckCertRevocationStatus { get { return default(bool); } }
        public virtual System.Security.Authentication.CipherAlgorithmType CipherAlgorithm { get { return default(System.Security.Authentication.CipherAlgorithmType); } }
        public virtual int CipherStrength { get { return default(int); } }
        public virtual System.Security.Authentication.HashAlgorithmType HashAlgorithm { get { return default(System.Security.Authentication.HashAlgorithmType); } }
        public virtual int HashStrength { get { return default(int); } }
        public override bool IsAuthenticated { get { return default(bool); } }
        public override bool IsEncrypted { get { return default(bool); } }
        public override bool IsMutuallyAuthenticated { get { return default(bool); } }
        public override bool IsServer { get { return default(bool); } }
        public override bool IsSigned { get { return default(bool); } }
        public virtual System.Security.Authentication.ExchangeAlgorithmType KeyExchangeAlgorithm { get { return default(System.Security.Authentication.ExchangeAlgorithmType); } }
        public virtual int KeyExchangeStrength { get { return default(int); } }
        public override long Length { get { return default(long); } }
        public virtual System.Security.Cryptography.X509Certificates.X509Certificate LocalCertificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate); } }
        public override long Position { get { return default(long); } set { } }
        public override int ReadTimeout { get { return default(int); } set { } }
        public virtual System.Security.Cryptography.X509Certificates.X509Certificate RemoteCertificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate); } }
        public virtual System.Security.Authentication.SslProtocols SslProtocol { get { return default(System.Security.Authentication.SslProtocols); } }
        public override int WriteTimeout { get { return default(int); } set { } }
        public virtual void AuthenticateAsClient(string targetHost) { }
        public virtual void AuthenticateAsClient(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }
        public virtual System.Threading.Tasks.Task AuthenticateAsClientAsync(string targetHost) { return default(System.Threading.Tasks.Task); }
        public virtual System.Threading.Tasks.Task AuthenticateAsClientAsync(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { return default(System.Threading.Tasks.Task); }
        public virtual void AuthenticateAsServer(System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate) { }
        public virtual void AuthenticateAsServer(System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, bool clientCertificateRequired, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }
        public virtual System.Threading.Tasks.Task AuthenticateAsServerAsync(System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate) { return default(System.Threading.Tasks.Task); }
        public virtual System.Threading.Tasks.Task AuthenticateAsServerAsync(System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, bool clientCertificateRequired, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { return default(System.Threading.Tasks.Task); }
        public virtual System.IAsyncResult BeginAuthenticateAsClient(string targetHost, System.AsyncCallback asyncCallback, object asyncState) { return default(System.IAsyncResult); }
        public virtual System.IAsyncResult BeginAuthenticateAsClient(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation, System.AsyncCallback asyncCallback, object asyncState) { return default(System.IAsyncResult); }
        public virtual System.IAsyncResult BeginAuthenticateAsServer(System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, System.AsyncCallback asyncCallback, object asyncState) { return default(System.IAsyncResult); }
        public virtual System.IAsyncResult BeginAuthenticateAsServer(System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, bool clientCertificateRequired, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation, System.AsyncCallback asyncCallback, object asyncState) { return default(System.IAsyncResult); }
        public override System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback asyncCallback, object asyncState) { return default(System.IAsyncResult); }
        public override System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback asyncCallback, object asyncState) { return default(System.IAsyncResult); }
        protected override void Dispose(bool disposing) { }
        public virtual void EndAuthenticateAsClient(System.IAsyncResult asyncResult) { }
        public virtual void EndAuthenticateAsServer(System.IAsyncResult asyncResult) { }
        public override int EndRead(System.IAsyncResult asyncResult) { return default(int); }
        public override void EndWrite(System.IAsyncResult asyncResult) { }
        public override void Flush() { }
        public override int Read(byte[] buffer, int offset, int count) { return default(int); }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { return default(long); }
        public override void SetLength(long value) { }
        public void Write(byte[] buffer) { }
        public override void Write(byte[] buffer, int offset, int count) { }
        public SslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, System.Net.Security.RemoteCertificateValidationCallback userCertificateValidationCallback, System.Net.Security.LocalCertificateSelectionCallback userCertificateSelectionCallback, System.Net.Security.EncryptionPolicy encryptionPolicy) : base(default(System.IO.Stream), default(bool)) { }
        public System.Net.TransportContext TransportContext { get { return default(System.Net.TransportContext); } }
    }
  public enum EncryptionPolicy {
    AllowNoEncryption = 1,
    NoEncryption = 2,
    RequireEncryption = 0,
  }
} // end of System.Net.Security
namespace System.Security.Authentication {
    public partial class AuthenticationException : System.SystemException
    {
        public AuthenticationException() { }
        protected AuthenticationException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public AuthenticationException(string message) { }
        public AuthenticationException(string message, System.Exception innerException) { }
    }

    public partial class InvalidCredentialException : System.Security.Authentication.AuthenticationException
    {
        public InvalidCredentialException() { }
        protected InvalidCredentialException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public InvalidCredentialException(string message) { }
        public InvalidCredentialException(string message, System.Exception innerException) { }
    }
} // end of System.Security.Authentication
namespace System.Security.Authentication.ExtendedProtection {
    public partial class ExtendedProtectionPolicy : System.Runtime.Serialization.ISerializable
    {
        protected ExtendedProtectionPolicy(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ExtendedProtectionPolicy(System.Security.Authentication.ExtendedProtection.PolicyEnforcement policyEnforcement) { }
        public ExtendedProtectionPolicy(System.Security.Authentication.ExtendedProtection.PolicyEnforcement policyEnforcement, System.Security.Authentication.ExtendedProtection.ChannelBinding customChannelBinding) { }
        public ExtendedProtectionPolicy(System.Security.Authentication.ExtendedProtection.PolicyEnforcement policyEnforcement, System.Security.Authentication.ExtendedProtection.ProtectionScenario protectionScenario, System.Collections.ICollection customServiceNames) { }
        public ExtendedProtectionPolicy(System.Security.Authentication.ExtendedProtection.PolicyEnforcement policyEnforcement, System.Security.Authentication.ExtendedProtection.ProtectionScenario protectionScenario, System.Security.Authentication.ExtendedProtection.ServiceNameCollection customServiceNames) { }
        public System.Security.Authentication.ExtendedProtection.ChannelBinding CustomChannelBinding { get { return default(System.Security.Authentication.ExtendedProtection.ChannelBinding); } }
        public System.Security.Authentication.ExtendedProtection.ServiceNameCollection CustomServiceNames { get { return default(System.Security.Authentication.ExtendedProtection.ServiceNameCollection); } }
        public static bool OSSupportsExtendedProtection { get { return default(bool); } }
        public System.Security.Authentication.ExtendedProtection.PolicyEnforcement PolicyEnforcement { get { return default(System.Security.Authentication.ExtendedProtection.PolicyEnforcement); } }
        public System.Security.Authentication.ExtendedProtection.ProtectionScenario ProtectionScenario { get { return default(System.Security.Authentication.ExtendedProtection.ProtectionScenario); } }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override string ToString() { return default(string); }
    }

    public enum PolicyEnforcement
    {
        Always = 2,
        Never = 0,
        WhenSupported = 1,
    }

    public enum ProtectionScenario
    {
        TransportSelected = 0,
        TrustedProxy = 1,
    }
    public partial class ServiceNameCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection
    {
        public ServiceNameCollection(System.Collections.ICollection items) { }
        public System.Security.Authentication.ExtendedProtection.ServiceNameCollection Merge(System.Collections.IEnumerable serviceNames) { return default(System.Security.Authentication.ExtendedProtection.ServiceNameCollection); }
        public System.Security.Authentication.ExtendedProtection.ServiceNameCollection Merge(string serviceName) { return default(System.Security.Authentication.ExtendedProtection.ServiceNameCollection); }
        public bool Contains(string searchServiceName) { return default(bool); }
        public override System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        public override int Count { get { return default(int); } }
        bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
        object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    }
} // end of System.Security.Authentication.ExtendedProtection
