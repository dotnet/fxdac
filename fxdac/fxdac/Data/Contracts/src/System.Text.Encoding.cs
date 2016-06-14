[assembly:System.CLSCompliant(true)]
namespace System.Text {

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
        [System.Security.SecuritySafeCriticalAttribute]
        public override void Reset() { }
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
        public override int MaxCharCount { [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline across NGen image boundaries")]get { return default(int); } }
        public override System.Text.EncoderFallbackBuffer CreateFallbackBuffer() { return default(System.Text.EncoderFallbackBuffer); }
        [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline across NGen image boundaries")]
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
        [System.Security.SecuritySafeCriticalAttribute]
        public override void Reset() { }
    }
} // end of System.Text
