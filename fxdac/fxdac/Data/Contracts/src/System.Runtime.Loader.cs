[assembly:System.CLSCompliant(true)]
namespace System.Reflection {
  public static partial class AssemblyExtensions {
    public static System.Type[] GetExportedTypes(this System.Reflection.Assembly assembly) { return default(System.Type[]); }
    public static System.Reflection.Module[] GetModules(this System.Reflection.Assembly assembly) { return default(System.Reflection.Module[]); }
    public static System.Type[] GetTypes(this System.Reflection.Assembly assembly) { return default(System.Type[]); }
  }

} // end of System.Reflection
namespace System.Runtime.Loader {
  public abstract partial class AssemblyLoadContext {
    protected AssemblyLoadContext() { }
    public static System.Runtime.Loader.AssemblyLoadContext Default { get { return default(System.Runtime.Loader.AssemblyLoadContext); } }
    public event System.Func<System.Runtime.Loader.AssemblyLoadContext, System.Reflection.AssemblyName, System.Reflection.Assembly> Resolving { add { } remove { } }
    public event System.Action<System.Runtime.Loader.AssemblyLoadContext> Unloading { add { } remove { } }
    public static System.Reflection.AssemblyName GetAssemblyName(string assemblyPath) { return default(System.Reflection.AssemblyName); }
    public static System.Runtime.Loader.AssemblyLoadContext GetLoadContext(System.Reflection.Assembly assembly) { return default(System.Runtime.Loader.AssemblyLoadContext); }
    protected abstract System.Reflection.Assembly Load(System.Reflection.AssemblyName assemblyName);
    public System.Reflection.Assembly LoadFromAssemblyName(System.Reflection.AssemblyName assemblyName) { return default(System.Reflection.Assembly); }
    public System.Reflection.Assembly LoadFromAssemblyPath(string assemblyPath) { return default(System.Reflection.Assembly); }
    public System.Reflection.Assembly LoadFromNativeImagePath(string nativeImagePath, string assemblyPath) { return default(System.Reflection.Assembly); }
    public System.Reflection.Assembly LoadFromStream(System.IO.Stream assembly) { return default(System.Reflection.Assembly); }
    public System.Reflection.Assembly LoadFromStream(System.IO.Stream assembly, System.IO.Stream assemblySymbols) { return default(System.Reflection.Assembly); }
    protected virtual System.IntPtr LoadUnmanagedDll(string unmanagedDllName) { return default(System.IntPtr); }
    protected System.IntPtr LoadUnmanagedDllFromPath(string unmanagedDllPath) { return default(System.IntPtr); }
    public void SetProfileOptimizationRoot(string directoryPath) { }
    public void StartProfileOptimization(string profile) { }
  }

} // end of System.Runtime.Loader
