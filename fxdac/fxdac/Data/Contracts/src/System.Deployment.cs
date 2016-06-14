[assembly:System.CLSCompliant(true)]
namespace System.Deployment.Internal {
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public static partial class InternalActivationContextHelper
    {
        public static object GetActivationContextData(System.ActivationContext appInfo) { return default(object); }
        public static object GetApplicationComponentManifest(System.ActivationContext appInfo) { return default(object); }
        public static byte[] GetApplicationManifestBytes(System.ActivationContext appInfo) { return default(byte[]); }
        public static object GetDeploymentComponentManifest(System.ActivationContext appInfo) { return default(object); }
        public static byte[] GetDeploymentManifestBytes(System.ActivationContext appInfo) { return default(byte[]); }
        public static bool IsFirstRun(System.ActivationContext appInfo) { return default(bool); }
        public static void PrepareForExecution(System.ActivationContext appInfo) { }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public static partial class InternalApplicationIdentityHelper
    {
        public static object GetInternalAppId(System.ApplicationIdentity id) { return default(object); }
    }
} // end of System.Deployment.Internal
