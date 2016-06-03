[assembly:System.CLSCompliant(true)]
namespace System.Diagnostics {
  public partial class Stopwatch {
    public static readonly long Frequency;
    public static readonly bool IsHighResolution;
    public Stopwatch() { }
    public System.TimeSpan Elapsed { get { return default(System.TimeSpan); } }
    public long ElapsedMilliseconds { get { return default(long); } }
    public long ElapsedTicks { get { return default(long); } }
    public bool IsRunning { get { return default(bool); } }
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]public static long GetTimestamp() { return default(long); }
    public void Reset() { }
    public void Restart() { }
    public void Start() { }
    public static System.Diagnostics.Stopwatch StartNew() { return default(System.Diagnostics.Stopwatch); }
    public void Stop() { }
  }

} // end of System.Diagnostics
namespace System.Net {
  public static partial class WebUtility {
    public static string HtmlDecode(string value) { return default(string); }
    public static void HtmlDecode(string value, System.IO.TextWriter output) { }
    public static string HtmlEncode(string value) { return default(string); }
    public static void HtmlEncode(string value, System.IO.TextWriter output) { }
    public static string UrlDecode(string encodedValue) { return default(string); }
    public static byte[] UrlDecodeToBytes(byte[] encodedValue, int offset, int count) { return default(byte[]); }
    public static string UrlEncode(string value) { return default(string); }
    public static byte[] UrlEncodeToBytes(byte[] value, int offset, int count) { return default(byte[]); }
  }

} // end of System.Net
