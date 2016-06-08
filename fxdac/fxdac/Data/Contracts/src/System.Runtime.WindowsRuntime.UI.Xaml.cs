[assembly:System.CLSCompliant(true)]
namespace Windows.UI.Xaml {
  [System.Security.SecurityCriticalAttribute]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct CornerRadius {
    public CornerRadius(double uniformRadius) { throw new System.NotImplementedException(); }
    public CornerRadius(double topLeft, double topRight, double bottomRight, double bottomLeft) { throw new System.NotImplementedException(); }
    public double BottomLeft { get { return default(double); } set { } }
    public double BottomRight { get { return default(double); } set { } }
    public double TopLeft { get { return default(double); } set { } }
    public double TopRight { get { return default(double); } set { } }
    [System.Security.SecuritySafeCriticalAttribute]
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(Windows.UI.Xaml.CornerRadius cornerRadius) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Windows.UI.Xaml.CornerRadius cr1, Windows.UI.Xaml.CornerRadius cr2) { return default(bool); }
    public static bool operator !=(Windows.UI.Xaml.CornerRadius cr1, Windows.UI.Xaml.CornerRadius cr2) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override string ToString() { return default(string); }
  }

  [System.Security.SecurityCriticalAttribute]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Duration {
    public Duration(System.TimeSpan timeSpan) { throw new System.NotImplementedException(); }
    public static Windows.UI.Xaml.Duration Automatic { get { return default(Windows.UI.Xaml.Duration); } }
    public static Windows.UI.Xaml.Duration Forever { get { return default(Windows.UI.Xaml.Duration); } }
    public bool HasTimeSpan { get { return default(bool); } }
    public System.TimeSpan TimeSpan { get { return default(System.TimeSpan); } }
    public Windows.UI.Xaml.Duration Add(Windows.UI.Xaml.Duration duration) { return default(Windows.UI.Xaml.Duration); }
    public static int Compare(Windows.UI.Xaml.Duration t1, Windows.UI.Xaml.Duration t2) { return default(int); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override bool Equals(object value) { return default(bool); }
    public bool Equals(Windows.UI.Xaml.Duration duration) { return default(bool); }
    public static bool Equals(Windows.UI.Xaml.Duration t1, Windows.UI.Xaml.Duration t2) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override int GetHashCode() { return default(int); }
    public static Windows.UI.Xaml.Duration operator +(Windows.UI.Xaml.Duration t1, Windows.UI.Xaml.Duration t2) { return default(Windows.UI.Xaml.Duration); }
    public static bool operator ==(Windows.UI.Xaml.Duration t1, Windows.UI.Xaml.Duration t2) { return default(bool); }
    public static bool operator >(Windows.UI.Xaml.Duration t1, Windows.UI.Xaml.Duration t2) { return default(bool); }
    public static bool operator >=(Windows.UI.Xaml.Duration t1, Windows.UI.Xaml.Duration t2) { return default(bool); }
    public static implicit operator Windows.UI.Xaml.Duration (System.TimeSpan timeSpan) { return default(Windows.UI.Xaml.Duration); }
    public static bool operator !=(Windows.UI.Xaml.Duration t1, Windows.UI.Xaml.Duration t2) { return default(bool); }
    public static bool operator <(Windows.UI.Xaml.Duration t1, Windows.UI.Xaml.Duration t2) { return default(bool); }
    public static bool operator <=(Windows.UI.Xaml.Duration t1, Windows.UI.Xaml.Duration t2) { return default(bool); }
    public static Windows.UI.Xaml.Duration operator -(Windows.UI.Xaml.Duration t1, Windows.UI.Xaml.Duration t2) { return default(Windows.UI.Xaml.Duration); }
    public static Windows.UI.Xaml.Duration operator +(Windows.UI.Xaml.Duration duration) { return default(Windows.UI.Xaml.Duration); }
    public Windows.UI.Xaml.Duration Subtract(Windows.UI.Xaml.Duration duration) { return default(Windows.UI.Xaml.Duration); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override string ToString() { return default(string); }
  }

  [System.Security.SecurityCriticalAttribute]
  public enum DurationType {
    Automatic = 0,
    Forever = 2,
    TimeSpan = 1,
  }

  [System.Security.SecurityCriticalAttribute]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct GridLength {
    public GridLength(double pixels) { throw new System.NotImplementedException(); }
    public GridLength(double value, Windows.UI.Xaml.GridUnitType type) { throw new System.NotImplementedException(); }
    public static Windows.UI.Xaml.GridLength Auto { get { return default(Windows.UI.Xaml.GridLength); } }
    public Windows.UI.Xaml.GridUnitType GridUnitType { get { return default(Windows.UI.Xaml.GridUnitType); } }
    public bool IsAbsolute { get { return default(bool); } }
    public bool IsAuto { get { return default(bool); } }
    public bool IsStar { get { return default(bool); } }
    public double Value { get { return default(double); } }
    [System.Security.SecuritySafeCriticalAttribute]
    public override bool Equals(object oCompare) { return default(bool); }
    public bool Equals(Windows.UI.Xaml.GridLength gridLength) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Windows.UI.Xaml.GridLength gl1, Windows.UI.Xaml.GridLength gl2) { return default(bool); }
    public static bool operator !=(Windows.UI.Xaml.GridLength gl1, Windows.UI.Xaml.GridLength gl2) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override string ToString() { return default(string); }
  }

  [System.Security.SecurityCriticalAttribute]
  public enum GridUnitType {
    Auto = 0,
    Pixel = 1,
    Star = 2,
  }

  [System.Security.SecurityCriticalAttribute]
  public partial class LayoutCycleException : System.Exception {
    public LayoutCycleException() { }
    public LayoutCycleException(string message) { }
    public LayoutCycleException(string message, System.Exception innerException) { }
  }

  [System.Security.SecurityCriticalAttribute]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Thickness {
    public Thickness(double uniformLength) { throw new System.NotImplementedException(); }
    public Thickness(double left, double top, double right, double bottom) { throw new System.NotImplementedException(); }
    public double Bottom { get { return default(double); } set { } }
    public double Left { get { return default(double); } set { } }
    public double Right { get { return default(double); } set { } }
    public double Top { get { return default(double); } set { } }
    [System.Security.SecuritySafeCriticalAttribute]
    public override bool Equals(object obj) { return default(bool); }
    public bool Equals(Windows.UI.Xaml.Thickness thickness) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Windows.UI.Xaml.Thickness t1, Windows.UI.Xaml.Thickness t2) { return default(bool); }
    public static bool operator !=(Windows.UI.Xaml.Thickness t1, Windows.UI.Xaml.Thickness t2) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override string ToString() { return default(string); }
  }

} // end of Windows.UI.Xaml
namespace Windows.UI.Xaml.Automation {
  [System.Security.SecurityCriticalAttribute]
  public partial class ElementNotAvailableException : System.Exception {
    public ElementNotAvailableException() { }
    public ElementNotAvailableException(string message) { }
    public ElementNotAvailableException(string message, System.Exception innerException) { }
  }

  [System.Security.SecurityCriticalAttribute]
  public partial class ElementNotEnabledException : System.Exception {
    public ElementNotEnabledException() { }
    public ElementNotEnabledException(string message) { }
    public ElementNotEnabledException(string message, System.Exception innerException) { }
  }

} // end of Windows.UI.Xaml.Automation
namespace Windows.UI.Xaml.Controls.Primitives {
  [System.Security.SecurityCriticalAttribute]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct GeneratorPosition {
    public GeneratorPosition(int index, int offset) { throw new System.NotImplementedException(); }
    public int Index { get { return default(int); } set { } }
    public int Offset { get { return default(int); } set { } }
    [System.Security.SecuritySafeCriticalAttribute]
    public override bool Equals(object o) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Windows.UI.Xaml.Controls.Primitives.GeneratorPosition gp1, Windows.UI.Xaml.Controls.Primitives.GeneratorPosition gp2) { return default(bool); }
    public static bool operator !=(Windows.UI.Xaml.Controls.Primitives.GeneratorPosition gp1, Windows.UI.Xaml.Controls.Primitives.GeneratorPosition gp2) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override string ToString() { return default(string); }
  }

} // end of Windows.UI.Xaml.Controls.Primitives
namespace Windows.UI.Xaml.Markup {
  [System.Security.SecurityCriticalAttribute]
  public partial class XamlParseException : System.Exception {
    public XamlParseException() { }
    public XamlParseException(string message) { }
    public XamlParseException(string message, System.Exception innerException) { }
  }

} // end of Windows.UI.Xaml.Markup
namespace Windows.UI.Xaml.Media.Animation {
  [System.Security.SecurityCriticalAttribute]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct KeyTime {
    public System.TimeSpan TimeSpan { get { return default(System.TimeSpan); } }
    [System.Security.SecuritySafeCriticalAttribute]
    public override bool Equals(object value) { return default(bool); }
    public bool Equals(Windows.UI.Xaml.Media.Animation.KeyTime value) { return default(bool); }
    public static bool Equals(Windows.UI.Xaml.Media.Animation.KeyTime keyTime1, Windows.UI.Xaml.Media.Animation.KeyTime keyTime2) { return default(bool); }
    public static Windows.UI.Xaml.Media.Animation.KeyTime FromTimeSpan(System.TimeSpan timeSpan) { return default(Windows.UI.Xaml.Media.Animation.KeyTime); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Windows.UI.Xaml.Media.Animation.KeyTime keyTime1, Windows.UI.Xaml.Media.Animation.KeyTime keyTime2) { return default(bool); }
    public static implicit operator Windows.UI.Xaml.Media.Animation.KeyTime (System.TimeSpan timeSpan) { return default(Windows.UI.Xaml.Media.Animation.KeyTime); }
    public static bool operator !=(Windows.UI.Xaml.Media.Animation.KeyTime keyTime1, Windows.UI.Xaml.Media.Animation.KeyTime keyTime2) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override string ToString() { return default(string); }
  }

  [System.Security.SecurityCriticalAttribute]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct RepeatBehavior : System.IFormattable {
    public RepeatBehavior(double count) { throw new System.NotImplementedException(); }
    public RepeatBehavior(System.TimeSpan duration) { throw new System.NotImplementedException(); }
    public double Count { get { return default(double); } set { } }
    public System.TimeSpan Duration { get { return default(System.TimeSpan); } set { } }
    public static Windows.UI.Xaml.Media.Animation.RepeatBehavior Forever { get { return default(Windows.UI.Xaml.Media.Animation.RepeatBehavior); } }
    public bool HasCount { get { return default(bool); } }
    public bool HasDuration { get { return default(bool); } }
    public Windows.UI.Xaml.Media.Animation.RepeatBehaviorType Type { get { return default(Windows.UI.Xaml.Media.Animation.RepeatBehaviorType); } set { } }
    [System.Security.SecuritySafeCriticalAttribute]
    public override bool Equals(object value) { return default(bool); }
    public bool Equals(Windows.UI.Xaml.Media.Animation.RepeatBehavior repeatBehavior) { return default(bool); }
    public static bool Equals(Windows.UI.Xaml.Media.Animation.RepeatBehavior repeatBehavior1, Windows.UI.Xaml.Media.Animation.RepeatBehavior repeatBehavior2) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(Windows.UI.Xaml.Media.Animation.RepeatBehavior repeatBehavior1, Windows.UI.Xaml.Media.Animation.RepeatBehavior repeatBehavior2) { return default(bool); }
    public static bool operator !=(Windows.UI.Xaml.Media.Animation.RepeatBehavior repeatBehavior1, Windows.UI.Xaml.Media.Animation.RepeatBehavior repeatBehavior2) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    string System.IFormattable.ToString(string format, System.IFormatProvider formatProvider) { return default(string); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override string ToString() { return default(string); }
    public string ToString(System.IFormatProvider formatProvider) { return default(string); }
  }

  [System.Security.SecurityCriticalAttribute]
  public enum RepeatBehaviorType {
    Count = 0,
    Duration = 1,
    Forever = 2,
  }

} // end of Windows.UI.Xaml.Media.Animation
namespace Windows.UI.Xaml.Media.Media3D {
  [System.Security.SecurityCriticalAttribute]
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct Matrix3D : System.IFormattable {
    public Matrix3D(double m11, double m12, double m13, double m14, double m21, double m22, double m23, double m24, double m31, double m32, double m33, double m34, double offsetX, double offsetY, double offsetZ, double m44) { throw new System.NotImplementedException(); }
    public bool HasInverse { get { return default(bool); } }
    public static Windows.UI.Xaml.Media.Media3D.Matrix3D Identity { get { return default(Windows.UI.Xaml.Media.Media3D.Matrix3D); } }
    public bool IsIdentity { get { return default(bool); } }
    public double M11 { get { return default(double); } set { } }
    public double M12 { get { return default(double); } set { } }
    public double M13 { get { return default(double); } set { } }
    public double M14 { get { return default(double); } set { } }
    public double M21 { get { return default(double); } set { } }
    public double M22 { get { return default(double); } set { } }
    public double M23 { get { return default(double); } set { } }
    public double M24 { get { return default(double); } set { } }
    public double M31 { get { return default(double); } set { } }
    public double M32 { get { return default(double); } set { } }
    public double M33 { get { return default(double); } set { } }
    public double M34 { get { return default(double); } set { } }
    public double M44 { get { return default(double); } set { } }
    public double OffsetX { get { return default(double); } set { } }
    public double OffsetY { get { return default(double); } set { } }
    public double OffsetZ { get { return default(double); } set { } }
    [System.Security.SecuritySafeCriticalAttribute]
    public override bool Equals(object o) { return default(bool); }
    public bool Equals(Windows.UI.Xaml.Media.Media3D.Matrix3D value) { return default(bool); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override int GetHashCode() { return default(int); }
    public void Invert() { }
    public static bool operator ==(Windows.UI.Xaml.Media.Media3D.Matrix3D matrix1, Windows.UI.Xaml.Media.Media3D.Matrix3D matrix2) { return default(bool); }
    public static bool operator !=(Windows.UI.Xaml.Media.Media3D.Matrix3D matrix1, Windows.UI.Xaml.Media.Media3D.Matrix3D matrix2) { return default(bool); }
    public static Windows.UI.Xaml.Media.Media3D.Matrix3D operator *(Windows.UI.Xaml.Media.Media3D.Matrix3D matrix1, Windows.UI.Xaml.Media.Media3D.Matrix3D matrix2) { return default(Windows.UI.Xaml.Media.Media3D.Matrix3D); }
    [System.Security.SecuritySafeCriticalAttribute]
    string System.IFormattable.ToString(string format, System.IFormatProvider provider) { return default(string); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override string ToString() { return default(string); }
    public string ToString(System.IFormatProvider provider) { return default(string); }
  }

} // end of Windows.UI.Xaml.Media.Media3D
