[assembly:System.CLSCompliant(true)]
namespace System.IO.Compression {
  public partial class ZipArchive : System.IDisposable {
    public ZipArchive(System.IO.Stream stream) { }
    public ZipArchive(System.IO.Stream stream, System.IO.Compression.ZipArchiveMode mode) { }
    public ZipArchive(System.IO.Stream stream, System.IO.Compression.ZipArchiveMode mode, bool leaveOpen) { }
    public ZipArchive(System.IO.Stream stream, System.IO.Compression.ZipArchiveMode mode, bool leaveOpen, System.Text.Encoding entryNameEncoding) { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.IO.Compression.ZipArchiveEntry> Entries { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IO.Compression.ZipArchiveEntry>); } }
    public System.IO.Compression.ZipArchiveMode Mode { get { return default(System.IO.Compression.ZipArchiveMode); } }
    public System.IO.Compression.ZipArchiveEntry CreateEntry(string entryName) { return default(System.IO.Compression.ZipArchiveEntry); }
    public System.IO.Compression.ZipArchiveEntry CreateEntry(string entryName, System.IO.Compression.CompressionLevel compressionLevel) { return default(System.IO.Compression.ZipArchiveEntry); }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public System.IO.Compression.ZipArchiveEntry GetEntry(string entryName) { return default(System.IO.Compression.ZipArchiveEntry); }
  }

  public partial class ZipArchiveEntry {
    internal ZipArchiveEntry() { }
    public System.IO.Compression.ZipArchive Archive { get { return default(System.IO.Compression.ZipArchive); } }
    public long CompressedLength { get { return default(long); } }
    public string FullName { get { return default(string); } }
    public System.DateTimeOffset LastWriteTime { get { return default(System.DateTimeOffset); } set { } }
    public long Length { get { return default(long); } }
    public string Name { get { return default(string); } }
    public void Delete() { }
    public System.IO.Stream Open() { return default(System.IO.Stream); }
    public override string ToString() { return default(string); }
  }

  public enum ZipArchiveMode {
    Create = 1,
    Read = 0,
    Update = 2,
  }

  public static partial class ZipFile {
    public static void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName) { }
    public static void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName, System.IO.Compression.CompressionLevel compressionLevel, bool includeBaseDirectory) { }
    public static void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName, System.IO.Compression.CompressionLevel compressionLevel, bool includeBaseDirectory, System.Text.Encoding entryNameEncoding) { }
    public static void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName) { }
    public static void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName, System.Text.Encoding entryNameEncoding) { }
    public static System.IO.Compression.ZipArchive Open(string archiveFileName, System.IO.Compression.ZipArchiveMode mode) { return default(System.IO.Compression.ZipArchive); }
    public static System.IO.Compression.ZipArchive Open(string archiveFileName, System.IO.Compression.ZipArchiveMode mode, System.Text.Encoding entryNameEncoding) { return default(System.IO.Compression.ZipArchive); }
    public static System.IO.Compression.ZipArchive OpenRead(string archiveFileName) { return default(System.IO.Compression.ZipArchive); }
  }

  [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
  public static partial class ZipFileExtensions {
    public static System.IO.Compression.ZipArchiveEntry CreateEntryFromFile(this System.IO.Compression.ZipArchive destination, string sourceFileName, string entryName) { return default(System.IO.Compression.ZipArchiveEntry); }
    public static System.IO.Compression.ZipArchiveEntry CreateEntryFromFile(this System.IO.Compression.ZipArchive destination, string sourceFileName, string entryName, System.IO.Compression.CompressionLevel compressionLevel) { return default(System.IO.Compression.ZipArchiveEntry); }
    public static void ExtractToDirectory(this System.IO.Compression.ZipArchive source, string destinationDirectoryName) { }
    public static void ExtractToFile(this System.IO.Compression.ZipArchiveEntry source, string destinationFileName) { }
    public static void ExtractToFile(this System.IO.Compression.ZipArchiveEntry source, string destinationFileName, bool overwrite) { }
  }

} // end of System.IO.Compression
