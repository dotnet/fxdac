[assembly:System.CLSCompliant(true)]
namespace System.ComponentModel {
  public partial class Win32Exception : System.Runtime.InteropServices.ExternalException, System.Runtime.Serialization.ISerializable {
    public Win32Exception() { }
    public Win32Exception(int error) { }
    public Win32Exception(int error, string message) { }
    protected Win32Exception(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public Win32Exception(string message) { }
    public Win32Exception(string message, System.Exception innerException) { }
    public int NativeErrorCode { get { return default(int); } }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }

} // end of System.ComponentModel
