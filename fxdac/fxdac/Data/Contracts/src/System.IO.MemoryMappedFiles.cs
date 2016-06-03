[assembly:System.CLSCompliant(true)]
namespace Microsoft.Win32.SafeHandles {
  public sealed partial class SafeMemoryMappedFileHandle : Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid {
    public SafeMemoryMappedFileHandle(System.IntPtr preexistingHandle, bool ownsHandle) : base (default(bool)) { }
    protected override bool ReleaseHandle() { return default(bool); }
  }

  public sealed partial class SafeMemoryMappedViewHandle : System.Runtime.InteropServices.SafeBuffer {
    internal SafeMemoryMappedViewHandle() : base (default(bool)) { }
    protected override bool ReleaseHandle() { return default(bool); }
  }

} // end of Microsoft.Win32.SafeHandles
namespace System.IO.MemoryMappedFiles {
  public partial class MemoryMappedFile : System.IDisposable {
    internal MemoryMappedFile() { }
    public Microsoft.Win32.SafeHandles.SafeMemoryMappedFileHandle SafeMemoryMappedFileHandle { get { return default(Microsoft.Win32.SafeHandles.SafeMemoryMappedFileHandle); } }
    public static System.IO.MemoryMappedFiles.MemoryMappedFile CreateFromFile(System.IO.FileStream fileStream, string mapName, long capacity, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access, System.IO.MemoryMappedFiles.MemoryMappedFileSecurity memoryMappedFileSecurity, System.IO.HandleInheritability inheritability, bool leaveOpen) { return default(System.IO.MemoryMappedFiles.MemoryMappedFile); }
    public static System.IO.MemoryMappedFiles.MemoryMappedFile CreateFromFile(string path) { return default(System.IO.MemoryMappedFiles.MemoryMappedFile); }
    public static System.IO.MemoryMappedFiles.MemoryMappedFile CreateFromFile(string path, System.IO.FileMode mode) { return default(System.IO.MemoryMappedFiles.MemoryMappedFile); }
    public static System.IO.MemoryMappedFiles.MemoryMappedFile CreateFromFile(string path, System.IO.FileMode mode, string mapName) { return default(System.IO.MemoryMappedFiles.MemoryMappedFile); }
    public static System.IO.MemoryMappedFiles.MemoryMappedFile CreateFromFile(string path, System.IO.FileMode mode, string mapName, long capacity) { return default(System.IO.MemoryMappedFiles.MemoryMappedFile); }
    public static System.IO.MemoryMappedFiles.MemoryMappedFile CreateFromFile(string path, System.IO.FileMode mode, string mapName, long capacity, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access) { return default(System.IO.MemoryMappedFiles.MemoryMappedFile); }
    public static System.IO.MemoryMappedFiles.MemoryMappedFile CreateNew(string mapName, long capacity) { return default(System.IO.MemoryMappedFiles.MemoryMappedFile); }
    public static System.IO.MemoryMappedFiles.MemoryMappedFile CreateNew(string mapName, long capacity, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access) { return default(System.IO.MemoryMappedFiles.MemoryMappedFile); }
    public static System.IO.MemoryMappedFiles.MemoryMappedFile CreateNew(string mapName, long capacity, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access, System.IO.MemoryMappedFiles.MemoryMappedFileOptions options, System.IO.MemoryMappedFiles.MemoryMappedFileSecurity memoryMappedFileSecurity, System.IO.HandleInheritability inheritability) { return default(System.IO.MemoryMappedFiles.MemoryMappedFile); }
    public static System.IO.MemoryMappedFiles.MemoryMappedFile CreateOrOpen(string mapName, long capacity) { return default(System.IO.MemoryMappedFiles.MemoryMappedFile); }
    public static System.IO.MemoryMappedFiles.MemoryMappedFile CreateOrOpen(string mapName, long capacity, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access) { return default(System.IO.MemoryMappedFiles.MemoryMappedFile); }
    public static System.IO.MemoryMappedFiles.MemoryMappedFile CreateOrOpen(string mapName, long capacity, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access, System.IO.MemoryMappedFiles.MemoryMappedFileOptions options, System.IO.MemoryMappedFiles.MemoryMappedFileSecurity memoryMappedFileSecurity, System.IO.HandleInheritability inheritability) { return default(System.IO.MemoryMappedFiles.MemoryMappedFile); }
    public System.IO.MemoryMappedFiles.MemoryMappedViewAccessor CreateViewAccessor() { return default(System.IO.MemoryMappedFiles.MemoryMappedViewAccessor); }
    public System.IO.MemoryMappedFiles.MemoryMappedViewAccessor CreateViewAccessor(long offset, long size) { return default(System.IO.MemoryMappedFiles.MemoryMappedViewAccessor); }
    public System.IO.MemoryMappedFiles.MemoryMappedViewAccessor CreateViewAccessor(long offset, long size, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access) { return default(System.IO.MemoryMappedFiles.MemoryMappedViewAccessor); }
    public System.IO.MemoryMappedFiles.MemoryMappedViewStream CreateViewStream() { return default(System.IO.MemoryMappedFiles.MemoryMappedViewStream); }
    public System.IO.MemoryMappedFiles.MemoryMappedViewStream CreateViewStream(long offset, long size) { return default(System.IO.MemoryMappedFiles.MemoryMappedViewStream); }
    public System.IO.MemoryMappedFiles.MemoryMappedViewStream CreateViewStream(long offset, long size, System.IO.MemoryMappedFiles.MemoryMappedFileAccess access) { return default(System.IO.MemoryMappedFiles.MemoryMappedViewStream); }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public System.IO.MemoryMappedFiles.MemoryMappedFileSecurity GetAccessControl() { return default(System.IO.MemoryMappedFiles.MemoryMappedFileSecurity); }
    public static System.IO.MemoryMappedFiles.MemoryMappedFile OpenExisting(string mapName) { return default(System.IO.MemoryMappedFiles.MemoryMappedFile); }
    public static System.IO.MemoryMappedFiles.MemoryMappedFile OpenExisting(string mapName, System.IO.MemoryMappedFiles.MemoryMappedFileRights desiredAccessRights) { return default(System.IO.MemoryMappedFiles.MemoryMappedFile); }
    public static System.IO.MemoryMappedFiles.MemoryMappedFile OpenExisting(string mapName, System.IO.MemoryMappedFiles.MemoryMappedFileRights desiredAccessRights, System.IO.HandleInheritability inheritability) { return default(System.IO.MemoryMappedFiles.MemoryMappedFile); }
    public void SetAccessControl(System.IO.MemoryMappedFiles.MemoryMappedFileSecurity memoryMappedFileSecurity) { }
  }

  public enum MemoryMappedFileAccess {
    CopyOnWrite = 3,
    Read = 1,
    ReadExecute = 4,
    ReadWrite = 0,
    ReadWriteExecute = 5,
    Write = 2,
  }

  [System.FlagsAttribute]
  public enum MemoryMappedFileOptions {
    DelayAllocatePages = 67108864,
    None = 0,
  }

  [System.FlagsAttribute]
  public enum MemoryMappedFileRights {
    AccessSystemSecurity = 16777216,
    ChangePermissions = 262144,
    CopyOnWrite = 1,
    Delete = 65536,
    Execute = 8,
    FullControl = 983055,
    Read = 4,
    ReadExecute = 12,
    ReadPermissions = 131072,
    ReadWrite = 6,
    ReadWriteExecute = 14,
    TakeOwnership = 524288,
    Write = 2,
  }

  public partial class MemoryMappedFileSecurity : System.Security.AccessControl.ObjectSecurity<System.IO.MemoryMappedFiles.MemoryMappedFileRights> {
    public MemoryMappedFileSecurity() : base (default(bool), default(System.Security.AccessControl.ResourceType)) { }
  }

  public sealed partial class MemoryMappedViewAccessor : System.IO.UnmanagedMemoryAccessor {
    internal MemoryMappedViewAccessor() { }
    public long PointerOffset { get { return default(long); } }
    public Microsoft.Win32.SafeHandles.SafeMemoryMappedViewHandle SafeMemoryMappedViewHandle { [System.Security.SecurityCriticalAttribute]get { return default(Microsoft.Win32.SafeHandles.SafeMemoryMappedViewHandle); } }
    [System.Security.SecuritySafeCriticalAttribute]
    protected override void Dispose(bool disposing) { }
    [System.Security.SecurityCriticalAttribute]
    public void Flush() { }
  }

  public sealed partial class MemoryMappedViewStream : System.IO.UnmanagedMemoryStream {
    internal MemoryMappedViewStream() { }
    public long PointerOffset { get { return default(long); } }
    public Microsoft.Win32.SafeHandles.SafeMemoryMappedViewHandle SafeMemoryMappedViewHandle { [System.Security.SecurityCriticalAttribute]get { return default(Microsoft.Win32.SafeHandles.SafeMemoryMappedViewHandle); } }
    [System.Security.SecuritySafeCriticalAttribute]
    protected override void Dispose(bool disposing) { }
    [System.Security.SecurityCriticalAttribute]
    public override void Flush() { }
    public override void SetLength(long value) { }
  }

} // end of System.IO.MemoryMappedFiles
