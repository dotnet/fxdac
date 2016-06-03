[assembly:System.CLSCompliant(true)]
namespace System.IO.Compression {
  public enum CompressionLevel {
    Fastest = 1,
    NoCompression = 2,
    Optimal = 0,
  }

  public enum CompressionMode {
    Compress = 1,
    Decompress = 0,
  }

  public partial class DeflateStream : System.IO.Stream {
    public DeflateStream(System.IO.Stream stream, System.IO.Compression.CompressionLevel compressionLevel) { }
    public DeflateStream(System.IO.Stream stream, System.IO.Compression.CompressionLevel compressionLevel, bool leaveOpen) { }
    public DeflateStream(System.IO.Stream compressedStream, System.IO.Compression.CompressionMode mode) { }
    public DeflateStream(System.IO.Stream compressedStream, System.IO.Compression.CompressionMode mode, bool leaveOpen) { }
    public System.IO.Stream BaseStream { get { return default(System.IO.Stream); } }
    public override bool CanRead { get { return default(bool); } }
    public override bool CanSeek { get { return default(bool); } }
    public override bool CanWrite { get { return default(bool); } }
    public override long Length { get { return default(long); } }
    public override long Position { get { return default(long); } set { } }
    public override System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback cback, object state) { return default(System.IAsyncResult); }
    public override System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback cback, object state) { return default(System.IAsyncResult); }
    protected override void Dispose(bool disposing) { }
    public override int EndRead(System.IAsyncResult async_result) { return default(int); }
    public override void EndWrite(System.IAsyncResult async_result) { }
    public override void Flush() { }
    public override int Read(byte[] dest, int dest_offset, int count) { return default(int); }
    public override long Seek(long offset, System.IO.SeekOrigin origin) { return default(long); }
    public override void SetLength(long value) { }
    public override void Write(byte[] src, int src_offset, int count) { }
  }

  public partial class GZipStream : System.IO.Stream {
    public GZipStream(System.IO.Stream stream, System.IO.Compression.CompressionLevel compressionLevel) { }
    public GZipStream(System.IO.Stream stream, System.IO.Compression.CompressionLevel compressionLevel, bool leaveOpen) { }
    public GZipStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode) { }
    public GZipStream(System.IO.Stream stream, System.IO.Compression.CompressionMode mode, bool leaveOpen) { }
    public System.IO.Stream BaseStream { get { return default(System.IO.Stream); } }
    public override bool CanRead { get { return default(bool); } }
    public override bool CanSeek { get { return default(bool); } }
    public override bool CanWrite { get { return default(bool); } }
    public override long Length { get { return default(long); } }
    public override long Position { get { return default(long); } set { } }
    public override System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback cback, object state) { return default(System.IAsyncResult); }
    public override System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback cback, object state) { return default(System.IAsyncResult); }
    protected override void Dispose(bool disposing) { }
    public override int EndRead(System.IAsyncResult async_result) { return default(int); }
    public override void EndWrite(System.IAsyncResult async_result) { }
    public override void Flush() { }
    public override int Read(byte[] dest, int dest_offset, int count) { return default(int); }
    public override long Seek(long offset, System.IO.SeekOrigin origin) { return default(long); }
    public override void SetLength(long value) { }
    public override void Write(byte[] src, int src_offset, int count) { }
  }

} // end of System.IO.Compression
