[assembly:System.CLSCompliant(true)]
namespace Microsoft.Win32.SafeHandles {
    public abstract partial class CriticalHandleMinusOneIsInvalid : System.Runtime.InteropServices.CriticalHandle
    {
        protected CriticalHandleMinusOneIsInvalid() : base(default(System.IntPtr)) { }
        public override bool IsInvalid { get { return default(bool); } }
    }
    public abstract partial class CriticalHandleZeroOrMinusOneIsInvalid : System.Runtime.InteropServices.CriticalHandle
    {
        protected CriticalHandleZeroOrMinusOneIsInvalid() : base(default(System.IntPtr)) { }
        public override bool IsInvalid { get { return default(bool); } }
    }
} // end of Microsoft.Win32.SafeHandles
