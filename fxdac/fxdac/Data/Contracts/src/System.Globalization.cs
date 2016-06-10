[assembly:System.CLSCompliant(true)]
namespace System {

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class TimeZone
    {
        protected TimeZone() { }
        public static System.TimeZone CurrentTimeZone { get { return default(System.TimeZone); } }
        public abstract string DaylightName { get; }
        public abstract string StandardName { get; }
        public abstract System.Globalization.DaylightTime GetDaylightChanges(int year);
        public abstract System.TimeSpan GetUtcOffset(System.DateTime time);
        public virtual bool IsDaylightSavingTime(System.DateTime time) { return default(bool); }
        public static bool IsDaylightSavingTime(System.DateTime time, System.Globalization.DaylightTime daylightTimes) { return default(bool); }
        public virtual System.DateTime ToLocalTime(System.DateTime time) { return default(System.DateTime); }
        public virtual System.DateTime ToUniversalTime(System.DateTime time) { return default(System.DateTime); }
    }


    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
    public partial class TimeZoneNotFoundException : System.Exception
    {
        public TimeZoneNotFoundException() { }
        protected TimeZoneNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public TimeZoneNotFoundException(string message) { }
        public TimeZoneNotFoundException(string message, System.Exception innerException) { }
    }

} // end of System
namespace System.Globalization {

    public static partial class CharUnicodeInfo
    {
        public static int GetDecimalDigitValue(char ch) { return default(int); }
        public static int GetDecimalDigitValue(string s, int index) { return default(int); }
        public static int GetDigitValue(char ch) { return default(int); }
        public static int GetDigitValue(string s, int index) { return default(int); }
        public static double GetNumericValue(char ch) { return default(double); }
        public static double GetNumericValue(string s, int index) { return default(double); }
        public static System.Globalization.UnicodeCategory GetUnicodeCategory(char ch) { return default(System.Globalization.UnicodeCategory); }
        public static System.Globalization.UnicodeCategory GetUnicodeCategory(string s, int index) { return default(System.Globalization.UnicodeCategory); }
    }


    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DaylightTime
    {
        public DaylightTime(System.DateTime start, System.DateTime end, System.TimeSpan delta) { }
        public System.TimeSpan Delta { get { return default(System.TimeSpan); } }
        public System.DateTime End { get { return default(System.DateTime); } }
        public System.DateTime Start { get { return default(System.DateTime); } }
    }


    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class RegionInfo
    {
        public RegionInfo(int culture) { }
        public RegionInfo(string name) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public virtual string CurrencyEnglishName { get { return default(string); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public virtual string CurrencyNativeName { get { return default(string); } }
        public virtual string CurrencySymbol { get { return default(string); } }
        public static System.Globalization.RegionInfo CurrentRegion { get { return default(System.Globalization.RegionInfo); } }
        public virtual string DisplayName { get { return default(string); } }
        public virtual string EnglishName { get { return default(string); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public virtual int GeoId { get { return default(int); } }
        public virtual bool IsMetric { get { return default(bool); } }
        public virtual string ISOCurrencySymbol { get { return default(string); } }
        public virtual string Name { get { return default(string); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public virtual string NativeName { get { return default(string); } }
        public virtual string ThreeLetterISORegionName { get { return default(string); } }
        public virtual string ThreeLetterWindowsRegionName { get { return default(string); } }
        public virtual string TwoLetterISORegionName { get { return default(string); } }
        public override bool Equals(object value) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public override string ToString() { return default(string); }
    }


    public sealed partial class SortVersion : System.IEquatable<System.Globalization.SortVersion>
    {
        public SortVersion(int fullVersion, System.Guid sortId) { }
        public int FullVersion { get { return default(int); } }
        public System.Guid SortId { get { return default(System.Guid); } }
        public bool Equals(System.Globalization.SortVersion other) { return default(bool); }
        public override bool Equals(object obj) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public static bool operator ==(System.Globalization.SortVersion left, System.Globalization.SortVersion right) { return default(bool); }
        public static bool operator !=(System.Globalization.SortVersion left, System.Globalization.SortVersion right) { return default(bool); }
    }


    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class StringInfo
    {
        public StringInfo() { }
        public StringInfo(string value) { }
        public int LengthInTextElements { get { return default(int); } }
        public string String { get { return default(string); } set { } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override bool Equals(object value) { return default(bool); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetHashCode() { return default(int); }
        public static string GetNextTextElement(string str) { return default(string); }
        public static string GetNextTextElement(string str, int index) { return default(string); }
        public static System.Globalization.TextElementEnumerator GetTextElementEnumerator(string str) { return default(System.Globalization.TextElementEnumerator); }
        public static System.Globalization.TextElementEnumerator GetTextElementEnumerator(string str, int index) { return default(System.Globalization.TextElementEnumerator); }
        public static int[] ParseCombiningCharacters(string str) { return default(int[]); }
        public string SubstringByTextElements(int startingTextElement) { return default(string); }
        public string SubstringByTextElements(int startingTextElement, int lengthInTextElements) { return default(string); }
    }


    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class TextElementEnumerator : System.Collections.IEnumerator
    {
        internal TextElementEnumerator() { }
        public object Current { get { return default(object); } }
        public int ElementIndex { get { return default(int); } }
        public string GetTextElement() { return default(string); }
        public bool MoveNext() { return default(bool); }
        public void Reset() { }
    }

} // end of System.Globalization
