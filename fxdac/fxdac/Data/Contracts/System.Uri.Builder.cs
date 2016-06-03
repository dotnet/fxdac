[assembly:System.CLSCompliant(true)]
namespace System {
  public partial class FileStyleUriParser : System.UriParser {
    public FileStyleUriParser() { }
  }

  public partial class FtpStyleUriParser : System.UriParser {
    public FtpStyleUriParser() { }
  }

  public partial class GenericUriParser : System.UriParser {
    public GenericUriParser(System.GenericUriParserOptions options) { }
  }

  [System.FlagsAttribute]
  public enum GenericUriParserOptions {
    AllowEmptyAuthority = 2,
    Default = 0,
    DontCompressPath = 128,
    DontConvertPathBackslashes = 64,
    DontUnescapePathDotsAndSlashes = 256,
    GenericAuthority = 1,
    Idn = 512,
    IriParsing = 1024,
    NoFragment = 32,
    NoPort = 8,
    NoQuery = 16,
    NoUserInfo = 4,
  }

  public partial class HttpStyleUriParser : System.UriParser {
    public HttpStyleUriParser() { }
  }

  public partial class NetPipeStyleUriParser : System.UriParser {
    public NetPipeStyleUriParser() { }
  }

  public partial class NetTcpStyleUriParser : System.UriParser {
    public NetTcpStyleUriParser() { }
  }

  public partial class NewsStyleUriParser : System.UriParser {
    public NewsStyleUriParser() { }
  }

  public partial class UriBuilder {
    public UriBuilder() { }
    public UriBuilder(string uri) { }
    public UriBuilder(string schemeName, string hostName) { }
    public UriBuilder(string scheme, string host, int portNumber) { }
    public UriBuilder(string scheme, string host, int port, string pathValue) { }
    public UriBuilder(string scheme, string host, int port, string path, string extraValue) { }
    public UriBuilder(System.Uri uri) { }
    public string Fragment { get { return default(string); } set { } }
    public string Host { get { return default(string); } set { } }
    public string Password { get { return default(string); } set { } }
    public string Path { get { return default(string); } set { } }
    public int Port { get { return default(int); } set { } }
    public string Query { get { return default(string); } set { } }
    public string Scheme { get { return default(string); } set { } }
    public System.Uri Uri { get { return default(System.Uri); } }
    public string UserName { get { return default(string); } set { } }
    public override bool Equals(object rparam) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }

  public enum UriIdnScope {
    All = 2,
    AllExceptIntranet = 1,
    None = 0,
  }

  public abstract partial class UriParser {
    protected UriParser() { }
    protected internal virtual string GetComponents(System.Uri uri, System.UriComponents components, System.UriFormat format) { return default(string); }
    protected internal virtual void InitializeAndValidate(System.Uri uri, out System.UriFormatException parsingError) { parsingError = default(System.UriFormatException); }
    protected internal virtual bool IsBaseOf(System.Uri baseUri, System.Uri relativeUri) { return default(bool); }
    public static bool IsKnownScheme(string schemeName) { return default(bool); }
    protected internal virtual bool IsWellFormedOriginalString(System.Uri uri) { return default(bool); }
    protected internal virtual System.UriParser OnNewUri() { return default(System.UriParser); }
    protected virtual void OnRegister(string schemeName, int defaultPort) { }
    public static void Register(System.UriParser uriParser, string schemeName, int defaultPort) { }
    protected internal virtual string Resolve(System.Uri baseUri, System.Uri relativeUri, out System.UriFormatException parsingError) { parsingError = default(System.UriFormatException); return default(string); }
  }

} // end of System
