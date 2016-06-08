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
namespace System.Net {
  public static partial class WebUtility {
    public static string HtmlDecode(string value) { return default(string); }
    public static void HtmlDecode(string value, System.IO.TextWriter output) { }
    public static string HtmlEncode(string value) { return default(string); }
    public static void HtmlEncode(string value, System.IO.TextWriter output) { }
    public static string UrlDecode(string encodedValue) { return default(string); }
    public static byte[] UrlDecodeToBytes(byte[] encodedValue, int offset, int count) { return default(byte[]); }
    public static string UrlEncode(string value) { return default(string); }
    public static byte[] UrlEncodeToBytes(byte[] value, int offset, int count) { return default(byte[]); }
  }

} // end of System.Net
namespace System.Runtime.Versioning {
  public sealed partial class FrameworkName : System.IEquatable<System.Runtime.Versioning.FrameworkName> {
    public FrameworkName(string frameworkName) { }
    public FrameworkName(string identifier, System.Version version) { }
    public FrameworkName(string identifier, System.Version version, string profile) { }
    public string FullName { get { return default(string); } }
    public string Identifier { get { return default(string); } }
    public string Profile { get { return default(string); } }
    public System.Version Version { get { return default(System.Version); } }
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(System.Runtime.Versioning.FrameworkName other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.Runtime.Versioning.FrameworkName left, System.Runtime.Versioning.FrameworkName right) { return default(bool); }
    public static bool operator !=(System.Runtime.Versioning.FrameworkName left, System.Runtime.Versioning.FrameworkName right) { return default(bool); }
    public override string ToString() { return default(string); }
  }

} // end of System.Runtime.Versioning
