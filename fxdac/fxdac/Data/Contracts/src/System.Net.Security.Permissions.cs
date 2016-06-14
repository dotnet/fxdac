[assembly:System.CLSCompliant(true)]
namespace System.Net {

    public sealed partial class WebPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission
    {
        public WebPermission() { }
        public WebPermission(System.Net.NetworkAccess access, string uriString) { }
        public WebPermission(System.Net.NetworkAccess access, System.Text.RegularExpressions.Regex uriRegex) { }
        public WebPermission(System.Security.Permissions.PermissionState state) { }
        public System.Collections.IEnumerator AcceptList { get { return default(System.Collections.IEnumerator); } }
        public System.Collections.IEnumerator ConnectList { get { return default(System.Collections.IEnumerator); } }
        public void AddPermission(System.Net.NetworkAccess access, string uriString) { }
        public void AddPermission(System.Net.NetworkAccess access, System.Text.RegularExpressions.Regex uriRegex) { }
        public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
        public override void FromXml(System.Security.SecurityElement securityElement) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
        public override bool IsSubsetOf(System.Security.IPermission target) { return default(bool); }
        public bool IsUnrestricted() { return default(bool); }
        public override System.Security.SecurityElement ToXml() { return default(System.Security.SecurityElement); }
        public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
    }

    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple = true, Inherited = false)]
    public sealed partial class WebPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public WebPermissionAttribute(System.Security.Permissions.SecurityAction action) : base(default(System.Security.Permissions.SecurityAction)) { }
        public string Accept { get { return default(string); } set { } }
        public string AcceptPattern { get { return default(string); } set { } }
        public string Connect { get { return default(string); } set { } }
        public string ConnectPattern { get { return default(string); } set { } }
        public override System.Security.IPermission CreatePermission() { return default(System.Security.IPermission); }
    }
} // end of System.Net
