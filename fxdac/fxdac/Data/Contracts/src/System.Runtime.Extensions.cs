[assembly:System.CLSCompliant(true)]
namespace System {
    public sealed partial class ApplicationId
    {
        public ApplicationId(byte[] publicKeyToken, string name, System.Version version, string processorArchitecture, string culture) { }
        public string Culture { get { return default(string); } }
        public string Name { get { return default(string); } }
        public string ProcessorArchitecture { get { return default(string); } }
        public byte[] PublicKeyToken { get { return default(byte[]); } }
        public System.Version Version { get { return default(System.Version); } }
        public System.ApplicationId Copy() { return default(System.ApplicationId); }
        public override bool Equals(object o) { return default(bool); }
        public override int GetHashCode() { return default(int); }
        public override string ToString() { return default(string); }
    }
    public sealed partial class ApplicationIdentity : System.Runtime.Serialization.ISerializable
    {
        public ApplicationIdentity(string applicationIdentityFullName) { }
        public string CodeBase { get { return default(string); } }
        public string FullName { get { return default(string); } }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override string ToString() { return default(string); }
    }

    [System.FlagsAttribute]
    public enum Base64FormattingOptions
    {
        InsertLineBreaks = 1,
        None = 0,
    }
    public partial class ContextMarshalException : System.SystemException
    {
        public ContextMarshalException() { }
        protected ContextMarshalException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ContextMarshalException(string message) { }
        public ContextMarshalException(string message, System.Exception inner) { }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(256), Inherited = false)]
    public partial class ContextStaticAttribute : System.Attribute
    {
        public ContextStaticAttribute() { }
    }

    public static partial class Convert
    {
        public static readonly object DBNull;
        public static object ChangeType(object value, System.Type conversionType) { return default(object); }
        public static object ChangeType(object value, System.Type conversionType, System.IFormatProvider provider) { return default(object); }
        public static object ChangeType(object value, System.TypeCode typeCode) { return default(object); }
        public static object ChangeType(object value, System.TypeCode typeCode, System.IFormatProvider provider) { return default(object); }
        public static byte[] FromBase64CharArray(char[] inArray, int offset, int length) { return default(byte[]); }
        public static byte[] FromBase64String(string s) { return default(byte[]); }
        public static System.TypeCode GetTypeCode(object value) { return default(System.TypeCode); }
        public static bool IsDBNull(object value) { return default(bool); }
        public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut) { return default(int); }
        public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut, System.Base64FormattingOptions options) { return default(int); }
        public static string ToBase64String(byte[] inArray) { return default(string); }
        public static string ToBase64String(byte[] inArray, System.Base64FormattingOptions options) { return default(string); }
        public static string ToBase64String(byte[] inArray, int offset, int length) { return default(string); }
        public static string ToBase64String(byte[] inArray, int offset, int length, System.Base64FormattingOptions options) { return default(string); }
        public static bool ToBoolean(bool value) { return default(bool); }
        public static bool ToBoolean(byte value) { return default(bool); }
        public static bool ToBoolean(char value) { return default(bool); }
        public static bool ToBoolean(System.DateTime value) { return default(bool); }
        public static bool ToBoolean(decimal value) { return default(bool); }
        public static bool ToBoolean(double value) { return default(bool); }
        public static bool ToBoolean(short value) { return default(bool); }
        public static bool ToBoolean(int value) { return default(bool); }
        public static bool ToBoolean(long value) { return default(bool); }
        public static bool ToBoolean(object value) { return default(bool); }
        public static bool ToBoolean(object value, System.IFormatProvider provider) { return default(bool); }
        [System.CLSCompliantAttribute(false)]
        public static bool ToBoolean(sbyte value) { return default(bool); }
        public static bool ToBoolean(float value) { return default(bool); }
        public static bool ToBoolean(string value) { return default(bool); }
        public static bool ToBoolean(string value, System.IFormatProvider provider) { return default(bool); }
        [System.CLSCompliantAttribute(false)]
        public static bool ToBoolean(ushort value) { return default(bool); }
        [System.CLSCompliantAttribute(false)]
        public static bool ToBoolean(uint value) { return default(bool); }
        [System.CLSCompliantAttribute(false)]
        public static bool ToBoolean(ulong value) { return default(bool); }
        public static byte ToByte(bool value) { return default(byte); }
        public static byte ToByte(byte value) { return default(byte); }
        public static byte ToByte(char value) { return default(byte); }
        public static byte ToByte(System.DateTime value) { return default(byte); }
        public static byte ToByte(decimal value) { return default(byte); }
        public static byte ToByte(double value) { return default(byte); }
        public static byte ToByte(short value) { return default(byte); }
        public static byte ToByte(int value) { return default(byte); }
        public static byte ToByte(long value) { return default(byte); }
        public static byte ToByte(object value) { return default(byte); }
        public static byte ToByte(object value, System.IFormatProvider provider) { return default(byte); }
        [System.CLSCompliantAttribute(false)]
        public static byte ToByte(sbyte value) { return default(byte); }
        public static byte ToByte(float value) { return default(byte); }
        public static byte ToByte(string value) { return default(byte); }
        public static byte ToByte(string value, System.IFormatProvider provider) { return default(byte); }
        public static byte ToByte(string value, int fromBase) { return default(byte); }
        [System.CLSCompliantAttribute(false)]
        public static byte ToByte(ushort value) { return default(byte); }
        [System.CLSCompliantAttribute(false)]
        public static byte ToByte(uint value) { return default(byte); }
        [System.CLSCompliantAttribute(false)]
        public static byte ToByte(ulong value) { return default(byte); }
        public static char ToChar(bool value) { return default(char); }
        public static char ToChar(byte value) { return default(char); }
        public static char ToChar(char value) { return default(char); }
        public static char ToChar(System.DateTime value) { return default(char); }
        public static char ToChar(decimal value) { return default(char); }
        public static char ToChar(double value) { return default(char); }
        public static char ToChar(short value) { return default(char); }
        public static char ToChar(int value) { return default(char); }
        public static char ToChar(long value) { return default(char); }
        public static char ToChar(object value) { return default(char); }
        public static char ToChar(object value, System.IFormatProvider provider) { return default(char); }
        [System.CLSCompliantAttribute(false)]
        public static char ToChar(sbyte value) { return default(char); }
        public static char ToChar(float value) { return default(char); }
        public static char ToChar(string value) { return default(char); }
        public static char ToChar(string value, System.IFormatProvider provider) { return default(char); }
        [System.CLSCompliantAttribute(false)]
        public static char ToChar(ushort value) { return default(char); }
        [System.CLSCompliantAttribute(false)]
        public static char ToChar(uint value) { return default(char); }
        [System.CLSCompliantAttribute(false)]
        public static char ToChar(ulong value) { return default(char); }
        public static System.DateTime ToDateTime(bool value) { return default(System.DateTime); }
        public static System.DateTime ToDateTime(byte value) { return default(System.DateTime); }
        public static System.DateTime ToDateTime(char value) { return default(System.DateTime); }
        public static System.DateTime ToDateTime(System.DateTime value) { return default(System.DateTime); }
        public static System.DateTime ToDateTime(decimal value) { return default(System.DateTime); }
        public static System.DateTime ToDateTime(double value) { return default(System.DateTime); }
        public static System.DateTime ToDateTime(short value) { return default(System.DateTime); }
        public static System.DateTime ToDateTime(int value) { return default(System.DateTime); }
        public static System.DateTime ToDateTime(long value) { return default(System.DateTime); }
        public static System.DateTime ToDateTime(object value) { return default(System.DateTime); }
        public static System.DateTime ToDateTime(object value, System.IFormatProvider provider) { return default(System.DateTime); }
        [System.CLSCompliantAttribute(false)]
        public static System.DateTime ToDateTime(sbyte value) { return default(System.DateTime); }
        public static System.DateTime ToDateTime(float value) { return default(System.DateTime); }
        public static System.DateTime ToDateTime(string value) { return default(System.DateTime); }
        public static System.DateTime ToDateTime(string value, System.IFormatProvider provider) { return default(System.DateTime); }
        [System.CLSCompliantAttribute(false)]
        public static System.DateTime ToDateTime(ushort value) { return default(System.DateTime); }
        [System.CLSCompliantAttribute(false)]
        public static System.DateTime ToDateTime(uint value) { return default(System.DateTime); }
        [System.CLSCompliantAttribute(false)]
        public static System.DateTime ToDateTime(ulong value) { return default(System.DateTime); }
        public static decimal ToDecimal(bool value) { return default(decimal); }
        public static decimal ToDecimal(byte value) { return default(decimal); }
        public static decimal ToDecimal(char value) { return default(decimal); }
        public static decimal ToDecimal(System.DateTime value) { return default(decimal); }
        public static decimal ToDecimal(decimal value) { return default(decimal); }
        public static decimal ToDecimal(double value) { return default(decimal); }
        public static decimal ToDecimal(short value) { return default(decimal); }
        public static decimal ToDecimal(int value) { return default(decimal); }
        public static decimal ToDecimal(long value) { return default(decimal); }
        public static decimal ToDecimal(object value) { return default(decimal); }
        public static decimal ToDecimal(object value, System.IFormatProvider provider) { return default(decimal); }
        [System.CLSCompliantAttribute(false)]
        public static decimal ToDecimal(sbyte value) { return default(decimal); }
        public static decimal ToDecimal(float value) { return default(decimal); }
        public static decimal ToDecimal(string value) { return default(decimal); }
        public static decimal ToDecimal(string value, System.IFormatProvider provider) { return default(decimal); }
        [System.CLSCompliantAttribute(false)]
        public static decimal ToDecimal(ushort value) { return default(decimal); }
        [System.CLSCompliantAttribute(false)]
        public static decimal ToDecimal(uint value) { return default(decimal); }
        [System.CLSCompliantAttribute(false)]
        public static decimal ToDecimal(ulong value) { return default(decimal); }
        public static double ToDouble(bool value) { return default(double); }
        public static double ToDouble(byte value) { return default(double); }
        public static double ToDouble(char value) { return default(double); }
        public static double ToDouble(System.DateTime value) { return default(double); }
        public static double ToDouble(decimal value) { return default(double); }
        public static double ToDouble(double value) { return default(double); }
        public static double ToDouble(short value) { return default(double); }
        public static double ToDouble(int value) { return default(double); }
        public static double ToDouble(long value) { return default(double); }
        public static double ToDouble(object value) { return default(double); }
        public static double ToDouble(object value, System.IFormatProvider provider) { return default(double); }
        [System.CLSCompliantAttribute(false)]
        public static double ToDouble(sbyte value) { return default(double); }
        public static double ToDouble(float value) { return default(double); }
        public static double ToDouble(string value) { return default(double); }
        public static double ToDouble(string value, System.IFormatProvider provider) { return default(double); }
        [System.CLSCompliantAttribute(false)]
        public static double ToDouble(ushort value) { return default(double); }
        [System.CLSCompliantAttribute(false)]
        public static double ToDouble(uint value) { return default(double); }
        [System.CLSCompliantAttribute(false)]
        public static double ToDouble(ulong value) { return default(double); }
        public static short ToInt16(bool value) { return default(short); }
        public static short ToInt16(byte value) { return default(short); }
        public static short ToInt16(char value) { return default(short); }
        public static short ToInt16(System.DateTime value) { return default(short); }
        public static short ToInt16(decimal value) { return default(short); }
        public static short ToInt16(double value) { return default(short); }
        public static short ToInt16(short value) { return default(short); }
        public static short ToInt16(int value) { return default(short); }
        public static short ToInt16(long value) { return default(short); }
        public static short ToInt16(object value) { return default(short); }
        public static short ToInt16(object value, System.IFormatProvider provider) { return default(short); }
        [System.CLSCompliantAttribute(false)]
        public static short ToInt16(sbyte value) { return default(short); }
        public static short ToInt16(float value) { return default(short); }
        public static short ToInt16(string value) { return default(short); }
        public static short ToInt16(string value, System.IFormatProvider provider) { return default(short); }
        public static short ToInt16(string value, int fromBase) { return default(short); }
        [System.CLSCompliantAttribute(false)]
        public static short ToInt16(ushort value) { return default(short); }
        [System.CLSCompliantAttribute(false)]
        public static short ToInt16(uint value) { return default(short); }
        [System.CLSCompliantAttribute(false)]
        public static short ToInt16(ulong value) { return default(short); }
        public static int ToInt32(bool value) { return default(int); }
        public static int ToInt32(byte value) { return default(int); }
        public static int ToInt32(char value) { return default(int); }
        public static int ToInt32(System.DateTime value) { return default(int); }
        public static int ToInt32(decimal value) { return default(int); }
        public static int ToInt32(double value) { return default(int); }
        public static int ToInt32(short value) { return default(int); }
        public static int ToInt32(int value) { return default(int); }
        public static int ToInt32(long value) { return default(int); }
        public static int ToInt32(object value) { return default(int); }
        public static int ToInt32(object value, System.IFormatProvider provider) { return default(int); }
        [System.CLSCompliantAttribute(false)]
        public static int ToInt32(sbyte value) { return default(int); }
        public static int ToInt32(float value) { return default(int); }
        public static int ToInt32(string value) { return default(int); }
        public static int ToInt32(string value, System.IFormatProvider provider) { return default(int); }
        public static int ToInt32(string value, int fromBase) { return default(int); }
        [System.CLSCompliantAttribute(false)]
        public static int ToInt32(ushort value) { return default(int); }
        [System.CLSCompliantAttribute(false)]
        public static int ToInt32(uint value) { return default(int); }
        [System.CLSCompliantAttribute(false)]
        public static int ToInt32(ulong value) { return default(int); }
        public static long ToInt64(bool value) { return default(long); }
        public static long ToInt64(byte value) { return default(long); }
        public static long ToInt64(char value) { return default(long); }
        public static long ToInt64(System.DateTime value) { return default(long); }
        public static long ToInt64(decimal value) { return default(long); }
        public static long ToInt64(double value) { return default(long); }
        public static long ToInt64(short value) { return default(long); }
        public static long ToInt64(int value) { return default(long); }
        public static long ToInt64(long value) { return default(long); }
        public static long ToInt64(object value) { return default(long); }
        public static long ToInt64(object value, System.IFormatProvider provider) { return default(long); }
        [System.CLSCompliantAttribute(false)]
        public static long ToInt64(sbyte value) { return default(long); }
        public static long ToInt64(float value) { return default(long); }
        public static long ToInt64(string value) { return default(long); }
        public static long ToInt64(string value, System.IFormatProvider provider) { return default(long); }
        public static long ToInt64(string value, int fromBase) { return default(long); }
        [System.CLSCompliantAttribute(false)]
        public static long ToInt64(ushort value) { return default(long); }
        [System.CLSCompliantAttribute(false)]
        public static long ToInt64(uint value) { return default(long); }
        [System.CLSCompliantAttribute(false)]
        public static long ToInt64(ulong value) { return default(long); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(bool value) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(byte value) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(char value) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(System.DateTime value) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(decimal value) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(double value) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(short value) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(int value) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(long value) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(object value) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(object value, System.IFormatProvider provider) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(sbyte value) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(float value) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(string value) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(string value, System.IFormatProvider provider) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(string value, int fromBase) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(ushort value) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(uint value) { return default(sbyte); }
        [System.CLSCompliantAttribute(false)]
        public static sbyte ToSByte(ulong value) { return default(sbyte); }
        public static float ToSingle(bool value) { return default(float); }
        public static float ToSingle(byte value) { return default(float); }
        public static float ToSingle(char value) { return default(float); }
        public static float ToSingle(System.DateTime value) { return default(float); }
        public static float ToSingle(decimal value) { return default(float); }
        public static float ToSingle(double value) { return default(float); }
        public static float ToSingle(short value) { return default(float); }
        public static float ToSingle(int value) { return default(float); }
        public static float ToSingle(long value) { return default(float); }
        public static float ToSingle(object value) { return default(float); }
        public static float ToSingle(object value, System.IFormatProvider provider) { return default(float); }
        [System.CLSCompliantAttribute(false)]
        public static float ToSingle(sbyte value) { return default(float); }
        public static float ToSingle(float value) { return default(float); }
        public static float ToSingle(string value) { return default(float); }
        public static float ToSingle(string value, System.IFormatProvider provider) { return default(float); }
        [System.CLSCompliantAttribute(false)]
        public static float ToSingle(ushort value) { return default(float); }
        [System.CLSCompliantAttribute(false)]
        public static float ToSingle(uint value) { return default(float); }
        [System.CLSCompliantAttribute(false)]
        public static float ToSingle(ulong value) { return default(float); }
        public static string ToString(bool value) { return default(string); }
        public static string ToString(bool value, System.IFormatProvider provider) { return default(string); }
        public static string ToString(byte value) { return default(string); }
        public static string ToString(byte value, System.IFormatProvider provider) { return default(string); }
        public static string ToString(byte value, int toBase) { return default(string); }
        public static string ToString(char value) { return default(string); }
        public static string ToString(char value, System.IFormatProvider provider) { return default(string); }
        public static string ToString(System.DateTime value) { return default(string); }
        public static string ToString(System.DateTime value, System.IFormatProvider provider) { return default(string); }
        public static string ToString(decimal value) { return default(string); }
        public static string ToString(decimal value, System.IFormatProvider provider) { return default(string); }
        public static string ToString(double value) { return default(string); }
        public static string ToString(double value, System.IFormatProvider provider) { return default(string); }
        public static string ToString(short value) { return default(string); }
        public static string ToString(short value, System.IFormatProvider provider) { return default(string); }
        public static string ToString(short value, int toBase) { return default(string); }
        public static string ToString(int value) { return default(string); }
        public static string ToString(int value, System.IFormatProvider provider) { return default(string); }
        public static string ToString(int value, int toBase) { return default(string); }
        public static string ToString(long value) { return default(string); }
        public static string ToString(long value, System.IFormatProvider provider) { return default(string); }
        public static string ToString(long value, int toBase) { return default(string); }
        public static string ToString(object value) { return default(string); }
        public static string ToString(object value, System.IFormatProvider provider) { return default(string); }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(sbyte value) { return default(string); }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(sbyte value, System.IFormatProvider provider) { return default(string); }
        public static string ToString(float value) { return default(string); }
        public static string ToString(float value, System.IFormatProvider provider) { return default(string); }
        public static string ToString(string value) { return default(string); }
        public static string ToString(string value, System.IFormatProvider provider) { return default(string); }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(ushort value) { return default(string); }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(ushort value, System.IFormatProvider provider) { return default(string); }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(uint value) { return default(string); }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(uint value, System.IFormatProvider provider) { return default(string); }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(ulong value) { return default(string); }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(ulong value, System.IFormatProvider provider) { return default(string); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(bool value) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(byte value) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(char value) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(System.DateTime value) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(decimal value) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(double value) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(short value) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(int value) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(long value) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(object value) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(object value, System.IFormatProvider provider) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(sbyte value) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(float value) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(string value) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(string value, System.IFormatProvider provider) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(string value, int fromBase) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(ushort value) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(uint value) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static ushort ToUInt16(ulong value) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(bool value) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(byte value) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(char value) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(System.DateTime value) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(decimal value) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(double value) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(short value) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(int value) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(long value) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(object value) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(object value, System.IFormatProvider provider) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(sbyte value) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(float value) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(string value) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(string value, System.IFormatProvider provider) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(string value, int fromBase) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(ushort value) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(uint value) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static uint ToUInt32(ulong value) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(bool value) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(byte value) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(char value) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(System.DateTime value) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(decimal value) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(double value) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(short value) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(int value) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(long value) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(object value) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(object value, System.IFormatProvider provider) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(sbyte value) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(float value) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(string value) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(string value, System.IFormatProvider provider) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(string value, int fromBase) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(ushort value) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(uint value) { return default(ulong); }
        [System.CLSCompliantAttribute(false)]
        public static ulong ToUInt64(ulong value) { return default(ulong); }
    }
    public static partial class Environment
    {
        public static string CommandLine { get { return default(string); } }
        public static string CurrentDirectory { get { return default(string); } set { } }
        public static int CurrentManagedThreadId { get { return default(int); } }
        public static int ExitCode { get { return default(int); } set { } }
        public static bool HasShutdownStarted { get { return default(bool); } }
        public static bool Is64BitOperatingSystem { get { return default(bool); } }
        public static bool Is64BitProcess { get { return default(bool); } }
        public static string MachineName { get { return default(string); } }
        public static string NewLine { get { return default(string); } }
        public static System.OperatingSystem OSVersion { get { return default(System.OperatingSystem); } }
        public static int ProcessorCount { get { return default(int); } }
        public static string StackTrace { get { return default(string); } }
        public static int SystemPageSize { get { return default(int); } }
        public static int TickCount { get { return default(int); } }
        public static string UserDomainName { get { return default(string); } }
        public static bool UserInteractive { get { return default(bool); } }
        public static string UserName { get { return default(string); } }
        public static System.Version Version { get { return default(System.Version); } }
        public static long WorkingSet { get { return default(long); } }
        public static void Exit(int exitCode) { }
        public static string ExpandEnvironmentVariables(string name) { return default(string); }
        public static void FailFast(string message) { }
        public static void FailFast(string message, System.Exception exception) { }
        public static string[] GetCommandLineArgs() { return default(string[]); }
        public static string GetEnvironmentVariable(string variable) { return default(string); }
        public static System.Collections.IDictionary GetEnvironmentVariables() { return default(System.Collections.IDictionary); }
        public static string GetFolderPath(System.Environment.SpecialFolder folder) { return default(string); }
        public static string GetFolderPath(System.Environment.SpecialFolder folder, System.Environment.SpecialFolderOption option) { return default(string); }
        public static string[] GetLogicalDrives() { return default(string[]); }
        public static void SetEnvironmentVariable(string variable, string value) { }
        public enum SpecialFolder
        {
            AdminTools = 48,
            ApplicationData = 26,
            CDBurning = 59,
            CommonAdminTools = 47,
            CommonApplicationData = 35,
            CommonDesktopDirectory = 25,
            CommonDocuments = 46,
            CommonMusic = 53,
            CommonOemLinks = 58,
            CommonPictures = 54,
            CommonProgramFiles = 43,
            CommonProgramFilesX86 = 44,
            CommonPrograms = 23,
            CommonStartMenu = 22,
            CommonStartup = 24,
            CommonTemplates = 45,
            CommonVideos = 55,
            Cookies = 33,
            Desktop = 0,
            DesktopDirectory = 16,
            Favorites = 6,
            Fonts = 20,
            History = 34,
            InternetCache = 32,
            LocalApplicationData = 28,
            LocalizedResources = 57,
            MyComputer = 17,
            MyDocuments = 5,
            MyMusic = 13,
            MyPictures = 39,
            MyVideos = 14,
            NetworkShortcuts = 19,
            Personal = 5,
            PrinterShortcuts = 27,
            ProgramFiles = 38,
            ProgramFilesX86 = 42,
            Programs = 2,
            Recent = 8,
            Resources = 56,
            SendTo = 9,
            StartMenu = 11,
            Startup = 7,
            System = 37,
            SystemX86 = 41,
            Templates = 21,
            UserProfile = 40,
            Windows = 36,
        }
        public enum SpecialFolderOption
        {
            Create = 32768,
            DoNotVerify = 16384,
            None = 0,
        }
    }
    public enum EnvironmentVariableTarget
    {
        Machine = 2,
        Process = 0,
        User = 1,
    }
    public sealed partial class MulticastNotSupportedException : System.SystemException
    {
        public MulticastNotSupportedException() { }
        public MulticastNotSupportedException(string message) { }
        public MulticastNotSupportedException(string message, System.Exception inner) { }
    }
    public sealed partial class OperatingSystem : System.ICloneable, System.Runtime.Serialization.ISerializable
    {
        public OperatingSystem(System.PlatformID platform, System.Version version) { }
        public System.PlatformID Platform { get { return default(System.PlatformID); } }
        public string ServicePack { get { return default(string); } }
        public System.Version Version { get { return default(System.Version); } }
        public string VersionString { get { return default(string); } }
        public object Clone() { return default(object); }
        public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override string ToString() { return default(string); }
    }
    public enum PlatformID
    {
        MacOSX = 6,
        Unix = 4,
        Win32NT = 2,
        Win32S = 0,
        Win32Windows = 1,
        WinCE = 3,
        Xbox = 5,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct RuntimeArgumentHandle
    {
    }
    public partial class FileStyleUriParser : System.UriParser
    {
        public FileStyleUriParser() { }
    }

    public partial class FtpStyleUriParser : System.UriParser
    {
        public FtpStyleUriParser() { }
    }

    public partial class GenericUriParser : System.UriParser
    {
        public GenericUriParser(System.GenericUriParserOptions options) { }
    }

    [System.FlagsAttribute]
    public enum GenericUriParserOptions
    {
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

    public partial class HttpStyleUriParser : System.UriParser
    {
        public HttpStyleUriParser() { }
    }
    public partial class NetPipeStyleUriParser : System.UriParser
    {
        public NetPipeStyleUriParser() { }
    }
    public partial class NetTcpStyleUriParser : System.UriParser
    {
        public NetTcpStyleUriParser() { }
    }
    public partial class NewsStyleUriParser : System.UriParser
    {
        public NewsStyleUriParser() { }
    }

    public partial class UriBuilder
    {
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

    public enum UriIdnScope
    {
        All = 2,
        AllExceptIntranet = 1,
        None = 0,
    }

    public abstract partial class UriParser
    {
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
namespace System.IO {
    public static partial class Path
    {
        public static readonly char AltDirectorySeparatorChar;
        public static readonly char DirectorySeparatorChar;
        [System.ObsoleteAttribute("see GetInvalidPathChars and GetInvalidFileNameChars methods.")]
        public static readonly char[] InvalidPathChars;
        public static readonly char PathSeparator;
        public static readonly char VolumeSeparatorChar;
        public static string ChangeExtension(string path, string extension) { return default(string); }
        public static string Combine(string path1, string path2) { return default(string); }
        public static string Combine(string path1, string path2, string path3) { return default(string); }
        public static string Combine(string path1, string path2, string path3, string path4) { return default(string); }
        public static string Combine(params string[] paths) { return default(string); }
        public static string GetDirectoryName(string path) { return default(string); }
        public static string GetExtension(string path) { return default(string); }
        public static string GetFileName(string path) { return default(string); }
        public static string GetFileNameWithoutExtension(string path) { return default(string); }
        public static string GetFullPath(string path) { return default(string); }
        public static char[] GetInvalidFileNameChars() { return default(char[]); }
        public static char[] GetInvalidPathChars() { return default(char[]); }
        public static string GetPathRoot(string path) { return default(string); }
        public static string GetRandomFileName() { return default(string); }
        public static string GetTempFileName() { return default(string); }
        public static string GetTempPath() { return default(string); }
        public static bool HasExtension(string path) { return default(bool); }
        public static bool IsPathRooted(string path) { return default(bool); }
    }
} // end of System.IO
namespace System.Runtime {
    [System.AttributeUsageAttribute((System.AttributeTargets)(1), Inherited = false)]
    public sealed partial class AssemblyTargetedPatchBandAttribute : System.Attribute
    {
        public AssemblyTargetedPatchBandAttribute(string targetedPatchBand) { }
        public string TargetedPatchBand { get { return default(string); } }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(96), AllowMultiple = false, Inherited = false)]
    public sealed partial class TargetedPatchingOptOutAttribute : System.Attribute
    {
        public TargetedPatchingOptOutAttribute(string reason) { }
        public string Reason { get { return default(string); } }
    }
} // end of System.Runtime
namespace System.Net {

    public static partial class WebUtility
    {
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
