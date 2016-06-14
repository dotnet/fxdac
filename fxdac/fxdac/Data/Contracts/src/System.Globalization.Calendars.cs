[assembly:System.CLSCompliant(true)]
namespace System.Globalization {

    public partial class ChineseLunisolarCalendar : System.Globalization.EastAsianLunisolarCalendar
    {
        public const int ChineseEra = 1;
        public ChineseLunisolarCalendar() { }
        protected override int DaysInYearBeforeMinSupportedYear { get { return default(int); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int[] Eras { get { return default(int[]); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.DateTime MaxSupportedDateTime { get { return default(System.DateTime); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.DateTime MinSupportedDateTime { get { return default(System.DateTime); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetEra(System.DateTime time) { return default(int); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class EastAsianLunisolarCalendar : System.Globalization.Calendar
    {
        internal EastAsianLunisolarCalendar() { }
        public override System.Globalization.CalendarAlgorithmType AlgorithmType { get { return default(System.Globalization.CalendarAlgorithmType); } }
        public override int TwoDigitYearMax { get { return default(int); } set { } }
        public override System.DateTime AddMonths(System.DateTime time, int months) { return default(System.DateTime); }
        public override System.DateTime AddYears(System.DateTime time, int years) { return default(System.DateTime); }
        public int GetCelestialStem(int sexagenaryYear) { return default(int); }
        public override int GetDayOfMonth(System.DateTime time) { return default(int); }
        public override System.DayOfWeek GetDayOfWeek(System.DateTime time) { return default(System.DayOfWeek); }
        public override int GetDayOfYear(System.DateTime time) { return default(int); }
        public override int GetDaysInMonth(int year, int month, int era) { return default(int); }
        public override int GetDaysInYear(int year, int era) { return default(int); }
        public override int GetLeapMonth(int year, int era) { return default(int); }
        public override int GetMonth(System.DateTime time) { return default(int); }
        public override int GetMonthsInYear(int year, int era) { return default(int); }
        public virtual int GetSexagenaryYear(System.DateTime time) { return default(int); }
        public int GetTerrestrialBranch(int sexagenaryYear) { return default(int); }
        public override int GetYear(System.DateTime time) { return default(int); }
        public override bool IsLeapDay(int year, int month, int day, int era) { return default(bool); }
        public override bool IsLeapMonth(int year, int month, int era) { return default(bool); }
        public override bool IsLeapYear(int year, int era) { return default(bool); }
        public override System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { return default(System.DateTime); }
        public override int ToFourDigitYear(int year) { return default(int); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class GregorianCalendar : System.Globalization.Calendar
    {
        public const int ADEra = 1;
        public GregorianCalendar() { }
        public GregorianCalendar(System.Globalization.GregorianCalendarTypes type) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.Globalization.CalendarAlgorithmType AlgorithmType { get { return default(System.Globalization.CalendarAlgorithmType); } }
        public virtual System.Globalization.GregorianCalendarTypes CalendarType { get { return default(System.Globalization.GregorianCalendarTypes); } set { } }
        public override int[] Eras { get { return default(int[]); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.DateTime MaxSupportedDateTime { get { return default(System.DateTime); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.DateTime MinSupportedDateTime { get { return default(System.DateTime); } }
        public override int TwoDigitYearMax { get { return default(int); } set { } }
        public override System.DateTime AddMonths(System.DateTime time, int months) { return default(System.DateTime); }
        public override System.DateTime AddYears(System.DateTime time, int years) { return default(System.DateTime); }
        public override int GetDayOfMonth(System.DateTime time) { return default(int); }
        public override System.DayOfWeek GetDayOfWeek(System.DateTime time) { return default(System.DayOfWeek); }
        public override int GetDayOfYear(System.DateTime time) { return default(int); }
        public override int GetDaysInMonth(int year, int month, int era) { return default(int); }
        public override int GetDaysInYear(int year, int era) { return default(int); }
        public override int GetEra(System.DateTime time) { return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetLeapMonth(int year, int era) { return default(int); }
        public override int GetMonth(System.DateTime time) { return default(int); }
        public override int GetMonthsInYear(int year, int era) { return default(int); }
        public override int GetYear(System.DateTime time) { return default(int); }
        public override bool IsLeapDay(int year, int month, int day, int era) { return default(bool); }
        public override bool IsLeapMonth(int year, int month, int era) { return default(bool); }
        public override bool IsLeapYear(int year, int era) { return default(bool); }
        public override System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { return default(System.DateTime); }
        public override int ToFourDigitYear(int year) { return default(int); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum GregorianCalendarTypes
    {
        Arabic = 10,
        Localized = 1,
        MiddleEastFrench = 9,
        TransliteratedEnglish = 11,
        TransliteratedFrench = 12,
        USEnglish = 2,
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class HebrewCalendar : System.Globalization.Calendar
    {
        public static readonly int HebrewEra;
        public HebrewCalendar() { }
        public override System.Globalization.CalendarAlgorithmType AlgorithmType { get { return default(System.Globalization.CalendarAlgorithmType); } }
        public override int[] Eras { get { return default(int[]); } }
        public override System.DateTime MaxSupportedDateTime { get { return default(System.DateTime); } }
        public override System.DateTime MinSupportedDateTime { get { return default(System.DateTime); } }
        public override int TwoDigitYearMax { get { return default(int); } set { } }
        public override System.DateTime AddMonths(System.DateTime time, int months) { return default(System.DateTime); }
        public override System.DateTime AddYears(System.DateTime time, int years) { return default(System.DateTime); }
        public override int GetDayOfMonth(System.DateTime time) { return default(int); }
        public override System.DayOfWeek GetDayOfWeek(System.DateTime time) { return default(System.DayOfWeek); }
        public override int GetDayOfYear(System.DateTime time) { return default(int); }
        public override int GetDaysInMonth(int year, int month, int era) { return default(int); }
        public override int GetDaysInYear(int year, int era) { return default(int); }
        public override int GetEra(System.DateTime time) { return default(int); }
        public override int GetLeapMonth(int year, int era) { return default(int); }
        public override int GetMonth(System.DateTime time) { return default(int); }
        public override int GetMonthsInYear(int year, int era) { return default(int); }
        public override int GetYear(System.DateTime time) { return default(int); }
        public override bool IsLeapDay(int year, int month, int day, int era) { return default(bool); }
        public override bool IsLeapMonth(int year, int month, int era) { return default(bool); }
        public override bool IsLeapYear(int year, int era) { return default(bool); }
        public override System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { return default(System.DateTime); }
        public override int ToFourDigitYear(int year) { return default(int); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class HijriCalendar : System.Globalization.Calendar
    {
        public static readonly int HijriEra;
        public HijriCalendar() { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.Globalization.CalendarAlgorithmType AlgorithmType { get { return default(System.Globalization.CalendarAlgorithmType); } }
        protected override int DaysInYearBeforeMinSupportedYear { get { return default(int); } }
        public override int[] Eras { get { return default(int[]); } }
        public int HijriAdjustment { [System.Security.SecuritySafeCriticalAttribute]get { return default(int); } set { } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.DateTime MaxSupportedDateTime { get { return default(System.DateTime); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.DateTime MinSupportedDateTime { get { return default(System.DateTime); } }
        public override int TwoDigitYearMax { get { return default(int); } set { } }
        public override System.DateTime AddMonths(System.DateTime time, int months) { return default(System.DateTime); }
        public override System.DateTime AddYears(System.DateTime time, int years) { return default(System.DateTime); }
        public override int GetDayOfMonth(System.DateTime time) { return default(int); }
        public override System.DayOfWeek GetDayOfWeek(System.DateTime time) { return default(System.DayOfWeek); }
        public override int GetDayOfYear(System.DateTime time) { return default(int); }
        public override int GetDaysInMonth(int year, int month, int era) { return default(int); }
        public override int GetDaysInYear(int year, int era) { return default(int); }
        public override int GetEra(System.DateTime time) { return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetLeapMonth(int year, int era) { return default(int); }
        public override int GetMonth(System.DateTime time) { return default(int); }
        public override int GetMonthsInYear(int year, int era) { return default(int); }
        public override int GetYear(System.DateTime time) { return default(int); }
        public override bool IsLeapDay(int year, int month, int day, int era) { return default(bool); }
        public override bool IsLeapMonth(int year, int month, int era) { return default(bool); }
        public override bool IsLeapYear(int year, int era) { return default(bool); }
        public override System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { return default(System.DateTime); }
        public override int ToFourDigitYear(int year) { return default(int); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class JapaneseCalendar : System.Globalization.Calendar
    {
        public JapaneseCalendar() { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.Globalization.CalendarAlgorithmType AlgorithmType { get { return default(System.Globalization.CalendarAlgorithmType); } }
        public override int[] Eras { get { return default(int[]); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.DateTime MaxSupportedDateTime { get { return default(System.DateTime); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.DateTime MinSupportedDateTime { get { return default(System.DateTime); } }
        public override int TwoDigitYearMax { get { return default(int); } set { } }
        public override System.DateTime AddMonths(System.DateTime time, int months) { return default(System.DateTime); }
        public override System.DateTime AddYears(System.DateTime time, int years) { return default(System.DateTime); }
        public override int GetDayOfMonth(System.DateTime time) { return default(int); }
        public override System.DayOfWeek GetDayOfWeek(System.DateTime time) { return default(System.DayOfWeek); }
        public override int GetDayOfYear(System.DateTime time) { return default(int); }
        public override int GetDaysInMonth(int year, int month, int era) { return default(int); }
        public override int GetDaysInYear(int year, int era) { return default(int); }
        public override int GetEra(System.DateTime time) { return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetLeapMonth(int year, int era) { return default(int); }
        public override int GetMonth(System.DateTime time) { return default(int); }
        public override int GetMonthsInYear(int year, int era) { return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetWeekOfYear(System.DateTime time, System.Globalization.CalendarWeekRule rule, System.DayOfWeek firstDayOfWeek) { return default(int); }
        public override int GetYear(System.DateTime time) { return default(int); }
        public override bool IsLeapDay(int year, int month, int day, int era) { return default(bool); }
        public override bool IsLeapMonth(int year, int month, int era) { return default(bool); }
        public override bool IsLeapYear(int year, int era) { return default(bool); }
        public override System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { return default(System.DateTime); }
        public override int ToFourDigitYear(int year) { return default(int); }
    }

    public partial class JapaneseLunisolarCalendar : System.Globalization.EastAsianLunisolarCalendar
    {
        public const int JapaneseEra = 1;
        public JapaneseLunisolarCalendar() { }
        protected override int DaysInYearBeforeMinSupportedYear { get { return default(int); } }
        public override int[] Eras { get { return default(int[]); } }
        public override System.DateTime MaxSupportedDateTime { get { return default(System.DateTime); } }
        public override System.DateTime MinSupportedDateTime { get { return default(System.DateTime); } }
        public override int GetEra(System.DateTime time) { return default(int); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class JulianCalendar : System.Globalization.Calendar
    {
        public static readonly int JulianEra;
        public JulianCalendar() { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.Globalization.CalendarAlgorithmType AlgorithmType { get { return default(System.Globalization.CalendarAlgorithmType); } }
        public override int[] Eras { get { return default(int[]); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.DateTime MaxSupportedDateTime { get { return default(System.DateTime); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.DateTime MinSupportedDateTime { get { return default(System.DateTime); } }
        public override int TwoDigitYearMax { get { return default(int); } set { } }
        public override System.DateTime AddMonths(System.DateTime time, int months) { return default(System.DateTime); }
        public override System.DateTime AddYears(System.DateTime time, int years) { return default(System.DateTime); }
        public override int GetDayOfMonth(System.DateTime time) { return default(int); }
        public override System.DayOfWeek GetDayOfWeek(System.DateTime time) { return default(System.DayOfWeek); }
        public override int GetDayOfYear(System.DateTime time) { return default(int); }
        public override int GetDaysInMonth(int year, int month, int era) { return default(int); }
        public override int GetDaysInYear(int year, int era) { return default(int); }
        public override int GetEra(System.DateTime time) { return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetLeapMonth(int year, int era) { return default(int); }
        public override int GetMonth(System.DateTime time) { return default(int); }
        public override int GetMonthsInYear(int year, int era) { return default(int); }
        public override int GetYear(System.DateTime time) { return default(int); }
        public override bool IsLeapDay(int year, int month, int day, int era) { return default(bool); }
        public override bool IsLeapMonth(int year, int month, int era) { return default(bool); }
        public override bool IsLeapYear(int year, int era) { return default(bool); }
        public override System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { return default(System.DateTime); }
        public override int ToFourDigitYear(int year) { return default(int); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class KoreanCalendar : System.Globalization.Calendar
    {
        public const int KoreanEra = 1;
        public KoreanCalendar() { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.Globalization.CalendarAlgorithmType AlgorithmType { get { return default(System.Globalization.CalendarAlgorithmType); } }
        public override int[] Eras { get { return default(int[]); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.DateTime MaxSupportedDateTime { get { return default(System.DateTime); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.DateTime MinSupportedDateTime { get { return default(System.DateTime); } }
        public override int TwoDigitYearMax { get { return default(int); } set { } }
        public override System.DateTime AddMonths(System.DateTime time, int months) { return default(System.DateTime); }
        public override System.DateTime AddYears(System.DateTime time, int years) { return default(System.DateTime); }
        public override int GetDayOfMonth(System.DateTime time) { return default(int); }
        public override System.DayOfWeek GetDayOfWeek(System.DateTime time) { return default(System.DayOfWeek); }
        public override int GetDayOfYear(System.DateTime time) { return default(int); }
        public override int GetDaysInMonth(int year, int month, int era) { return default(int); }
        public override int GetDaysInYear(int year, int era) { return default(int); }
        public override int GetEra(System.DateTime time) { return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetLeapMonth(int year, int era) { return default(int); }
        public override int GetMonth(System.DateTime time) { return default(int); }
        public override int GetMonthsInYear(int year, int era) { return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetWeekOfYear(System.DateTime time, System.Globalization.CalendarWeekRule rule, System.DayOfWeek firstDayOfWeek) { return default(int); }
        public override int GetYear(System.DateTime time) { return default(int); }
        public override bool IsLeapDay(int year, int month, int day, int era) { return default(bool); }
        public override bool IsLeapMonth(int year, int month, int era) { return default(bool); }
        public override bool IsLeapYear(int year, int era) { return default(bool); }
        public override System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { return default(System.DateTime); }
        public override int ToFourDigitYear(int year) { return default(int); }
    }

    public partial class KoreanLunisolarCalendar : System.Globalization.EastAsianLunisolarCalendar
    {
        public const int GregorianEra = 1;
        public KoreanLunisolarCalendar() { }
        protected override int DaysInYearBeforeMinSupportedYear { get { return default(int); } }
        public override int[] Eras { get { return default(int[]); } }
        public override System.DateTime MaxSupportedDateTime { get { return default(System.DateTime); } }
        public override System.DateTime MinSupportedDateTime { get { return default(System.DateTime); } }
        public override int GetEra(System.DateTime time) { return default(int); }
    }

    public partial class PersianCalendar : System.Globalization.Calendar
    {
        public static readonly int PersianEra;
        public PersianCalendar() { }
        public override System.Globalization.CalendarAlgorithmType AlgorithmType { get { return default(System.Globalization.CalendarAlgorithmType); } }
        public override int[] Eras { get { return default(int[]); } }
        public override System.DateTime MaxSupportedDateTime { get { return default(System.DateTime); } }
        public override System.DateTime MinSupportedDateTime { get { return default(System.DateTime); } }
        public override int TwoDigitYearMax { get { return default(int); } set { } }
        public override System.DateTime AddMonths(System.DateTime time, int months) { return default(System.DateTime); }
        public override System.DateTime AddYears(System.DateTime time, int years) { return default(System.DateTime); }
        public override int GetDayOfMonth(System.DateTime time) { return default(int); }
        public override System.DayOfWeek GetDayOfWeek(System.DateTime time) { return default(System.DayOfWeek); }
        public override int GetDayOfYear(System.DateTime time) { return default(int); }
        public override int GetDaysInMonth(int year, int month, int era) { return default(int); }
        public override int GetDaysInYear(int year, int era) { return default(int); }
        public override int GetEra(System.DateTime time) { return default(int); }
        public override int GetLeapMonth(int year, int era) { return default(int); }
        public override int GetMonth(System.DateTime time) { return default(int); }
        public override int GetMonthsInYear(int year, int era) { return default(int); }
        public override int GetYear(System.DateTime time) { return default(int); }
        public override bool IsLeapDay(int year, int month, int day, int era) { return default(bool); }
        public override bool IsLeapMonth(int year, int month, int era) { return default(bool); }
        public override bool IsLeapYear(int year, int era) { return default(bool); }
        public override System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { return default(System.DateTime); }
        public override int ToFourDigitYear(int year) { return default(int); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class TaiwanCalendar : System.Globalization.Calendar
    {
        public TaiwanCalendar() { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.Globalization.CalendarAlgorithmType AlgorithmType { get { return default(System.Globalization.CalendarAlgorithmType); } }
        public override int[] Eras { get { return default(int[]); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.DateTime MaxSupportedDateTime { get { return default(System.DateTime); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.DateTime MinSupportedDateTime { get { return default(System.DateTime); } }
        public override int TwoDigitYearMax { get { return default(int); } set { } }
        public override System.DateTime AddMonths(System.DateTime time, int months) { return default(System.DateTime); }
        public override System.DateTime AddYears(System.DateTime time, int years) { return default(System.DateTime); }
        public override int GetDayOfMonth(System.DateTime time) { return default(int); }
        public override System.DayOfWeek GetDayOfWeek(System.DateTime time) { return default(System.DayOfWeek); }
        public override int GetDayOfYear(System.DateTime time) { return default(int); }
        public override int GetDaysInMonth(int year, int month, int era) { return default(int); }
        public override int GetDaysInYear(int year, int era) { return default(int); }
        public override int GetEra(System.DateTime time) { return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetLeapMonth(int year, int era) { return default(int); }
        public override int GetMonth(System.DateTime time) { return default(int); }
        public override int GetMonthsInYear(int year, int era) { return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetWeekOfYear(System.DateTime time, System.Globalization.CalendarWeekRule rule, System.DayOfWeek firstDayOfWeek) { return default(int); }
        public override int GetYear(System.DateTime time) { return default(int); }
        public override bool IsLeapDay(int year, int month, int day, int era) { return default(bool); }
        public override bool IsLeapMonth(int year, int month, int era) { return default(bool); }
        public override bool IsLeapYear(int year, int era) { return default(bool); }
        public override System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { return default(System.DateTime); }
        public override int ToFourDigitYear(int year) { return default(int); }
    }

    public partial class TaiwanLunisolarCalendar : System.Globalization.EastAsianLunisolarCalendar
    {
        public TaiwanLunisolarCalendar() { }
        protected override int DaysInYearBeforeMinSupportedYear { get { return default(int); } }
        public override int[] Eras { get { return default(int[]); } }
        public override System.DateTime MaxSupportedDateTime { get { return default(System.DateTime); } }
        public override System.DateTime MinSupportedDateTime { get { return default(System.DateTime); } }
        public override int GetEra(System.DateTime time) { return default(int); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class ThaiBuddhistCalendar : System.Globalization.Calendar
    {
        public const int ThaiBuddhistEra = 1;
        public ThaiBuddhistCalendar() { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.Globalization.CalendarAlgorithmType AlgorithmType { get { return default(System.Globalization.CalendarAlgorithmType); } }
        public override int[] Eras { get { return default(int[]); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.DateTime MaxSupportedDateTime { get { return default(System.DateTime); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.DateTime MinSupportedDateTime { get { return default(System.DateTime); } }
        public override int TwoDigitYearMax { get { return default(int); } set { } }
        public override System.DateTime AddMonths(System.DateTime time, int months) { return default(System.DateTime); }
        public override System.DateTime AddYears(System.DateTime time, int years) { return default(System.DateTime); }
        public override int GetDayOfMonth(System.DateTime time) { return default(int); }
        public override System.DayOfWeek GetDayOfWeek(System.DateTime time) { return default(System.DayOfWeek); }
        public override int GetDayOfYear(System.DateTime time) { return default(int); }
        public override int GetDaysInMonth(int year, int month, int era) { return default(int); }
        public override int GetDaysInYear(int year, int era) { return default(int); }
        public override int GetEra(System.DateTime time) { return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetLeapMonth(int year, int era) { return default(int); }
        public override int GetMonth(System.DateTime time) { return default(int); }
        public override int GetMonthsInYear(int year, int era) { return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override int GetWeekOfYear(System.DateTime time, System.Globalization.CalendarWeekRule rule, System.DayOfWeek firstDayOfWeek) { return default(int); }
        public override int GetYear(System.DateTime time) { return default(int); }
        public override bool IsLeapDay(int year, int month, int day, int era) { return default(bool); }
        public override bool IsLeapMonth(int year, int month, int era) { return default(bool); }
        public override bool IsLeapYear(int year, int era) { return default(bool); }
        public override System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { return default(System.DateTime); }
        public override int ToFourDigitYear(int year) { return default(int); }
    }

    public partial class UmAlQuraCalendar : System.Globalization.Calendar
    {
        public const int UmAlQuraEra = 1;
        public UmAlQuraCalendar() { }
        public override System.Globalization.CalendarAlgorithmType AlgorithmType { get { return default(System.Globalization.CalendarAlgorithmType); } }
        protected override int DaysInYearBeforeMinSupportedYear { get { return default(int); } }
        public override int[] Eras { get { return default(int[]); } }
        public override System.DateTime MaxSupportedDateTime { get { return default(System.DateTime); } }
        public override System.DateTime MinSupportedDateTime { get { return default(System.DateTime); } }
        public override int TwoDigitYearMax { get { return default(int); } set { } }
        public override System.DateTime AddMonths(System.DateTime time, int months) { return default(System.DateTime); }
        public override System.DateTime AddYears(System.DateTime time, int years) { return default(System.DateTime); }
        public override int GetDayOfMonth(System.DateTime time) { return default(int); }
        public override System.DayOfWeek GetDayOfWeek(System.DateTime time) { return default(System.DayOfWeek); }
        public override int GetDayOfYear(System.DateTime time) { return default(int); }
        public override int GetDaysInMonth(int year, int month, int era) { return default(int); }
        public override int GetDaysInYear(int year, int era) { return default(int); }
        public override int GetEra(System.DateTime time) { return default(int); }
        public override int GetLeapMonth(int year, int era) { return default(int); }
        public override int GetMonth(System.DateTime time) { return default(int); }
        public override int GetMonthsInYear(int year, int era) { return default(int); }
        public override int GetYear(System.DateTime time) { return default(int); }
        public override bool IsLeapDay(int year, int month, int day, int era) { return default(bool); }
        public override bool IsLeapMonth(int year, int month, int era) { return default(bool); }
        public override bool IsLeapYear(int year, int era) { return default(bool); }
        public override System.DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { return default(System.DateTime); }
        public override int ToFourDigitYear(int year) { return default(int); }
    }
} // end of System.Globalization
