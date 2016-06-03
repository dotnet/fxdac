[assembly:System.CLSCompliant(true)]
namespace System.Net {
  public partial class AuthenticationManager {
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

  public partial class Authorization {
    public Authorization(string token) { }
    public Authorization(string token, bool finished) { }
    public Authorization(string token, bool finished, string connectionGroupId) { }
    public bool Complete { get { return default(bool); } }
    public string ConnectionGroupId { get { return default(string); } }
    public string Message { get { return default(string); } }
    public bool MutuallyAuthenticated { get { return default(bool); } set { } }
    public string[] ProtectionRealm { get { return default(string[]); } set { } }
  }

  public delegate System.Collections.Generic.IEnumerable<string> CipherSuitesCallback(System.Net.SecurityProtocolType protocol, System.Collections.Generic.IEnumerable<string> allCiphers);

  public partial class EndpointPermission {
    internal EndpointPermission() { }
    public string Hostname { get { return default(string); } }
    public int Port { get { return default(int); } }
    public System.Net.TransportType Transport { get { return default(System.Net.TransportType); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }

  public partial class FileWebRequest : System.Net.WebRequest, System.Runtime.Serialization.ISerializable {
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

  public partial class FileWebResponse : System.Net.WebResponse, System.IDisposable, System.Runtime.Serialization.ISerializable {
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

  public enum FtpStatusCode {
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

  public sealed partial class FtpWebRequest : System.Net.WebRequest {
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

  public partial class FtpWebResponse : System.Net.WebResponse {
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
  public partial class GlobalProxySelection {
    public GlobalProxySelection() { }
    public static System.Net.IWebProxy Select { get { return default(System.Net.IWebProxy); } set { } }
    public static System.Net.IWebProxy GetEmptyWebProxy() { return default(System.Net.IWebProxy); }
  }

  public partial class HttpVersion {
    public static readonly System.Version Version10;
    public static readonly System.Version Version11;
    public HttpVersion() { }
  }

  public partial interface IAuthenticationModule {
    string AuthenticationType { get; }
    bool CanPreAuthenticate { get; }
    System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest request, System.Net.ICredentials credentials);
    System.Net.Authorization PreAuthenticate(System.Net.WebRequest request, System.Net.ICredentials credentials);
  }

  public partial interface ICertificatePolicy {
    bool CheckValidationResult(System.Net.ServicePoint srvPoint, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Net.WebRequest request, int certificateProblem);
  }

  public partial interface ICredentialPolicy {
    bool ShouldSendCredential(System.Uri challengeUri, System.Net.WebRequest request, System.Net.NetworkCredential credential, System.Net.IAuthenticationModule authenticationModule);
  }

  public partial interface IWebProxyScript {
    void Close();
    bool Load(System.Uri scriptLocation, string script, System.Type helperType);
    string Run(string url, string host);
  }

  [System.FlagsAttribute]
  public enum NetworkAccess {
    Accept = 128,
    Connect = 64,
  }

  [System.FlagsAttribute]
  public enum SecurityProtocolType {
    Ssl3 = 48,
    Tls = 192,
  }

  public partial class ServicePointManager {
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

  public sealed partial class SocketPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission {
    public const int AllPorts = -1;
    public SocketPermission(System.Net.NetworkAccess access, System.Net.TransportType transport, string hostName, int portNumber) { }
    public SocketPermission(System.Security.Permissions.PermissionState state) { }
    public System.Collections.IEnumerator AcceptList { get { return default(System.Collections.IEnumerator); } }
    public System.Collections.IEnumerator ConnectList { get { return default(System.Collections.IEnumerator); } }
    public void AddPermission(System.Net.NetworkAccess access, System.Net.TransportType transport, string hostName, int portNumber) { }
    public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
    public override void FromXml(System.Security.SecurityElement securityElement) { }
    public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
    public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
    public bool IsUnrestricted() { return default(bool); }
    public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
  public sealed partial class SocketPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute {
    public SocketPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
    public string Access { get { return default(string); } set { } }
    public string Host { get { return default(string); } set { } }
    public string Port { get { return default(string); } set { } }
    public string Transport { get { return default(string); } set { } }
    public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
  }

  public enum TransportType {
    All = 3,
    Connectionless = 1,
    ConnectionOriented = 2,
    Tcp = 2,
    Udp = 1,
  }

  public partial class WebProxy : System.Net.IWebProxy, System.Runtime.Serialization.ISerializable {
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

  public static partial class WebRequestMethods {
    public static partial class File {
      public const string DownloadFile = "GET";
      public const string UploadFile = "PUT";
    }
    public static partial class Ftp {
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
    public static partial class Http {
      public const string Connect = "CONNECT";
      public const string Get = "GET";
      public const string Head = "HEAD";
      public const string MkCol = "MKCOL";
      public const string Post = "POST";
      public const string Put = "PUT";
    }
  }

} // end of System.Net
namespace System.Net.Cache {
  public enum HttpCacheAgeControl {
    MaxAge = 2,
    MaxAgeAndMaxStale = 6,
    MaxAgeAndMinFresh = 3,
    MaxStale = 4,
    MinFresh = 1,
    None = 0,
  }

  public enum HttpRequestCacheLevel {
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

  public partial class HttpRequestCachePolicy : System.Net.Cache.RequestCachePolicy {
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

} // end of System.Net.Cache
