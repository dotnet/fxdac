[assembly:System.CLSCompliant(true)]
namespace System.Text {
    public abstract partial class Decoder
    {
        protected Decoder() { }
        public System.Text.DecoderFallback Fallback { get { return default(System.Text.DecoderFallback); } set { } }
        public System.Text.DecoderFallbackBuffer FallbackBuffer { get { return default(System.Text.DecoderFallbackBuffer); } }
        [System.CLSCompliantAttribute(false)]
        public unsafe virtual void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { bytesUsed = default(int); charsUsed = default(int); completed = default(bool); }
        public virtual void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { bytesUsed = default(int); charsUsed = default(int); completed = default(bool); }
        [System.CLSCompliantAttribute(false)]
        public unsafe virtual int GetCharCount(byte* bytes, int count, bool flush) { return default(int); }
        public abstract int GetCharCount(byte[] bytes, int index, int count);
        public virtual int GetCharCount(byte[] bytes, int index, int count, bool flush) { return default(int); }
        [System.CLSCompliantAttribute(false)]
        public unsafe virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { return default(int); }
        public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
        public virtual int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { return default(int); }
        public virtual void Reset() { }
    }

    public sealed partial class DecoderExceptionFallback : System.Text.DecoderFallback
    {
        public DecoderExceptionFallback() { }
        public override int MaxCharCount { get { return default(int); } }
        public override System.Text.DecoderFallbackBuffer CreateFallbackBuffer() { return default(System.Text.DecoderFallbackBuffer); }
        public override bool Equals(object value) { return default(bool); }
        public override int GetHashCode() { return default(int); }
    }

    public sealed partial class DecoderExceptionFallbackBuffer : System.Text.DecoderFallbackBuffer
    {
        public DecoderExceptionFallbackBuffer() { }
        public override int Remaining { get { return default(int); } }
        public override bool Fallback(byte[] bytesUnknown, int index) { return default(bool); }
        public override char GetNextChar() { return default(char); }
        public override bool MovePrevious() { return default(bool); }
    }

    public abstract partial class DecoderFallback
    {
        protected DecoderFallback() { }
        public static System.Text.DecoderFallback ExceptionFallback { get { return default(System.Text.DecoderFallback); } }
        public abstract int MaxCharCount { get; }
        public static System.Text.DecoderFallback ReplacementFallback { get { return default(System.Text.DecoderFallback); } }
        public abstract System.Text.DecoderFallbackBuffer CreateFallbackBuffer();
    }

    public abstract partial class DecoderFallbackBuffer
    {
        protected DecoderFallbackBuffer() { }
        public abstract int Remaining { get; }
        public abstract bool Fallback(byte[] bytesUnknown, int index);
        public abstract char GetNextChar();
        public abstract bool MovePrevious();
        public virtual void Reset() { }
    }

    public sealed partial class DecoderFallbackException : System.ArgumentException
    {
        public DecoderFallbackException() { }
        public DecoderFallbackException(string message) { }
        public DecoderFallbackException(string message, byte[] bytesUnknown, int index) { }
        public DecoderFallbackException(string message, System.Exception innerException) { }
        public byte[] BytesUnknown { get { return default(byte[]); } }
        public int Index { get { return default(int); } }
    }

    public sealed partial class DecoderReplacementFallback : System.Text.DecoderFallback
    {
        public DecoderReplacementFallback() { }
        public DecoderReplacementFallback(string replacement) { }
        public string DefaultString { get { return default(string); } }
        public override int MaxCharCount { get { return default(int); } }
        public override System.Text.DecoderFallbackBuffer CreateFallbackBuffer() { return default(System.Text.DecoderFallbackBuffer); }
        public override bool Equals(object value) { return default(bool); }
        public override int GetHashCode() { return default(int); }
    }

    public sealed partial class DecoderReplacementFallbackBuffer : System.Text.DecoderFallbackBuffer
    {
        public DecoderReplacementFallbackBuffer(System.Text.DecoderReplacementFallback fallback) { }
        public override int Remaining { get { return default(int); } }
        public override bool Fallback(byte[] bytesUnknown, int index) { return default(bool); }
        public override char GetNextChar() { return default(char); }
        public override bool MovePrevious() { return default(bool); }
        public override void Reset() { }
    }
    public abstract partial class Encoder
    {
        protected Encoder() { }
        public System.Text.EncoderFallback Fallback { get { return default(System.Text.EncoderFallback); } set { } }
        public System.Text.EncoderFallbackBuffer FallbackBuffer { get { return default(System.Text.EncoderFallbackBuffer); } }
        [System.CLSCompliantAttribute(false)]
        public unsafe virtual void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { charsUsed = default(int); bytesUsed = default(int); completed = default(bool); }
        public virtual void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { charsUsed = default(int); bytesUsed = default(int); completed = default(bool); }
        [System.CLSCompliantAttribute(false)]
        public unsafe virtual int GetByteCount(char* chars, int count, bool flush) { return default(int); }
        public abstract int GetByteCount(char[] chars, int index, int count, bool flush);
        [System.CLSCompliantAttribute(false)]
        public unsafe virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { return default(int); }
        public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush);
        public virtual void Reset() { }
    }

    public sealed partial class EncoderExceptionFallback : System.Text.EncoderFallback
    {
        public EncoderExceptionFallback() { }
        public override int MaxCharCount { get { return default(int); } }
        public override System.Text.EncoderFallbackBuffer CreateFallbackBuffer() { return default(System.Text.EncoderFallbackBuffer); }
        public override bool Equals(object value) { return default(bool); }
        public override int GetHashCode() { return default(int); }
    }

    public sealed partial class EncoderExceptionFallbackBuffer : System.Text.EncoderFallbackBuffer
    {
        public EncoderExceptionFallbackBuffer() { }
        public override int Remaining { get { return default(int); } }
        public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { return default(bool); }
        public override bool Fallback(char charUnknown, int index) { return default(bool); }
        public override char GetNextChar() { return default(char); }
        public override bool MovePrevious() { return default(bool); }
    }

    public abstract partial class EncoderFallback
    {
        protected EncoderFallback() { }
        public static System.Text.EncoderFallback ExceptionFallback { get { return default(System.Text.EncoderFallback); } }
        public abstract int MaxCharCount { get; }
        public static System.Text.EncoderFallback ReplacementFallback { get { return default(System.Text.EncoderFallback); } }
        public abstract System.Text.EncoderFallbackBuffer CreateFallbackBuffer();
    }

    public abstract partial class EncoderFallbackBuffer
    {
        protected EncoderFallbackBuffer() { }
        public abstract int Remaining { get; }
        public abstract bool Fallback(char charUnknownHigh, char charUnknownLow, int index);
        public abstract bool Fallback(char charUnknown, int index);
        public abstract char GetNextChar();
        public abstract bool MovePrevious();
        public virtual void Reset() { }
    }

    public sealed partial class EncoderFallbackException : System.ArgumentException
    {
        public EncoderFallbackException() { }
        public EncoderFallbackException(string message) { }
        public EncoderFallbackException(string message, System.Exception innerException) { }
        public char CharUnknown { get { return default(char); } }
        public char CharUnknownHigh { get { return default(char); } }
        public char CharUnknownLow { get { return default(char); } }
        public int Index { get { return default(int); } }
        public bool IsUnknownSurrogate() { return default(bool); }
    }

    public sealed partial class EncoderReplacementFallback : System.Text.EncoderFallback
    {
        public EncoderReplacementFallback() { }
        public EncoderReplacementFallback(string replacement) { }
        public string DefaultString { get { return default(string); } }
        public override int MaxCharCount { get { return default(int); } }
        public override System.Text.EncoderFallbackBuffer CreateFallbackBuffer() { return default(System.Text.EncoderFallbackBuffer); }
        public override bool Equals(object value) { return default(bool); }
        public override int GetHashCode() { return default(int); }
    }

    public sealed partial class EncoderReplacementFallbackBuffer : System.Text.EncoderFallbackBuffer
    {
        public EncoderReplacementFallbackBuffer(System.Text.EncoderReplacementFallback fallback) { }
        public override int Remaining { get { return default(int); } }
        public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { return default(bool); }
        public override bool Fallback(char charUnknown, int index) { return default(bool); }
        public override char GetNextChar() { return default(char); }
        public override bool MovePrevious() { return default(bool); }
        public override void Reset() { }
    }
    public abstract partial class Encoding : System.ICloneable
    {
        protected Encoding() { }
        protected Encoding(int codePage) { }
        public static System.Text.Encoding ASCII { get { return default(System.Text.Encoding); } }
        public static System.Text.Encoding BigEndianUnicode { get { return default(System.Text.Encoding); } }
        public virtual string BodyName { get { return default(string); } }
        public virtual int CodePage { get { return default(int); } }
        public System.Text.DecoderFallback DecoderFallback { get { return default(System.Text.DecoderFallback); } set { } }
        public static System.Text.Encoding Default { get { return default(System.Text.Encoding); } }
        public System.Text.EncoderFallback EncoderFallback { get { return default(System.Text.EncoderFallback); } set { } }
        public virtual string EncodingName { get { return default(string); } }
        public virtual string HeaderName { get { return default(string); } }
        public virtual bool IsBrowserDisplay { get { return default(bool); } }
        public virtual bool IsBrowserSave { get { return default(bool); } }
        public virtual bool IsMailNewsDisplay { get { return default(bool); } }
        public virtual bool IsMailNewsSave { get { return default(bool); } }
        public bool IsReadOnly { get { return default(bool); } }
        public virtual bool IsSingleByte { get { return default(bool); } }
        public static System.Text.Encoding Unicode { get { return default(System.Text.Encoding); } }
        public static System.Text.Encoding UTF32 { get { return default(System.Text.Encoding); } }
        public static System.Text.Encoding UTF7 { get { return default(System.Text.Encoding); } }
        public static System.Text.Encoding UTF8 { get { return default(System.Text.Encoding); } }
        public virtual string WebName { get { return default(string); } }
        public virtual int WindowsCodePage { get { return default(int); } }
        public virtual object Clone() { return default(object); }
        public static byte[] Convert(System.Text.Encoding srcEncoding, System.Text.Encoding dstEncoding, byte[] bytes) { return default(byte[]); }
        public static byte[] Convert(System.Text.Encoding srcEncoding, System.Text.Encoding dstEncoding, byte[] bytes, int index, int count) { return default(byte[]); }
        public override bool Equals(object value) { return default(bool); }
        [System.CLSCompliantAttribute(false)]
        public unsafe virtual int GetByteCount(char* chars, int count) { return default(int); }
        public virtual int GetByteCount(char[] chars) { return default(int); }
        public abstract int GetByteCount(char[] chars, int index, int count);
        public virtual int GetByteCount(string s) { return default(int); }
        [System.CLSCompliantAttribute(false)]
        public unsafe virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { return default(int); }
        public virtual byte[] GetBytes(char[] chars) { return default(byte[]); }
        public virtual byte[] GetBytes(char[] chars, int index, int count) { return default(byte[]); }
        public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);
        public virtual byte[] GetBytes(string s) { return default(byte[]); }
        public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { return default(int); }
        [System.CLSCompliantAttribute(false)]
        public unsafe virtual int GetCharCount(byte* bytes, int count) { return default(int); }
        public virtual int GetCharCount(byte[] bytes) { return default(int); }
        public abstract int GetCharCount(byte[] bytes, int index, int count);
        [System.CLSCompliantAttribute(false)]
        public unsafe virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { return default(int); }
        public virtual char[] GetChars(byte[] bytes) { return default(char[]); }
        public virtual char[] GetChars(byte[] bytes, int index, int count) { return default(char[]); }
        public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
        public virtual System.Text.Decoder GetDecoder() { return default(System.Text.Decoder); }
        public virtual System.Text.Encoder GetEncoder() { return default(System.Text.Encoder); }
        public static System.Text.Encoding GetEncoding(int codepage) { return default(System.Text.Encoding); }
        public static System.Text.Encoding GetEncoding(int codepage, System.Text.EncoderFallback encoderFallback, System.Text.DecoderFallback decoderFallback) { return default(System.Text.Encoding); }
        public static System.Text.Encoding GetEncoding(string name) { return default(System.Text.Encoding); }
        public static System.Text.Encoding GetEncoding(string name, System.Text.EncoderFallback encoderFallback, System.Text.DecoderFallback decoderFallback) { return default(System.Text.Encoding); }
        public static System.Text.EncodingInfo[] GetEncodings() { return default(System.Text.EncodingInfo[]); }
        public override int GetHashCode() { return default(int); }
        public abstract int GetMaxByteCount(int charCount);
        public abstract int GetMaxCharCount(int byteCount);
        public virtual byte[] GetPreamble() { return default(byte[]); }
        public virtual string GetString(byte[] bytes) { return default(string); }
        public virtual string GetString(byte[] bytes, int index, int count) { return default(string); }
        public bool IsAlwaysNormalized() { return default(bool); }
        public virtual bool IsAlwaysNormalized(System.Text.NormalizationForm form) { return default(bool); }
        protected Encoding(int codePage, System.Text.EncoderFallback encoderFallback, System.Text.DecoderFallback decoderFallback) { }
        [System.CLSCompliantAttribute(false)]
        public unsafe string GetString(byte* bytes, int byteCount) { return default(string); }
        public static void RegisterProvider(System.Text.EncodingProvider provider) { }
    }

    public sealed partial class EncodingInfo
    {
        internal EncodingInfo() { }
        public int CodePage { get { return default(int); } }
        public string DisplayName { get { return default(string); } }
        public string Name { get { return default(string); } }
        public override bool Equals(object value) { return default(bool); }
        public System.Text.Encoding GetEncoding() { return default(System.Text.Encoding); }
        public override int GetHashCode() { return default(int); }
    }
  public abstract partial class EncodingProvider {
    public EncodingProvider() { }
    public abstract System.Text.Encoding GetEncoding(int codepage);
    public virtual System.Text.Encoding GetEncoding(int codepage, System.Text.EncoderFallback encoderFallback, System.Text.DecoderFallback decoderFallback) { return default(System.Text.Encoding); }
    public abstract System.Text.Encoding GetEncoding(string name);
    public virtual System.Text.Encoding GetEncoding(string name, System.Text.EncoderFallback encoderFallback, System.Text.DecoderFallback decoderFallback) { return default(System.Text.Encoding); }
  }
} // end of System.Text
