[assembly:System.CLSCompliant(true)]
namespace System.Net {
  public delegate System.Net.IPEndPoint BindIPEndPoint(System.Net.ServicePoint servicePoint, System.Net.IPEndPoint remoteEndPoint, int retryCount);

  public delegate void HttpContinueDelegate(int StatusCode, System.Net.WebHeaderCollection httpHeaders);

  public partial class HttpWebRequest : System.Net.WebRequest, System.Runtime.Serialization.ISerializable {
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
  }

  public partial class HttpWebResponse : System.Net.WebResponse, System.IDisposable, System.Runtime.Serialization.ISerializable {
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
  }

  public partial interface IWebRequestCreate {
    System.Net.WebRequest Create(System.Uri uri);
  }

  public partial class ProtocolViolationException : System.InvalidOperationException, System.Runtime.Serialization.ISerializable {
    public ProtocolViolationException() { }
    protected ProtocolViolationException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public ProtocolViolationException(string message) { }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }

  public partial class ServicePoint {
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

  public partial class WebException : System.InvalidOperationException, System.Runtime.Serialization.ISerializable {
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

  public enum WebExceptionStatus {
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

  public abstract partial class WebRequest :System.Runtime.Serialization.ISerializable {
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

  public abstract partial class WebResponse :System.IDisposable, System.Runtime.Serialization.ISerializable {
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
  public enum RequestCacheLevel {
    BypassCache = 1,
    CacheIfAvailable = 3,
    CacheOnly = 2,
    Default = 0,
    NoCacheNoStore = 6,
    Reload = 5,
    Revalidate = 4,
  }

  public partial class RequestCachePolicy {
    public RequestCachePolicy() { }
    public RequestCachePolicy(System.Net.Cache.RequestCacheLevel level) { }
    public System.Net.Cache.RequestCacheLevel Level { get { return default(System.Net.Cache.RequestCacheLevel); } }
    public override string ToString() { return default(string); }
  }

} // end of System.Net.Cache
