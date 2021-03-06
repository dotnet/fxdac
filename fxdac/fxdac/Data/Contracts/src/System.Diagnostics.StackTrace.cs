[assembly:System.CLSCompliant(true)]
namespace System.Diagnostics {
    public partial class StackFrame
    {
        public const int OFFSET_UNKNOWN = -1;
        public StackFrame() { }
        public StackFrame(bool fNeedFileInfo) { }
        public StackFrame(int skipFrames) { }
        public StackFrame(int skipFrames, bool fNeedFileInfo) { }
        public StackFrame(string fileName, int lineNumber) { }
        public StackFrame(string fileName, int lineNumber, int colNumber) { }
        public virtual int GetFileColumnNumber() { return default(int); }
        public virtual int GetFileLineNumber() { return default(int); }
        public virtual string GetFileName() { return default(string); }
        public virtual int GetILOffset() { return default(int); }
        public virtual System.Reflection.MethodBase GetMethod() { return default(System.Reflection.MethodBase); }
        public virtual int GetNativeOffset() { return default(int); }
        public override string ToString() { return default(string); }
    }
    public partial class StackTrace
    {
        public const int METHODS_TO_SKIP = 0;
        public StackTrace() { }
        public StackTrace(bool fNeedFileInfo) { }
        public StackTrace(System.Diagnostics.StackFrame frame) { }
        public StackTrace(System.Exception e) { }
        public StackTrace(System.Exception e, bool fNeedFileInfo) { }
        public StackTrace(System.Exception e, int skipFrames) { }
        public StackTrace(System.Exception e, int skipFrames, bool fNeedFileInfo) { }
        public StackTrace(int skipFrames) { }
        public StackTrace(int skipFrames, bool fNeedFileInfo) { }
        [System.ObsoleteAttribute]
        public StackTrace(System.Threading.Thread targetThread, bool needFileInfo) { }
        public virtual int FrameCount { get { return default(int); } }
        public virtual System.Diagnostics.StackFrame GetFrame(int index) { return default(System.Diagnostics.StackFrame); }
        public virtual System.Diagnostics.StackFrame[] GetFrames() { return default(System.Diagnostics.StackFrame[]); }
        public override string ToString() { return default(string); }
    }
  public static partial class StackFrameExtensions {
    public static System.IntPtr GetNativeImageBase(this System.Diagnostics.StackFrame stackFrame) { return default(System.IntPtr); }
    public static System.IntPtr GetNativeIP(this System.Diagnostics.StackFrame stackFrame) { return default(System.IntPtr); }
    public static bool HasILOffset(this System.Diagnostics.StackFrame stackFrame) { return default(bool); }
    public static bool HasMethod(this System.Diagnostics.StackFrame stackFrame) { return default(bool); }
    public static bool HasNativeImage(this System.Diagnostics.StackFrame stackFrame) { return default(bool); }
    public static bool HasSource(this System.Diagnostics.StackFrame stackFrame) { return default(bool); }
  }
} // end of System.Diagnostics
