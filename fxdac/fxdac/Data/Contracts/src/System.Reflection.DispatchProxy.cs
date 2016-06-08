[assembly:System.CLSCompliant(true)]
namespace System.Reflection {
  public abstract partial class DispatchProxy {
    protected DispatchProxy() { }
    public static T Create<T, TProxy>() where TProxy : System.Reflection.DispatchProxy { return default(T); }
    protected abstract object Invoke(System.Reflection.MethodInfo targetMethod, object[] args);
  }

} // end of System.Reflection
