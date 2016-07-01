[assembly:System.CLSCompliant(true)]
namespace System.Net {
    public partial class AuthenticationManager
    {
        internal AuthenticationManager() { }
        public static System.Net.ICredentialPolicy CredentialPolicy { get { return default(System.Net.ICredentialPolicy); } set { } }
        public static System.Collections.Specialized.StringDictionary CustomTargetNameDictionary { get { return default(System.Collections.Specialized.StringDictionary); } }
        public static System.Collections.IEnumerator RegisteredModules { get { return default(System.Collections.IEnumerator); } }
        public static System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest request, System.Net.ICredentials credentials) { return default(System.Net.Authorization); }
        public static System.Net.Authorization PreAuthenticate(System.Net.WebRequest request, System.Net.ICredentials credentials) { return default(System.Net.Authorization); }
        public static void Register(System.Net.IAuthenticationModule authenticationModule) { }
        public static void Unregister(System.Net.IAuthenticationModule authenticationModule) { }
        public static void Unregister(string authenticationScheme) { }
    }

    public partial class Authorization
    {
        public Authorization(string token) { }
        public Authorization(string token, bool finished) { }
        public Authorization(string token, bool finished, string connectionGroupId) { }
        public bool Complete { get { return default(bool); } }
        public string ConnectionGroupId { get { return default(string); } }
        public string Message { get { return default(string); } }
        public bool MutuallyAuthenticated { get { return default(bool); } set { } }
        public string[] ProtectionRealm { get { return default(string[]); } set { } }
    }

    public delegate System.Net.IPEndPoint BindIPEndPoint(System.Net.ServicePoint servicePoint, System.Net.IPEndPoint remoteEndPoint, int retryCount);

    public delegate System.Collections.Generic.IEnumerable<string> CipherSuitesCallback(System.Net.SecurityProtocolType protocol, System.Collections.Generic.IEnumerable<string> allCiphers);

    public partial class EndpointPermission
    {
        internal EndpointPermission() { }
        public string Hostname { get { return default(string); } }
        public int Port { get { return default(int); } }
        public System.Net.TransportType Transport { get { return default(System.Net.TransportType); } }
        public override bool Equals(object obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public override string ToString() { return default(string); }
    }

    public partial class FileWebRequest : System.Net.WebRequest, System.Runtime.Serialization.ISerializable
    {
        [System.ObsoleteAttribute("Serialization is obsoleted for this type", false)]
        protected FileWebRequest(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public override string ConnectionGroupName { get { return default(string); } set { } }
        public override long ContentLength { get { return default(long); } set { } }
        public override string ContentType { get { return default(string); } set { } }
        public override System.Net.ICredentials Credentials { get { return default(System.Net.ICredentials); } set { } }
        public override System.Net.WebHeaderCollection Headers { get { return default(System.Net.WebHeaderCollection); } }
        public override string Method { get { return default(string); } set { } }
        public override bool PreAuthenticate { get { return default(bool); } set { } }
        public override System.Net.IWebProxy Proxy { get { return default(System.Net.IWebProxy); } set { } }
        public override System.Uri RequestUri { get { return default(System.Uri); } }
        public override int Timeout { get { return default(int); } set { } }
        public override bool UseDefaultCredentials { get { return default(bool); } set { } }
        public override void Abort() { }
        public override System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
        public override System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
        public override System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult) { return default(System.IO.Stream); }
        public override System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult) { return default(System.Net.WebResponse); }
        protected override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public override System.IO.Stream GetRequestStream() { return default(System.IO.Stream); }
        public override System.Net.WebResponse GetResponse() { return default(System.Net.WebResponse); }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    }

    public partial class FileWebResponse : System.Net.WebResponse, System.IDisposable, System.Runtime.Serialization.ISerializable
    {
        [System.ObsoleteAttribute("Serialization is obsoleted for this type", false)]
        protected FileWebResponse(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public override long ContentLength { get { return default(long); } }
        public override string ContentType { get { return default(string); } }
        public override System.Net.WebHeaderCollection Headers { get { return default(System.Net.WebHeaderCollection); } }
        public override System.Uri ResponseUri { get { return default(System.Uri); } }
        public override void Close() { }
        protected override void Dispose(bool disposing) { }
        ~FileWebResponse() { }
        protected override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public override System.IO.Stream GetResponseStream() { return default(System.IO.Stream); }
        void System.IDisposable.Dispose() { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    }

    public enum FtpStatusCode
    {
        AccountNeeded = 532,
        ActionAbortedLocalProcessingError = 451,
        ActionAbortedUnknownPageType = 551,
        ActionNotTakenFilenameNotAllowed = 553,
        ActionNotTakenFileUnavailable = 550,
        ActionNotTakenFileUnavailableOrBusy = 450,
        ActionNotTakenInsufficientSpace = 452,
        ArgumentSyntaxError = 501,
        BadCommandSequence = 503,
        CantOpenData = 425,
        ClosingControl = 221,
        ClosingData = 226,
        CommandExtraneous = 202,
        CommandNotImplemented = 502,
        CommandOK = 200,
        CommandSyntaxError = 500,
        ConnectionClosed = 426,
        DataAlreadyOpen = 125,
        DirectoryStatus = 212,
        EnteringPassive = 227,
        FileActionAborted = 552,
        FileActionOK = 250,
        FileCommandPending = 350,
        FileStatus = 213,
        LoggedInProceed = 230,
        NeedLoginAccount = 332,
        NotLoggedIn = 530,
        OpeningData = 150,
        PathnameCreated = 257,
        RestartMarker = 110,
        SendPasswordCommand = 331,
        SendUserCommand = 220,
        ServerWantsSecureSession = 234,
        ServiceNotAvailable = 421,
        ServiceTemporarilyNotAvailable = 120,
        SystemType = 215,
        Undefined = 0,
    }

    public sealed partial class FtpWebRequest : System.Net.WebRequest
    {
        internal FtpWebRequest() { }
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get { return default(System.Security.Cryptography.X509Certificates.X509CertificateCollection); } set { } }
        public override string ConnectionGroupName { get { return default(string); } set { } }
        public override long ContentLength { get { return default(long); } set { } }
        public long ContentOffset { get { return default(long); } set { } }
        public override string ContentType { get { return default(string); } set { } }
        public override System.Net.ICredentials Credentials { get { return default(System.Net.ICredentials); } set { } }
        public bool EnableSsl { get { return default(bool); } set { } }
        public override System.Net.WebHeaderCollection Headers { get { return default(System.Net.WebHeaderCollection); } set { } }
        public bool KeepAlive { get { return default(bool); } set { } }
        public override string Method { get { return default(string); } set { } }
        public override bool PreAuthenticate { get { return default(bool); } set { } }
        public override System.Net.IWebProxy Proxy { get { return default(System.Net.IWebProxy); } set { } }
        public int ReadWriteTimeout { get { return default(int); } set { } }
        public string RenameTo { get { return default(string); } set { } }
        public override System.Uri RequestUri { get { return default(System.Uri); } }
        public System.Net.ServicePoint ServicePoint { get { return default(System.Net.ServicePoint); } }
        public override int Timeout { get { return default(int); } set { } }
        public bool UseBinary { get { return default(bool); } set { } }
        public override bool UseDefaultCredentials { get { return default(bool); } set { } }
        public bool UsePassive { get { return default(bool); } set { } }
        public override void Abort() { }
        public override System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
        public override System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
        public override System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult) { return default(System.IO.Stream); }
        public override System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult) { return default(System.Net.WebResponse); }
        public override System.IO.Stream GetRequestStream() { return default(System.IO.Stream); }
        public override System.Net.WebResponse GetResponse() { return default(System.Net.WebResponse); }
    }

    public partial class FtpWebResponse : System.Net.WebResponse
    {
        internal FtpWebResponse() { }
        public string BannerMessage { get { return default(string); } }
        public override long ContentLength { get { return default(long); } }
        public string ExitMessage { get { return default(string); } }
        public override System.Net.WebHeaderCollection Headers { get { return default(System.Net.WebHeaderCollection); } }
        public System.DateTime LastModified { get { return default(System.DateTime); } }
        public override System.Uri ResponseUri { get { return default(System.Uri); } }
        public System.Net.FtpStatusCode StatusCode { get { return default(System.Net.FtpStatusCode); } }
        public string StatusDescription { get { return default(string); } }
        public string WelcomeMessage { get { return default(string); } }
        public override void Close() { }
        public override System.IO.Stream GetResponseStream() { return default(System.IO.Stream); }
    }

    [System.ObsoleteAttribute("Use WebRequest.DefaultProxy instead")]
    public partial class GlobalProxySelection
    {
        public GlobalProxySelection() { }
        public static System.Net.IWebProxy Select { get { return default(System.Net.IWebProxy); } set { } }
        public static System.Net.IWebProxy GetEmptyWebProxy() { return default(System.Net.IWebProxy); }
    }

    public delegate void HttpContinueDelegate(int StatusCode, System.Net.WebHeaderCollection httpHeaders);

    public partial class HttpWebRequest : System.Net.WebRequest, System.Runtime.Serialization.ISerializable
    {
        [System.ObsoleteAttribute("Serialization is obsoleted for this type", false)]
        protected HttpWebRequest(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public HttpWebRequest(System.Uri uri) { }
        public string Accept { get { return default(string); } set { } }
        public System.Uri Address { get { return default(System.Uri); } }
        public bool AllowAutoRedirect { get { return default(bool); } set { } }
        public virtual bool AllowReadStreamBuffering { get { return default(bool); } set { } }
        public bool AllowWriteStreamBuffering { get { return default(bool); } set { } }
        public System.Net.DecompressionMethods AutomaticDecompression { get { return default(System.Net.DecompressionMethods); } set { } }
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get { return default(System.Security.Cryptography.X509Certificates.X509CertificateCollection); } set { } }
        public string Connection { get { return default(string); } set { } }
        public override string ConnectionGroupName { get { return default(string); } set { } }
        public override long ContentLength { get { return default(long); } set { } }
        public override string ContentType { get { return default(string); } set { } }
        public System.Net.HttpContinueDelegate ContinueDelegate { get { return default(System.Net.HttpContinueDelegate); } set { } }
        public int ContinueTimeout { get { return default(int); } set { } }
        public virtual System.Net.CookieContainer CookieContainer { get { return default(System.Net.CookieContainer); } set { } }
        public override System.Net.ICredentials Credentials { get { return default(System.Net.ICredentials); } set { } }
        public System.DateTime Date { get { return default(System.DateTime); } set { } }
        public static int DefaultMaximumErrorResponseLength { get { return default(int); } set { } }
        public static int DefaultMaximumResponseHeadersLength { get { return default(int); } set { } }
        public string Expect { get { return default(string); } set { } }
        public virtual bool HaveResponse { get { return default(bool); } }
        public override System.Net.WebHeaderCollection Headers { get { return default(System.Net.WebHeaderCollection); } set { } }
        public string Host { get { return default(string); } set { } }
        public System.DateTime IfModifiedSince { get { return default(System.DateTime); } set { } }
        public bool KeepAlive { get { return default(bool); } set { } }
        public int MaximumAutomaticRedirections { get { return default(int); } set { } }
        public int MaximumResponseHeadersLength { get { return default(int); } set { } }
        public string MediaType { get { return default(string); } set { } }
        public override string Method { get { return default(string); } set { } }
        public bool Pipelined { get { return default(bool); } set { } }
        public override bool PreAuthenticate { get { return default(bool); } set { } }
        public System.Version ProtocolVersion { get { return default(System.Version); } set { } }
        public override System.Net.IWebProxy Proxy { get { return default(System.Net.IWebProxy); } set { } }
        public int ReadWriteTimeout { get { return default(int); } set { } }
        public string Referer { get { return default(string); } set { } }
        public override System.Uri RequestUri { get { return default(System.Uri); } }
        public bool SendChunked { get { return default(bool); } set { } }
        public System.Net.ServicePoint ServicePoint { get { return default(System.Net.ServicePoint); } }
        public virtual bool SupportsCookieContainer { get { return default(bool); } }
        public override int Timeout { get { return default(int); } set { } }
        public string TransferEncoding { get { return default(string); } set { } }
        public bool UnsafeAuthenticatedConnectionSharing { get { return default(bool); } set { } }
        public override bool UseDefaultCredentials { get { return default(bool); } set { } }
        public string UserAgent { get { return default(string); } set { } }
        public override void Abort() { }
        public void AddRange(int range) { }
        public void AddRange(int from, int to) { }
        public void AddRange(long range) { }
        public void AddRange(long from, long to) { }
        public void AddRange(string rangeSpecifier, int range) { }
        public void AddRange(string rangeSpecifier, int from, int to) { }
        public void AddRange(string rangeSpecifier, long range) { }
        public void AddRange(string rangeSpecifier, long from, long to) { }
        public override System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
        public override System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
        public override System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult) { return default(System.IO.Stream); }
        public System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult, out System.Net.TransportContext transportContext) { transportContext = default(System.Net.TransportContext); return default(System.IO.Stream); }
        public override System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult) { return default(System.Net.WebResponse); }
        protected override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public override System.IO.Stream GetRequestStream() { return default(System.IO.Stream); }
        public override System.Net.WebResponse GetResponse() { return default(System.Net.WebResponse); }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        internal HttpWebRequest() { }
    }

    public partial class HttpWebResponse : System.Net.WebResponse, System.IDisposable, System.Runtime.Serialization.ISerializable
    {
        [System.ObsoleteAttribute("Serialization is obsoleted for this type", false)]
        protected HttpWebResponse(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public string CharacterSet { get { return default(string); } }
        public string ContentEncoding { get { return default(string); } }
        public override long ContentLength { get { return default(long); } }
        public override string ContentType { get { return default(string); } }
        public virtual System.Net.CookieCollection Cookies { get { return default(System.Net.CookieCollection); } set { } }
        public override System.Net.WebHeaderCollection Headers { get { return default(System.Net.WebHeaderCollection); } }
        public override bool IsMutuallyAuthenticated { get { return default(bool); } }
        public System.DateTime LastModified { get { return default(System.DateTime); } }
        public virtual string Method { get { return default(string); } }
        public System.Version ProtocolVersion { get { return default(System.Version); } }
        public override System.Uri ResponseUri { get { return default(System.Uri); } }
        public string Server { get { return default(string); } }
        public virtual System.Net.HttpStatusCode StatusCode { get { return default(System.Net.HttpStatusCode); } }
        public virtual string StatusDescription { get { return default(string); } }
        public override void Close() { }
        protected override void Dispose(bool disposing) { }
        protected override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public string GetResponseHeader(string headerName) { return default(string); }
        public override System.IO.Stream GetResponseStream() { return default(System.IO.Stream); }
        void System.IDisposable.Dispose() { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        internal HttpWebResponse() { }
        public override bool SupportsHeaders { get { return default(bool); } }
    }

    public partial interface IAuthenticationModule
    {
        string AuthenticationType { get; }
        bool CanPreAuthenticate { get; }
        System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest request, System.Net.ICredentials credentials);
        System.Net.Authorization PreAuthenticate(System.Net.WebRequest request, System.Net.ICredentials credentials);
    }

    public partial interface ICertificatePolicy
    {
        bool CheckValidationResult(System.Net.ServicePoint srvPoint, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Net.WebRequest request, int certificateProblem);
    }

    public partial interface ICredentialPolicy
    {
        bool ShouldSendCredential(System.Uri challengeUri, System.Net.WebRequest request, System.Net.NetworkCredential credential, System.Net.IAuthenticationModule authenticationModule);
    }

    public partial interface IWebProxyScript
    {
        void Close();
        bool Load(System.Uri scriptLocation, string script, System.Type helperType);
        string Run(string url, string host);
    }

    public partial interface IWebRequestCreate
    {
        System.Net.WebRequest Create(System.Uri uri);
    }

    public partial class ProtocolViolationException : System.InvalidOperationException, System.Runtime.Serialization.ISerializable
    {
        public ProtocolViolationException() { }
        protected ProtocolViolationException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public ProtocolViolationException(string message) { }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }

    [System.FlagsAttribute]
    public enum SecurityProtocolType
    {
        Ssl3 = 48,
        Tls = 192,
    }

    public partial class ServicePoint
    {
        internal ServicePoint() { }
        public System.Uri Address { get { return default(System.Uri); } }
        public System.Net.BindIPEndPoint BindIPEndPointDelegate { get { return default(System.Net.BindIPEndPoint); } set { } }
        public System.Security.Cryptography.X509Certificates.X509Certificate Certificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate); } }
        public System.Security.Cryptography.X509Certificates.X509Certificate ClientCertificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate); } }
        public int ConnectionLeaseTimeout { get { return default(int); } set { } }
        public int ConnectionLimit { get { return default(int); } set { } }
        public string ConnectionName { get { return default(string); } }
        public int CurrentConnections { get { return default(int); } }
        public bool Expect100Continue { get { return default(bool); } set { } }
        public System.DateTime IdleSince { get { return default(System.DateTime); } }
        public int MaxIdleTime { get { return default(int); } set { } }
        public virtual System.Version ProtocolVersion { get { return default(System.Version); } }
        public int ReceiveBufferSize { get { return default(int); } set { } }
        public bool SupportsPipelining { get { return default(bool); } }
        public bool UseNagleAlgorithm { get { return default(bool); } set { } }
        public bool CloseConnectionGroup(string connectionGroupName) { return default(bool); }
        public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval) { }
    }

    public partial class WebException : System.InvalidOperationException, System.Runtime.Serialization.ISerializable
    {
        public WebException() { }
        protected WebException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public WebException(string message) { }
        public WebException(string message, System.Exception innerException) { }
        public WebException(string message, System.Exception innerException, System.Net.WebExceptionStatus status, System.Net.WebResponse response) { }
        public WebException(string message, System.Net.WebExceptionStatus status) { }
        public System.Net.WebResponse Response { get { return default(System.Net.WebResponse); } }
        public System.Net.WebExceptionStatus Status { get { return default(System.Net.WebExceptionStatus); } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }

    public enum WebExceptionStatus
    {
        CacheEntryNotFound = 18,
        ConnectFailure = 2,
        ConnectionClosed = 8,
        KeepAliveFailure = 12,
        MessageLengthLimitExceeded = 17,
        NameResolutionFailure = 1,
        Pending = 13,
        PipelineFailure = 5,
        ProtocolError = 7,
        ProxyNameResolutionFailure = 15,
        ReceiveFailure = 3,
        RequestCanceled = 6,
        RequestProhibitedByCachePolicy = 19,
        RequestProhibitedByProxy = 20,
        SecureChannelFailure = 10,
        SendFailure = 4,
        ServerProtocolViolation = 11,
        Success = 0,
        Timeout = 14,
        TrustFailure = 9,
        UnknownError = 16,
    }

    public partial class WebProxy : System.Net.IWebProxy, System.Runtime.Serialization.ISerializable
    {
        public WebProxy() { }
        protected WebProxy(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public WebProxy(string address) { }
        public WebProxy(string address, bool bypassOnLocal) { }
        public WebProxy(string address, bool bypassOnLocal, string[] bypassList) { }
        public WebProxy(string address, bool bypassOnLocal, string[] bypassList, System.Net.ICredentials credentials) { }
        public WebProxy(string host, int port) { }
        public WebProxy(System.Uri address) { }
        public WebProxy(System.Uri address, bool bypassOnLocal) { }
        public WebProxy(System.Uri address, bool bypassOnLocal, string[] bypassList) { }
        public WebProxy(System.Uri address, bool bypassOnLocal, string[] bypassList, System.Net.ICredentials credentials) { }
        public System.Uri Address { get { return default(System.Uri); } set { } }
        public System.Collections.ArrayList BypassArrayList { get { return default(System.Collections.ArrayList); } }
        public string[] BypassList { get { return default(string[]); } set { } }
        public bool BypassProxyOnLocal { get { return default(bool); } set { } }
        public System.Net.ICredentials Credentials { get { return default(System.Net.ICredentials); } set { } }
        public bool UseDefaultCredentials { get { return default(bool); } set { } }
        [System.ObsoleteAttribute("This method has been deprecated", false)]
        public static System.Net.WebProxy GetDefaultProxy() { return default(System.Net.WebProxy); }
        protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public System.Uri GetProxy(System.Uri destination) { return default(System.Uri); }
        public bool IsBypassed(System.Uri host) { return default(bool); }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    }

    public abstract partial class WebRequest :System.Runtime.Serialization.ISerializable
    {
        protected WebRequest() { }
        protected WebRequest(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public System.Net.Security.AuthenticationLevel AuthenticationLevel { get { return default(System.Net.Security.AuthenticationLevel); } set { } }
        public virtual System.Net.Cache.RequestCachePolicy CachePolicy { get { return default(System.Net.Cache.RequestCachePolicy); } set { } }
        public virtual string ConnectionGroupName { get { return default(string); } set { } }
        public virtual long ContentLength { get { return default(long); } set { } }
        public virtual string ContentType { get { return default(string); } set { } }
        public virtual System.Net.ICredentials Credentials { get { return default(System.Net.ICredentials); } set { } }
        public static System.Net.Cache.RequestCachePolicy DefaultCachePolicy { get { return default(System.Net.Cache.RequestCachePolicy); } set { } }
        public static System.Net.IWebProxy DefaultWebProxy { get { return default(System.Net.IWebProxy); } set { } }
        public virtual System.Net.WebHeaderCollection Headers { get { return default(System.Net.WebHeaderCollection); } set { } }
        public System.Security.Principal.TokenImpersonationLevel ImpersonationLevel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Security.Principal.TokenImpersonationLevel); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual string Method { get { return default(string); } set { } }
        public virtual bool PreAuthenticate { get { return default(bool); } set { } }
        public virtual System.Net.IWebProxy Proxy { get { return default(System.Net.IWebProxy); } set { } }
        public virtual System.Uri RequestUri { get { return default(System.Uri); } }
        public virtual int Timeout { get { return default(int); } set { } }
        public virtual bool UseDefaultCredentials { get { return default(bool); } set { } }
        public virtual void Abort() { }
        public virtual System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
        public virtual System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
        public static System.Net.WebRequest Create(string requestUriString) { return default(System.Net.WebRequest); }
        public static System.Net.WebRequest Create(System.Uri requestUri) { return default(System.Net.WebRequest); }
        public static System.Net.WebRequest CreateDefault(System.Uri requestUri) { return default(System.Net.WebRequest); }
        public static System.Net.HttpWebRequest CreateHttp(string requestUriString) { return default(System.Net.HttpWebRequest); }
        public static System.Net.HttpWebRequest CreateHttp(System.Uri requestUri) { return default(System.Net.HttpWebRequest); }
        public virtual System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult) { return default(System.IO.Stream); }
        public virtual System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult) { return default(System.Net.WebResponse); }
        protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public virtual System.IO.Stream GetRequestStream() { return default(System.IO.Stream); }
        public virtual System.Threading.Tasks.Task<System.IO.Stream> GetRequestStreamAsync() { return default(System.Threading.Tasks.Task<System.IO.Stream>); }
        public virtual System.Net.WebResponse GetResponse() { return default(System.Net.WebResponse); }
        public virtual System.Threading.Tasks.Task<System.Net.WebResponse> GetResponseAsync() { return default(System.Threading.Tasks.Task<System.Net.WebResponse>); }
        public static System.Net.IWebProxy GetSystemWebProxy() { return default(System.Net.IWebProxy); }
        public static bool RegisterPrefix(string prefix, System.Net.IWebRequestCreate creator) { return default(bool); }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    }

    public static partial class WebRequestMethods
    {
        public static partial class File
        {
            public const string DownloadFile = "GET";
            public const string UploadFile = "PUT";
        }
        public static partial class Ftp
        {
            public const string AppendFile = "APPE";
            public const string DeleteFile = "DELE";
            public const string DownloadFile = "RETR";
            public const string GetDateTimestamp = "MDTM";
            public const string GetFileSize = "SIZE";
            public const string ListDirectory = "NLST";
            public const string ListDirectoryDetails = "LIST";
            public const string MakeDirectory = "MKD";
            public const string PrintWorkingDirectory = "PWD";
            public const string RemoveDirectory = "RMD";
            public const string Rename = "RENAME";
            public const string UploadFile = "STOR";
            public const string UploadFileWithUniqueName = "STOU";
        }
        public static partial class Http
        {
            public const string Connect = "CONNECT";
            public const string Get = "GET";
            public const string Head = "HEAD";
            public const string MkCol = "MKCOL";
            public const string Post = "POST";
            public const string Put = "PUT";
        }
    }

    public abstract partial class WebResponse :System.IDisposable, System.Runtime.Serialization.ISerializable
    {
        protected WebResponse() { }
        protected WebResponse(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public virtual long ContentLength { get { return default(long); } set { } }
        public virtual string ContentType { get { return default(string); } set { } }
        public virtual System.Net.WebHeaderCollection Headers { get { return default(System.Net.WebHeaderCollection); } }
        public virtual bool IsFromCache { get { return default(bool); } }
        public virtual bool IsMutuallyAuthenticated { get { return default(bool); } }
        public virtual System.Uri ResponseUri { get { return default(System.Uri); } }
        public virtual bool SupportsHeaders { get { return default(bool); } }
        public virtual void Close() { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public virtual System.IO.Stream GetResponseStream() { return default(System.IO.Stream); }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    }
} // end of System.Net
namespace System.Net.Cache {
    public enum HttpCacheAgeControl
    {
        MaxAge = 2,
        MaxAgeAndMaxStale = 6,
        MaxAgeAndMinFresh = 3,
        MaxStale = 4,
        MinFresh = 1,
        None = 0,
    }

    public enum HttpRequestCacheLevel
    {
        BypassCache = 1,
        CacheIfAvailable = 3,
        CacheOnly = 2,
        CacheOrNextCacheOnly = 7,
        Default = 0,
        NoCacheNoStore = 6,
        Refresh = 8,
        Reload = 5,
        Revalidate = 4,
    }

    public partial class HttpRequestCachePolicy : System.Net.Cache.RequestCachePolicy
    {
        public HttpRequestCachePolicy() { }
        public HttpRequestCachePolicy(System.DateTime cacheSyncDate) { }
        public HttpRequestCachePolicy(System.Net.Cache.HttpCacheAgeControl cacheAgeControl, System.TimeSpan ageOrFreshOrStale) { }
        public HttpRequestCachePolicy(System.Net.Cache.HttpCacheAgeControl cacheAgeControl, System.TimeSpan maxAge, System.TimeSpan freshOrStale) { }
        public HttpRequestCachePolicy(System.Net.Cache.HttpCacheAgeControl cacheAgeControl, System.TimeSpan maxAge, System.TimeSpan freshOrStale, System.DateTime cacheSyncDate) { }
        public HttpRequestCachePolicy(System.Net.Cache.HttpRequestCacheLevel level) { }
        public System.DateTime CacheSyncDate { get { return default(System.DateTime); } }
        public new System.Net.Cache.HttpRequestCacheLevel Level { get { return default(System.Net.Cache.HttpRequestCacheLevel); } }
        public System.TimeSpan MaxAge { get { return default(System.TimeSpan); } }
        public System.TimeSpan MaxStale { get { return default(System.TimeSpan); } }
        public System.TimeSpan MinFresh { get { return default(System.TimeSpan); } }
        public override string ToString() { return default(string); }
    }

    public enum RequestCacheLevel
    {
        BypassCache = 1,
        CacheIfAvailable = 3,
        CacheOnly = 2,
        Default = 0,
        NoCacheNoStore = 6,
        Reload = 5,
        Revalidate = 4,
    }

    public partial class RequestCachePolicy
    {
        public RequestCachePolicy() { }
        public RequestCachePolicy(System.Net.Cache.RequestCacheLevel level) { }
        public System.Net.Cache.RequestCacheLevel Level { get { return default(System.Net.Cache.RequestCacheLevel); } }
        public override string ToString() { return default(string); }
    }
} // end of System.Net.Cache
