[assembly:System.CLSCompliant(true)]
namespace System.IO {
    public static partial class Directory
    {
        public static System.IO.DirectoryInfo CreateDirectory(string path) { return default(System.IO.DirectoryInfo); }
        public static System.IO.DirectoryInfo CreateDirectory(string path, System.Security.AccessControl.DirectorySecurity directorySecurity) { return default(System.IO.DirectoryInfo); }
        public static void Delete(string path) { }
        public static void Delete(string path, bool recursive) { }
        public static System.Collections.Generic.IEnumerable<string> EnumerateDirectories(string path) { return default(System.Collections.Generic.IEnumerable<string>); }
        public static System.Collections.Generic.IEnumerable<string> EnumerateDirectories(string path, string searchPattern) { return default(System.Collections.Generic.IEnumerable<string>); }
        public static System.Collections.Generic.IEnumerable<string> EnumerateDirectories(string path, string searchPattern, System.IO.SearchOption searchOption) { return default(System.Collections.Generic.IEnumerable<string>); }
        public static System.Collections.Generic.IEnumerable<string> EnumerateFiles(string path) { return default(System.Collections.Generic.IEnumerable<string>); }
        public static System.Collections.Generic.IEnumerable<string> EnumerateFiles(string path, string searchPattern) { return default(System.Collections.Generic.IEnumerable<string>); }
        public static System.Collections.Generic.IEnumerable<string> EnumerateFiles(string path, string searchPattern, System.IO.SearchOption searchOption) { return default(System.Collections.Generic.IEnumerable<string>); }
        public static System.Collections.Generic.IEnumerable<string> EnumerateFileSystemEntries(string path) { return default(System.Collections.Generic.IEnumerable<string>); }
        public static System.Collections.Generic.IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern) { return default(System.Collections.Generic.IEnumerable<string>); }
        public static System.Collections.Generic.IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, System.IO.SearchOption searchOption) { return default(System.Collections.Generic.IEnumerable<string>); }
        public static bool Exists(string path) { return default(bool); }
        public static System.Security.AccessControl.DirectorySecurity GetAccessControl(string path) { return default(System.Security.AccessControl.DirectorySecurity); }
        public static System.Security.AccessControl.DirectorySecurity GetAccessControl(string path, System.Security.AccessControl.AccessControlSections includeSections) { return default(System.Security.AccessControl.DirectorySecurity); }
        public static System.DateTime GetCreationTime(string path) { return default(System.DateTime); }
        public static System.DateTime GetCreationTimeUtc(string path) { return default(System.DateTime); }
        public static string GetCurrentDirectory() { return default(string); }
        public static string[] GetDirectories(string path) { return default(string[]); }
        public static string[] GetDirectories(string path, string searchPattern) { return default(string[]); }
        public static string[] GetDirectories(string path, string searchPattern, System.IO.SearchOption searchOption) { return default(string[]); }
        public static string GetDirectoryRoot(string path) { return default(string); }
        public static string[] GetFiles(string path) { return default(string[]); }
        public static string[] GetFiles(string path, string searchPattern) { return default(string[]); }
        public static string[] GetFiles(string path, string searchPattern, System.IO.SearchOption searchOption) { return default(string[]); }
        public static string[] GetFileSystemEntries(string path) { return default(string[]); }
        public static string[] GetFileSystemEntries(string path, string searchPattern) { return default(string[]); }
        public static string[] GetFileSystemEntries(string path, string searchPattern, System.IO.SearchOption searchOption) { return default(string[]); }
        public static System.DateTime GetLastAccessTime(string path) { return default(System.DateTime); }
        public static System.DateTime GetLastAccessTimeUtc(string path) { return default(System.DateTime); }
        public static System.DateTime GetLastWriteTime(string path) { return default(System.DateTime); }
        public static System.DateTime GetLastWriteTimeUtc(string path) { return default(System.DateTime); }
        public static string[] GetLogicalDrives() { return default(string[]); }
        public static System.IO.DirectoryInfo GetParent(string path) { return default(System.IO.DirectoryInfo); }
        public static void Move(string sourceDirName, string destDirName) { }
        public static void SetAccessControl(string path, System.Security.AccessControl.DirectorySecurity directorySecurity) { }
        public static void SetCreationTime(string path, System.DateTime creationTime) { }
        public static void SetCreationTimeUtc(string path, System.DateTime creationTimeUtc) { }
        public static void SetCurrentDirectory(string path) { }
        public static void SetLastAccessTime(string path, System.DateTime lastAccessTime) { }
        public static void SetLastAccessTimeUtc(string path, System.DateTime lastAccessTimeUtc) { }
        public static void SetLastWriteTime(string path, System.DateTime lastWriteTime) { }
        public static void SetLastWriteTimeUtc(string path, System.DateTime lastWriteTimeUtc) { }
    }
    public sealed partial class DirectoryInfo : System.IO.FileSystemInfo
    {
        public DirectoryInfo(string path) { }
        public override bool Exists { get { return default(bool); } }
        public override string Name { get { return default(string); } }
        public System.IO.DirectoryInfo Parent { get { return default(System.IO.DirectoryInfo); } }
        public System.IO.DirectoryInfo Root { get { return default(System.IO.DirectoryInfo); } }
        public void Create() { }
        public void Create(System.Security.AccessControl.DirectorySecurity directorySecurity) { }
        public System.IO.DirectoryInfo CreateSubdirectory(string path) { return default(System.IO.DirectoryInfo); }
        public System.IO.DirectoryInfo CreateSubdirectory(string path, System.Security.AccessControl.DirectorySecurity directorySecurity) { return default(System.IO.DirectoryInfo); }
        public override void Delete() { }
        public void Delete(bool recursive) { }
        public System.Collections.Generic.IEnumerable<System.IO.DirectoryInfo> EnumerateDirectories() { return default(System.Collections.Generic.IEnumerable<System.IO.DirectoryInfo>); }
        public System.Collections.Generic.IEnumerable<System.IO.DirectoryInfo> EnumerateDirectories(string searchPattern) { return default(System.Collections.Generic.IEnumerable<System.IO.DirectoryInfo>); }
        public System.Collections.Generic.IEnumerable<System.IO.DirectoryInfo> EnumerateDirectories(string searchPattern, System.IO.SearchOption searchOption) { return default(System.Collections.Generic.IEnumerable<System.IO.DirectoryInfo>); }
        public System.Collections.Generic.IEnumerable<System.IO.FileInfo> EnumerateFiles() { return default(System.Collections.Generic.IEnumerable<System.IO.FileInfo>); }
        public System.Collections.Generic.IEnumerable<System.IO.FileInfo> EnumerateFiles(string searchPattern) { return default(System.Collections.Generic.IEnumerable<System.IO.FileInfo>); }
        public System.Collections.Generic.IEnumerable<System.IO.FileInfo> EnumerateFiles(string searchPattern, System.IO.SearchOption searchOption) { return default(System.Collections.Generic.IEnumerable<System.IO.FileInfo>); }
        public System.Collections.Generic.IEnumerable<System.IO.FileSystemInfo> EnumerateFileSystemInfos() { return default(System.Collections.Generic.IEnumerable<System.IO.FileSystemInfo>); }
        public System.Collections.Generic.IEnumerable<System.IO.FileSystemInfo> EnumerateFileSystemInfos(string searchPattern) { return default(System.Collections.Generic.IEnumerable<System.IO.FileSystemInfo>); }
        public System.Collections.Generic.IEnumerable<System.IO.FileSystemInfo> EnumerateFileSystemInfos(string searchPattern, System.IO.SearchOption searchOption) { return default(System.Collections.Generic.IEnumerable<System.IO.FileSystemInfo>); }
        public System.Security.AccessControl.DirectorySecurity GetAccessControl() { return default(System.Security.AccessControl.DirectorySecurity); }
        public System.Security.AccessControl.DirectorySecurity GetAccessControl(System.Security.AccessControl.AccessControlSections includeSections) { return default(System.Security.AccessControl.DirectorySecurity); }
        public System.IO.DirectoryInfo[] GetDirectories() { return default(System.IO.DirectoryInfo[]); }
        public System.IO.DirectoryInfo[] GetDirectories(string searchPattern) { return default(System.IO.DirectoryInfo[]); }
        public System.IO.DirectoryInfo[] GetDirectories(string searchPattern, System.IO.SearchOption searchOption) { return default(System.IO.DirectoryInfo[]); }
        public System.IO.FileInfo[] GetFiles() { return default(System.IO.FileInfo[]); }
        public System.IO.FileInfo[] GetFiles(string searchPattern) { return default(System.IO.FileInfo[]); }
        public System.IO.FileInfo[] GetFiles(string searchPattern, System.IO.SearchOption searchOption) { return default(System.IO.FileInfo[]); }
        public System.IO.FileSystemInfo[] GetFileSystemInfos() { return default(System.IO.FileSystemInfo[]); }
        public System.IO.FileSystemInfo[] GetFileSystemInfos(string searchPattern) { return default(System.IO.FileSystemInfo[]); }
        public System.IO.FileSystemInfo[] GetFileSystemInfos(string searchPattern, System.IO.SearchOption searchOption) { return default(System.IO.FileSystemInfo[]); }
        public void MoveTo(string destDirName) { }
        public void SetAccessControl(System.Security.AccessControl.DirectorySecurity directorySecurity) { }
        public override string ToString() { return default(string); }
    }
    public static partial class File
    {
        public static void AppendAllLines(string path, System.Collections.Generic.IEnumerable<string> contents) { }
        public static void AppendAllLines(string path, System.Collections.Generic.IEnumerable<string> contents, System.Text.Encoding encoding) { }
        public static void AppendAllText(string path, string contents) { }
        public static void AppendAllText(string path, string contents, System.Text.Encoding encoding) { }
        public static System.IO.StreamWriter AppendText(string path) { return default(System.IO.StreamWriter); }
        public static void Copy(string sourceFileName, string destFileName) { }
        public static void Copy(string sourceFileName, string destFileName, bool overwrite) { }
        public static System.IO.FileStream Create(string path) { return default(System.IO.FileStream); }
        public static System.IO.FileStream Create(string path, int bufferSize) { return default(System.IO.FileStream); }
        public static System.IO.StreamWriter CreateText(string path) { return default(System.IO.StreamWriter); }
        public static void Decrypt(string path) { }
        public static void Delete(string path) { }
        public static void Encrypt(string path) { }
        public static bool Exists(string path) { return default(bool); }
        public static System.IO.FileAttributes GetAttributes(string path) { return default(System.IO.FileAttributes); }
        public static System.DateTime GetCreationTime(string path) { return default(System.DateTime); }
        public static System.DateTime GetCreationTimeUtc(string path) { return default(System.DateTime); }
        public static System.DateTime GetLastAccessTime(string path) { return default(System.DateTime); }
        public static System.DateTime GetLastAccessTimeUtc(string path) { return default(System.DateTime); }
        public static System.DateTime GetLastWriteTime(string path) { return default(System.DateTime); }
        public static System.DateTime GetLastWriteTimeUtc(string path) { return default(System.DateTime); }
        public static void Move(string sourceFileName, string destFileName) { }
        public static System.IO.FileStream Open(string path, System.IO.FileMode mode) { return default(System.IO.FileStream); }
        public static System.IO.FileStream Open(string path, System.IO.FileMode mode, System.IO.FileAccess access) { return default(System.IO.FileStream); }
        public static System.IO.FileStream Open(string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share) { return default(System.IO.FileStream); }
        public static System.IO.FileStream OpenRead(string path) { return default(System.IO.FileStream); }
        public static System.IO.StreamReader OpenText(string path) { return default(System.IO.StreamReader); }
        public static System.IO.FileStream OpenWrite(string path) { return default(System.IO.FileStream); }
        public static byte[] ReadAllBytes(string path) { return default(byte[]); }
        public static string[] ReadAllLines(string path) { return default(string[]); }
        public static string[] ReadAllLines(string path, System.Text.Encoding encoding) { return default(string[]); }
        public static string ReadAllText(string path) { return default(string); }
        public static string ReadAllText(string path, System.Text.Encoding encoding) { return default(string); }
        public static System.Collections.Generic.IEnumerable<string> ReadLines(string path) { return default(System.Collections.Generic.IEnumerable<string>); }
        public static System.Collections.Generic.IEnumerable<string> ReadLines(string path, System.Text.Encoding encoding) { return default(System.Collections.Generic.IEnumerable<string>); }
        public static void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName) { }
        public static void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors) { }
        public static void SetAttributes(string path, System.IO.FileAttributes fileAttributes) { }
        public static void SetCreationTime(string path, System.DateTime creationTime) { }
        public static void SetCreationTimeUtc(string path, System.DateTime creationTimeUtc) { }
        public static void SetLastAccessTime(string path, System.DateTime lastAccessTime) { }
        public static void SetLastAccessTimeUtc(string path, System.DateTime lastAccessTimeUtc) { }
        public static void SetLastWriteTime(string path, System.DateTime lastWriteTime) { }
        public static void SetLastWriteTimeUtc(string path, System.DateTime lastWriteTimeUtc) { }
        public static void WriteAllBytes(string path, byte[] bytes) { }
        public static void WriteAllLines(string path, System.Collections.Generic.IEnumerable<string> contents) { }
        public static void WriteAllLines(string path, System.Collections.Generic.IEnumerable<string> contents, System.Text.Encoding encoding) { }
        public static void WriteAllLines(string path, string[] contents) { }
        public static void WriteAllLines(string path, string[] contents, System.Text.Encoding encoding) { }
        public static void WriteAllText(string path, string contents) { }
        public static void WriteAllText(string path, string contents, System.Text.Encoding encoding) { }
        public static System.IO.FileStream Create(string path, int bufferSize, System.IO.FileOptions options) { return default(System.IO.FileStream); }
    }
    public sealed partial class FileInfo : System.IO.FileSystemInfo
    {
        public FileInfo(string fileName) { }
        public System.IO.DirectoryInfo Directory { get { return default(System.IO.DirectoryInfo); } }
        public string DirectoryName { get { return default(string); } }
        public override bool Exists { get { return default(bool); } }
        public bool IsReadOnly { get { return default(bool); } set { } }
        public long Length { get { return default(long); } }
        public override string Name { get { return default(string); } }
        public System.IO.StreamWriter AppendText() { return default(System.IO.StreamWriter); }
        public System.IO.FileInfo CopyTo(string destFileName) { return default(System.IO.FileInfo); }
        public System.IO.FileInfo CopyTo(string destFileName, bool overwrite) { return default(System.IO.FileInfo); }
        public System.IO.FileStream Create() { return default(System.IO.FileStream); }
        public System.IO.StreamWriter CreateText() { return default(System.IO.StreamWriter); }
        public void Decrypt() { }
        public override void Delete() { }
        public void Encrypt() { }
        public void MoveTo(string destFileName) { }
        public System.IO.FileStream Open(System.IO.FileMode mode) { return default(System.IO.FileStream); }
        public System.IO.FileStream Open(System.IO.FileMode mode, System.IO.FileAccess access) { return default(System.IO.FileStream); }
        public System.IO.FileStream Open(System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share) { return default(System.IO.FileStream); }
        public System.IO.FileStream OpenRead() { return default(System.IO.FileStream); }
        public System.IO.StreamReader OpenText() { return default(System.IO.StreamReader); }
        public System.IO.FileStream OpenWrite() { return default(System.IO.FileStream); }
        public override string ToString() { return default(string); }
    }
    public abstract partial class FileSystemInfo
    {
        protected string FullPath;
        protected string OriginalPath;
        protected FileSystemInfo() { }
        protected FileSystemInfo(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public System.IO.FileAttributes Attributes { get { return default(System.IO.FileAttributes); } set { } }
        public System.DateTime CreationTime { get { return default(System.DateTime); } set { } }
        public System.DateTime CreationTimeUtc { get { return default(System.DateTime); } set { } }
        public abstract bool Exists { get; }
        public string Extension { get { return default(string); } }
        public virtual string FullName { get { return default(string); } }
        public System.DateTime LastAccessTime { get { return default(System.DateTime); } set { } }
        public System.DateTime LastAccessTimeUtc { get { return default(System.DateTime); } set { } }
        public System.DateTime LastWriteTime { get { return default(System.DateTime); } set { } }
        public System.DateTime LastWriteTimeUtc { get { return default(System.DateTime); } set { } }
        public abstract string Name { get; }
        public abstract void Delete();
        public void Refresh() { }
    }
    public enum SearchOption
    {
        AllDirectories = 1,
        TopDirectoryOnly = 0,
    }
  public static partial class FileSystemAclExtensions {
    public static System.Security.AccessControl.DirectorySecurity GetAccessControl(this System.IO.DirectoryInfo directoryInfo) { return default(System.Security.AccessControl.DirectorySecurity); }
    public static System.Security.AccessControl.DirectorySecurity GetAccessControl(this System.IO.DirectoryInfo directoryInfo, System.Security.AccessControl.AccessControlSections includeSections) { return default(System.Security.AccessControl.DirectorySecurity); }
    public static System.Security.AccessControl.FileSecurity GetAccessControl(this System.IO.FileInfo fileInfo) { return default(System.Security.AccessControl.FileSecurity); }
    public static System.Security.AccessControl.FileSecurity GetAccessControl(this System.IO.FileInfo fileInfo, System.Security.AccessControl.AccessControlSections includeSections) { return default(System.Security.AccessControl.FileSecurity); }
    public static System.Security.AccessControl.FileSecurity GetAccessControl(this System.IO.FileStream fileStream) { return default(System.Security.AccessControl.FileSecurity); }
    public static void SetAccessControl(this System.IO.DirectoryInfo directoryInfo, System.Security.AccessControl.DirectorySecurity directorySecurity) { }
    public static void SetAccessControl(this System.IO.FileInfo fileInfo, System.Security.AccessControl.FileSecurity fileSecurity) { }
    public static void SetAccessControl(this System.IO.FileStream fileStream, System.Security.AccessControl.FileSecurity fileSecurity) { }
  }
} // end of System.IO
namespace System.Security.AccessControl {

    public abstract partial class DirectoryObjectSecurity : System.Security.AccessControl.ObjectSecurity
    {
        protected DirectoryObjectSecurity() : base(default(bool), default(bool)) { }
        protected DirectoryObjectSecurity(System.Security.AccessControl.CommonSecurityDescriptor securityDescriptor) : base(default(bool), default(bool)) { }
        public virtual System.Security.AccessControl.AccessRule AccessRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type, System.Guid objectType, System.Guid inheritedObjectType) { return default(System.Security.AccessControl.AccessRule); }
        protected void AddAccessRule(System.Security.AccessControl.ObjectAccessRule rule) { }
        protected void AddAuditRule(System.Security.AccessControl.ObjectAuditRule rule) { }
        public virtual System.Security.AccessControl.AuditRule AuditRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags, System.Guid objectType, System.Guid inheritedObjectType) { return default(System.Security.AccessControl.AuditRule); }
        public System.Security.AccessControl.AuthorizationRuleCollection GetAccessRules(bool includeExplicit, bool includeInherited, System.Type targetType) { return default(System.Security.AccessControl.AuthorizationRuleCollection); }
        public System.Security.AccessControl.AuthorizationRuleCollection GetAuditRules(bool includeExplicit, bool includeInherited, System.Type targetType) { return default(System.Security.AccessControl.AuthorizationRuleCollection); }
        protected override bool ModifyAccess(System.Security.AccessControl.AccessControlModification modification, System.Security.AccessControl.AccessRule rule, out bool modified) { modified = default(bool); return default(bool); }
        protected override bool ModifyAudit(System.Security.AccessControl.AccessControlModification modification, System.Security.AccessControl.AuditRule rule, out bool modified) { modified = default(bool); return default(bool); }
        protected bool RemoveAccessRule(System.Security.AccessControl.ObjectAccessRule rule) { return default(bool); }
        protected void RemoveAccessRuleAll(System.Security.AccessControl.ObjectAccessRule rule) { }
        protected void RemoveAccessRuleSpecific(System.Security.AccessControl.ObjectAccessRule rule) { }
        protected bool RemoveAuditRule(System.Security.AccessControl.ObjectAuditRule rule) { return default(bool); }
        protected void RemoveAuditRuleAll(System.Security.AccessControl.ObjectAuditRule rule) { }
        protected void RemoveAuditRuleSpecific(System.Security.AccessControl.ObjectAuditRule rule) { }
        protected void ResetAccessRule(System.Security.AccessControl.ObjectAccessRule rule) { }
        protected void SetAccessRule(System.Security.AccessControl.ObjectAccessRule rule) { }
        protected void SetAuditRule(System.Security.AccessControl.ObjectAuditRule rule) { }
    }

    public sealed partial class DirectorySecurity : System.Security.AccessControl.FileSystemSecurity
    {
        public DirectorySecurity() { }
        public DirectorySecurity(string name, System.Security.AccessControl.AccessControlSections includeSections) { }
    }

    public sealed partial class FileSecurity : System.Security.AccessControl.FileSystemSecurity
    {
        public FileSecurity() { }
        public FileSecurity(string fileName, System.Security.AccessControl.AccessControlSections includeSections) { }
    }

    public sealed partial class FileSystemAccessRule : System.Security.AccessControl.AccessRule
    {
        public FileSystemAccessRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.FileSystemRights fileSystemRights, System.Security.AccessControl.AccessControlType type) : base(default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
        public FileSystemAccessRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.FileSystemRights fileSystemRights, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type) : base(default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
        public FileSystemAccessRule(string identity, System.Security.AccessControl.FileSystemRights fileSystemRights, System.Security.AccessControl.AccessControlType type) : base(default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
        public FileSystemAccessRule(string identity, System.Security.AccessControl.FileSystemRights fileSystemRights, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type) : base(default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AccessControlType)) { }
        public System.Security.AccessControl.FileSystemRights FileSystemRights { get { return default(System.Security.AccessControl.FileSystemRights); } }
    }

    public sealed partial class FileSystemAuditRule : System.Security.AccessControl.AuditRule
    {
        public FileSystemAuditRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.FileSystemRights fileSystemRights, System.Security.AccessControl.AuditFlags flags) : base(default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
        public FileSystemAuditRule(System.Security.Principal.IdentityReference identity, System.Security.AccessControl.FileSystemRights fileSystemRights, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags) : base(default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
        public FileSystemAuditRule(string identity, System.Security.AccessControl.FileSystemRights fileSystemRights, System.Security.AccessControl.AuditFlags flags) : base(default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
        public FileSystemAuditRule(string identity, System.Security.AccessControl.FileSystemRights fileSystemRights, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags) : base(default(System.Security.Principal.IdentityReference), default(int), default(bool), default(System.Security.AccessControl.InheritanceFlags), default(System.Security.AccessControl.PropagationFlags), default(System.Security.AccessControl.AuditFlags)) { }
        public System.Security.AccessControl.FileSystemRights FileSystemRights { get { return default(System.Security.AccessControl.FileSystemRights); } }
    }

    [System.FlagsAttribute]
    public enum FileSystemRights
    {
        AppendData = 4,
        ChangePermissions = 262144,
        CreateDirectories = 4,
        CreateFiles = 2,
        Delete = 65536,
        DeleteSubdirectoriesAndFiles = 64,
        ExecuteFile = 32,
        FullControl = 2032127,
        ListDirectory = 1,
        Modify = 197055,
        Read = 131209,
        ReadAndExecute = 131241,
        ReadAttributes = 128,
        ReadData = 1,
        ReadExtendedAttributes = 8,
        ReadPermissions = 131072,
        Synchronize = 1048576,
        TakeOwnership = 524288,
        Traverse = 32,
        Write = 278,
        WriteAttributes = 256,
        WriteData = 2,
        WriteExtendedAttributes = 16,
    }

    public abstract partial class FileSystemSecurity : System.Security.AccessControl.NativeObjectSecurity
    {
        internal FileSystemSecurity() : base(default(bool), default(System.Security.AccessControl.ResourceType)) { }
        public override System.Type AccessRightType { get { return default(System.Type); } }
        public override System.Type AccessRuleType { get { return default(System.Type); } }
        public override System.Type AuditRuleType { get { return default(System.Type); } }
        public sealed override System.Security.AccessControl.AccessRule AccessRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AccessControlType type) { return default(System.Security.AccessControl.AccessRule); }
        public void AddAccessRule(System.Security.AccessControl.FileSystemAccessRule rule) { }
        public void AddAuditRule(System.Security.AccessControl.FileSystemAuditRule rule) { }
        public sealed override System.Security.AccessControl.AuditRule AuditRuleFactory(System.Security.Principal.IdentityReference identityReference, int accessMask, bool isInherited, System.Security.AccessControl.InheritanceFlags inheritanceFlags, System.Security.AccessControl.PropagationFlags propagationFlags, System.Security.AccessControl.AuditFlags flags) { return default(System.Security.AccessControl.AuditRule); }
        public bool RemoveAccessRule(System.Security.AccessControl.FileSystemAccessRule rule) { return default(bool); }
        public void RemoveAccessRuleAll(System.Security.AccessControl.FileSystemAccessRule rule) { }
        public void RemoveAccessRuleSpecific(System.Security.AccessControl.FileSystemAccessRule rule) { }
        public bool RemoveAuditRule(System.Security.AccessControl.FileSystemAuditRule rule) { return default(bool); }
        public void RemoveAuditRuleAll(System.Security.AccessControl.FileSystemAuditRule rule) { }
        public void RemoveAuditRuleSpecific(System.Security.AccessControl.FileSystemAuditRule rule) { }
        public void ResetAccessRule(System.Security.AccessControl.FileSystemAccessRule rule) { }
        public void SetAccessRule(System.Security.AccessControl.FileSystemAccessRule rule) { }
        public void SetAuditRule(System.Security.AccessControl.FileSystemAuditRule rule) { }
    }
} // end of System.Security.AccessControl
namespace System.Security.Permissions {

    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple = true, Inherited = false)]
    public sealed partial class FileIOPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public FileIOPermissionAttribute(System.Security.Permissions.SecurityAction action) : base(default(System.Security.Permissions.SecurityAction)) { }
        [System.ObsoleteAttribute("use newer properties")]
        public string All { get { return default(string); } set { } }
        public System.Security.Permissions.FileIOPermissionAccess AllFiles { get { return default(System.Security.Permissions.FileIOPermissionAccess); } set { } }
        public System.Security.Permissions.FileIOPermissionAccess AllLocalFiles { get { return default(System.Security.Permissions.FileIOPermissionAccess); } set { } }
        public string Append { get { return default(string); } set { } }
        public string ChangeAccessControl { get { return default(string); } set { } }
        public string PathDiscovery { get { return default(string); } set { } }
        public string Read { get { return default(string); } set { } }
        public string ViewAccessControl { get { return default(string); } set { } }
        public string ViewAndModify { get { return default(string); } set { } }
        public string Write { get { return default(string); } set { } }
        public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
    }
} // end of System.Security.Permissions
