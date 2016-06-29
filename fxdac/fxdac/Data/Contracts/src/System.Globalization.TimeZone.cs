[assembly:System.CLSCompliant(true)]
namespace System {
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
} // end of System
namespace System.Globalization {
    public partial class DaylightTime
    {
        public DaylightTime(System.DateTime start, System.DateTime end, System.TimeSpan delta) { }
        public System.TimeSpan Delta { get { return default(System.TimeSpan); } }
        public System.DateTime End { get { return default(System.DateTime); } }
        public System.DateTime Start { get { return default(System.DateTime); } }
    }
} // end of System.Globalization
