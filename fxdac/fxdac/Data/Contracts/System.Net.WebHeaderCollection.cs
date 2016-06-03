[assembly:System.CLSCompliant(true)]
namespace System.Net {
  public enum HttpRequestHeader {
    Accept = 20,
    AcceptCharset = 21,
    AcceptEncoding = 22,
    AcceptLanguage = 23,
    Allow = 10,
    Authorization = 24,
    CacheControl = 0,
    Connection = 1,
    ContentEncoding = 13,
    ContentLanguage = 14,
    ContentLength = 11,
    ContentLocation = 15,
    ContentMd5 = 16,
    ContentRange = 17,
    ContentType = 12,
    Cookie = 25,
    Date = 2,
    Expect = 26,
    Expires = 18,
    From = 27,
    Host = 28,
    IfMatch = 29,
    IfModifiedSince = 30,
    IfNoneMatch = 31,
    IfRange = 32,
    IfUnmodifiedSince = 33,
    KeepAlive = 3,
    LastModified = 19,
    MaxForwards = 34,
    Pragma = 4,
    ProxyAuthorization = 35,
    Range = 37,
    Referer = 36,
    Te = 38,
    Trailer = 5,
    TransferEncoding = 6,
    Translate = 39,
    Upgrade = 7,
    UserAgent = 40,
    Via = 8,
    Warning = 9,
  }

  public enum HttpResponseHeader {
    AcceptRanges = 20,
    Age = 21,
    Allow = 10,
    CacheControl = 0,
    Connection = 1,
    ContentEncoding = 13,
    ContentLanguage = 14,
    ContentLength = 11,
    ContentLocation = 15,
    ContentMd5 = 16,
    ContentRange = 17,
    ContentType = 12,
    Date = 2,
    ETag = 22,
    Expires = 18,
    KeepAlive = 3,
    LastModified = 19,
    Location = 23,
    Pragma = 4,
    ProxyAuthenticate = 24,
    RetryAfter = 25,
    Server = 26,
    SetCookie = 27,
    Trailer = 5,
    TransferEncoding = 6,
    Upgrade = 7,
    Vary = 28,
    Via = 8,
    Warning = 9,
    WwwAuthenticate = 29,
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class WebHeaderCollection : System.Collections.Specialized.NameValueCollection, System.Runtime.Serialization.ISerializable {
    public WebHeaderCollection() { }
    protected WebHeaderCollection(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public override string[] AllKeys { get { return default(string[]); } }
    public override int Count { get { return default(int); } }
    public string this[System.Net.HttpRequestHeader header] { get { return default(string); } set { } }
    public string this[System.Net.HttpResponseHeader header] { get { return default(string); } set { } }
    public override System.Collections.Specialized.NameObjectCollectionBase.KeysCollection Keys { get { return default(System.Collections.Specialized.NameObjectCollectionBase.KeysCollection); } }
    public void Add(System.Net.HttpRequestHeader header, string value) { }
    public void Add(System.Net.HttpResponseHeader header, string value) { }
    public void Add(string header) { }
    public override void Add(string name, string value) { }
    protected void AddWithoutValidate(string headerName, string headerValue) { }
    public override void Clear() { }
    public override string Get(int index) { return default(string); }
    public override string Get(string name) { return default(string); }
    public override System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public override string GetKey(int index) { return default(string); }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public override string[] GetValues(int index) { return default(string[]); }
    public override string[] GetValues(string header) { return default(string[]); }
    public static bool IsRestricted(string headerName) { return default(bool); }
    public static bool IsRestricted(string headerName, bool response) { return default(bool); }
    public override void OnDeserialization(object sender) { }
    public void Remove(System.Net.HttpRequestHeader header) { }
    public void Remove(System.Net.HttpResponseHeader header) { }
    public override void Remove(string name) { }
    public void Set(System.Net.HttpRequestHeader header, string value) { }
    public void Set(System.Net.HttpResponseHeader header, string value) { }
    public override void Set(string name, string value) { }
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public byte[] ToByteArray() { return default(byte[]); }
    public override string ToString() { return default(string); }
  }

} // end of System.Net
