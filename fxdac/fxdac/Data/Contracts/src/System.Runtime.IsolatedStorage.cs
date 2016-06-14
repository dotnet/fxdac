[assembly:System.CLSCompliant(true)]
namespace System.IO.IsolatedStorage {
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface INormalizeForIsolatedStorage
    {
        object Normalize();
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class IsolatedStorage     {
        protected IsolatedStorage() { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public object ApplicationIdentity { get { return default(object); } }
        public object AssemblyIdentity { get { return default(object); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public virtual long AvailableFreeSpace { get { return default(long); } }
        [System.CLSCompliantAttribute(false)]
        [System.ObsoleteAttribute]
        public virtual ulong CurrentSize { get { return default(ulong); } }
        public object DomainIdentity { get { return default(object); } }
        [System.CLSCompliantAttribute(false)]
        [System.ObsoleteAttribute]
        public virtual ulong MaximumSize { get { return default(ulong); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public virtual long Quota { get { return default(long); } }
        public System.IO.IsolatedStorage.IsolatedStorageScope Scope { get { return default(System.IO.IsolatedStorage.IsolatedStorageScope); } }
        protected virtual char SeparatorExternal { get { return default(char); } }
        protected virtual char SeparatorInternal { get { return default(char); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public virtual long UsedSize { get { return default(long); } }
        protected abstract System.Security.Permissions.IsolatedStoragePermission GetPermission(System.Security.PermissionSet ps);
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public virtual bool IncreaseQuotaTo(long newQuotaSize) { return default(bool); }
        protected void InitStore(System.IO.IsolatedStorage.IsolatedStorageScope scope, System.Type appEvidenceType) { }
        protected void InitStore(System.IO.IsolatedStorage.IsolatedStorageScope scope, System.Type domainEvidenceType, System.Type assemblyEvidenceType) { }
        public abstract void Remove();
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class IsolatedStorageException : System.Exception
    {
        public IsolatedStorageException() { }
        protected IsolatedStorageException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public IsolatedStorageException(string message) { }
        public IsolatedStorageException(string message, System.Exception inner) { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class IsolatedStorageFile : System.IO.IsolatedStorage.IsolatedStorage, System.IDisposable
    {
        internal IsolatedStorageFile() { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override long AvailableFreeSpace { get { return default(long); } }
        [System.CLSCompliantAttribute(false)]
        [System.ObsoleteAttribute]
        public override ulong CurrentSize { get { return default(ulong); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public static bool IsEnabled { get { return default(bool); } }
        [System.CLSCompliantAttribute(false)]
        [System.ObsoleteAttribute]
        public override ulong MaximumSize { get { return default(ulong); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override long Quota { get { return default(long); } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override long UsedSize { get { return default(long); } }
        public void Close() { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public void CopyFile(string sourceFileName, string destinationFileName) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public void CopyFile(string sourceFileName, string destinationFileName, bool overwrite) { }
        public void CreateDirectory(string dir) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.IO.IsolatedStorage.IsolatedStorageFileStream CreateFile(string path) { return default(System.IO.IsolatedStorage.IsolatedStorageFileStream); }
        public void DeleteDirectory(string dir) { }
        public void DeleteFile(string file) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public bool DirectoryExists(string path) { return default(bool); }
        public void Dispose() { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public bool FileExists(string path) { return default(bool); }
        ~IsolatedStorageFile() { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.DateTimeOffset GetCreationTime(string path) { return default(System.DateTimeOffset); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public string[] GetDirectoryNames() { return default(string[]); }
        public string[] GetDirectoryNames(string searchPattern) { return default(string[]); }
        public static System.Collections.IEnumerator GetEnumerator(System.IO.IsolatedStorage.IsolatedStorageScope scope) { return default(System.Collections.IEnumerator); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public string[] GetFileNames() { return default(string[]); }
        public string[] GetFileNames(string searchPattern) { return default(string[]); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.DateTimeOffset GetLastAccessTime(string path) { return default(System.DateTimeOffset); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.DateTimeOffset GetLastWriteTime(string path) { return default(System.DateTimeOffset); }
        public static System.IO.IsolatedStorage.IsolatedStorageFile GetMachineStoreForApplication() { return default(System.IO.IsolatedStorage.IsolatedStorageFile); }
        public static System.IO.IsolatedStorage.IsolatedStorageFile GetMachineStoreForAssembly() { return default(System.IO.IsolatedStorage.IsolatedStorageFile); }
        public static System.IO.IsolatedStorage.IsolatedStorageFile GetMachineStoreForDomain() { return default(System.IO.IsolatedStorage.IsolatedStorageFile); }
        protected override System.Security.Permissions.IsolatedStoragePermission GetPermission(System.Security.PermissionSet ps) { return default(System.Security.Permissions.IsolatedStoragePermission); }
        public static System.IO.IsolatedStorage.IsolatedStorageFile GetStore(System.IO.IsolatedStorage.IsolatedStorageScope scope, object applicationIdentity) { return default(System.IO.IsolatedStorage.IsolatedStorageFile); }
        public static System.IO.IsolatedStorage.IsolatedStorageFile GetStore(System.IO.IsolatedStorage.IsolatedStorageScope scope, object domainIdentity, object assemblyIdentity) { return default(System.IO.IsolatedStorage.IsolatedStorageFile); }
        public static System.IO.IsolatedStorage.IsolatedStorageFile GetStore(System.IO.IsolatedStorage.IsolatedStorageScope scope, System.Security.Policy.Evidence domainEvidence, System.Type domainEvidenceType, System.Security.Policy.Evidence assemblyEvidence, System.Type assemblyEvidenceType) { return default(System.IO.IsolatedStorage.IsolatedStorageFile); }
        public static System.IO.IsolatedStorage.IsolatedStorageFile GetStore(System.IO.IsolatedStorage.IsolatedStorageScope scope, System.Type applicationEvidenceType) { return default(System.IO.IsolatedStorage.IsolatedStorageFile); }
        public static System.IO.IsolatedStorage.IsolatedStorageFile GetStore(System.IO.IsolatedStorage.IsolatedStorageScope scope, System.Type domainEvidenceType, System.Type assemblyEvidenceType) { return default(System.IO.IsolatedStorage.IsolatedStorageFile); }
        public static System.IO.IsolatedStorage.IsolatedStorageFile GetUserStoreForApplication() { return default(System.IO.IsolatedStorage.IsolatedStorageFile); }
        public static System.IO.IsolatedStorage.IsolatedStorageFile GetUserStoreForAssembly() { return default(System.IO.IsolatedStorage.IsolatedStorageFile); }
        public static System.IO.IsolatedStorage.IsolatedStorageFile GetUserStoreForDomain() { return default(System.IO.IsolatedStorage.IsolatedStorageFile); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public static System.IO.IsolatedStorage.IsolatedStorageFile GetUserStoreForSite() { return default(System.IO.IsolatedStorage.IsolatedStorageFile); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override bool IncreaseQuotaTo(long newQuotaSize) { return default(bool); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public void MoveDirectory(string sourceDirectoryName, string destinationDirectoryName) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public void MoveFile(string sourceFileName, string destinationFileName) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.IO.IsolatedStorage.IsolatedStorageFileStream OpenFile(string path, System.IO.FileMode mode) { return default(System.IO.IsolatedStorage.IsolatedStorageFileStream); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.IO.IsolatedStorage.IsolatedStorageFileStream OpenFile(string path, System.IO.FileMode mode, System.IO.FileAccess access) { return default(System.IO.IsolatedStorage.IsolatedStorageFileStream); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.IO.IsolatedStorage.IsolatedStorageFileStream OpenFile(string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share) { return default(System.IO.IsolatedStorage.IsolatedStorageFileStream); }
        public override void Remove() { }
        public static void Remove(System.IO.IsolatedStorage.IsolatedStorageScope scope) { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class IsolatedStorageFileStream : System.IO.FileStream
    {
        public IsolatedStorageFileStream(string path, System.IO.FileMode mode) : base(default(System.IntPtr), default(System.IO.FileAccess)) { }
        public IsolatedStorageFileStream(string path, System.IO.FileMode mode, System.IO.FileAccess access) : base(default(System.IntPtr), default(System.IO.FileAccess)) { }
        public IsolatedStorageFileStream(string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share) : base(default(System.IntPtr), default(System.IO.FileAccess)) { }
        public IsolatedStorageFileStream(string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share, int bufferSize) : base(default(System.IntPtr), default(System.IO.FileAccess)) { }
        public IsolatedStorageFileStream(string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share, int bufferSize, System.IO.IsolatedStorage.IsolatedStorageFile isf) : base(default(System.IntPtr), default(System.IO.FileAccess)) { }
        public IsolatedStorageFileStream(string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share, System.IO.IsolatedStorage.IsolatedStorageFile isf) : base(default(System.IntPtr), default(System.IO.FileAccess)) { }
        public IsolatedStorageFileStream(string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.IsolatedStorage.IsolatedStorageFile isf) : base(default(System.IntPtr), default(System.IO.FileAccess)) { }
        public IsolatedStorageFileStream(string path, System.IO.FileMode mode, System.IO.IsolatedStorage.IsolatedStorageFile isf) : base(default(System.IntPtr), default(System.IO.FileAccess)) { }
        public override bool CanRead { get { return default(bool); } }
        public override bool CanSeek { get { return default(bool); } }
        public override bool CanWrite { get { return default(bool); } }
        [System.ObsoleteAttribute("Use SafeFileHandle - once available")]
        public override System.IntPtr Handle { get { return default(System.IntPtr); } }
        public override bool IsAsync { get { return default(bool); } }
        public override long Length { get { return default(long); } }
        public override long Position { get { return default(long); } set { } }
        public override Microsoft.Win32.SafeHandles.SafeFileHandle SafeFileHandle { get { return default(Microsoft.Win32.SafeHandles.SafeFileHandle); } }
        public override System.IAsyncResult BeginRead(byte[] buffer, int offset, int numBytes, System.AsyncCallback userCallback, object stateObject) { return default(System.IAsyncResult); }
        public override System.IAsyncResult BeginWrite(byte[] buffer, int offset, int numBytes, System.AsyncCallback userCallback, object stateObject) { return default(System.IAsyncResult); }
        protected override void Dispose(bool disposing) { }
        public override int EndRead(System.IAsyncResult asyncResult) { return default(int); }
        public override void EndWrite(System.IAsyncResult asyncResult) { }
        public override void Flush() { }
        public override void Flush(bool flushToDisk) { }
        public override int Read(byte[] buffer, int offset, int count) { return default(int); }
        public override int ReadByte() { return default(int); }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { return default(long); }
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
        public override void WriteByte(byte value) { }
    }

    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum IsolatedStorageScope
    {
        Application = 32,
        Assembly = 4,
        Domain = 2,
        Machine = 16,
        None = 0,
        Roaming = 8,
        User = 1,
    }

    public enum IsolatedStorageSecurityOptions
    {
        IncreaseQuotaForApplication = 4,
    }

    public partial class IsolatedStorageSecurityState : System.Security.SecurityState
    {
        internal IsolatedStorageSecurityState() { }
        public System.IO.IsolatedStorage.IsolatedStorageSecurityOptions Options { get { return default(System.IO.IsolatedStorage.IsolatedStorageSecurityOptions); } }
        public long Quota { get { return default(long); } set { } }
        public long UsedSize { get { return default(long); } }
        public override void EnsureState() { }
    }
} // end of System.IO.IsolatedStorage
namespace System.Security.Permissions {

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum IsolatedStorageContainment
    {
        AdministerIsolatedStorageByUser = 112,
        ApplicationIsolationByMachine = 69,
        ApplicationIsolationByRoamingUser = 101,
        ApplicationIsolationByUser = 21,
        AssemblyIsolationByMachine = 64,
        AssemblyIsolationByRoamingUser = 96,
        AssemblyIsolationByUser = 32,
        DomainIsolationByMachine = 48,
        DomainIsolationByRoamingUser = 80,
        DomainIsolationByUser = 16,
        None = 0,
        UnrestrictedIsolatedStorage = 240,
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class IsolatedStorageFilePermission : System.Security.Permissions.IsolatedStoragePermission
    {
        public IsolatedStorageFilePermission(System.Security.Permissions.PermissionState state) : base(default(System.Security.Permissions.PermissionState)) { }
        public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
        public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
        public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple = true, Inherited = false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class IsolatedStorageFilePermissionAttribute : System.Security.Permissions.IsolatedStoragePermissionAttribute
    {
        public IsolatedStorageFilePermissionAttribute(System.Security.Permissions.SecurityAction action) : base(default(System.Security.Permissions.SecurityAction)) { }
        public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class IsolatedStoragePermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission
    {
        protected IsolatedStoragePermission(System.Security.Permissions.PermissionState state) { }
        public System.Security.Permissions.IsolatedStorageContainment UsageAllowed { get { return default(System.Security.Permissions.IsolatedStorageContainment); } set { } }
        public long UserQuota { get { return default(long); } set { } }
        public override void FromXml(System.Security.SecurityElement esd) { }
        public bool IsUnrestricted() { return default(bool); }
        public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple = true, Inherited = false)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class IsolatedStoragePermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        protected IsolatedStoragePermissionAttribute(System.Security.Permissions.SecurityAction action) : base(default(System.Security.Permissions.SecurityAction)) { }
        public System.Security.Permissions.IsolatedStorageContainment UsageAllowed { get { return default(System.Security.Permissions.IsolatedStorageContainment); } set { } }
        public long UserQuota { get { return default(long); } set { } }
    }
} // end of System.Security.Permissions
