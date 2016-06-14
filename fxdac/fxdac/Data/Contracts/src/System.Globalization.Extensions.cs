[assembly:System.CLSCompliant(true)]
namespace System.Globalization {

    public sealed partial class IdnMapping
    {
        public IdnMapping() { }
        public bool AllowUnassigned { get { return default(bool); } set { } }
        public bool UseStd3AsciiRules { get { return default(bool); } set { } }
        public override bool Equals(object obj) { return default(bool); }
        public string GetAscii(string unicode) { return default(string); }
        public string GetAscii(string unicode, int index) { return default(string); }
        public string GetAscii(string unicode, int index, int count) { return default(string); }
        public override int GetHashCode() { return default(int); }
        public string GetUnicode(string ascii) { return default(string); }
        public string GetUnicode(string ascii, int index) { return default(string); }
        public string GetUnicode(string ascii, int index, int count) { return default(string); }
    }
  public static partial class GlobalizationExtensions {
    public static System.StringComparer GetStringComparer(this System.Globalization.CompareInfo compareInfo, System.Globalization.CompareOptions options) { return default(System.StringComparer); }
  }
} // end of System.Globalization
namespace System {
  public static partial class StringNormalizationExtensions {
    public static bool IsNormalized(this string value) { return default(bool); }
    [System.Security.SecurityCriticalAttribute]
    public static bool IsNormalized(this string value, System.Text.NormalizationForm normalizationForm) { return default(bool); }
    public static string Normalize(this string value) { return default(string); }
    [System.Security.SecurityCriticalAttribute]
    public static string Normalize(this string value, System.Text.NormalizationForm normalizationForm) { return default(string); }
  }
} // end of System
