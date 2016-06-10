[assembly:System.CLSCompliant(true)]
namespace System.IO {

    public partial class UnmanagedMemoryAccessor : System.IDisposable
    {
        protected UnmanagedMemoryAccessor() { }
        [System.Security.SecuritySafeCriticalAttribute]
        public UnmanagedMemoryAccessor(System.Runtime.InteropServices.SafeBuffer buffer, long offset, long capacity) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public UnmanagedMemoryAccessor(System.Runtime.InteropServices.SafeBuffer buffer, long offset, long capacity, System.IO.FileAccess access) { }
        public bool CanRead { get { return default(bool); } }
        public bool CanWrite { get { return default(bool); } }
        public long Capacity { get { return default(long); } }
        protected bool IsOpen { get { return default(bool); } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        [System.Security.SecuritySafeCriticalAttribute]
        protected void Initialize(System.Runtime.InteropServices.SafeBuffer buffer, long offset, long capacity, System.IO.FileAccess access) { }
        [System.Security.SecurityCriticalAttribute]
        public void Read<T>(long position, out T structure) where T : struct { structure = default(T); }
        [System.Security.SecurityCriticalAttribute]
        public int ReadArray<T>(long position, T[] array, int offset, int count) where T : struct { return default(int); }
        public bool ReadBoolean(long position) { return default(bool); }
        public byte ReadByte(long position) { return default(byte); }
        [System.Security.SecuritySafeCriticalAttribute]
        public char ReadChar(long position) { return default(char); }
        [System.Security.SecuritySafeCriticalAttribute]
        public decimal ReadDecimal(long position) { return default(decimal); }
        [System.Security.SecuritySafeCriticalAttribute]
        public double ReadDouble(long position) { return default(double); }
        [System.Security.SecuritySafeCriticalAttribute]
        public short ReadInt16(long position) { return default(short); }
        [System.Security.SecuritySafeCriticalAttribute]
        public int ReadInt32(long position) { return default(int); }
        [System.Security.SecuritySafeCriticalAttribute]
        public long ReadInt64(long position) { return default(long); }
        [System.CLSCompliantAttribute(false)]
        [System.Security.SecuritySafeCriticalAttribute]
        public sbyte ReadSByte(long position) { return default(sbyte); }
        [System.Security.SecuritySafeCriticalAttribute]
        public float ReadSingle(long position) { return default(float); }
        [System.CLSCompliantAttribute(false)]
        [System.Security.SecuritySafeCriticalAttribute]
        public ushort ReadUInt16(long position) { return default(ushort); }
        [System.CLSCompliantAttribute(false)]
        [System.Security.SecuritySafeCriticalAttribute]
        public uint ReadUInt32(long position) { return default(uint); }
        [System.CLSCompliantAttribute(false)]
        [System.Security.SecuritySafeCriticalAttribute]
        public ulong ReadUInt64(long position) { return default(ulong); }
        public void Write(long position, bool value) { }
        public void Write(long position, byte value) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void Write(long position, char value) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void Write(long position, decimal value) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void Write(long position, double value) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void Write(long position, short value) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void Write(long position, int value) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void Write(long position, long value) { }
        [System.CLSCompliantAttribute(false)]
        [System.Security.SecuritySafeCriticalAttribute]
        public void Write(long position, sbyte value) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void Write(long position, float value) { }
        [System.CLSCompliantAttribute(false)]
        [System.Security.SecuritySafeCriticalAttribute]
        public void Write(long position, ushort value) { }
        [System.CLSCompliantAttribute(false)]
        [System.Security.SecuritySafeCriticalAttribute]
        public void Write(long position, uint value) { }
        [System.CLSCompliantAttribute(false)]
        [System.Security.SecuritySafeCriticalAttribute]
        public void Write(long position, ulong value) { }
        [System.Security.SecurityCriticalAttribute]
        public void Write<T>(long position, ref T structure) where T : struct { }
        [System.Security.SecurityCriticalAttribute]
        public void WriteArray<T>(long position, T[] array, int offset, int count) where T : struct { }
    }


    public partial class UnmanagedMemoryStream : System.IO.Stream
    {
        [System.Security.SecuritySafeCriticalAttribute]
        protected UnmanagedMemoryStream() { }
        [System.CLSCompliantAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe UnmanagedMemoryStream(byte* pointer, long length) { }
        [System.CLSCompliantAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        public unsafe UnmanagedMemoryStream(byte* pointer, long length, long capacity, System.IO.FileAccess access) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public UnmanagedMemoryStream(System.Runtime.InteropServices.SafeBuffer buffer, long offset, long length) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public UnmanagedMemoryStream(System.Runtime.InteropServices.SafeBuffer buffer, long offset, long length, System.IO.FileAccess access) { }
        public override bool CanRead { [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline across NGen image boundaries")]get { return default(bool); } }
        public override bool CanSeek { [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline across NGen image boundaries")]get { return default(bool); } }
        public override bool CanWrite { [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline across NGen image boundaries")]get { return default(bool); } }
        public long Capacity { get { return default(long); } }
        public override long Length { [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline across NGen image boundaries")]get { return default(long); } }
        public override long Position { [System.Runtime.TargetedPatchingOptOutAttribute("Performance critical to inline across NGen image boundaries")]get { return default(long); } [System.Security.SecuritySafeCriticalAttribute]set { } }
        [System.CLSCompliantAttribute(false)]
        public unsafe byte* PositionPointer { [System.Security.SecurityCriticalAttribute]get { return default(byte*); } [System.Security.SecurityCriticalAttribute]set { } }
        [System.Security.SecuritySafeCriticalAttribute]
        protected override void Dispose(bool disposing) { }
        public override void Flush() { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.Threading.Tasks.Task FlushAsync(System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        [System.CLSCompliantAttribute(false)]
        [System.Security.SecurityCriticalAttribute]
        protected unsafe void Initialize(byte* pointer, long length, long capacity, System.IO.FileAccess access) { }
        [System.Security.SecuritySafeCriticalAttribute]
        protected void Initialize(System.Runtime.InteropServices.SafeBuffer buffer, long offset, long length, System.IO.FileAccess access) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int Read(byte[] buffer, int offset, int count) { buffer = default(byte[]); return default(int); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task<int>); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override int ReadByte() { return default(int); }
        public override long Seek(long offset, System.IO.SeekOrigin loc) { return default(long); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override void SetLength(long value) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public override void Write(byte[] buffer, int offset, int count) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken) { return default(System.Threading.Tasks.Task); }
        [System.Security.SecuritySafeCriticalAttribute]
        public override void WriteByte(byte value) { }
    }

} // end of System.IO
