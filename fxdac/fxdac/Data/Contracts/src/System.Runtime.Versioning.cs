[assembly:System.CLSCompliant(true)]
namespace System.Runtime.Versioning {
    public static partial class CompatibilitySwitch
    {
        public static string GetValue(string compatibilitySwitchName) { return default(string); }
        public static bool IsEnabled(string compatibilitySwitchName) { return default(bool); }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(5887), AllowMultiple = false, Inherited = false)]
    public sealed partial class ComponentGuaranteesAttribute : System.Attribute
    {
        public ComponentGuaranteesAttribute(System.Runtime.Versioning.ComponentGuaranteesOptions guarantees) { }
        public System.Runtime.Versioning.ComponentGuaranteesOptions Guarantees { get { return default(System.Runtime.Versioning.ComponentGuaranteesOptions); } }
    }

    [System.FlagsAttribute]
    public enum ComponentGuaranteesOptions
    {
        Exchange = 1,
        None = 0,
        SideBySide = 4,
        Stable = 2,
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(224), Inherited = false)]
    [System.Diagnostics.ConditionalAttribute("RESOURCE_ANNOTATION_WORK")]
    public sealed partial class ResourceConsumptionAttribute : System.Attribute
    {
        public ResourceConsumptionAttribute(System.Runtime.Versioning.ResourceScope resourceScope) { }
        public ResourceConsumptionAttribute(System.Runtime.Versioning.ResourceScope resourceScope, System.Runtime.Versioning.ResourceScope consumptionScope) { }
        public System.Runtime.Versioning.ResourceScope ConsumptionScope { get { return default(System.Runtime.Versioning.ResourceScope); } }
        public System.Runtime.Versioning.ResourceScope ResourceScope { get { return default(System.Runtime.Versioning.ResourceScope); } }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(480), Inherited = false)]
    [System.Diagnostics.ConditionalAttribute("RESOURCE_ANNOTATION_WORK")]
    public sealed partial class ResourceExposureAttribute : System.Attribute
    {
        public ResourceExposureAttribute(System.Runtime.Versioning.ResourceScope exposureLevel) { }
        public System.Runtime.Versioning.ResourceScope ResourceExposureLevel { get { return default(System.Runtime.Versioning.ResourceScope); } }
    }

    [System.FlagsAttribute]
    public enum ResourceScope
    {
        AppDomain = 4,
        Assembly = 32,
        Library = 8,
        Machine = 1,
        None = 0,
        Private = 16,
        Process = 2,
    }

    public static partial class VersioningHelper
    {
        public static string MakeVersionSafeName(string name, System.Runtime.Versioning.ResourceScope from, System.Runtime.Versioning.ResourceScope to) { return default(string); }
        [System.Security.SecuritySafeCriticalAttribute]
        public static string MakeVersionSafeName(string name, System.Runtime.Versioning.ResourceScope from, System.Runtime.Versioning.ResourceScope to, System.Type type) { return default(string); }
    }
} // end of System.Runtime.Versioning
