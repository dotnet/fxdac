[assembly:System.CLSCompliant(true)]
namespace System.IO {

    [System.FlagsAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum FileAttributes
    {
        Archive = 32,
        Compressed = 2048,
        Device = 64,
        Directory = 16,
        Encrypted = 16384,
        Hidden = 2,
        IntegrityStream = 32768,
        Normal = 128,
        NoScrubData = 131072,
        NotContentIndexed = 8192,
        Offline = 4096,
        ReadOnly = 1,
        ReparsePoint = 1024,
        SparseFile = 512,
        System = 4,
        Temporary = 256,
    }

} // end of System.IO
