[assembly:System.CLSCompliant(true)]
namespace System.Security {
    public sealed partial class SecureString : System.IDisposable
    {
        public SecureString() { }
        [System.CLSCompliantAttribute(false)]
        public unsafe SecureString(char* value, int length) { }
        public int Length { get { return default(int); } }
        [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
        public void AppendChar(char c) { }
        public void Clear() { }
        public System.Security.SecureString Copy() { return default(System.Security.SecureString); }
        public void Dispose() { }
        [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
        public void InsertAt(int index, char c) { }
        public bool IsReadOnly() { return default(bool); }
        public void MakeReadOnly() { }
        [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
        public void RemoveAt(int index) { }
        [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptionsAttribute]
        public void SetAt(int index, char c) { }
    }
  public static partial class SecureStringMarshal {
    public static System.IntPtr SecureStringToCoTaskMemAnsi(System.Security.SecureString s) { return default(System.IntPtr); }
    public static System.IntPtr SecureStringToCoTaskMemUnicode(System.Security.SecureString s) { return default(System.IntPtr); }
    public static System.IntPtr SecureStringToGlobalAllocAnsi(System.Security.SecureString s) { return default(System.IntPtr); }
    public static System.IntPtr SecureStringToGlobalAllocUnicode(System.Security.SecureString s) { return default(System.IntPtr); }
  }
} // end of System.Security
