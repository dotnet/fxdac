[assembly:System.CLSCompliant(true)]
namespace System.IO {

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class DriveInfo : System.Runtime.Serialization.ISerializable
    {
        public DriveInfo(string driveName) { }
        public long AvailableFreeSpace { get { return default(long); } }
        public string DriveFormat { get { return default(string); } }
        public System.IO.DriveType DriveType { get { return default(System.IO.DriveType); } }
        public bool IsReady { get { return default(bool); } }
        public string Name { get { return default(string); } }
        public System.IO.DirectoryInfo RootDirectory { get { return default(System.IO.DirectoryInfo); } }
        public long TotalFreeSpace { get { return default(long); } }
        public long TotalSize { get { return default(long); } }
        public string VolumeLabel { get { return default(string); } set { } }
        public static System.IO.DriveInfo[] GetDrives() { return default(System.IO.DriveInfo[]); }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override string ToString() { return default(string); }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DriveNotFoundException : System.IO.IOException
    {
        public DriveNotFoundException() { }
        protected DriveNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public DriveNotFoundException(string message) { }
        public DriveNotFoundException(string message, System.Exception innerException) { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum DriveType
    {
        CDRom = 5,
        Fixed = 3,
        Network = 4,
        NoRootDirectory = 1,
        Ram = 6,
        Removable = 2,
        Unknown = 0,
    }
} // end of System.IO
