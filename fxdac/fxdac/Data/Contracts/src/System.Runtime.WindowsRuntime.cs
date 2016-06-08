[assembly:System.CLSCompliant(true)]
namespace Windows.Foundation {
  [System.Security.SecurityCriticalAttribute]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Point : System.IFormattable {
    public Point(double x, double y) { throw new System.NotImplementedException(); }
    public double X { get { return default(double); } set { } }
    public double Y { get { return default(double); } set { } }
    [System.Security.SecuritySafeCriticalAttribute]
    public override bool Equals(object o) { return default(bool); }
    public bool Equals(Windows.Foundation.Point value) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Windows.Foundation.Point point1, Windows.Foundation.Point point2) { return default(bool); }
    public static bool operator !=(Windows.Foundation.Point point1, Windows.Foundation.Point point2) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    string System.IFormattable.ToString(string format, System.IFormatProvider provider) { return default(string); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override string ToString() { return default(string); }
    public string ToString(System.IFormatProvider provider) { return default(string); }
  }

  [System.Security.SecurityCriticalAttribute]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Rect : System.IFormattable {
    public Rect(double x, double y, double width, double height) { throw new System.NotImplementedException(); }
    public Rect(Windows.Foundation.Point point1, Windows.Foundation.Point point2) { throw new System.NotImplementedException(); }
    public Rect(Windows.Foundation.Point location, Windows.Foundation.Size size) { throw new System.NotImplementedException(); }
    public double Bottom { get { return default(double); } }
    public static Windows.Foundation.Rect Empty { get { return default(Windows.Foundation.Rect); } }
    public double Height { get { return default(double); } set { } }
    public bool IsEmpty { get { return default(bool); } }
    public double Left { get { return default(double); } }
    public double Right { get { return default(double); } }
    public double Top { get { return default(double); } }
    public double Width { get { return default(double); } set { } }
    public double X { get { return default(double); } set { } }
    public double Y { get { return default(double); } set { } }
    public bool Contains(Windows.Foundation.Point point) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override bool Equals(object o) { return default(bool); }
    public bool Equals(Windows.Foundation.Rect value) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override int GetHashCode() { return default(int); }
    public void Intersect(Windows.Foundation.Rect rect) { }
    public static bool operator ==(Windows.Foundation.Rect rect1, Windows.Foundation.Rect rect2) { return default(bool); }
    public static bool operator !=(Windows.Foundation.Rect rect1, Windows.Foundation.Rect rect2) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    string System.IFormattable.ToString(string format, System.IFormatProvider provider) { return default(string); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override string ToString() { return default(string); }
    public string ToString(System.IFormatProvider provider) { return default(string); }
    public void Union(Windows.Foundation.Point point) { }
    public void Union(Windows.Foundation.Rect rect) { }
  }

  [System.Security.SecurityCriticalAttribute]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Size {
    public Size(double width, double height) { throw new System.NotImplementedException(); }
    public static Windows.Foundation.Size Empty { get { return default(Windows.Foundation.Size); } }
    public double Height { get { return default(double); } set { } }
    public bool IsEmpty { get { return default(bool); } }
    public double Width { get { return default(double); } set { } }
    [System.Security.SecuritySafeCriticalAttribute]
    public override bool Equals(object o) { return default(bool); }
    public bool Equals(Windows.Foundation.Size value) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Windows.Foundation.Size size1, Windows.Foundation.Size size2) { return default(bool); }
    public static bool operator !=(Windows.Foundation.Size size1, Windows.Foundation.Size size2) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override string ToString() { return default(string); }
  }

} // end of Windows.Foundation
namespace Windows.UI {
  [System.Security.SecurityCriticalAttribute]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Color : System.IFormattable {
    public byte A { get { return default(byte); } set { } }
    public byte B { get { return default(byte); } set { } }
    public byte G { get { return default(byte); } set { } }
    public byte R { get { return default(byte); } set { } }
    [System.Security.SecuritySafeCriticalAttribute]
    public override bool Equals(object o) { return default(bool); }
    public bool Equals(Windows.UI.Color color) { return default(bool); }
    public static Windows.UI.Color FromArgb(byte a, byte r, byte g, byte b) { return default(Windows.UI.Color); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Windows.UI.Color color1, Windows.UI.Color color2) { return default(bool); }
    public static bool operator !=(Windows.UI.Color color1, Windows.UI.Color color2) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    string System.IFormattable.ToString(string format, System.IFormatProvider provider) { return default(string); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override string ToString() { return default(string); }
    public string ToString(System.IFormatProvider provider) { return default(string); }
  }

} // end of Windows.UI
