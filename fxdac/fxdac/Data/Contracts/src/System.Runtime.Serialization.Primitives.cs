[assembly:System.CLSCompliant(true)]
namespace System.Runtime.Serialization {
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class SerializationException : System.SystemException {
    public SerializationException() { }
    protected SerializationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public SerializationException(string message) { }
    public SerializationException(string message, System.Exception innerException) { }
  }

} // end of System.Runtime.Serialization
