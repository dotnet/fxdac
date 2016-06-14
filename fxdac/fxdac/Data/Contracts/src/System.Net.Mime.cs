[assembly:System.CLSCompliant(true)]
namespace System.Net.Mime {
    public partial class ContentDisposition
    {
        public ContentDisposition() { }
        public ContentDisposition(string disposition) { }
        public System.DateTime CreationDate { get { return default(System.DateTime); } set { } }
        public string DispositionType { get { return default(string); } set { } }
        public string FileName { get { return default(string); } set { } }
        public bool Inline { get { return default(bool); } set { } }
        public System.DateTime ModificationDate { get { return default(System.DateTime); } set { } }
        public System.Collections.Specialized.StringDictionary Parameters { get { return default(System.Collections.Specialized.StringDictionary); } }
        public System.DateTime ReadDate { get { return default(System.DateTime); } set { } }
        public long Size { get { return default(long); } set { } }
        public override bool Equals(object obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public override string ToString() { return default(string); }
    }

    public partial class ContentType
    {
        public ContentType() { }
        public ContentType(string contentType) { }
        public string Boundary { get { return default(string); } set { } }
        public string CharSet { get { return default(string); } set { } }
        public string MediaType { get { return default(string); } set { } }
        public string Name { get { return default(string); } set { } }
        public System.Collections.Specialized.StringDictionary Parameters { get { return default(System.Collections.Specialized.StringDictionary); } }
        public override bool Equals(object obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public override string ToString() { return default(string); }
    }

    public static partial class DispositionTypeNames
    {
        public const string Attachment = "attachment";
        public const string Inline = "inline";
    }

    public static partial class MediaTypeNames
    {
        public static partial class Application
        {
            public const string Octet = "application/octet-stream";
            public const string Pdf = "application/pdf";
            public const string Rtf = "application/rtf";
            public const string Soap = "application/soap+xml";
            public const string Zip = "application/zip";
        }
        public static partial class Image
        {
            public const string Gif = "image/gif";
            public const string Jpeg = "image/jpeg";
            public const string Tiff = "image/tiff";
        }
        public static partial class Text
        {
            public const string Html = "text/html";
            public const string Plain = "text/plain";
            public const string RichText = "text/richtext";
            public const string Xml = "text/xml";
        }
    }

    public enum TransferEncoding
    {
        Base64 = 1,
        QuotedPrintable = 0,
        SevenBit = 2,
        Unknown = -1,
    }
} // end of System.Net.Mime
