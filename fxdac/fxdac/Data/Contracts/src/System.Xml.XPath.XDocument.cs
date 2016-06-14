[assembly:System.CLSCompliant(true)]
namespace System.Xml.XPath {
  public static partial class Extensions {
    public static System.Xml.XPath.XPathNavigator CreateNavigator(this System.Xml.Linq.XNode node) { return default(System.Xml.XPath.XPathNavigator); }
    public static System.Xml.XPath.XPathNavigator CreateNavigator(this System.Xml.Linq.XNode node, System.Xml.XmlNameTable nameTable) { return default(System.Xml.XPath.XPathNavigator); }
    public static object XPathEvaluate(this System.Xml.Linq.XNode node, string expression) { return default(object); }
    public static object XPathEvaluate(this System.Xml.Linq.XNode node, string expression, System.Xml.IXmlNamespaceResolver resolver) { return default(object); }
    public static System.Xml.Linq.XElement XPathSelectElement(this System.Xml.Linq.XNode node, string expression) { return default(System.Xml.Linq.XElement); }
    public static System.Xml.Linq.XElement XPathSelectElement(this System.Xml.Linq.XNode node, string expression, System.Xml.IXmlNamespaceResolver resolver) { return default(System.Xml.Linq.XElement); }
    public static System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> XPathSelectElements(this System.Xml.Linq.XNode node, string expression) { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>); }
    public static System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement> XPathSelectElements(this System.Xml.Linq.XNode node, string expression, System.Xml.IXmlNamespaceResolver resolver) { return default(System.Collections.Generic.IEnumerable<System.Xml.Linq.XElement>); }
  }
  public static partial class XDocumentExtensions {
    public static System.Xml.XPath.IXPathNavigable ToXPathNavigable(this System.Xml.Linq.XNode node) { return default(System.Xml.XPath.IXPathNavigable); }
  }
} // end of System.Xml.XPath
