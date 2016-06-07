[assembly:System.CLSCompliant(true)]
namespace System {
  public partial class UriTypeConverter : System.ComponentModel.TypeConverter {
    public UriTypeConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }

} // end of System
namespace System.ComponentModel {
  public partial class AddingNewEventArgs : System.EventArgs {
    public AddingNewEventArgs() { }
    public AddingNewEventArgs(object newObject) { }
    public object NewObject { get { return default(object); } set { } }
  }

  public delegate void AddingNewEventHandler(object sender, System.ComponentModel.AddingNewEventArgs e);

  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public sealed partial class AmbientValueAttribute : System.Attribute {
    public AmbientValueAttribute(bool value) { }
    public AmbientValueAttribute(byte value) { }
    public AmbientValueAttribute(char value) { }
    public AmbientValueAttribute(double value) { }
    public AmbientValueAttribute(short value) { }
    public AmbientValueAttribute(int value) { }
    public AmbientValueAttribute(long value) { }
    public AmbientValueAttribute(object value) { }
    public AmbientValueAttribute(float value) { }
    public AmbientValueAttribute(string value) { }
    public AmbientValueAttribute(System.Type type, string value) { }
    public object Value { get { return default(object); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }

  public partial class ArrayConverter : System.ComponentModel.CollectionConverter {
    public ArrayConverter() { }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
    public override System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public override bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class AttributeCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    public static readonly System.ComponentModel.AttributeCollection Empty;
    protected AttributeCollection() { }
    public AttributeCollection(params System.Attribute[] attributes) { }
    protected virtual System.Attribute[] Attributes { get { return default(System.Attribute[]); } }
    public int Count { get { return default(int); } }
    public virtual System.Attribute this[int index] { get { return default(System.Attribute); } }
    public virtual System.Attribute this[System.Type attributeType] { get { return default(System.Attribute); } }
    int System.Collections.ICollection.Count { get { return default(int); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    public bool Contains(System.Attribute attribute) { return default(bool); }
    public bool Contains(System.Attribute[] attributes) { return default(bool); }
    public void CopyTo(System.Array array, int index) { }
    public static System.ComponentModel.AttributeCollection FromExisting(System.ComponentModel.AttributeCollection existing, params System.Attribute[] newAttributes) { return default(System.ComponentModel.AttributeCollection); }
    protected System.Attribute GetDefaultAttribute(System.Type attributeType) { return default(System.Attribute); }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public bool Matches(System.Attribute attribute) { return default(bool); }
    public bool Matches(System.Attribute[] attributes) { return default(bool); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
  public partial class AttributeProviderAttribute : System.Attribute {
    public AttributeProviderAttribute(string typeName) { }
    public AttributeProviderAttribute(string typeName, string propertyName) { }
    public AttributeProviderAttribute(System.Type type) { }
    public string PropertyName { get { return default(string); } }
    public string TypeName { get { return default(string); } }
  }

  public abstract partial class BaseNumberConverter : System.ComponentModel.TypeConverter {
    protected BaseNumberConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type t) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public sealed partial class BindableAttribute : System.Attribute {
    public static readonly System.ComponentModel.BindableAttribute Default;
    public static readonly System.ComponentModel.BindableAttribute No;
    public static readonly System.ComponentModel.BindableAttribute Yes;
    public BindableAttribute(bool bindable) { }
    public BindableAttribute(bool bindable, System.ComponentModel.BindingDirection direction) { }
    public BindableAttribute(System.ComponentModel.BindableSupport flags) { }
    public BindableAttribute(System.ComponentModel.BindableSupport flags, System.ComponentModel.BindingDirection direction) { }
    public bool Bindable { get { return default(bool); } }
    public System.ComponentModel.BindingDirection Direction { get { return default(System.ComponentModel.BindingDirection); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }

  public enum BindableSupport {
    Default = 2,
    No = 0,
    Yes = 1,
  }

  public enum BindingDirection {
    OneWay = 0,
    TwoWay = 1,
  }

  public partial class BindingList<T> : System.Collections.ObjectModel.Collection<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.IBindingList, System.ComponentModel.ICancelAddNew, System.ComponentModel.IRaiseItemChangedEvents {
    public BindingList() { }
    public BindingList(System.Collections.Generic.IList<T> list) { }
    public bool AllowEdit { get { return default(bool); } set { } }
    public bool AllowNew { get { return default(bool); } set { } }
    public bool AllowRemove { get { return default(bool); } set { } }
    protected virtual bool IsSortedCore { get { return default(bool); } }
    public bool RaiseListChangedEvents { get { return default(bool); } set { } }
    protected virtual System.ComponentModel.ListSortDirection SortDirectionCore { get { return default(System.ComponentModel.ListSortDirection); } }
    protected virtual System.ComponentModel.PropertyDescriptor SortPropertyCore { get { return default(System.ComponentModel.PropertyDescriptor); } }
    protected virtual bool SupportsChangeNotificationCore { get { return default(bool); } }
    protected virtual bool SupportsSearchingCore { get { return default(bool); } }
    protected virtual bool SupportsSortingCore { get { return default(bool); } }
    bool System.ComponentModel.IBindingList.AllowEdit { get { return default(bool); } }
    bool System.ComponentModel.IBindingList.AllowNew { get { return default(bool); } }
    bool System.ComponentModel.IBindingList.AllowRemove { get { return default(bool); } }
    bool System.ComponentModel.IBindingList.IsSorted { get { return default(bool); } }
    System.ComponentModel.ListSortDirection System.ComponentModel.IBindingList.SortDirection { get { return default(System.ComponentModel.ListSortDirection); } }
    System.ComponentModel.PropertyDescriptor System.ComponentModel.IBindingList.SortProperty { get { return default(System.ComponentModel.PropertyDescriptor); } }
    bool System.ComponentModel.IBindingList.SupportsChangeNotification { get { return default(bool); } }
    bool System.ComponentModel.IBindingList.SupportsSearching { get { return default(bool); } }
    bool System.ComponentModel.IBindingList.SupportsSorting { get { return default(bool); } }
    bool System.ComponentModel.IRaiseItemChangedEvents.RaisesItemChangedEvents { get { return default(bool); } }
    public event System.ComponentModel.AddingNewEventHandler AddingNew { add { } remove { } }
    public event System.ComponentModel.ListChangedEventHandler ListChanged { add { } remove { } }
    public T AddNew() { return default(T); }
    protected virtual object AddNewCore() { return default(object); }
    protected virtual void ApplySortCore(System.ComponentModel.PropertyDescriptor prop, System.ComponentModel.ListSortDirection direction) { }
    public virtual void CancelNew(int itemIndex) { }
    protected override void ClearItems() { }
    public virtual void EndNew(int itemIndex) { }
    protected virtual int FindCore(System.ComponentModel.PropertyDescriptor prop, object key) { return default(int); }
    protected override void InsertItem(int index, T item) { }
    protected virtual void OnAddingNew(System.ComponentModel.AddingNewEventArgs e) { }
    protected virtual void OnListChanged(System.ComponentModel.ListChangedEventArgs e) { }
    protected override void RemoveItem(int index) { }
    protected virtual void RemoveSortCore() { }
    public void ResetBindings() { }
    public void ResetItem(int position) { }
    protected override void SetItem(int index, T item) { }
    void System.ComponentModel.IBindingList.AddIndex(System.ComponentModel.PropertyDescriptor prop) { }
    object System.ComponentModel.IBindingList.AddNew() { return default(object); }
    void System.ComponentModel.IBindingList.ApplySort(System.ComponentModel.PropertyDescriptor prop, System.ComponentModel.ListSortDirection direction) { }
    int System.ComponentModel.IBindingList.Find(System.ComponentModel.PropertyDescriptor prop, object key) { return default(int); }
    void System.ComponentModel.IBindingList.RemoveIndex(System.ComponentModel.PropertyDescriptor prop) { }
    void System.ComponentModel.IBindingList.RemoveSort() { }
  }

  public partial class BooleanConverter : System.ComponentModel.TypeConverter {
    public BooleanConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }

  public partial class ByteConverter : System.ComponentModel.BaseNumberConverter {
    public ByteConverter() { }
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

  public partial class CharConverter : System.ComponentModel.TypeConverter {
    public CharConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }

  public enum CollectionChangeAction {
    Add = 1,
    Refresh = 3,
    Remove = 2,
  }

  public partial class CollectionChangeEventArgs : System.EventArgs {
    public CollectionChangeEventArgs(System.ComponentModel.CollectionChangeAction action, object element) { }
    public virtual System.ComponentModel.CollectionChangeAction Action { get { return default(System.ComponentModel.CollectionChangeAction); } }
    public virtual object Element { get { return default(object); } }
  }

  public delegate void CollectionChangeEventHandler(object sender, System.ComponentModel.CollectionChangeEventArgs e);

  public partial class CollectionConverter : System.ComponentModel.TypeConverter {
    public CollectionConverter() { }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
    public override System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public override bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class ComplexBindingPropertiesAttribute : System.Attribute {
    public static readonly System.ComponentModel.ComplexBindingPropertiesAttribute Default;
    public ComplexBindingPropertiesAttribute() { }
    public ComplexBindingPropertiesAttribute(string dataSource) { }
    public ComplexBindingPropertiesAttribute(string dataSource, string dataMember) { }
    public string DataMember { get { return default(string); } }
    public string DataSource { get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }

  [System.ComponentModel.DesignerCategoryAttribute("Component")]
  [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(1))]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class Component :System.ComponentModel.IComponent, System.IDisposable {
    public Component() { }
    protected virtual bool CanRaiseEvents { get { return default(bool); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.ComponentModel.IContainer Container { get { return default(System.ComponentModel.IContainer); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    protected bool DesignMode { get { return default(bool); } }
    protected System.ComponentModel.EventHandlerList Events { get { return default(System.ComponentModel.EventHandlerList); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public virtual System.ComponentModel.ISite Site { get { return default(System.ComponentModel.ISite); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public event System.EventHandler Disposed { add { } remove { } }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    ~Component() { }
    protected virtual object GetService(System.Type service) { return default(object); }
    public override string ToString() { return default(string); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class ComponentCollection : System.Collections.ReadOnlyCollectionBase {
    public ComponentCollection(System.ComponentModel.IComponent[] components) { }
    public virtual System.ComponentModel.IComponent this[int index] { get { return default(System.ComponentModel.IComponent); } }
    public virtual System.ComponentModel.IComponent this[string name] { get { return default(System.ComponentModel.IComponent); } }
    public void CopyTo(System.ComponentModel.IComponent[] array, int index) { }
  }

  public partial class ComponentConverter : System.ComponentModel.ReferenceConverter {
    public ComponentConverter(System.Type type) : base (default(System.Type)) { }
    public override System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public override bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }

  public abstract partial class ComponentEditor {
    protected ComponentEditor() { }
    public abstract bool EditComponent(System.ComponentModel.ITypeDescriptorContext context, object component);
    public bool EditComponent(object component) { return default(bool); }
  }

  public partial class ComponentResourceManager : System.Resources.ResourceManager {
    public ComponentResourceManager() { }
    public ComponentResourceManager(System.Type t) { }
    public void ApplyResources(object value, string objectName) { }
    public virtual void ApplyResources(object value, string objectName, System.Globalization.CultureInfo culture) { }
  }

  public partial class Container : System.ComponentModel.IContainer, System.IDisposable {
    public Container() { }
    public virtual System.ComponentModel.ComponentCollection Components { get { return default(System.ComponentModel.ComponentCollection); } }
    public virtual void Add(System.ComponentModel.IComponent component) { }
    public virtual void Add(System.ComponentModel.IComponent component, string name) { }
    protected virtual System.ComponentModel.ISite CreateSite(System.ComponentModel.IComponent component, string name) { return default(System.ComponentModel.ISite); }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    ~Container() { }
    protected virtual object GetService(System.Type service) { return default(object); }
    public virtual void Remove(System.ComponentModel.IComponent component) { }
    protected void RemoveWithoutUnsiting(System.ComponentModel.IComponent component) { }
    protected virtual void ValidateName(System.ComponentModel.IComponent component, string name) { }
  }

  public abstract partial class ContainerFilterService {
    protected ContainerFilterService() { }
    public virtual System.ComponentModel.ComponentCollection FilterComponents(System.ComponentModel.ComponentCollection components) { return default(System.ComponentModel.ComponentCollection); }
  }

  public partial class CultureInfoConverter : System.ComponentModel.TypeConverter {
    public CultureInfoConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
    protected virtual string GetCultureName(System.Globalization.CultureInfo culture) { return default(string); }
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }

  public abstract partial class CustomTypeDescriptor : System.ComponentModel.ICustomTypeDescriptor {
    protected CustomTypeDescriptor() { }
    protected CustomTypeDescriptor(System.ComponentModel.ICustomTypeDescriptor parent) { }
    public virtual System.ComponentModel.AttributeCollection GetAttributes() { return default(System.ComponentModel.AttributeCollection); }
    public virtual string GetClassName() { return default(string); }
    public virtual string GetComponentName() { return default(string); }
    public virtual System.ComponentModel.TypeConverter GetConverter() { return default(System.ComponentModel.TypeConverter); }
    public virtual System.ComponentModel.EventDescriptor GetDefaultEvent() { return default(System.ComponentModel.EventDescriptor); }
    public virtual System.ComponentModel.PropertyDescriptor GetDefaultProperty() { return default(System.ComponentModel.PropertyDescriptor); }
    public virtual object GetEditor(System.Type editorBaseType) { return default(object); }
    public virtual System.ComponentModel.EventDescriptorCollection GetEvents() { return default(System.ComponentModel.EventDescriptorCollection); }
    public virtual System.ComponentModel.EventDescriptorCollection GetEvents(System.Attribute[] attributes) { return default(System.ComponentModel.EventDescriptorCollection); }
    public virtual System.ComponentModel.PropertyDescriptorCollection GetProperties() { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public virtual System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public virtual object GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd) { return default(object); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class DataObjectAttribute : System.Attribute {
    public static readonly System.ComponentModel.DataObjectAttribute DataObject;
    public static readonly System.ComponentModel.DataObjectAttribute Default;
    public static readonly System.ComponentModel.DataObjectAttribute NonDataObject;
    public DataObjectAttribute() { }
    public DataObjectAttribute(bool isDataObject) { }
    public bool IsDataObject { get { return default(bool); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
  public sealed partial class DataObjectFieldAttribute : System.Attribute {
    public DataObjectFieldAttribute(bool primaryKey) { }
    public DataObjectFieldAttribute(bool primaryKey, bool isIdentity) { }
    public DataObjectFieldAttribute(bool primaryKey, bool isIdentity, bool isNullable) { }
    public DataObjectFieldAttribute(bool primaryKey, bool isIdentity, bool isNullable, int length) { }
    public bool IsIdentity { get { return default(bool); } }
    public bool IsNullable { get { return default(bool); } }
    public int Length { get { return default(int); } }
    public bool PrimaryKey { get { return default(bool); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
  public sealed partial class DataObjectMethodAttribute : System.Attribute {
    public DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType methodType) { }
    public DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType methodType, bool isDefault) { }
    public bool IsDefault { get { return default(bool); } }
    public System.ComponentModel.DataObjectMethodType MethodType { get { return default(System.ComponentModel.DataObjectMethodType); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool Match(object obj) { return default(bool); }
  }

  public enum DataObjectMethodType {
    Delete = 4,
    Fill = 0,
    Insert = 3,
    Select = 1,
    Update = 2,
  }

  public partial class DateTimeConverter : System.ComponentModel.TypeConverter {
    public DateTimeConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }

  public partial class DateTimeOffsetConverter : System.ComponentModel.TypeConverter {
    public DateTimeOffsetConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }

  public partial class DecimalConverter : System.ComponentModel.BaseNumberConverter {
    public DecimalConverter() { }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class DefaultBindingPropertyAttribute : System.Attribute {
    public static readonly System.ComponentModel.DefaultBindingPropertyAttribute Default;
    public DefaultBindingPropertyAttribute() { }
    public DefaultBindingPropertyAttribute(string name) { }
    public string Name { get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class DefaultPropertyAttribute : System.Attribute {
    public static readonly System.ComponentModel.DefaultPropertyAttribute Default;
    public DefaultPropertyAttribute(string name) { }
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

  [System.AttributeUsageAttribute((System.AttributeTargets)(1028))]
  public sealed partial class DesignTimeVisibleAttribute : System.Attribute {
    public static readonly System.ComponentModel.DesignTimeVisibleAttribute Default;
    public static readonly System.ComponentModel.DesignTimeVisibleAttribute No;
    public static readonly System.ComponentModel.DesignTimeVisibleAttribute Yes;
    public DesignTimeVisibleAttribute() { }
    public DesignTimeVisibleAttribute(bool visible) { }
    public bool Visible { get { return default(bool); } }
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

  public partial class DoubleConverter : System.ComponentModel.BaseNumberConverter {
    public DoubleConverter() { }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true, Inherited=true)]
  public sealed partial class EditorAttribute : System.Attribute {
    public EditorAttribute() { }
    public EditorAttribute(string typeName, string baseTypeName) { }
    public EditorAttribute(string typeName, System.Type baseType) { }
    public EditorAttribute(System.Type type, System.Type baseType) { }
    public string EditorBaseTypeName { get { return default(string); } }
    public string EditorTypeName { get { return default(string); } }
    public override object TypeId { get { return default(object); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }

  public partial class EnumConverter : System.ComponentModel.TypeConverter {
    public EnumConverter(System.Type type) { }
    protected virtual System.Collections.IComparer Comparer { get { return default(System.Collections.IComparer); } }
    protected System.Type EnumType { get { return default(System.Type); } }
    protected System.ComponentModel.TypeConverter.StandardValuesCollection Values { get { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); } set { } }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override bool IsValid(System.ComponentModel.ITypeDescriptorContext context, object value) { return default(bool); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class EventDescriptor : System.ComponentModel.MemberDescriptor {
    protected EventDescriptor(System.ComponentModel.MemberDescriptor descr) : base (default(string)) { }
    protected EventDescriptor(System.ComponentModel.MemberDescriptor descr, System.Attribute[] attrs) : base (default(string)) { }
    protected EventDescriptor(string name, System.Attribute[] attrs) : base (default(string)) { }
    public abstract System.Type ComponentType { get; }
    public abstract System.Type EventType { get; }
    public abstract bool IsMulticast { get; }
    public abstract void AddEventHandler(object component, System.Delegate value);
    public abstract void RemoveEventHandler(object component, System.Delegate value);
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class EventDescriptorCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    public static readonly System.ComponentModel.EventDescriptorCollection Empty;
    public EventDescriptorCollection(System.ComponentModel.EventDescriptor[] events) { }
    public EventDescriptorCollection(System.ComponentModel.EventDescriptor[] events, bool readOnly) { }
    public int Count { get { return default(int); } }
    public virtual System.ComponentModel.EventDescriptor this[int index] { get { return default(System.ComponentModel.EventDescriptor); } }
    public virtual System.ComponentModel.EventDescriptor this[string name] { get { return default(System.ComponentModel.EventDescriptor); } }
    int System.Collections.ICollection.Count { get { return default(int); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    public int Add(System.ComponentModel.EventDescriptor value) { return default(int); }
    public void Clear() { }
    public bool Contains(System.ComponentModel.EventDescriptor value) { return default(bool); }
    public virtual System.ComponentModel.EventDescriptor Find(string name, bool ignoreCase) { return default(System.ComponentModel.EventDescriptor); }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public int IndexOf(System.ComponentModel.EventDescriptor value) { return default(int); }
    public void Insert(int index, System.ComponentModel.EventDescriptor value) { }
    protected void InternalSort(System.Collections.IComparer sorter) { }
    protected void InternalSort(string[] names) { }
    public void Remove(System.ComponentModel.EventDescriptor value) { }
    public void RemoveAt(int index) { }
    public virtual System.ComponentModel.EventDescriptorCollection Sort() { return default(System.ComponentModel.EventDescriptorCollection); }
    public virtual System.ComponentModel.EventDescriptorCollection Sort(System.Collections.IComparer comparer) { return default(System.ComponentModel.EventDescriptorCollection); }
    public virtual System.ComponentModel.EventDescriptorCollection Sort(string[] names) { return default(System.ComponentModel.EventDescriptorCollection); }
    public virtual System.ComponentModel.EventDescriptorCollection Sort(string[] names, System.Collections.IComparer comparer) { return default(System.ComponentModel.EventDescriptorCollection); }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    int System.Collections.IList.Add(object value) { return default(int); }
    void System.Collections.IList.Clear() { }
    bool System.Collections.IList.Contains(object value) { return default(bool); }
    int System.Collections.IList.IndexOf(object value) { return default(int); }
    void System.Collections.IList.Insert(int index, object value) { }
    void System.Collections.IList.Remove(object value) { }
    void System.Collections.IList.RemoveAt(int index) { }
  }

  public sealed partial class EventHandlerList : System.IDisposable {
    public EventHandlerList() { }
    public System.Delegate this[object key] { get { return default(System.Delegate); } set { } }
    public void AddHandler(object key, System.Delegate value) { }
    public void AddHandlers(System.ComponentModel.EventHandlerList listToAddFrom) { }
    public void Dispose() { }
    public void RemoveHandler(object key, System.Delegate value) { }
  }

  public partial class ExpandableObjectConverter : System.ComponentModel.TypeConverter {
    public ExpandableObjectConverter() { }
    public override System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public override bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public sealed partial class ExtenderProvidedPropertyAttribute : System.Attribute {
    public ExtenderProvidedPropertyAttribute() { }
    public System.ComponentModel.PropertyDescriptor ExtenderProperty { get { return default(System.ComponentModel.PropertyDescriptor); } }
    public System.ComponentModel.IExtenderProvider Provider { get { return default(System.ComponentModel.IExtenderProvider); } }
    public System.Type ReceiverType { get { return default(System.Type); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }

  public partial class GuidConverter : System.ComponentModel.TypeConverter {
    public GuidConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }

  public partial class HandledEventArgs : System.EventArgs {
    public HandledEventArgs() { }
    public HandledEventArgs(bool defaultHandledValue) { }
    public bool Handled { get { return default(bool); } set { } }
  }

  public delegate void HandledEventHandler(object sender, System.ComponentModel.HandledEventArgs e);

  public partial interface IBindingList : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    bool AllowEdit { get; }
    bool AllowNew { get; }
    bool AllowRemove { get; }
    bool IsSorted { get; }
    System.ComponentModel.ListSortDirection SortDirection { get; }
    System.ComponentModel.PropertyDescriptor SortProperty { get; }
    bool SupportsChangeNotification { get; }
    bool SupportsSearching { get; }
    bool SupportsSorting { get; }
    event System.ComponentModel.ListChangedEventHandler ListChanged;
    void AddIndex(System.ComponentModel.PropertyDescriptor property);
    object AddNew();
    void ApplySort(System.ComponentModel.PropertyDescriptor property, System.ComponentModel.ListSortDirection direction);
    int Find(System.ComponentModel.PropertyDescriptor property, object key);
    void RemoveIndex(System.ComponentModel.PropertyDescriptor property);
    void RemoveSort();
  }

  public partial interface IBindingListView : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.IBindingList {
    string Filter { get; set; }
    System.ComponentModel.ListSortDescriptionCollection SortDescriptions { get; }
    bool SupportsAdvancedSorting { get; }
    bool SupportsFiltering { get; }
    void ApplySort(System.ComponentModel.ListSortDescriptionCollection sorts);
    void RemoveFilter();
  }

  public partial interface ICancelAddNew {
    void CancelNew(int itemIndex);
    void EndNew(int itemIndex);
  }

  [System.ObsoleteAttribute("This interface has been deprecated. Add a TypeDescriptionProvider to handle type TypeDescriptor.ComObjectType instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
  public partial interface IComNativeDescriptorHandler {
    System.ComponentModel.AttributeCollection GetAttributes(object component);
    string GetClassName(object component);
    System.ComponentModel.TypeConverter GetConverter(object component);
    System.ComponentModel.EventDescriptor GetDefaultEvent(object component);
    System.ComponentModel.PropertyDescriptor GetDefaultProperty(object component);
    object GetEditor(object component, System.Type baseEditorType);
    System.ComponentModel.EventDescriptorCollection GetEvents(object component);
    System.ComponentModel.EventDescriptorCollection GetEvents(object component, System.Attribute[] attributes);
    string GetName(object component);
    System.ComponentModel.PropertyDescriptorCollection GetProperties(object component, System.Attribute[] attributes);
    object GetPropertyValue(object component, int dispid, ref bool success);
    object GetPropertyValue(object component, string propertyName, ref bool success);
  }

  [System.ComponentModel.DesignerAttribute("System.ComponentModel.Design.ComponentDesigner, System.Design, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.ComponentModel.Design.IDesigner))]
  [System.ComponentModel.DesignerAttribute("System.Windows.Forms.Design.ComponentDocumentDesigner, System.Design, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.ComponentModel.Design.IRootDesigner))]
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

  public partial interface ICustomTypeDescriptor {
    System.ComponentModel.AttributeCollection GetAttributes();
    string GetClassName();
    string GetComponentName();
    System.ComponentModel.TypeConverter GetConverter();
    System.ComponentModel.EventDescriptor GetDefaultEvent();
    System.ComponentModel.PropertyDescriptor GetDefaultProperty();
    object GetEditor(System.Type editorBaseType);
    System.ComponentModel.EventDescriptorCollection GetEvents();
    System.ComponentModel.EventDescriptorCollection GetEvents(System.Attribute[] attributes);
    System.ComponentModel.PropertyDescriptorCollection GetProperties();
    System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Attribute[] attributes);
    object GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd);
  }

  public partial interface IDataErrorInfo {
    string Error { get; }
    string this[string columnName] { get; }
  }

  public partial interface IExtenderProvider {
    bool CanExtend(object extendee);
  }

  public partial interface IIntellisenseBuilder {
    string Name { get; }
    bool Show(string language, string value, ref string newValue);
  }

  [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.DataSourceListEditor, System.Design, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [System.ComponentModel.MergablePropertyAttribute(false)]
  public partial interface IListSource {
    bool ContainsListCollection { get; }
    System.Collections.IList GetList();
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

  public partial interface INestedContainer : System.ComponentModel.IContainer, System.IDisposable {
    System.ComponentModel.IComponent Owner { get; }
  }

  public partial interface INestedSite : System.ComponentModel.ISite, System.IServiceProvider {
    string FullName { get; }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(896))]
  public sealed partial class InheritanceAttribute : System.Attribute {
    public static readonly System.ComponentModel.InheritanceAttribute Default;
    public static readonly System.ComponentModel.InheritanceAttribute Inherited;
    public static readonly System.ComponentModel.InheritanceAttribute InheritedReadOnly;
    public static readonly System.ComponentModel.InheritanceAttribute NotInherited;
    public InheritanceAttribute() { }
    public InheritanceAttribute(System.ComponentModel.InheritanceLevel inheritanceLevel) { }
    public System.ComponentModel.InheritanceLevel InheritanceLevel { get { return default(System.ComponentModel.InheritanceLevel); } }
    public override bool Equals(object value) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
    public override string ToString() { return default(string); }
  }

  public enum InheritanceLevel {
    Inherited = 1,
    InheritedReadOnly = 2,
    NotInherited = 3,
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class InitializationEventAttribute : System.Attribute {
    public InitializationEventAttribute(string eventName) { }
    public string EventName { get { return default(string); } }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public partial class InstallerTypeAttribute : System.Attribute {
    public InstallerTypeAttribute(string typeName) { }
    public InstallerTypeAttribute(System.Type installerType) { }
    public virtual System.Type InstallerType { get { return default(System.Type); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }

  public abstract partial class InstanceCreationEditor {
    protected InstanceCreationEditor() { }
    public virtual string Text { get { return default(string); } }
    public abstract object CreateInstance(System.ComponentModel.ITypeDescriptorContext context, System.Type instanceType);
  }

  public partial class Int16Converter : System.ComponentModel.BaseNumberConverter {
    public Int16Converter() { }
  }

  public partial class Int32Converter : System.ComponentModel.BaseNumberConverter {
    public Int32Converter() { }
  }

  public partial class Int64Converter : System.ComponentModel.BaseNumberConverter {
    public Int64Converter() { }
  }

  public partial class InvalidAsynchronousStateException : System.ArgumentException {
    public InvalidAsynchronousStateException() { }
    protected InvalidAsynchronousStateException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public InvalidAsynchronousStateException(string message) { }
    public InvalidAsynchronousStateException(string message, System.Exception innerException) { }
  }

  public partial class InvalidEnumArgumentException : System.ArgumentException {
    public InvalidEnumArgumentException() { }
    protected InvalidEnumArgumentException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public InvalidEnumArgumentException(string message) { }
    public InvalidEnumArgumentException(string message, System.Exception innerException) { }
    public InvalidEnumArgumentException(string argumentName, int invalidValue, System.Type enumClass) { }
  }

  public partial interface IRaiseItemChangedEvents {
    bool RaisesItemChangedEvents { get; }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface ISite : System.IServiceProvider {
    System.ComponentModel.IComponent Component { get; }
    System.ComponentModel.IContainer Container { get; }
    bool DesignMode { get; }
    string Name { get; set; }
  }

  public partial interface ISupportInitialize {
    void BeginInit();
    void EndInit();
  }

  public partial interface ISupportInitializeNotification : System.ComponentModel.ISupportInitialize {
    bool IsInitialized { get; }
    event System.EventHandler Initialized;
  }

  public partial interface ISynchronizeInvoke {
    bool InvokeRequired { get; }
    System.IAsyncResult BeginInvoke(System.Delegate method, object[] args);
    object EndInvoke(System.IAsyncResult result);
    object Invoke(System.Delegate method, object[] args);
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface ITypeDescriptorContext : System.IServiceProvider {
    System.ComponentModel.IContainer Container { get; }
    object Instance { get; }
    System.ComponentModel.PropertyDescriptor PropertyDescriptor { get; }
    void OnComponentChanged();
    bool OnComponentChanging();
  }

  public partial interface ITypedList {
    System.ComponentModel.PropertyDescriptorCollection GetItemProperties(System.ComponentModel.PropertyDescriptor[] listAccessors);
    string GetListName(System.ComponentModel.PropertyDescriptor[] listAccessors);
  }

  public abstract partial class License : System.IDisposable {
    protected License() { }
    public abstract string LicenseKey { get; }
    public abstract void Dispose();
  }

  public partial class LicenseContext : System.IServiceProvider {
    public LicenseContext() { }
    public virtual System.ComponentModel.LicenseUsageMode UsageMode { get { return default(System.ComponentModel.LicenseUsageMode); } }
    public virtual string GetSavedLicenseKey(System.Type type, System.Reflection.Assembly resourceAssembly) { return default(string); }
    public virtual object GetService(System.Type type) { return default(object); }
    public virtual void SetSavedLicenseKey(System.Type type, string key) { }
  }

  public partial class LicenseException : System.SystemException {
    protected LicenseException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public LicenseException(System.Type type) { }
    public LicenseException(System.Type type, object instance) { }
    public LicenseException(System.Type type, object instance, string message) { }
    public LicenseException(System.Type type, object instance, string message, System.Exception innerException) { }
    public System.Type LicensedType { get { return default(System.Type); } }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }

  public sealed partial class LicenseManager {
    internal LicenseManager() { }
    public static System.ComponentModel.LicenseContext CurrentContext { get { return default(System.ComponentModel.LicenseContext); } set { } }
    public static System.ComponentModel.LicenseUsageMode UsageMode { get { return default(System.ComponentModel.LicenseUsageMode); } }
    public static object CreateWithContext(System.Type type, System.ComponentModel.LicenseContext creationContext) { return default(object); }
    public static object CreateWithContext(System.Type type, System.ComponentModel.LicenseContext creationContext, object[] args) { return default(object); }
    public static bool IsLicensed(System.Type type) { return default(bool); }
    public static bool IsValid(System.Type type) { return default(bool); }
    public static bool IsValid(System.Type type, object instance, out System.ComponentModel.License license) { license = default(System.ComponentModel.License); return default(bool); }
    public static void LockContext(object contextUser) { }
    public static void UnlockContext(object contextUser) { }
    public static void Validate(System.Type type) { }
    public static System.ComponentModel.License Validate(System.Type type, object instance) { return default(System.ComponentModel.License); }
  }

  public abstract partial class LicenseProvider {
    protected LicenseProvider() { }
    public abstract System.ComponentModel.License GetLicense(System.ComponentModel.LicenseContext context, System.Type type, object instance, bool allowExceptions);
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=false)]
  public sealed partial class LicenseProviderAttribute : System.Attribute {
    public static readonly System.ComponentModel.LicenseProviderAttribute Default;
    public LicenseProviderAttribute() { }
    public LicenseProviderAttribute(string typeName) { }
    public LicenseProviderAttribute(System.Type type) { }
    public System.Type LicenseProvider { get { return default(System.Type); } }
    public override object TypeId { get { return default(object); } }
    public override bool Equals(object value) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }

  public enum LicenseUsageMode {
    Designtime = 1,
    Runtime = 0,
  }

  public partial class LicFileLicenseProvider : System.ComponentModel.LicenseProvider {
    public LicFileLicenseProvider() { }
    protected virtual string GetKey(System.Type type) { return default(string); }
    public override System.ComponentModel.License GetLicense(System.ComponentModel.LicenseContext context, System.Type type, object instance, bool allowExceptions) { return default(System.ComponentModel.License); }
    protected virtual bool IsKeyValid(string key, System.Type type) { return default(bool); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public sealed partial class ListBindableAttribute : System.Attribute {
    public static readonly System.ComponentModel.ListBindableAttribute Default;
    public static readonly System.ComponentModel.ListBindableAttribute No;
    public static readonly System.ComponentModel.ListBindableAttribute Yes;
    public ListBindableAttribute(bool listBindable) { }
    public ListBindableAttribute(System.ComponentModel.BindableSupport flags) { }
    public bool ListBindable { get { return default(bool); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }

  public partial class ListChangedEventArgs : System.EventArgs {
    public ListChangedEventArgs(System.ComponentModel.ListChangedType listChangedType, System.ComponentModel.PropertyDescriptor propDesc) { }
    public ListChangedEventArgs(System.ComponentModel.ListChangedType listChangedType, int newIndex) { }
    public ListChangedEventArgs(System.ComponentModel.ListChangedType listChangedType, int newIndex, System.ComponentModel.PropertyDescriptor propDesc) { }
    public ListChangedEventArgs(System.ComponentModel.ListChangedType listChangedType, int newIndex, int oldIndex) { }
    public System.ComponentModel.ListChangedType ListChangedType { get { return default(System.ComponentModel.ListChangedType); } }
    public int NewIndex { get { return default(int); } }
    public int OldIndex { get { return default(int); } }
    public System.ComponentModel.PropertyDescriptor PropertyDescriptor { get { return default(System.ComponentModel.PropertyDescriptor); } }
  }

  public delegate void ListChangedEventHandler(object sender, System.ComponentModel.ListChangedEventArgs e);

  public enum ListChangedType {
    ItemAdded = 1,
    ItemChanged = 4,
    ItemDeleted = 2,
    ItemMoved = 3,
    PropertyDescriptorAdded = 5,
    PropertyDescriptorChanged = 7,
    PropertyDescriptorDeleted = 6,
    Reset = 0,
  }

  public partial class ListSortDescription {
    public ListSortDescription(System.ComponentModel.PropertyDescriptor property, System.ComponentModel.ListSortDirection direction) { }
    public System.ComponentModel.PropertyDescriptor PropertyDescriptor { get { return default(System.ComponentModel.PropertyDescriptor); } set { } }
    public System.ComponentModel.ListSortDirection SortDirection { get { return default(System.ComponentModel.ListSortDirection); } set { } }
  }

  public partial class ListSortDescriptionCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    public ListSortDescriptionCollection() { }
    public ListSortDescriptionCollection(System.ComponentModel.ListSortDescription[] sorts) { }
    public int Count { get { return default(int); } }
    public System.ComponentModel.ListSortDescription this[int index] { get { return default(System.ComponentModel.ListSortDescription); } set { } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    public bool Contains(object value) { return default(bool); }
    public void CopyTo(System.Array array, int index) { }
    public int IndexOf(object value) { return default(int); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    int System.Collections.IList.Add(object value) { return default(int); }
    void System.Collections.IList.Clear() { }
    void System.Collections.IList.Insert(int index, object value) { }
    void System.Collections.IList.Remove(object value) { }
    void System.Collections.IList.RemoveAt(int index) { }
  }

  public enum ListSortDirection {
    Ascending = 0,
    Descending = 1,
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

  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class LookupBindingPropertiesAttribute : System.Attribute {
    public static readonly System.ComponentModel.LookupBindingPropertiesAttribute Default;
    public LookupBindingPropertiesAttribute() { }
    public LookupBindingPropertiesAttribute(string dataSource, string displayMember, string valueMember, string lookupMember) { }
    public string DataSource { get { return default(string); } }
    public string DisplayMember { get { return default(string); } }
    public string LookupMember { get { return default(string); } }
    public string ValueMember { get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }

  [System.ComponentModel.DesignerAttribute("System.Windows.Forms.Design.ComponentDocumentDesigner, System.Design, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.ComponentModel.Design.IRootDesigner))]
  [System.ComponentModel.DesignerCategoryAttribute("Component")]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class MarshalByValueComponent : System.ComponentModel.IComponent, System.IDisposable, System.IServiceProvider {
    public MarshalByValueComponent() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    public virtual System.ComponentModel.IContainer Container { get { return default(System.ComponentModel.IContainer); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public virtual bool DesignMode { get { return default(bool); } }
    protected System.ComponentModel.EventHandlerList Events { get { return default(System.ComponentModel.EventHandlerList); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public virtual System.ComponentModel.ISite Site { get { return default(System.ComponentModel.ISite); } set { } }
    public event System.EventHandler Disposed { add { } remove { } }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    ~MarshalByValueComponent() { }
    public virtual object GetService(System.Type service) { return default(object); }
    public override string ToString() { return default(string); }
  }

  public partial class MaskedTextProvider : System.ICloneable {
    public MaskedTextProvider(string mask) { }
    public MaskedTextProvider(string mask, bool restrictToAscii) { }
    public MaskedTextProvider(string mask, char passwordChar, bool allowPromptAsInput) { }
    public MaskedTextProvider(string mask, System.Globalization.CultureInfo culture) { }
    public MaskedTextProvider(string mask, System.Globalization.CultureInfo culture, bool restrictToAscii) { }
    public MaskedTextProvider(string mask, System.Globalization.CultureInfo culture, bool allowPromptAsInput, char promptChar, char passwordChar, bool restrictToAscii) { }
    public MaskedTextProvider(string mask, System.Globalization.CultureInfo culture, char passwordChar, bool allowPromptAsInput) { }
    public bool AllowPromptAsInput { get { return default(bool); } }
    public bool AsciiOnly { get { return default(bool); } }
    public int AssignedEditPositionCount { get { return default(int); } }
    public int AvailableEditPositionCount { get { return default(int); } }
    public System.Globalization.CultureInfo Culture { get { return default(System.Globalization.CultureInfo); } }
    public static char DefaultPasswordChar { get { return default(char); } }
    public int EditPositionCount { get { return default(int); } }
    public System.Collections.IEnumerator EditPositions { get { return default(System.Collections.IEnumerator); } }
    public bool IncludeLiterals { get { return default(bool); } set { } }
    public bool IncludePrompt { get { return default(bool); } set { } }
    public static int InvalidIndex { get { return default(int); } }
    public bool IsPassword { get { return default(bool); } set { } }
    public char this[int index] { get { return default(char); } }
    public int LastAssignedPosition { get { return default(int); } }
    public int Length { get { return default(int); } }
    public string Mask { get { return default(string); } }
    public bool MaskCompleted { get { return default(bool); } }
    public bool MaskFull { get { return default(bool); } }
    public char PasswordChar { get { return default(char); } set { } }
    public char PromptChar { get { return default(char); } set { } }
    public bool ResetOnPrompt { get { return default(bool); } set { } }
    public bool ResetOnSpace { get { return default(bool); } set { } }
    public bool SkipLiterals { get { return default(bool); } set { } }
    public bool Add(char input) { return default(bool); }
    public bool Add(char input, out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { testPosition = default(int); resultHint = default(System.ComponentModel.MaskedTextResultHint); return default(bool); }
    public bool Add(string input) { return default(bool); }
    public bool Add(string input, out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { testPosition = default(int); resultHint = default(System.ComponentModel.MaskedTextResultHint); return default(bool); }
    public void Clear() { }
    public void Clear(out System.ComponentModel.MaskedTextResultHint resultHint) { resultHint = default(System.ComponentModel.MaskedTextResultHint); }
    public object Clone() { return default(object); }
    public int FindAssignedEditPositionFrom(int position, bool direction) { return default(int); }
    public int FindAssignedEditPositionInRange(int startPosition, int endPosition, bool direction) { return default(int); }
    public int FindEditPositionFrom(int position, bool direction) { return default(int); }
    public int FindEditPositionInRange(int startPosition, int endPosition, bool direction) { return default(int); }
    public int FindNonEditPositionFrom(int position, bool direction) { return default(int); }
    public int FindNonEditPositionInRange(int startPosition, int endPosition, bool direction) { return default(int); }
    public int FindUnassignedEditPositionFrom(int position, bool direction) { return default(int); }
    public int FindUnassignedEditPositionInRange(int startPosition, int endPosition, bool direction) { return default(int); }
    public static bool GetOperationResultFromHint(System.ComponentModel.MaskedTextResultHint hint) { return default(bool); }
    public bool InsertAt(char input, int position) { return default(bool); }
    public bool InsertAt(char input, int position, out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { testPosition = default(int); resultHint = default(System.ComponentModel.MaskedTextResultHint); return default(bool); }
    public bool InsertAt(string input, int position) { return default(bool); }
    public bool InsertAt(string input, int position, out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { testPosition = default(int); resultHint = default(System.ComponentModel.MaskedTextResultHint); return default(bool); }
    public bool IsAvailablePosition(int position) { return default(bool); }
    public bool IsEditPosition(int position) { return default(bool); }
    public static bool IsValidInputChar(char c) { return default(bool); }
    public static bool IsValidMaskChar(char c) { return default(bool); }
    public static bool IsValidPasswordChar(char c) { return default(bool); }
    public bool Remove() { return default(bool); }
    public bool Remove(out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { testPosition = default(int); resultHint = default(System.ComponentModel.MaskedTextResultHint); return default(bool); }
    public bool RemoveAt(int position) { return default(bool); }
    public bool RemoveAt(int startPosition, int endPosition) { return default(bool); }
    public bool RemoveAt(int startPosition, int endPosition, out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { testPosition = default(int); resultHint = default(System.ComponentModel.MaskedTextResultHint); return default(bool); }
    public bool Replace(char input, int position) { return default(bool); }
    public bool Replace(char input, int startPosition, int endPosition, out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { testPosition = default(int); resultHint = default(System.ComponentModel.MaskedTextResultHint); return default(bool); }
    public bool Replace(char input, int position, out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { testPosition = default(int); resultHint = default(System.ComponentModel.MaskedTextResultHint); return default(bool); }
    public bool Replace(string input, int position) { return default(bool); }
    public bool Replace(string input, int startPosition, int endPosition, out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { testPosition = default(int); resultHint = default(System.ComponentModel.MaskedTextResultHint); return default(bool); }
    public bool Replace(string input, int position, out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { testPosition = default(int); resultHint = default(System.ComponentModel.MaskedTextResultHint); return default(bool); }
    public bool Set(string input) { return default(bool); }
    public bool Set(string input, out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { testPosition = default(int); resultHint = default(System.ComponentModel.MaskedTextResultHint); return default(bool); }
    public string ToDisplayString() { return default(string); }
    public override string ToString() { return default(string); }
    public string ToString(bool ignorePasswordChar) { return default(string); }
    public string ToString(bool includePrompt, bool includeLiterals) { return default(string); }
    public string ToString(bool ignorePasswordChar, bool includePrompt, bool includeLiterals, int startPosition, int length) { return default(string); }
    public string ToString(bool includePrompt, bool includeLiterals, int startPosition, int length) { return default(string); }
    public string ToString(bool ignorePasswordChar, int startPosition, int length) { return default(string); }
    public string ToString(int startPosition, int length) { return default(string); }
    public bool VerifyChar(char input, int position, out System.ComponentModel.MaskedTextResultHint hint) { hint = default(System.ComponentModel.MaskedTextResultHint); return default(bool); }
    public bool VerifyEscapeChar(char input, int position) { return default(bool); }
    public bool VerifyString(string input) { return default(bool); }
    public bool VerifyString(string input, out int testPosition, out System.ComponentModel.MaskedTextResultHint resultHint) { testPosition = default(int); resultHint = default(System.ComponentModel.MaskedTextResultHint); return default(bool); }
  }

  public enum MaskedTextResultHint {
    AlphanumericCharacterExpected = -2,
    AsciiCharacterExpected = -1,
    CharacterEscaped = 1,
    DigitExpected = -3,
    InvalidInput = -51,
    LetterExpected = -4,
    NoEffect = 2,
    NonEditPosition = -54,
    PositionOutOfRange = -55,
    PromptCharNotAllowed = -52,
    SideEffect = 3,
    SignedDigitExpected = -5,
    Success = 4,
    UnavailableEditPosition = -53,
    Unknown = 0,
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class MemberDescriptor {
    protected MemberDescriptor(System.ComponentModel.MemberDescriptor descr) { }
    protected MemberDescriptor(System.ComponentModel.MemberDescriptor oldMemberDescriptor, System.Attribute[] newAttributes) { }
    protected MemberDescriptor(string name) { }
    protected MemberDescriptor(string name, System.Attribute[] attributes) { }
    protected virtual System.Attribute[] AttributeArray { get { return default(System.Attribute[]); } set { } }
    public virtual System.ComponentModel.AttributeCollection Attributes { get { return default(System.ComponentModel.AttributeCollection); } }
    public virtual string Category { get { return default(string); } }
    public virtual string Description { get { return default(string); } }
    public virtual bool DesignTimeOnly { get { return default(bool); } }
    public virtual string DisplayName { get { return default(string); } }
    public virtual bool IsBrowsable { get { return default(bool); } }
    public virtual string Name { get { return default(string); } }
    protected virtual int NameHashCode { get { return default(int); } }
    protected virtual System.ComponentModel.AttributeCollection CreateAttributeCollection() { return default(System.ComponentModel.AttributeCollection); }
    public override bool Equals(object obj) { return default(bool); }
    protected virtual void FillAttributes(System.Collections.IList attributeList) { }
    protected static System.Reflection.MethodInfo FindMethod(System.Type componentClass, string name, System.Type[] args, System.Type returnType) { return default(System.Reflection.MethodInfo); }
    protected static System.Reflection.MethodInfo FindMethod(System.Type componentClass, string name, System.Type[] args, System.Type returnType, bool publicOnly) { return default(System.Reflection.MethodInfo); }
    public override int GetHashCode() { return default(int); }
    protected virtual object GetInvocationTarget(System.Type type, object instance) { return default(object); }
    [System.ObsoleteAttribute("This method has been deprecated. Use GetInvocationTarget instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
    protected static object GetInvokee(System.Type componentClass, object component) { return default(object); }
    protected static System.ComponentModel.ISite GetSite(object component) { return default(System.ComponentModel.ISite); }
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

  public partial class MultilineStringConverter : System.ComponentModel.TypeConverter {
    public MultilineStringConverter() { }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
    public override System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public override bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }

  public partial class NestedContainer : System.ComponentModel.Container, System.ComponentModel.IContainer, System.ComponentModel.INestedContainer, System.IDisposable {
    public NestedContainer(System.ComponentModel.IComponent owner) { }
    public System.ComponentModel.IComponent Owner { get { return default(System.ComponentModel.IComponent); } }
    protected virtual string OwnerName { get { return default(string); } }
    protected override System.ComponentModel.ISite CreateSite(System.ComponentModel.IComponent component, string name) { return default(System.ComponentModel.ISite); }
    protected override void Dispose(bool disposing) { }
    protected override object GetService(System.Type service) { return default(object); }
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

  public partial class NullableConverter : System.ComponentModel.TypeConverter {
    public NullableConverter(System.Type type) { }
    public System.Type NullableType { get { return default(System.Type); } }
    public System.Type UnderlyingType { get { return default(System.Type); } }
    public System.ComponentModel.TypeConverter UnderlyingTypeConverter { get { return default(System.ComponentModel.TypeConverter); } }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
    public override object CreateInstance(System.ComponentModel.ITypeDescriptorContext context, System.Collections.IDictionary propertyValues) { return default(object); }
    public override bool GetCreateInstanceSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public override bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override bool IsValid(System.ComponentModel.ITypeDescriptorContext context, object value) { return default(bool); }
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
  public sealed partial class PasswordPropertyTextAttribute : System.Attribute {
    public static readonly System.ComponentModel.PasswordPropertyTextAttribute Default;
    public static readonly System.ComponentModel.PasswordPropertyTextAttribute No;
    public static readonly System.ComponentModel.PasswordPropertyTextAttribute Yes;
    public PasswordPropertyTextAttribute() { }
    public PasswordPropertyTextAttribute(bool password) { }
    public bool Password { get { return default(bool); } }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class PropertyDescriptor : System.ComponentModel.MemberDescriptor {
    protected PropertyDescriptor(System.ComponentModel.MemberDescriptor descr) : base (default(string)) { }
    protected PropertyDescriptor(System.ComponentModel.MemberDescriptor descr, System.Attribute[] attrs) : base (default(string)) { }
    protected PropertyDescriptor(string name, System.Attribute[] attrs) : base (default(string)) { }
    public abstract System.Type ComponentType { get; }
    public virtual System.ComponentModel.TypeConverter Converter { get { return default(System.ComponentModel.TypeConverter); } }
    public virtual bool IsLocalizable { get { return default(bool); } }
    public abstract bool IsReadOnly { get; }
    public abstract System.Type PropertyType { get; }
    public System.ComponentModel.DesignerSerializationVisibility SerializationVisibility { get { return default(System.ComponentModel.DesignerSerializationVisibility); } }
    public virtual bool SupportsChangeEvents { get { return default(bool); } }
    public virtual void AddValueChanged(object component, System.EventHandler handler) { }
    public abstract bool CanResetValue(object component);
    protected object CreateInstance(System.Type type) { return default(object); }
    public override bool Equals(object obj) { return default(bool); }
    protected override void FillAttributes(System.Collections.IList attributeList) { }
    public System.ComponentModel.PropertyDescriptorCollection GetChildProperties() { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public System.ComponentModel.PropertyDescriptorCollection GetChildProperties(System.Attribute[] filter) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public System.ComponentModel.PropertyDescriptorCollection GetChildProperties(object instance) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public virtual System.ComponentModel.PropertyDescriptorCollection GetChildProperties(object instance, System.Attribute[] filter) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public virtual object GetEditor(System.Type editorBaseType) { return default(object); }
    public override int GetHashCode() { return default(int); }
    protected override object GetInvocationTarget(System.Type type, object instance) { return default(object); }
    protected System.Type GetTypeFromName(string typeName) { return default(System.Type); }
    public abstract object GetValue(object component);
    protected internal System.EventHandler GetValueChangedHandler(object component) { return default(System.EventHandler); }
    protected virtual void OnValueChanged(object component, System.EventArgs e) { }
    public virtual void RemoveValueChanged(object component, System.EventHandler handler) { }
    public abstract void ResetValue(object component);
    public abstract void SetValue(object component, object value);
    public abstract bool ShouldSerializeValue(object component);
  }

  public partial class PropertyDescriptorCollection : System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable, System.Collections.IList {
    public static readonly System.ComponentModel.PropertyDescriptorCollection Empty;
    public PropertyDescriptorCollection(System.ComponentModel.PropertyDescriptor[] properties) { }
    public PropertyDescriptorCollection(System.ComponentModel.PropertyDescriptor[] properties, bool readOnly) { }
    public int Count { get { return default(int); } }
    public virtual System.ComponentModel.PropertyDescriptor this[int index] { get { return default(System.ComponentModel.PropertyDescriptor); } }
    public virtual System.ComponentModel.PropertyDescriptor this[string name] { get { return default(System.ComponentModel.PropertyDescriptor); } }
    int System.Collections.ICollection.Count { get { return default(int); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IDictionary.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IDictionary.IsReadOnly { get { return default(bool); } }
    object System.Collections.IDictionary.this[object key] { get { return default(object); } set { } }
    System.Collections.ICollection System.Collections.IDictionary.Keys { get { return default(System.Collections.ICollection); } }
    System.Collections.ICollection System.Collections.IDictionary.Values { get { return default(System.Collections.ICollection); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    public int Add(System.ComponentModel.PropertyDescriptor value) { return default(int); }
    public void Clear() { }
    public bool Contains(System.ComponentModel.PropertyDescriptor value) { return default(bool); }
    public void CopyTo(System.Array array, int index) { }
    public virtual System.ComponentModel.PropertyDescriptor Find(string name, bool ignoreCase) { return default(System.ComponentModel.PropertyDescriptor); }
    public virtual System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public int IndexOf(System.ComponentModel.PropertyDescriptor value) { return default(int); }
    public void Insert(int index, System.ComponentModel.PropertyDescriptor value) { }
    protected void InternalSort(System.Collections.IComparer sorter) { }
    protected void InternalSort(string[] names) { }
    public void Remove(System.ComponentModel.PropertyDescriptor value) { }
    public void RemoveAt(int index) { }
    public virtual System.ComponentModel.PropertyDescriptorCollection Sort() { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public virtual System.ComponentModel.PropertyDescriptorCollection Sort(System.Collections.IComparer comparer) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public virtual System.ComponentModel.PropertyDescriptorCollection Sort(string[] names) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public virtual System.ComponentModel.PropertyDescriptorCollection Sort(string[] names, System.Collections.IComparer comparer) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    void System.Collections.IDictionary.Add(object key, object value) { }
    void System.Collections.IDictionary.Clear() { }
    bool System.Collections.IDictionary.Contains(object key) { return default(bool); }
    System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { return default(System.Collections.IDictionaryEnumerator); }
    void System.Collections.IDictionary.Remove(object key) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    int System.Collections.IList.Add(object value) { return default(int); }
    void System.Collections.IList.Clear() { }
    bool System.Collections.IList.Contains(object value) { return default(bool); }
    int System.Collections.IList.IndexOf(object value) { return default(int); }
    void System.Collections.IList.Insert(int index, object value) { }
    void System.Collections.IList.Remove(object value) { }
    void System.Collections.IList.RemoveAt(int index) { }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public partial class PropertyTabAttribute : System.Attribute {
    public PropertyTabAttribute() { }
    public PropertyTabAttribute(string tabClassName) { }
    public PropertyTabAttribute(string tabClassName, System.ComponentModel.PropertyTabScope tabScope) { }
    public PropertyTabAttribute(System.Type tabClass) { }
    public PropertyTabAttribute(System.Type tabClass, System.ComponentModel.PropertyTabScope tabScope) { }
    public System.Type[] TabClasses { get { return default(System.Type[]); } }
    protected string[] TabClassNames { get { return default(string[]); } }
    public System.ComponentModel.PropertyTabScope[] TabScopes { get { return default(System.ComponentModel.PropertyTabScope[]); } }
    public bool Equals(System.ComponentModel.PropertyTabAttribute other) { return default(bool); }
    public override bool Equals(object other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    protected void InitializeArrays(string[] tabClassNames, System.ComponentModel.PropertyTabScope[] tabScopes) { }
    protected void InitializeArrays(System.Type[] tabClasses, System.ComponentModel.PropertyTabScope[] tabScopes) { }
  }

  public enum PropertyTabScope {
    Component = 3,
    Document = 2,
    Global = 1,
    Static = 0,
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=true)]
  public sealed partial class ProvidePropertyAttribute : System.Attribute {
    public ProvidePropertyAttribute(string propertyName, string receiverTypeName) { }
    public ProvidePropertyAttribute(string propertyName, System.Type receiverType) { }
    public string PropertyName { get { return default(string); } }
    public string ReceiverTypeName { get { return default(string); } }
    public override object TypeId { get { return default(object); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
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

  [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
  [System.ObsoleteAttribute("Use System.ComponentModel.SettingsBindableAttribute instead to work with the new settings model.")]
  public partial class RecommendedAsConfigurableAttribute : System.Attribute {
    public static readonly System.ComponentModel.RecommendedAsConfigurableAttribute Default;
    public static readonly System.ComponentModel.RecommendedAsConfigurableAttribute No;
    public static readonly System.ComponentModel.RecommendedAsConfigurableAttribute Yes;
    public RecommendedAsConfigurableAttribute(bool recommendedAsConfigurable) { }
    public bool RecommendedAsConfigurable { get { return default(bool); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }

  public partial class ReferenceConverter : System.ComponentModel.TypeConverter {
    public ReferenceConverter(System.Type type) { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    protected virtual bool IsValueAllowed(System.ComponentModel.ITypeDescriptorContext context, object value) { return default(bool); }
  }

  public partial class RefreshEventArgs : System.EventArgs {
    public RefreshEventArgs(object componentChanged) { }
    public RefreshEventArgs(System.Type typeChanged) { }
    public object ComponentChanged { get { return default(object); } }
    public System.Type TypeChanged { get { return default(System.Type); } }
  }

  public delegate void RefreshEventHandler(System.ComponentModel.RefreshEventArgs e);

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

  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public partial class RunInstallerAttribute : System.Attribute {
    public static readonly System.ComponentModel.RunInstallerAttribute Default;
    public static readonly System.ComponentModel.RunInstallerAttribute No;
    public static readonly System.ComponentModel.RunInstallerAttribute Yes;
    public RunInstallerAttribute(bool runInstaller) { }
    public bool RunInstaller { get { return default(bool); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }

  public partial class SByteConverter : System.ComponentModel.BaseNumberConverter {
    public SByteConverter() { }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
  public sealed partial class SettingsBindableAttribute : System.Attribute {
    public static readonly System.ComponentModel.SettingsBindableAttribute No;
    public static readonly System.ComponentModel.SettingsBindableAttribute Yes;
    public SettingsBindableAttribute(bool bindable) { }
    public bool Bindable { get { return default(bool); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }

  public partial class SingleConverter : System.ComponentModel.BaseNumberConverter {
    public SingleConverter() { }
  }

  public partial class StringConverter : System.ComponentModel.TypeConverter {
    public StringConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
  }

  public static partial class SyntaxCheck {
    public static bool CheckMachineName(string value) { return default(bool); }
    public static bool CheckPath(string value) { return default(bool); }
    public static bool CheckRootedPath(string value) { return default(bool); }
  }

  public partial class TimeSpanConverter : System.ComponentModel.TypeConverter {
    public TimeSpanConverter() { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public partial class ToolboxItemAttribute : System.Attribute {
    public static readonly System.ComponentModel.ToolboxItemAttribute Default;
    public static readonly System.ComponentModel.ToolboxItemAttribute None;
    public ToolboxItemAttribute(bool defaultType) { }
    public ToolboxItemAttribute(string toolboxItemTypeName) { }
    public ToolboxItemAttribute(System.Type toolboxItemType) { }
    public System.Type ToolboxItemType { get { return default(System.Type); } }
    public string ToolboxItemTypeName { get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=true, Inherited=true)]
  public sealed partial class ToolboxItemFilterAttribute : System.Attribute {
    public ToolboxItemFilterAttribute(string filterString) { }
    public ToolboxItemFilterAttribute(string filterString, System.ComponentModel.ToolboxItemFilterType filterType) { }
    public string FilterString { get { return default(string); } }
    public System.ComponentModel.ToolboxItemFilterType FilterType { get { return default(System.ComponentModel.ToolboxItemFilterType); } }
    public override object TypeId { get { return default(object); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool Match(object obj) { return default(bool); }
    public override string ToString() { return default(string); }
  }

  public enum ToolboxItemFilterType {
    Allow = 0,
    Custom = 1,
    Prevent = 2,
    Require = 3,
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class TypeConverter {
    public TypeConverter() { }
    public virtual bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public bool CanConvertFrom(System.Type sourceType) { return default(bool); }
    public virtual bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public bool CanConvertTo(System.Type destinationType) { return default(bool); }
    public virtual object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public object ConvertFrom(object value) { return default(object); }
    public object ConvertFromInvariantString(System.ComponentModel.ITypeDescriptorContext context, string text) { return default(object); }
    public object ConvertFromInvariantString(string text) { return default(object); }
    public object ConvertFromString(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, string text) { return default(object); }
    public object ConvertFromString(System.ComponentModel.ITypeDescriptorContext context, string text) { return default(object); }
    public object ConvertFromString(string text) { return default(object); }
    public virtual object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
    public object ConvertTo(object value, System.Type destinationType) { return default(object); }
    public string ConvertToInvariantString(System.ComponentModel.ITypeDescriptorContext context, object value) { return default(string); }
    public string ConvertToInvariantString(object value) { return default(string); }
    public string ConvertToString(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(string); }
    public string ConvertToString(System.ComponentModel.ITypeDescriptorContext context, object value) { return default(string); }
    public string ConvertToString(object value) { return default(string); }
    public object CreateInstance(System.Collections.IDictionary propertyValues) { return default(object); }
    public virtual object CreateInstance(System.ComponentModel.ITypeDescriptorContext context, System.Collections.IDictionary propertyValues) { return default(object); }
    protected System.Exception GetConvertFromException(object value) { return default(System.Exception); }
    protected System.Exception GetConvertToException(object value, System.Type destinationType) { return default(System.Exception); }
    public bool GetCreateInstanceSupported() { return default(bool); }
    public virtual bool GetCreateInstanceSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public virtual System.ComponentModel.PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public System.ComponentModel.PropertyDescriptorCollection GetProperties(object value) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public bool GetPropertiesSupported() { return default(bool); }
    public virtual bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public System.Collections.ICollection GetStandardValues() { return default(System.Collections.ICollection); }
    public virtual System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public bool GetStandardValuesExclusive() { return default(bool); }
    public virtual bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public bool GetStandardValuesSupported() { return default(bool); }
    public virtual bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public virtual bool IsValid(System.ComponentModel.ITypeDescriptorContext context, object value) { return default(bool); }
    public bool IsValid(object value) { return default(bool); }
    protected System.ComponentModel.PropertyDescriptorCollection SortProperties(System.ComponentModel.PropertyDescriptorCollection props, string[] names) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    protected abstract partial class SimplePropertyDescriptor : System.ComponentModel.PropertyDescriptor {
      protected SimplePropertyDescriptor(System.Type componentType, string name, System.Type propertyType) : base (default(string), default(System.Attribute[])) { }
      protected SimplePropertyDescriptor(System.Type componentType, string name, System.Type propertyType, System.Attribute[] attributes) : base (default(string), default(System.Attribute[])) { }
      public override System.Type ComponentType { get { return default(System.Type); } }
      public override bool IsReadOnly { get { return default(bool); } }
      public override System.Type PropertyType { get { return default(System.Type); } }
      public override bool CanResetValue(object component) { return default(bool); }
      public override void ResetValue(object component) { }
      public override bool ShouldSerializeValue(object component) { return default(bool); }
    }
    public partial class StandardValuesCollection : System.Collections.ICollection, System.Collections.IEnumerable {
      public StandardValuesCollection(System.Collections.ICollection values) { }
      public int Count { get { return default(int); } }
      public object this[int index] { get { return default(object); } }
      int System.Collections.ICollection.Count { get { return default(int); } }
      bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
      object System.Collections.ICollection.SyncRoot { get { return default(object); } }
      public void CopyTo(System.Array array, int index) { }
      public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
      void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
      System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
  public sealed partial class TypeConverterAttribute : System.Attribute {
    public static readonly System.ComponentModel.TypeConverterAttribute Default;
    public TypeConverterAttribute() { }
    public TypeConverterAttribute(string typeName) { }
    public TypeConverterAttribute(System.Type type) { }
    public string ConverterTypeName { get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }

  public abstract partial class TypeDescriptionProvider {
    protected TypeDescriptionProvider() { }
    protected TypeDescriptionProvider(System.ComponentModel.TypeDescriptionProvider parent) { }
    public virtual object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, object[] args) { return default(object); }
    public virtual System.Collections.IDictionary GetCache(object instance) { return default(System.Collections.IDictionary); }
    public virtual System.ComponentModel.ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { return default(System.ComponentModel.ICustomTypeDescriptor); }
    protected internal virtual System.ComponentModel.IExtenderProvider[] GetExtenderProviders(object instance) { return default(System.ComponentModel.IExtenderProvider[]); }
    public virtual string GetFullComponentName(object component) { return default(string); }
    public System.Type GetReflectionType(object instance) { return default(System.Type); }
    public System.Type GetReflectionType(System.Type objectType) { return default(System.Type); }
    public virtual System.Type GetReflectionType(System.Type objectType, object instance) { return default(System.Type); }
    public virtual System.Type GetRuntimeType(System.Type reflectionType) { return default(System.Type); }
    public System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(object instance) { return default(System.ComponentModel.ICustomTypeDescriptor); }
    public System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType) { return default(System.ComponentModel.ICustomTypeDescriptor); }
    public virtual System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, object instance) { return default(System.ComponentModel.ICustomTypeDescriptor); }
    public virtual bool IsSupportedType(System.Type type) { return default(bool); }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(4), Inherited=true)]
  public sealed partial class TypeDescriptionProviderAttribute : System.Attribute {
    public TypeDescriptionProviderAttribute(string typeName) { }
    public TypeDescriptionProviderAttribute(System.Type type) { }
    public string TypeName { get { return default(string); } }
  }

  public sealed partial class TypeDescriptor {
    internal TypeDescriptor() { }
    [System.ObsoleteAttribute("This property has been deprecated.  Use a type description provider to supply type information for COM types instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
    public static System.ComponentModel.IComNativeDescriptorHandler ComNativeDescriptorHandler { get { return default(System.ComponentModel.IComNativeDescriptorHandler); } set { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.Type ComObjectType { get { return default(System.Type); } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.Type InterfaceType { get { return default(System.Type); } }
    public static event System.ComponentModel.RefreshEventHandler Refreshed { add { } remove { } }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.ComponentModel.TypeDescriptionProvider AddAttributes(object instance, params System.Attribute[] attributes) { return default(System.ComponentModel.TypeDescriptionProvider); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.ComponentModel.TypeDescriptionProvider AddAttributes(System.Type type, params System.Attribute[] attributes) { return default(System.ComponentModel.TypeDescriptionProvider); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static void AddEditorTable(System.Type editorBaseType, System.Collections.Hashtable table) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static void AddProvider(System.ComponentModel.TypeDescriptionProvider provider, object instance) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static void AddProvider(System.ComponentModel.TypeDescriptionProvider provider, System.Type type) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static void AddProviderTransparent(System.ComponentModel.TypeDescriptionProvider provider, object instance) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static void AddProviderTransparent(System.ComponentModel.TypeDescriptionProvider provider, System.Type type) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static void CreateAssociation(object primary, object secondary) { }
    public static System.ComponentModel.Design.IDesigner CreateDesigner(System.ComponentModel.IComponent component, System.Type designerBaseType) { return default(System.ComponentModel.Design.IDesigner); }
    public static System.ComponentModel.EventDescriptor CreateEvent(System.Type componentType, System.ComponentModel.EventDescriptor oldEventDescriptor, params System.Attribute[] attributes) { return default(System.ComponentModel.EventDescriptor); }
    public static System.ComponentModel.EventDescriptor CreateEvent(System.Type componentType, string name, System.Type type, params System.Attribute[] attributes) { return default(System.ComponentModel.EventDescriptor); }
    public static object CreateInstance(System.IServiceProvider provider, System.Type objectType, System.Type[] argTypes, object[] args) { return default(object); }
    public static System.ComponentModel.PropertyDescriptor CreateProperty(System.Type componentType, System.ComponentModel.PropertyDescriptor oldPropertyDescriptor, params System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptor); }
    public static System.ComponentModel.PropertyDescriptor CreateProperty(System.Type componentType, string name, System.Type type, params System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptor); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static object GetAssociation(System.Type type, object primary) { return default(object); }
    public static System.ComponentModel.AttributeCollection GetAttributes(object component) { return default(System.ComponentModel.AttributeCollection); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.ComponentModel.AttributeCollection GetAttributes(object component, bool noCustomTypeDesc) { return default(System.ComponentModel.AttributeCollection); }
    public static System.ComponentModel.AttributeCollection GetAttributes(System.Type componentType) { return default(System.ComponentModel.AttributeCollection); }
    public static string GetClassName(object component) { return default(string); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static string GetClassName(object component, bool noCustomTypeDesc) { return default(string); }
    public static string GetClassName(System.Type componentType) { return default(string); }
    public static string GetComponentName(object component) { return default(string); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static string GetComponentName(object component, bool noCustomTypeDesc) { return default(string); }
    public static System.ComponentModel.TypeConverter GetConverter(object component) { return default(System.ComponentModel.TypeConverter); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.ComponentModel.TypeConverter GetConverter(object component, bool noCustomTypeDesc) { return default(System.ComponentModel.TypeConverter); }
    public static System.ComponentModel.TypeConverter GetConverter(System.Type type) { return default(System.ComponentModel.TypeConverter); }
    public static System.ComponentModel.EventDescriptor GetDefaultEvent(object component) { return default(System.ComponentModel.EventDescriptor); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.ComponentModel.EventDescriptor GetDefaultEvent(object component, bool noCustomTypeDesc) { return default(System.ComponentModel.EventDescriptor); }
    public static System.ComponentModel.EventDescriptor GetDefaultEvent(System.Type componentType) { return default(System.ComponentModel.EventDescriptor); }
    public static System.ComponentModel.PropertyDescriptor GetDefaultProperty(object component) { return default(System.ComponentModel.PropertyDescriptor); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.ComponentModel.PropertyDescriptor GetDefaultProperty(object component, bool noCustomTypeDesc) { return default(System.ComponentModel.PropertyDescriptor); }
    public static System.ComponentModel.PropertyDescriptor GetDefaultProperty(System.Type componentType) { return default(System.ComponentModel.PropertyDescriptor); }
    public static object GetEditor(object component, System.Type editorBaseType) { return default(object); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static object GetEditor(object component, System.Type editorBaseType, bool noCustomTypeDesc) { return default(object); }
    public static object GetEditor(System.Type type, System.Type editorBaseType) { return default(object); }
    public static System.ComponentModel.EventDescriptorCollection GetEvents(object component) { return default(System.ComponentModel.EventDescriptorCollection); }
    public static System.ComponentModel.EventDescriptorCollection GetEvents(object component, System.Attribute[] attributes) { return default(System.ComponentModel.EventDescriptorCollection); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.ComponentModel.EventDescriptorCollection GetEvents(object component, System.Attribute[] attributes, bool noCustomTypeDesc) { return default(System.ComponentModel.EventDescriptorCollection); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.ComponentModel.EventDescriptorCollection GetEvents(object component, bool noCustomTypeDesc) { return default(System.ComponentModel.EventDescriptorCollection); }
    public static System.ComponentModel.EventDescriptorCollection GetEvents(System.Type componentType) { return default(System.ComponentModel.EventDescriptorCollection); }
    public static System.ComponentModel.EventDescriptorCollection GetEvents(System.Type componentType, System.Attribute[] attributes) { return default(System.ComponentModel.EventDescriptorCollection); }
    public static string GetFullComponentName(object component) { return default(string); }
    public static System.ComponentModel.PropertyDescriptorCollection GetProperties(object component) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public static System.ComponentModel.PropertyDescriptorCollection GetProperties(object component, System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public static System.ComponentModel.PropertyDescriptorCollection GetProperties(object component, System.Attribute[] attributes, bool noCustomTypeDesc) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.ComponentModel.PropertyDescriptorCollection GetProperties(object component, bool noCustomTypeDesc) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public static System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Type componentType) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public static System.ComponentModel.PropertyDescriptorCollection GetProperties(System.Type componentType, System.Attribute[] attributes) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.ComponentModel.TypeDescriptionProvider GetProvider(object instance) { return default(System.ComponentModel.TypeDescriptionProvider); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.ComponentModel.TypeDescriptionProvider GetProvider(System.Type type) { return default(System.ComponentModel.TypeDescriptionProvider); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.Type GetReflectionType(object instance) { return default(System.Type); }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static System.Type GetReflectionType(System.Type type) { return default(System.Type); }
    public static void Refresh(object component) { }
    public static void Refresh(System.Reflection.Assembly assembly) { }
    public static void Refresh(System.Reflection.Module module) { }
    public static void Refresh(System.Type type) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static void RemoveAssociation(object primary, object secondary) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static void RemoveAssociations(object primary) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static void RemoveProvider(System.ComponentModel.TypeDescriptionProvider provider, object instance) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static void RemoveProvider(System.ComponentModel.TypeDescriptionProvider provider, System.Type type) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static void RemoveProviderTransparent(System.ComponentModel.TypeDescriptionProvider provider, object instance) { }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
    public static void RemoveProviderTransparent(System.ComponentModel.TypeDescriptionProvider provider, System.Type type) { }
    public static void SortDescriptorArray(System.Collections.IList infos) { }
  }

  public abstract partial class TypeListConverter : System.ComponentModel.TypeConverter {
    protected TypeListConverter(System.Type[] types) { }
    public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { return default(bool); }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { return default(object); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
    public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { return default(System.ComponentModel.TypeConverter.StandardValuesCollection); }
    public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
    public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { return default(bool); }
  }

  public partial class UInt16Converter : System.ComponentModel.BaseNumberConverter {
    public UInt16Converter() { }
  }

  public partial class UInt32Converter : System.ComponentModel.BaseNumberConverter {
    public UInt32Converter() { }
  }

  public partial class UInt64Converter : System.ComponentModel.BaseNumberConverter {
    public UInt64Converter() { }
  }

  public partial class WarningException : System.SystemException {
    public WarningException() { }
    protected WarningException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public WarningException(string message) { }
    public WarningException(string message, System.Exception innerException) { }
    public WarningException(string message, string helpUrl) { }
    public WarningException(string message, string helpUrl, string helpTopic) { }
    public string HelpTopic { get { return default(string); } }
    public string HelpUrl { get { return default(string); } }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }

} // end of System.ComponentModel
namespace System.ComponentModel.Design {
  public partial class ActiveDesignerEventArgs : System.EventArgs {
    public ActiveDesignerEventArgs(System.ComponentModel.Design.IDesignerHost oldDesigner, System.ComponentModel.Design.IDesignerHost newDesigner) { }
    public System.ComponentModel.Design.IDesignerHost NewDesigner { get { return default(System.ComponentModel.Design.IDesignerHost); } }
    public System.ComponentModel.Design.IDesignerHost OldDesigner { get { return default(System.ComponentModel.Design.IDesignerHost); } }
  }

  public delegate void ActiveDesignerEventHandler(object sender, System.ComponentModel.Design.ActiveDesignerEventArgs e);

  public partial class CheckoutException : System.Runtime.InteropServices.ExternalException {
    public static readonly System.ComponentModel.Design.CheckoutException Canceled;
    public CheckoutException() { }
    protected CheckoutException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public CheckoutException(string message) { }
    public CheckoutException(string message, System.Exception innerException) { }
    public CheckoutException(string message, int errorCode) { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class CommandID {
    public CommandID(System.Guid menuGroup, int commandID) { }
    public virtual System.Guid Guid { get { return default(System.Guid); } }
    public virtual int ID { get { return default(int); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class ComponentChangedEventArgs : System.EventArgs {
    public ComponentChangedEventArgs(object component, System.ComponentModel.MemberDescriptor member, object oldValue, object newValue) { }
    public object Component { get { return default(object); } }
    public System.ComponentModel.MemberDescriptor Member { get { return default(System.ComponentModel.MemberDescriptor); } }
    public object NewValue { get { return default(object); } }
    public object OldValue { get { return default(object); } }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public delegate void ComponentChangedEventHandler(object sender, System.ComponentModel.Design.ComponentChangedEventArgs e);

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public sealed partial class ComponentChangingEventArgs : System.EventArgs {
    public ComponentChangingEventArgs(object component, System.ComponentModel.MemberDescriptor member) { }
    public object Component { get { return default(object); } }
    public System.ComponentModel.MemberDescriptor Member { get { return default(System.ComponentModel.MemberDescriptor); } }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public delegate void ComponentChangingEventHandler(object sender, System.ComponentModel.Design.ComponentChangingEventArgs e);

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class ComponentEventArgs : System.EventArgs {
    public ComponentEventArgs(System.ComponentModel.IComponent component) { }
    public virtual System.ComponentModel.IComponent Component { get { return default(System.ComponentModel.IComponent); } }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public delegate void ComponentEventHandler(object sender, System.ComponentModel.Design.ComponentEventArgs e);

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class ComponentRenameEventArgs : System.EventArgs {
    public ComponentRenameEventArgs(object component, string oldName, string newName) { }
    public object Component { get { return default(object); } }
    public virtual string NewName { get { return default(string); } }
    public virtual string OldName { get { return default(string); } }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public delegate void ComponentRenameEventHandler(object sender, System.ComponentModel.Design.ComponentRenameEventArgs e);

  public partial class DesignerCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    public DesignerCollection(System.Collections.IList designers) { }
    public DesignerCollection(System.ComponentModel.Design.IDesignerHost[] designers) { }
    public int Count { get { return default(int); } }
    public virtual System.ComponentModel.Design.IDesignerHost this[int index] { get { return default(System.ComponentModel.Design.IDesignerHost); } }
    int System.Collections.ICollection.Count { get { return default(int); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }

  public partial class DesignerEventArgs : System.EventArgs {
    public DesignerEventArgs(System.ComponentModel.Design.IDesignerHost host) { }
    public System.ComponentModel.Design.IDesignerHost Designer { get { return default(System.ComponentModel.Design.IDesignerHost); } }
  }

  public delegate void DesignerEventHandler(object sender, System.ComponentModel.Design.DesignerEventArgs e);

  public abstract partial class DesignerOptionService : System.ComponentModel.Design.IDesignerOptionService {
    protected DesignerOptionService() { }
    public System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection Options { get { return default(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection); } }
    protected System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection CreateOptionCollection(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection parent, string name, object value) { return default(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection); }
    protected virtual void PopulateOptionCollection(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection options) { }
    protected virtual bool ShowDialog(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection options, object optionObject) { return default(bool); }
    object System.ComponentModel.Design.IDesignerOptionService.GetOptionValue(string pageName, string valueName) { return default(object); }
    void System.ComponentModel.Design.IDesignerOptionService.SetOptionValue(string pageName, string valueName, object value) { }
    [System.ComponentModel.EditorAttribute("", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    public sealed partial class DesignerOptionCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
      internal DesignerOptionCollection() { }
      public int Count { get { return default(int); } }
      public System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection this[int index] { get { return default(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection); } }
      public System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection this[string name] { get { return default(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection); } }
      public string Name { get { return default(string); } }
      public System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection Parent { get { return default(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection); } }
      public System.ComponentModel.PropertyDescriptorCollection Properties { get { return default(System.ComponentModel.PropertyDescriptorCollection); } }
      bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
      object System.Collections.ICollection.SyncRoot { get { return default(object); } }
      bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
      bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
      object System.Collections.IList.this[int index] { get { return default(object); } set { } }
      public void CopyTo(System.Array array, int index) { }
      public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
      public int IndexOf(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection value) { return default(int); }
      public bool ShowDialog() { return default(bool); }
      int System.Collections.IList.Add(object value) { return default(int); }
      void System.Collections.IList.Clear() { }
      bool System.Collections.IList.Contains(object value) { return default(bool); }
      int System.Collections.IList.IndexOf(object value) { return default(int); }
      void System.Collections.IList.Insert(int index, object value) { }
      void System.Collections.IList.Remove(object value) { }
      void System.Collections.IList.RemoveAt(int index) { }
    }
  }

  public abstract partial class DesignerTransaction : System.IDisposable {
    protected DesignerTransaction() { }
    protected DesignerTransaction(string description) { }
    public bool Canceled { get { return default(bool); } }
    public bool Committed { get { return default(bool); } }
    public string Description { get { return default(string); } }
    public void Cancel() { }
    public void Commit() { }
    protected virtual void Dispose(bool disposing) { }
    ~DesignerTransaction() { }
    protected abstract void OnCancel();
    protected abstract void OnCommit();
    void System.IDisposable.Dispose() { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class DesignerTransactionCloseEventArgs : System.EventArgs {
    [System.ObsoleteAttribute("This constructor is obsolete. Use DesignerTransactionCloseEventArgs(bool, bool) instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
    public DesignerTransactionCloseEventArgs(bool commit) { }
    public DesignerTransactionCloseEventArgs(bool commit, bool lastTransaction) { }
    public bool LastTransaction { get { return default(bool); } }
    public bool TransactionCommitted { get { return default(bool); } }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public delegate void DesignerTransactionCloseEventHandler(object sender, System.ComponentModel.Design.DesignerTransactionCloseEventArgs e);

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class DesignerVerb : System.ComponentModel.Design.MenuCommand {
    public DesignerVerb(string text, System.EventHandler handler) : base (default(System.EventHandler), default(System.ComponentModel.Design.CommandID)) { }
    public DesignerVerb(string text, System.EventHandler handler, System.ComponentModel.Design.CommandID startCommandID) : base (default(System.EventHandler), default(System.ComponentModel.Design.CommandID)) { }
    public string Description { get { return default(string); } set { } }
    public string Text { get { return default(string); } }
    public override string ToString() { return default(string); }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class DesignerVerbCollection : System.Collections.CollectionBase {
    public DesignerVerbCollection() { }
    public DesignerVerbCollection(System.ComponentModel.Design.DesignerVerb[] value) { }
    public System.ComponentModel.Design.DesignerVerb this[int index] { get { return default(System.ComponentModel.Design.DesignerVerb); } set { } }
    public int Add(System.ComponentModel.Design.DesignerVerb value) { return default(int); }
    public void AddRange(System.ComponentModel.Design.DesignerVerb[] value) { }
    public void AddRange(System.ComponentModel.Design.DesignerVerbCollection value) { }
    public bool Contains(System.ComponentModel.Design.DesignerVerb value) { return default(bool); }
    public void CopyTo(System.ComponentModel.Design.DesignerVerb[] array, int index) { }
    public int IndexOf(System.ComponentModel.Design.DesignerVerb value) { return default(int); }
    public void Insert(int index, System.ComponentModel.Design.DesignerVerb value) { }
    protected override void OnClear() { }
    protected override void OnInsert(int index, object value) { }
    protected override void OnRemove(int index, object value) { }
    protected override void OnSet(int index, object oldValue, object newValue) { }
    protected override void OnValidate(object value) { }
    public void Remove(System.ComponentModel.Design.DesignerVerb value) { }
  }

  public partial class DesigntimeLicenseContext : System.ComponentModel.LicenseContext {
    public DesigntimeLicenseContext() { }
    public override System.ComponentModel.LicenseUsageMode UsageMode { get { return default(System.ComponentModel.LicenseUsageMode); } }
    public override string GetSavedLicenseKey(System.Type type, System.Reflection.Assembly resourceAssembly) { return default(string); }
    public override void SetSavedLicenseKey(System.Type type, string key) { }
  }

  public partial class DesigntimeLicenseContextSerializer {
    internal DesigntimeLicenseContextSerializer() { }
    public static void Serialize(System.IO.Stream o, string cryptoKey, System.ComponentModel.Design.DesigntimeLicenseContext context) { }
  }

  public enum HelpContextType {
    Ambient = 0,
    Selection = 2,
    ToolWindowSelection = 3,
    Window = 1,
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=false, Inherited=false)]
  public sealed partial class HelpKeywordAttribute : System.Attribute {
    public static readonly System.ComponentModel.Design.HelpKeywordAttribute Default;
    public HelpKeywordAttribute() { }
    public HelpKeywordAttribute(string keyword) { }
    public HelpKeywordAttribute(System.Type t) { }
    public string HelpKeyword { get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override bool IsDefaultAttribute() { return default(bool); }
  }

  public enum HelpKeywordType {
    F1Keyword = 0,
    FilterKeyword = 2,
    GeneralKeyword = 1,
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface IComponentChangeService {
    event System.ComponentModel.Design.ComponentEventHandler ComponentAdded;
    event System.ComponentModel.Design.ComponentEventHandler ComponentAdding;
    event System.ComponentModel.Design.ComponentChangedEventHandler ComponentChanged;
    event System.ComponentModel.Design.ComponentChangingEventHandler ComponentChanging;
    event System.ComponentModel.Design.ComponentEventHandler ComponentRemoved;
    event System.ComponentModel.Design.ComponentEventHandler ComponentRemoving;
    event System.ComponentModel.Design.ComponentRenameEventHandler ComponentRename;
    void OnComponentChanged(object component, System.ComponentModel.MemberDescriptor member, object oldValue, object newValue);
    void OnComponentChanging(object component, System.ComponentModel.MemberDescriptor member);
  }

  public partial interface IComponentDiscoveryService {
    System.Collections.ICollection GetComponentTypes(System.ComponentModel.Design.IDesignerHost designerHost, System.Type baseType);
  }

  public partial interface IComponentInitializer {
    void InitializeExistingComponent(System.Collections.IDictionary defaultValues);
    void InitializeNewComponent(System.Collections.IDictionary defaultValues);
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface IDesigner : System.IDisposable {
    System.ComponentModel.IComponent Component { get; }
    System.ComponentModel.Design.DesignerVerbCollection Verbs { get; }
    void DoDefaultAction();
    void Initialize(System.ComponentModel.IComponent component);
  }

  public partial interface IDesignerEventService {
    System.ComponentModel.Design.IDesignerHost ActiveDesigner { get; }
    System.ComponentModel.Design.DesignerCollection Designers { get; }
    event System.ComponentModel.Design.ActiveDesignerEventHandler ActiveDesignerChanged;
    event System.ComponentModel.Design.DesignerEventHandler DesignerCreated;
    event System.ComponentModel.Design.DesignerEventHandler DesignerDisposed;
    event System.EventHandler SelectionChanged;
  }

  public partial interface IDesignerFilter {
    void PostFilterAttributes(System.Collections.IDictionary attributes);
    void PostFilterEvents(System.Collections.IDictionary events);
    void PostFilterProperties(System.Collections.IDictionary properties);
    void PreFilterAttributes(System.Collections.IDictionary attributes);
    void PreFilterEvents(System.Collections.IDictionary events);
    void PreFilterProperties(System.Collections.IDictionary properties);
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface IDesignerHost : System.ComponentModel.Design.IServiceContainer, System.IServiceProvider {
    System.ComponentModel.IContainer Container { get; }
    bool InTransaction { get; }
    bool Loading { get; }
    System.ComponentModel.IComponent RootComponent { get; }
    string RootComponentClassName { get; }
    string TransactionDescription { get; }
    event System.EventHandler Activated;
    event System.EventHandler Deactivated;
    event System.EventHandler LoadComplete;
    event System.ComponentModel.Design.DesignerTransactionCloseEventHandler TransactionClosed;
    event System.ComponentModel.Design.DesignerTransactionCloseEventHandler TransactionClosing;
    event System.EventHandler TransactionOpened;
    event System.EventHandler TransactionOpening;
    void Activate();
    System.ComponentModel.IComponent CreateComponent(System.Type componentClass);
    System.ComponentModel.IComponent CreateComponent(System.Type componentClass, string name);
    System.ComponentModel.Design.DesignerTransaction CreateTransaction();
    System.ComponentModel.Design.DesignerTransaction CreateTransaction(string description);
    void DestroyComponent(System.ComponentModel.IComponent component);
    System.ComponentModel.Design.IDesigner GetDesigner(System.ComponentModel.IComponent component);
    System.Type GetType(string typeName);
  }

  public partial interface IDesignerHostTransactionState {
    bool IsClosingTransaction { get; }
  }

  public partial interface IDesignerOptionService {
    object GetOptionValue(string pageName, string valueName);
    void SetOptionValue(string pageName, string valueName, object value);
  }

  public partial interface IDictionaryService {
    object GetKey(object value);
    object GetValue(object key);
    void SetValue(object key, object value);
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface IEventBindingService {
    string CreateUniqueMethodName(System.ComponentModel.IComponent component, System.ComponentModel.EventDescriptor e);
    System.Collections.ICollection GetCompatibleMethods(System.ComponentModel.EventDescriptor e);
    System.ComponentModel.EventDescriptor GetEvent(System.ComponentModel.PropertyDescriptor property);
    System.ComponentModel.PropertyDescriptorCollection GetEventProperties(System.ComponentModel.EventDescriptorCollection events);
    System.ComponentModel.PropertyDescriptor GetEventProperty(System.ComponentModel.EventDescriptor e);
    bool ShowCode();
    bool ShowCode(System.ComponentModel.IComponent component, System.ComponentModel.EventDescriptor e);
    bool ShowCode(int lineNumber);
  }

  public partial interface IExtenderListService {
    System.ComponentModel.IExtenderProvider[] GetExtenderProviders();
  }

  public partial interface IExtenderProviderService {
    void AddExtenderProvider(System.ComponentModel.IExtenderProvider provider);
    void RemoveExtenderProvider(System.ComponentModel.IExtenderProvider provider);
  }

  public partial interface IHelpService {
    void AddContextAttribute(string name, string value, System.ComponentModel.Design.HelpKeywordType keywordType);
    void ClearContextAttributes();
    System.ComponentModel.Design.IHelpService CreateLocalContext(System.ComponentModel.Design.HelpContextType contextType);
    void RemoveContextAttribute(string name, string value);
    void RemoveLocalContext(System.ComponentModel.Design.IHelpService localContext);
    void ShowHelpFromKeyword(string helpKeyword);
    void ShowHelpFromUrl(string helpUrl);
  }

  public partial interface IInheritanceService {
    void AddInheritedComponents(System.ComponentModel.IComponent component, System.ComponentModel.IContainer container);
    System.ComponentModel.InheritanceAttribute GetInheritanceAttribute(System.ComponentModel.IComponent component);
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface IMenuCommandService {
    System.ComponentModel.Design.DesignerVerbCollection Verbs { get; }
    void AddCommand(System.ComponentModel.Design.MenuCommand command);
    void AddVerb(System.ComponentModel.Design.DesignerVerb verb);
    System.ComponentModel.Design.MenuCommand FindCommand(System.ComponentModel.Design.CommandID commandID);
    bool GlobalInvoke(System.ComponentModel.Design.CommandID commandID);
    void RemoveCommand(System.ComponentModel.Design.MenuCommand command);
    void RemoveVerb(System.ComponentModel.Design.DesignerVerb verb);
    void ShowContextMenu(System.ComponentModel.Design.CommandID menuID, int x, int y);
  }

  public partial interface IReferenceService {
    System.ComponentModel.IComponent GetComponent(object reference);
    string GetName(object reference);
    object GetReference(string name);
    object[] GetReferences();
    object[] GetReferences(System.Type baseType);
  }

  public partial interface IResourceService {
    System.Resources.IResourceReader GetResourceReader(System.Globalization.CultureInfo info);
    System.Resources.IResourceWriter GetResourceWriter(System.Globalization.CultureInfo info);
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface IRootDesigner : System.ComponentModel.Design.IDesigner, System.IDisposable {
    System.ComponentModel.Design.ViewTechnology[] SupportedTechnologies { get; }
    object GetView(System.ComponentModel.Design.ViewTechnology technology);
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface ISelectionService {
    object PrimarySelection { get; }
    int SelectionCount { get; }
    event System.EventHandler SelectionChanged;
    event System.EventHandler SelectionChanging;
    bool GetComponentSelected(object component);
    System.Collections.ICollection GetSelectedComponents();
    void SetSelectedComponents(System.Collections.ICollection components);
    void SetSelectedComponents(System.Collections.ICollection components, System.ComponentModel.Design.SelectionTypes selectionType);
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial interface IServiceContainer : System.IServiceProvider {
    void AddService(System.Type serviceType, System.ComponentModel.Design.ServiceCreatorCallback callback);
    void AddService(System.Type serviceType, System.ComponentModel.Design.ServiceCreatorCallback callback, bool promote);
    void AddService(System.Type serviceType, object serviceInstance);
    void AddService(System.Type serviceType, object serviceInstance, bool promote);
    void RemoveService(System.Type serviceType);
    void RemoveService(System.Type serviceType, bool promote);
  }

  public partial interface ITreeDesigner : System.ComponentModel.Design.IDesigner, System.IDisposable {
    System.Collections.ICollection Children { get; }
    System.ComponentModel.Design.IDesigner Parent { get; }
  }

  public partial interface ITypeDescriptorFilterService {
    bool FilterAttributes(System.ComponentModel.IComponent component, System.Collections.IDictionary attributes);
    bool FilterEvents(System.ComponentModel.IComponent component, System.Collections.IDictionary events);
    bool FilterProperties(System.ComponentModel.IComponent component, System.Collections.IDictionary properties);
  }

  public partial interface ITypeDiscoveryService {
    System.Collections.ICollection GetTypes(System.Type baseType, bool excludeGlobalTypes);
  }

  public partial interface ITypeResolutionService {
    System.Reflection.Assembly GetAssembly(System.Reflection.AssemblyName name);
    System.Reflection.Assembly GetAssembly(System.Reflection.AssemblyName name, bool throwOnError);
    string GetPathOfAssembly(System.Reflection.AssemblyName name);
    System.Type GetType(string name);
    System.Type GetType(string name, bool throwOnError);
    System.Type GetType(string name, bool throwOnError, bool ignoreCase);
    void ReferenceAssembly(System.Reflection.AssemblyName name);
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public partial class MenuCommand {
    public MenuCommand(System.EventHandler handler, System.ComponentModel.Design.CommandID command) { }
    public virtual bool Checked { get { return default(bool); } set { } }
    public virtual System.ComponentModel.Design.CommandID CommandID { get { return default(System.ComponentModel.Design.CommandID); } }
    public virtual bool Enabled { get { return default(bool); } set { } }
    public virtual int OleStatus { get { return default(int); } }
    public virtual System.Collections.IDictionary Properties { get { return default(System.Collections.IDictionary); } }
    public virtual bool Supported { get { return default(bool); } set { } }
    public virtual bool Visible { get { return default(bool); } set { } }
    public event System.EventHandler CommandChanged { add { } remove { } }
    public virtual void Invoke() { }
    public virtual void Invoke(object arg) { }
    protected virtual void OnCommandChanged(System.EventArgs e) { }
    public override string ToString() { return default(string); }
  }

  [System.FlagsAttribute]
  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum SelectionTypes {
    Add = 64,
    Auto = 1,
    [System.ObsoleteAttribute("This value has been deprecated. Use SelectionTypes.Primary instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
    Click = 16,
    [System.ObsoleteAttribute("This value has been deprecated.  It is no longer supported. http://go.microsoft.com/fwlink/?linkid=14202")]
    MouseDown = 4,
    [System.ObsoleteAttribute("This value has been deprecated.  It is no longer supported. http://go.microsoft.com/fwlink/?linkid=14202")]
    MouseUp = 8,
    [System.ObsoleteAttribute("This value has been deprecated. Use SelectionTypes.Auto instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
    Normal = 1,
    Primary = 16,
    Remove = 128,
    Replace = 2,
    Toggle = 32,
    [System.ObsoleteAttribute("This value has been deprecated. Use Enum class methods to determine valid values, or use a type converter. http://go.microsoft.com/fwlink/?linkid=14202")]
    Valid = 31,
  }

  public partial class ServiceContainer : System.ComponentModel.Design.IServiceContainer, System.IDisposable, System.IServiceProvider {
    public ServiceContainer() { }
    public ServiceContainer(System.IServiceProvider parentProvider) { }
    protected virtual System.Type[] DefaultServices { get { return default(System.Type[]); } }
    public void AddService(System.Type serviceType, System.ComponentModel.Design.ServiceCreatorCallback callback) { }
    public virtual void AddService(System.Type serviceType, System.ComponentModel.Design.ServiceCreatorCallback callback, bool promote) { }
    public void AddService(System.Type serviceType, object serviceInstance) { }
    public virtual void AddService(System.Type serviceType, object serviceInstance, bool promote) { }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public virtual object GetService(System.Type serviceType) { return default(object); }
    public void RemoveService(System.Type serviceType) { }
    public virtual void RemoveService(System.Type serviceType, bool promote) { }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public delegate object ServiceCreatorCallback(System.ComponentModel.Design.IServiceContainer container, System.Type serviceType);

  public partial class StandardCommands {
    public static readonly System.ComponentModel.Design.CommandID AlignBottom;
    public static readonly System.ComponentModel.Design.CommandID AlignHorizontalCenters;
    public static readonly System.ComponentModel.Design.CommandID AlignLeft;
    public static readonly System.ComponentModel.Design.CommandID AlignRight;
    public static readonly System.ComponentModel.Design.CommandID AlignToGrid;
    public static readonly System.ComponentModel.Design.CommandID AlignTop;
    public static readonly System.ComponentModel.Design.CommandID AlignVerticalCenters;
    public static readonly System.ComponentModel.Design.CommandID ArrangeBottom;
    public static readonly System.ComponentModel.Design.CommandID ArrangeIcons;
    public static readonly System.ComponentModel.Design.CommandID ArrangeRight;
    public static readonly System.ComponentModel.Design.CommandID BringForward;
    public static readonly System.ComponentModel.Design.CommandID BringToFront;
    public static readonly System.ComponentModel.Design.CommandID CenterHorizontally;
    public static readonly System.ComponentModel.Design.CommandID CenterVertically;
    public static readonly System.ComponentModel.Design.CommandID Copy;
    public static readonly System.ComponentModel.Design.CommandID Cut;
    public static readonly System.ComponentModel.Design.CommandID Delete;
    public static readonly System.ComponentModel.Design.CommandID DocumentOutline;
    public static readonly System.ComponentModel.Design.CommandID F1Help;
    public static readonly System.ComponentModel.Design.CommandID Group;
    public static readonly System.ComponentModel.Design.CommandID HorizSpaceConcatenate;
    public static readonly System.ComponentModel.Design.CommandID HorizSpaceDecrease;
    public static readonly System.ComponentModel.Design.CommandID HorizSpaceIncrease;
    public static readonly System.ComponentModel.Design.CommandID HorizSpaceMakeEqual;
    public static readonly System.ComponentModel.Design.CommandID LineupIcons;
    public static readonly System.ComponentModel.Design.CommandID LockControls;
    public static readonly System.ComponentModel.Design.CommandID MultiLevelRedo;
    public static readonly System.ComponentModel.Design.CommandID MultiLevelUndo;
    public static readonly System.ComponentModel.Design.CommandID Paste;
    public static readonly System.ComponentModel.Design.CommandID Properties;
    public static readonly System.ComponentModel.Design.CommandID PropertiesWindow;
    public static readonly System.ComponentModel.Design.CommandID Redo;
    public static readonly System.ComponentModel.Design.CommandID Replace;
    public static readonly System.ComponentModel.Design.CommandID SelectAll;
    public static readonly System.ComponentModel.Design.CommandID SendBackward;
    public static readonly System.ComponentModel.Design.CommandID SendToBack;
    public static readonly System.ComponentModel.Design.CommandID ShowGrid;
    public static readonly System.ComponentModel.Design.CommandID ShowLargeIcons;
    public static readonly System.ComponentModel.Design.CommandID SizeToControl;
    public static readonly System.ComponentModel.Design.CommandID SizeToControlHeight;
    public static readonly System.ComponentModel.Design.CommandID SizeToControlWidth;
    public static readonly System.ComponentModel.Design.CommandID SizeToFit;
    public static readonly System.ComponentModel.Design.CommandID SizeToGrid;
    public static readonly System.ComponentModel.Design.CommandID SnapToGrid;
    public static readonly System.ComponentModel.Design.CommandID TabOrder;
    public static readonly System.ComponentModel.Design.CommandID Undo;
    public static readonly System.ComponentModel.Design.CommandID Ungroup;
    public static readonly System.ComponentModel.Design.CommandID VerbFirst;
    public static readonly System.ComponentModel.Design.CommandID VerbLast;
    public static readonly System.ComponentModel.Design.CommandID VertSpaceConcatenate;
    public static readonly System.ComponentModel.Design.CommandID VertSpaceDecrease;
    public static readonly System.ComponentModel.Design.CommandID VertSpaceIncrease;
    public static readonly System.ComponentModel.Design.CommandID VertSpaceMakeEqual;
    public static readonly System.ComponentModel.Design.CommandID ViewCode;
    public static readonly System.ComponentModel.Design.CommandID ViewGrid;
    public StandardCommands() { }
  }

  public partial class StandardToolWindows {
    public static readonly System.Guid ObjectBrowser;
    public static readonly System.Guid OutputWindow;
    public static readonly System.Guid ProjectExplorer;
    public static readonly System.Guid PropertyBrowser;
    public static readonly System.Guid RelatedLinks;
    public static readonly System.Guid ServerExplorer;
    public static readonly System.Guid TaskList;
    public static readonly System.Guid Toolbox;
    public StandardToolWindows() { }
  }

  public abstract partial class TypeDescriptionProviderService {
    protected TypeDescriptionProviderService() { }
    public abstract System.ComponentModel.TypeDescriptionProvider GetProvider(object instance);
    public abstract System.ComponentModel.TypeDescriptionProvider GetProvider(System.Type type);
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public enum ViewTechnology {
    Default = 2,
    [System.ObsoleteAttribute("This value has been deprecated. Use ViewTechnology.Default instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
    Passthrough = 0,
    [System.ObsoleteAttribute("This value has been deprecated. Use ViewTechnology.Default instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
    WindowsForms = 1,
  }

} // end of System.ComponentModel.Design
namespace System.ComponentModel.Design.Serialization {
  public abstract partial class ComponentSerializationService {
    protected ComponentSerializationService() { }
    public abstract System.ComponentModel.Design.Serialization.SerializationStore CreateStore();
    public abstract System.Collections.ICollection Deserialize(System.ComponentModel.Design.Serialization.SerializationStore store);
    public abstract System.Collections.ICollection Deserialize(System.ComponentModel.Design.Serialization.SerializationStore store, System.ComponentModel.IContainer container);
    public void DeserializeTo(System.ComponentModel.Design.Serialization.SerializationStore store, System.ComponentModel.IContainer container) { }
    public void DeserializeTo(System.ComponentModel.Design.Serialization.SerializationStore store, System.ComponentModel.IContainer container, bool validateRecycledTypes) { }
    public abstract void DeserializeTo(System.ComponentModel.Design.Serialization.SerializationStore store, System.ComponentModel.IContainer container, bool validateRecycledTypes, bool applyDefaults);
    public abstract System.ComponentModel.Design.Serialization.SerializationStore LoadStore(System.IO.Stream stream);
    public abstract void Serialize(System.ComponentModel.Design.Serialization.SerializationStore store, object value);
    public abstract void SerializeAbsolute(System.ComponentModel.Design.Serialization.SerializationStore store, object value);
    public abstract void SerializeMember(System.ComponentModel.Design.Serialization.SerializationStore store, object owningObject, System.ComponentModel.MemberDescriptor member);
    public abstract void SerializeMemberAbsolute(System.ComponentModel.Design.Serialization.SerializationStore store, object owningObject, System.ComponentModel.MemberDescriptor member);
  }

  public sealed partial class ContextStack {
    public ContextStack() { }
    public object Current { get { return default(object); } }
    public object this[int level] { get { return default(object); } }
    public object this[System.Type type] { get { return default(object); } }
    public void Append(object context) { }
    public object Pop() { return default(object); }
    public void Push(object context) { }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(4), Inherited=false)]
  public sealed partial class DefaultSerializationProviderAttribute : System.Attribute {
    public DefaultSerializationProviderAttribute(string providerTypeName) { }
    public DefaultSerializationProviderAttribute(System.Type providerType) { }
    public string ProviderTypeName { get { return default(string); } }
  }

  [System.Runtime.InteropServices.ComVisibleAttribute(true)]
  public abstract partial class DesignerLoader {
    protected DesignerLoader() { }
    public virtual bool Loading { get { return default(bool); } }
    public abstract void BeginLoad(System.ComponentModel.Design.Serialization.IDesignerLoaderHost host);
    public abstract void Dispose();
    public virtual void Flush() { }
  }

  [System.AttributeUsageAttribute((System.AttributeTargets)(1028), AllowMultiple=true, Inherited=true)]
  public sealed partial class DesignerSerializerAttribute : System.Attribute {
    public DesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName) { }
    public DesignerSerializerAttribute(string serializerTypeName, System.Type baseSerializerType) { }
    public DesignerSerializerAttribute(System.Type serializerType, System.Type baseSerializerType) { }
    public string SerializerBaseTypeName { get { return default(string); } }
    public string SerializerTypeName { get { return default(string); } }
    public override object TypeId { get { return default(object); } }
  }

  public partial interface IDesignerLoaderHost : System.ComponentModel.Design.IDesignerHost, System.ComponentModel.Design.IServiceContainer, System.IServiceProvider {
    void EndLoad(string baseClassName, bool successful, System.Collections.ICollection errorCollection);
    void Reload();
  }

  public partial interface IDesignerLoaderHost2 : System.ComponentModel.Design.IDesignerHost, System.ComponentModel.Design.IServiceContainer, System.ComponentModel.Design.Serialization.IDesignerLoaderHost, System.IServiceProvider {
    bool CanReloadWithErrors { get; set; }
    bool IgnoreErrorsDuringReload { get; set; }
  }

  public partial interface IDesignerLoaderService {
    void AddLoadDependency();
    void DependentLoadComplete(bool successful, System.Collections.ICollection errorCollection);
    bool Reload();
  }

  public partial interface IDesignerSerializationManager : System.IServiceProvider {
    System.ComponentModel.Design.Serialization.ContextStack Context { get; }
    System.ComponentModel.PropertyDescriptorCollection Properties { get; }
    event System.ComponentModel.Design.Serialization.ResolveNameEventHandler ResolveName;
    event System.EventHandler SerializationComplete;
    void AddSerializationProvider(System.ComponentModel.Design.Serialization.IDesignerSerializationProvider provider);
    object CreateInstance(System.Type type, System.Collections.ICollection arguments, string name, bool addToContainer);
    object GetInstance(string name);
    string GetName(object value);
    object GetSerializer(System.Type objectType, System.Type serializerType);
    System.Type GetType(string typeName);
    void RemoveSerializationProvider(System.ComponentModel.Design.Serialization.IDesignerSerializationProvider provider);
    void ReportError(object errorInformation);
    void SetName(object instance, string name);
  }

  public partial interface IDesignerSerializationProvider {
    object GetSerializer(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object currentSerializer, System.Type objectType, System.Type serializerType);
  }

  public partial interface IDesignerSerializationService {
    System.Collections.ICollection Deserialize(object serializationData);
    object Serialize(System.Collections.ICollection objects);
  }

  public partial interface INameCreationService {
    string CreateName(System.ComponentModel.IContainer container, System.Type dataType);
    bool IsValidName(string name);
    void ValidateName(string name);
  }

  public sealed partial class InstanceDescriptor {
    public InstanceDescriptor(System.Reflection.MemberInfo member, System.Collections.ICollection arguments) { }
    public InstanceDescriptor(System.Reflection.MemberInfo member, System.Collections.ICollection arguments, bool isComplete) { }
    public System.Collections.ICollection Arguments { get { return default(System.Collections.ICollection); } }
    public bool IsComplete { get { return default(bool); } }
    public System.Reflection.MemberInfo MemberInfo { get { return default(System.Reflection.MemberInfo); } }
    public object Invoke() { return default(object); }
  }

  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public partial struct MemberRelationship {
    public static readonly System.ComponentModel.Design.Serialization.MemberRelationship Empty;
    public MemberRelationship(object owner, System.ComponentModel.MemberDescriptor member) { throw new System.NotImplementedException(); }
    public bool IsEmpty { get { return default(bool); } }
    public System.ComponentModel.MemberDescriptor Member { get { return default(System.ComponentModel.MemberDescriptor); } }
    public object Owner { get { return default(object); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public static bool operator ==(System.ComponentModel.Design.Serialization.MemberRelationship left, System.ComponentModel.Design.Serialization.MemberRelationship right) { return default(bool); }
    public static bool operator !=(System.ComponentModel.Design.Serialization.MemberRelationship left, System.ComponentModel.Design.Serialization.MemberRelationship right) { return default(bool); }
  }

  public abstract partial class MemberRelationshipService {
    protected MemberRelationshipService() { }
    public System.ComponentModel.Design.Serialization.MemberRelationship this[System.ComponentModel.Design.Serialization.MemberRelationship source] { get { return default(System.ComponentModel.Design.Serialization.MemberRelationship); } set { } }
    public System.ComponentModel.Design.Serialization.MemberRelationship this[object sourceOwner, System.ComponentModel.MemberDescriptor sourceMember] { get { return default(System.ComponentModel.Design.Serialization.MemberRelationship); } set { } }
    protected virtual System.ComponentModel.Design.Serialization.MemberRelationship GetRelationship(System.ComponentModel.Design.Serialization.MemberRelationship source) { return default(System.ComponentModel.Design.Serialization.MemberRelationship); }
    protected virtual void SetRelationship(System.ComponentModel.Design.Serialization.MemberRelationship source, System.ComponentModel.Design.Serialization.MemberRelationship relationship) { }
    public abstract bool SupportsRelationship(System.ComponentModel.Design.Serialization.MemberRelationship source, System.ComponentModel.Design.Serialization.MemberRelationship relationship);
  }

  public partial class ResolveNameEventArgs : System.EventArgs {
    public ResolveNameEventArgs(string name) { }
    public string Name { get { return default(string); } }
    public object Value { get { return default(object); } set { } }
  }

  public delegate void ResolveNameEventHandler(object sender, System.ComponentModel.Design.Serialization.ResolveNameEventArgs e);

  [System.AttributeUsageAttribute((System.AttributeTargets)(1028), AllowMultiple=true, Inherited=true)]
  [System.ObsoleteAttribute("This attribute has been deprecated. Use DesignerSerializerAttribute instead.  For example, to specify a root designer for CodeDom, use DesignerSerializerAttribute(...,typeof(TypeCodeDomSerializer)).  http://go.microsoft.com/fwlink/?linkid=14202")]
  public sealed partial class RootDesignerSerializerAttribute : System.Attribute {
    public RootDesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName, bool reloadable) { }
    public RootDesignerSerializerAttribute(string serializerTypeName, System.Type baseSerializerType, bool reloadable) { }
    public RootDesignerSerializerAttribute(System.Type serializerType, System.Type baseSerializerType, bool reloadable) { }
    public bool Reloadable { get { return default(bool); } }
    public string SerializerBaseTypeName { get { return default(string); } }
    public string SerializerTypeName { get { return default(string); } }
    public override object TypeId { get { return default(object); } }
  }

  public abstract partial class SerializationStore : System.IDisposable {
    protected SerializationStore() { }
    public abstract System.Collections.ICollection Errors { get; }
    public abstract void Close();
    protected virtual void Dispose(bool disposing) { }
    public abstract void Save(System.IO.Stream stream);
    void System.IDisposable.Dispose() { }
  }

} // end of System.ComponentModel.Design.Serialization
namespace System.Security.Authentication.ExtendedProtection {
  public partial class ExtendedProtectionPolicyTypeConverter : System.ComponentModel.TypeConverter {
    public ExtendedProtectionPolicyTypeConverter() { }
    public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) { return default(bool); }
    public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { return default(object); }
  }

} // end of System.Security.Authentication.ExtendedProtection
