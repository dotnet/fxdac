[assembly:System.CLSCompliant(true)]
namespace System.Security {

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public sealed partial class SecurityElement
    {
        public SecurityElement(string tag) { }
        public SecurityElement(string tag, string text) { }
        public System.Collections.Hashtable Attributes { get { return default(System.Collections.Hashtable); } set { } }
        public System.Collections.ArrayList Children { get { return default(System.Collections.ArrayList); } set { } }
        public string Tag { get { return default(string); } set { } }
        public string Text { get { return default(string); } set { } }
        public void AddAttribute(string name, string value) { }
        public void AddChild(System.Security.SecurityElement child) { }
        public string Attribute(string name) { return default(string); }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Security.SecurityElement Copy() { return default(System.Security.SecurityElement); }
        public bool Equal(System.Security.SecurityElement other) { return default(bool); }
        public static string Escape(string str) { return default(string); }
        public static System.Security.SecurityElement FromString(string xml) { return default(System.Security.SecurityElement); }
        public static bool IsValidAttributeName(string name) { return default(bool); }
        public static bool IsValidAttributeValue(string value) { return default(bool); }
        public static bool IsValidTag(string tag) { return default(bool); }
        public static bool IsValidText(string text) { return default(bool); }
        public System.Security.SecurityElement SearchForChildByTag(string tag) { return default(System.Security.SecurityElement); }
        public string SearchForTextOfTag(string tag) { return default(string); }
        public override string ToString() { return default(string); }
    }
} // end of System.Security
namespace System.Security.Principal {

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IIdentity
    {
        string AuthenticationType { get; }
        bool IsAuthenticated { get; }
        string Name { get; }
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial interface IPrincipal
    {
        System.Security.Principal.IIdentity Identity { get; }
        bool IsInRole(string role);
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum PrincipalPolicy
    {
        NoPrincipal = 1,
        UnauthenticatedPrincipal = 0,
        WindowsPrincipal = 2,
    }

    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum TokenImpersonationLevel
    {
        Anonymous = 1,
        Delegation = 4,
        Identification = 2,
        Impersonation = 3,
        None = 0,
    }
} // end of System.Security.Principal
