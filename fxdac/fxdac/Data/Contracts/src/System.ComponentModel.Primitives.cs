[assembly:System.CLSCompliant(true)]
namespace System.ComponentModel {
  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public sealed partial class BrowsableAttribute : System.Attribute {
    public static readonly System.ComponentModel.BrowsableAttribute Default;
    public static readonly System.ComponentModel.BrowsableAttribute No;
    public static readonly System.ComponentModel.BrowsableAttribute Yes;
    public BrowsableAttribute(bool browsable) { }
    public bool Browsable { get { return default(bool); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public partial class CategoryAttribute : System.Attribute {
    public CategoryAttribute() { }
    public CategoryAttribute(string category) { }
    public static System.ComponentModel.CategoryAttribute Action { get { return default(System.ComponentModel.CategoryAttribute); } }
    public static System.ComponentModel.CategoryAttribute Appearance { get { return default(System.ComponentModel.CategoryAttribute); } }
    public static System.ComponentModel.CategoryAttribute Asynchronous { get { return default(System.ComponentModel.CategoryAttribute); } }
    public static System.ComponentModel.CategoryAttribute Behavior { get { return default(System.ComponentModel.CategoryAttribute); } }
    public string Category { get { return default(string); } }
    public static System.ComponentModel.CategoryAttribute Data { get { return default(System.ComponentModel.CategoryAttribute); } }
    public static System.ComponentModel.CategoryAttribute Default { get { return default(System.ComponentModel.CategoryAttribute); } }
    public static System.ComponentModel.CategoryAttribute Design { get { return default(System.ComponentModel.CategoryAttribute); } }
    public static System.ComponentModel.CategoryAttribute DragDrop { get { return default(System.ComponentModel.CategoryAttribute); } }
    public static System.ComponentModel.CategoryAttribute Focus { get { return default(System.ComponentModel.CategoryAttribute); } }
    public static System.ComponentModel.CategoryAttribute Format { get { return default(System.ComponentModel.CategoryAttribute); } }
    public static System.ComponentModel.CategoryAttribute Key { get { return default(System.ComponentModel.CategoryAttribute); } }
    public static System.ComponentModel.CategoryAttribute Layout { get { return default(System.ComponentModel.CategoryAttribute); } }
    public static System.ComponentModel.CategoryAttribute Mouse { get { return default(System.ComponentModel.CategoryAttribute); } }
    public static System.ComponentModel.CategoryAttribute WindowStyle { get { return default(System.ComponentModel.CategoryAttribute); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    protected virtual string GetLocalizedString(string value) { return default(string); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class ComponentCollection : System.Collections.ReadOnlyCollectionBase {
    public ComponentCollection(System.ComponentModel.IComponent[] components) { }
    public virtual System.ComponentModel.IComponent this[int index] { get { return default(System.ComponentModel.IComponent); } }
    public virtual System.ComponentModel.IComponent this[string name] { get { return default(System.ComponentModel.IComponent); } }
    public void CopyTo(System.ComponentModel.IComponent[] array, int index) { }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class DefaultEventAttribute : System.Attribute {
    public static readonly System.ComponentModel.DefaultEventAttribute Default;
    public DefaultEventAttribute(string name) { }
    public string Name { get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public partial class DescriptionAttribute : System.Attribute {
    public static readonly System.ComponentModel.DescriptionAttribute Default;
    public DescriptionAttribute() { }
    public DescriptionAttribute(string description) { }
    public virtual string Description { get { return default(string); } }
    protected string DescriptionValue { get { return default(string); } set { } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(1028), AllowMultiple=true, Inherited=true)]
  public sealed partial class DesignerAttribute : System.Attribute {
    public DesignerAttribute(string designerTypeName) { }
    public DesignerAttribute(string designerTypeName, string designerBaseTypeName) { }
    public DesignerAttribute(string designerTypeName, System.Type designerBaseType) { }
    public DesignerAttribute(System.Type designerType) { }
    public DesignerAttribute(System.Type designerType, System.Type designerBaseType) { }
    public string DesignerBaseTypeName { get { return default(string); } }
    public string DesignerTypeName { get { return default(string); } }
    public override object TypeId { get { return default(object); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=true)]
  public sealed partial class DesignerCategoryAttribute : System.Attribute {
    public static readonly System.ComponentModel.DesignerCategoryAttribute Component;
    public static readonly System.ComponentModel.DesignerCategoryAttribute Default;
    public static readonly System.ComponentModel.DesignerCategoryAttribute Form;
    public static readonly System.ComponentModel.DesignerCategoryAttribute Generic;
    public DesignerCategoryAttribute() { }
    public DesignerCategoryAttribute(string category) { }
    public string Category { get { return default(string); } }
    public override object TypeId { get { return default(object); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum DesignerSerializationVisibility {
    Content = 2,
    Hidden = 0,
    Visible = 1,
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(960))]
  public sealed partial class DesignerSerializationVisibilityAttribute : System.Attribute {
    public static readonly System.ComponentModel.DesignerSerializationVisibilityAttribute Content;
    public static readonly System.ComponentModel.DesignerSerializationVisibilityAttribute Default;
    public static readonly System.ComponentModel.DesignerSerializationVisibilityAttribute Hidden;
    public static readonly System.ComponentModel.DesignerSerializationVisibilityAttribute Visible;
    public DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility visibility) { }
    public System.ComponentModel.DesignerSerializationVisibility Visibility { get { return default(System.ComponentModel.DesignerSerializationVisibility); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public sealed partial class DesignOnlyAttribute : System.Attribute {
    public static readonly System.ComponentModel.DesignOnlyAttribute Default;
    public static readonly System.ComponentModel.DesignOnlyAttribute No;
    public static readonly System.ComponentModel.DesignOnlyAttribute Yes;
    public DesignOnlyAttribute(bool isDesignOnly) { }
    public bool IsDesignOnly { get { return default(bool); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(708))]
  public partial class DisplayNameAttribute : System.Attribute {
    public static readonly System.ComponentModel.DisplayNameAttribute Default;
    public DisplayNameAttribute() { }
    public DisplayNameAttribute(string displayName) { }
    public virtual string DisplayName { get { return default(string); } }
    protected string DisplayNameValue { get { return default(string); } set { } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }

  public sealed partial class EventHandlerList : System.IDisposable {
    public EventHandlerList() { }
    public System.Delegate this[object key] { get { return default(System.Delegate); } set { } }
    public void AddHandler(object key, System.Delegate value) { }
    public void AddHandlers(System.ComponentModel.EventHandlerList listToAddFrom) { }
    public void Dispose() { }
    public void RemoveHandler(object key, System.Delegate value) { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface IComponent : System.IDisposable {
    System.ComponentModel.ISite Site { get; set; }
    event System.EventHandler Disposed;
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface IContainer : System.IDisposable {
    System.ComponentModel.ComponentCollection Components { get; }
    void Add(System.ComponentModel.IComponent component);
    void Add(System.ComponentModel.IComponent component, string name);
    void Remove(System.ComponentModel.IComponent component);
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public sealed partial class ImmutableObjectAttribute : System.Attribute {
    public static readonly System.ComponentModel.ImmutableObjectAttribute Default;
    public static readonly System.ComponentModel.ImmutableObjectAttribute No;
    public static readonly System.ComponentModel.ImmutableObjectAttribute Yes;
    public ImmutableObjectAttribute(bool immutable) { }
    public bool Immutable { get { return default(bool); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class InitializationEventAttribute : System.Attribute {
    public InitializationEventAttribute(string eventName) { }
    public string EventName { get { return default(string); } }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface ISite : System.IServiceProvider {
    System.ComponentModel.IComponent Component { get; }
    System.ComponentModel.IContainer Container { get; }
    bool DesignMode { get; }
    string Name { get; set; }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public sealed partial class LocalizableAttribute : System.Attribute {
    public static readonly System.ComponentModel.LocalizableAttribute Default;
    public static readonly System.ComponentModel.LocalizableAttribute No;
    public static readonly System.ComponentModel.LocalizableAttribute Yes;
    public LocalizableAttribute(bool isLocalizable) { }
    public bool IsLocalizable { get { return default(bool); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public sealed partial class MergablePropertyAttribute : System.Attribute {
    public static readonly System.ComponentModel.MergablePropertyAttribute Default;
    public static readonly System.ComponentModel.MergablePropertyAttribute No;
    public static readonly System.ComponentModel.MergablePropertyAttribute Yes;
    public MergablePropertyAttribute(bool allowMerge) { }
    public bool AllowMerge { get { return default(bool); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
  public sealed partial class NotifyParentPropertyAttribute : System.Attribute {
    public static readonly System.ComponentModel.NotifyParentPropertyAttribute Default;
    public static readonly System.ComponentModel.NotifyParentPropertyAttribute No;
    public static readonly System.ComponentModel.NotifyParentPropertyAttribute Yes;
    public NotifyParentPropertyAttribute(bool notifyParent) { }
    public bool NotifyParent { get { return default(bool); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public sealed partial class ParenthesizePropertyNameAttribute : System.Attribute {
    public static readonly System.ComponentModel.ParenthesizePropertyNameAttribute Default;
    public ParenthesizePropertyNameAttribute() { }
    public ParenthesizePropertyNameAttribute(bool needParenthesis) { }
    public bool NeedParenthesis { get { return default(bool); } }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public sealed partial class ReadOnlyAttribute : System.Attribute {
    public static readonly System.ComponentModel.ReadOnlyAttribute Default;
    public static readonly System.ComponentModel.ReadOnlyAttribute No;
    public static readonly System.ComponentModel.ReadOnlyAttribute Yes;
    public ReadOnlyAttribute(bool isReadOnly) { }
    public bool IsReadOnly { get { return default(bool); } }
    public override bool Equals(object value) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }

  public enum RefreshProperties {
    All = 1,
    None = 0,
    Repaint = 2,
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public sealed partial class RefreshPropertiesAttribute : System.Attribute {
    public static readonly System.ComponentModel.RefreshPropertiesAttribute All;
    public static readonly System.ComponentModel.RefreshPropertiesAttribute Default;
    public static readonly System.ComponentModel.RefreshPropertiesAttribute Repaint;
    public RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties refresh) { }
    public System.ComponentModel.RefreshProperties RefreshProperties { get { return default(System.ComponentModel.RefreshProperties); } }
    public override bool Equals(object value) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }

} // end of System.ComponentModel
