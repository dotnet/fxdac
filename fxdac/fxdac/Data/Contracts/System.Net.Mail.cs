[assembly:System.CLSCompliant(true)]
namespace System.Net.Mail {
  public partial class AlternateView : System.Net.Mail.AttachmentBase {
    public AlternateView(System.IO.Stream contentStream) : base (default(System.IO.Stream)) { }
    public AlternateView(System.IO.Stream contentStream, System.Net.Mime.ContentType contentType) : base (default(System.IO.Stream)) { }
    public AlternateView(System.IO.Stream contentStream, string mediaType) : base (default(System.IO.Stream)) { }
    public AlternateView(string fileName) : base (default(System.IO.Stream)) { }
    public AlternateView(string fileName, System.Net.Mime.ContentType contentType) : base (default(System.IO.Stream)) { }
    public AlternateView(string fileName, string mediaType) : base (default(System.IO.Stream)) { }
    public System.Uri BaseUri { get { return default(System.Uri); } set { } }
    public System.Net.Mail.LinkedResourceCollection LinkedResources { get { return default(System.Net.Mail.LinkedResourceCollection); } }
    public static System.Net.Mail.AlternateView CreateAlternateViewFromString(string content) { return default(System.Net.Mail.AlternateView); }
    public static System.Net.Mail.AlternateView CreateAlternateViewFromString(string content, System.Net.Mime.ContentType contentType) { return default(System.Net.Mail.AlternateView); }
    public static System.Net.Mail.AlternateView CreateAlternateViewFromString(string content, System.Text.Encoding encoding, string mediaType) { return default(System.Net.Mail.AlternateView); }
    protected override void Dispose(bool disposing) { }
  }

  public sealed partial class AlternateViewCollection : System.Collections.ObjectModel.Collection<System.Net.Mail.AlternateView>, System.IDisposable {
    internal AlternateViewCollection() { }
    protected override void ClearItems() { }
    public void Dispose() { }
    protected override void InsertItem(int index, System.Net.Mail.AlternateView item) { }
    protected override void RemoveItem(int index) { }
    protected override void SetItem(int index, System.Net.Mail.AlternateView item) { }
  }

  public partial class Attachment : System.Net.Mail.AttachmentBase {
    public Attachment(System.IO.Stream contentStream, System.Net.Mime.ContentType contentType) : base (default(System.IO.Stream)) { }
    public Attachment(System.IO.Stream contentStream, string name) : base (default(System.IO.Stream)) { }
    public Attachment(System.IO.Stream contentStream, string name, string mediaType) : base (default(System.IO.Stream)) { }
    public Attachment(string fileName) : base (default(System.IO.Stream)) { }
    public Attachment(string fileName, System.Net.Mime.ContentType contentType) : base (default(System.IO.Stream)) { }
    public Attachment(string fileName, string mediaType) : base (default(System.IO.Stream)) { }
    public System.Net.Mime.ContentDisposition ContentDisposition { get { return default(System.Net.Mime.ContentDisposition); } }
    public string Name { get { return default(string); } set { } }
    public System.Text.Encoding NameEncoding { get { return default(System.Text.Encoding); } set { } }
    public static System.Net.Mail.Attachment CreateAttachmentFromString(string content, System.Net.Mime.ContentType contentType) { return default(System.Net.Mail.Attachment); }
    public static System.Net.Mail.Attachment CreateAttachmentFromString(string content, string name) { return default(System.Net.Mail.Attachment); }
    public static System.Net.Mail.Attachment CreateAttachmentFromString(string content, string name, System.Text.Encoding contentEncoding, string mediaType) { return default(System.Net.Mail.Attachment); }
  }

  public abstract partial class AttachmentBase : System.IDisposable {
    protected AttachmentBase(System.IO.Stream contentStream) { }
    protected AttachmentBase(System.IO.Stream contentStream, System.Net.Mime.ContentType contentType) { }
    protected AttachmentBase(System.IO.Stream contentStream, string mediaType) { }
    protected AttachmentBase(string fileName) { }
    protected AttachmentBase(string fileName, System.Net.Mime.ContentType contentType) { }
    protected AttachmentBase(string fileName, string mediaType) { }
    public string ContentId { get { return default(string); } set { } }
    public System.IO.Stream ContentStream { get { return default(System.IO.Stream); } }
    public System.Net.Mime.ContentType ContentType { get { return default(System.Net.Mime.ContentType); } set { } }
    public System.Net.Mime.TransferEncoding TransferEncoding { get { return default(System.Net.Mime.TransferEncoding); } set { } }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
  }

  public sealed partial class AttachmentCollection : System.Collections.ObjectModel.Collection<System.Net.Mail.Attachment>, System.IDisposable {
    internal AttachmentCollection() { }
    protected override void ClearItems() { }
    public void Dispose() { }
    protected override void InsertItem(int index, System.Net.Mail.Attachment item) { }
    protected override void RemoveItem(int index) { }
    protected override void SetItem(int index, System.Net.Mail.Attachment item) { }
  }

  [System.FlagsAttribute]
  public enum DeliveryNotificationOptions {
    Delay = 4,
    Never = 134217728,
    None = 0,
    OnFailure = 2,
    OnSuccess = 1,
  }

  public partial class LinkedResource : System.Net.Mail.AttachmentBase {
    public LinkedResource(System.IO.Stream contentStream) : base (default(System.IO.Stream)) { }
    public LinkedResource(System.IO.Stream contentStream, System.Net.Mime.ContentType contentType) : base (default(System.IO.Stream)) { }
    public LinkedResource(System.IO.Stream contentStream, string mediaType) : base (default(System.IO.Stream)) { }
    public LinkedResource(string fileName) : base (default(System.IO.Stream)) { }
    public LinkedResource(string fileName, System.Net.Mime.ContentType contentType) : base (default(System.IO.Stream)) { }
    public LinkedResource(string fileName, string mediaType) : base (default(System.IO.Stream)) { }
    public System.Uri ContentLink { get { return default(System.Uri); } set { } }
    public static System.Net.Mail.LinkedResource CreateLinkedResourceFromString(string content) { return default(System.Net.Mail.LinkedResource); }
    public static System.Net.Mail.LinkedResource CreateLinkedResourceFromString(string content, System.Net.Mime.ContentType contentType) { return default(System.Net.Mail.LinkedResource); }
    public static System.Net.Mail.LinkedResource CreateLinkedResourceFromString(string content, System.Text.Encoding contentEncoding, string mediaType) { return default(System.Net.Mail.LinkedResource); }
  }

  public sealed partial class LinkedResourceCollection : System.Collections.ObjectModel.Collection<System.Net.Mail.LinkedResource>, System.IDisposable {
    internal LinkedResourceCollection() { }
    protected override void ClearItems() { }
    public void Dispose() { }
    protected override void InsertItem(int index, System.Net.Mail.LinkedResource item) { }
    protected override void RemoveItem(int index) { }
    protected override void SetItem(int index, System.Net.Mail.LinkedResource item) { }
  }

  public partial class MailAddress {
    public MailAddress(string address) { }
    public MailAddress(string address, string displayName) { }
    public MailAddress(string address, string displayName, System.Text.Encoding displayNameEncoding) { }
    public string Address { get { return default(string); } }
    public string DisplayName { get { return default(string); } }
    public string Host { get { return default(string); } }
    public string User { get { return default(string); } }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }

  public partial class MailAddressCollection : System.Collections.ObjectModel.Collection<System.Net.Mail.MailAddress> {
    public MailAddressCollection() { }
    public void Add(string addresses) { }
    protected override void InsertItem(int index, System.Net.Mail.MailAddress item) { }
    protected override void SetItem(int index, System.Net.Mail.MailAddress item) { }
    public override string ToString() { return default(string); }
  }

  public partial class MailMessage : System.IDisposable {
    public MailMessage() { }
    public MailMessage(System.Net.Mail.MailAddress from, System.Net.Mail.MailAddress to) { }
    public MailMessage(string from, string to) { }
    public MailMessage(string from, string to, string subject, string body) { }
    public System.Net.Mail.AlternateViewCollection AlternateViews { get { return default(System.Net.Mail.AlternateViewCollection); } }
    public System.Net.Mail.AttachmentCollection Attachments { get { return default(System.Net.Mail.AttachmentCollection); } }
    public System.Net.Mail.MailAddressCollection Bcc { get { return default(System.Net.Mail.MailAddressCollection); } }
    public string Body { get { return default(string); } set { } }
    public System.Text.Encoding BodyEncoding { get { return default(System.Text.Encoding); } set { } }
    public System.Net.Mail.MailAddressCollection CC { get { return default(System.Net.Mail.MailAddressCollection); } }
    public System.Net.Mail.DeliveryNotificationOptions DeliveryNotificationOptions { get { return default(System.Net.Mail.DeliveryNotificationOptions); } set { } }
    public System.Net.Mail.MailAddress From { get { return default(System.Net.Mail.MailAddress); } set { } }
    public System.Collections.Specialized.NameValueCollection Headers { get { return default(System.Collections.Specialized.NameValueCollection); } }
    public System.Text.Encoding HeadersEncoding { get { return default(System.Text.Encoding); } set { } }
    public bool IsBodyHtml { get { return default(bool); } set { } }
    public System.Net.Mail.MailPriority Priority { get { return default(System.Net.Mail.MailPriority); } set { } }
    [System.ObsoleteAttribute("Use ReplyToList instead")]
    public System.Net.Mail.MailAddress ReplyTo { get { return default(System.Net.Mail.MailAddress); } set { } }
    public System.Net.Mail.MailAddressCollection ReplyToList { get { return default(System.Net.Mail.MailAddressCollection); } }
    public System.Net.Mail.MailAddress Sender { get { return default(System.Net.Mail.MailAddress); } set { } }
    public string Subject { get { return default(string); } set { } }
    public System.Text.Encoding SubjectEncoding { get { return default(System.Text.Encoding); } set { } }
    public System.Net.Mail.MailAddressCollection To { get { return default(System.Net.Mail.MailAddressCollection); } }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
  }

  public enum MailPriority {
    High = 2,
    Low = 1,
    Normal = 0,
  }

  public delegate void SendCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

  public enum SmtpAccess {
    Connect = 1,
    ConnectToUnrestrictedPort = 2,
    None = 0,
  }

  public partial class SmtpClient : System.IDisposable {
    public SmtpClient() { }
    public SmtpClient(string host) { }
    public SmtpClient(string host, int port) { }
    public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get { return default(System.Security.Cryptography.X509Certificates.X509CertificateCollection); } }
    public System.Net.ICredentialsByHost Credentials { get { return default(System.Net.ICredentialsByHost); } set { } }
    public System.Net.Mail.SmtpDeliveryMethod DeliveryMethod { get { return default(System.Net.Mail.SmtpDeliveryMethod); } set { } }
    public bool EnableSsl { get { return default(bool); } set { } }
    public string Host { get { return default(string); } set { } }
    public string PickupDirectoryLocation { get { return default(string); } set { } }
    public int Port { get { return default(int); } set { } }
    public System.Net.ServicePoint ServicePoint { get { return default(System.Net.ServicePoint); } }
    public string TargetName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int Timeout { get { return default(int); } set { } }
    public bool UseDefaultCredentials { get { return default(bool); } set { } }
    public event System.Net.Mail.SendCompletedEventHandler SendCompleted { add { } remove { } }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    protected void OnSendCompleted(System.ComponentModel.AsyncCompletedEventArgs e) { }
    public void Send(System.Net.Mail.MailMessage message) { }
    public void Send(string from, string to, string subject, string body) { }
    public void SendAsync(System.Net.Mail.MailMessage message, object userToken) { }
    public void SendAsync(string from, string to, string subject, string body, object userToken) { }
    public void SendAsyncCancel() { }
    public System.Threading.Tasks.Task SendMailAsync(System.Net.Mail.MailMessage message) { return default(System.Threading.Tasks.Task); }
    public System.Threading.Tasks.Task SendMailAsync(string from, string recipients, string subject, string body) { return default(System.Threading.Tasks.Task); }
  }

  public enum SmtpDeliveryMethod {
    Network = 0,
    PickupDirectoryFromIis = 2,
    SpecifiedPickupDirectory = 1,
  }

  public partial class SmtpException : System.Exception, System.Runtime.Serialization.ISerializable {
    public SmtpException() { }
    public SmtpException(System.Net.Mail.SmtpStatusCode statusCode) { }
    public SmtpException(System.Net.Mail.SmtpStatusCode statusCode, string message) { }
    protected SmtpException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public SmtpException(string message) { }
    public SmtpException(string message, System.Exception innerException) { }
    public System.Net.Mail.SmtpStatusCode StatusCode { get { return default(System.Net.Mail.SmtpStatusCode); } set { } }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }

  public partial class SmtpFailedRecipientException : System.Net.Mail.SmtpException, System.Runtime.Serialization.ISerializable {
    public SmtpFailedRecipientException() { }
    public SmtpFailedRecipientException(System.Net.Mail.SmtpStatusCode statusCode, string failedRecipient) { }
    public SmtpFailedRecipientException(System.Net.Mail.SmtpStatusCode statusCode, string failedRecipient, string serverResponse) { }
    protected SmtpFailedRecipientException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    public SmtpFailedRecipientException(string message) { }
    public SmtpFailedRecipientException(string message, System.Exception innerException) { }
    public SmtpFailedRecipientException(string message, string failedRecipient, System.Exception innerException) { }
    public string FailedRecipient { get { return default(string); } }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
  }

  public partial class SmtpFailedRecipientsException : System.Net.Mail.SmtpFailedRecipientException, System.Runtime.Serialization.ISerializable {
    public SmtpFailedRecipientsException() { }
    protected SmtpFailedRecipientsException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public SmtpFailedRecipientsException(string message) { }
    public SmtpFailedRecipientsException(string message, System.Exception innerException) { }
    public SmtpFailedRecipientsException(string message, System.Net.Mail.SmtpFailedRecipientException[] innerExceptions) { }
    public System.Net.Mail.SmtpFailedRecipientException[] InnerExceptions { get { return default(System.Net.Mail.SmtpFailedRecipientException[]); } }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }

  public enum SmtpStatusCode {
    BadCommandSequence = 503,
    CannotVerifyUserWillAttemptDelivery = 252,
    ClientNotPermitted = 454,
    CommandNotImplemented = 502,
    CommandParameterNotImplemented = 504,
    CommandUnrecognized = 500,
    ExceededStorageAllocation = 552,
    GeneralFailure = -1,
    HelpMessage = 214,
    InsufficientStorage = 452,
    LocalErrorInProcessing = 451,
    MailboxBusy = 450,
    MailboxNameNotAllowed = 553,
    MailboxUnavailable = 550,
    MustIssueStartTlsFirst = 530,
    Ok = 250,
    ServiceClosingTransmissionChannel = 221,
    ServiceNotAvailable = 421,
    ServiceReady = 220,
    StartMailInput = 354,
    SyntaxError = 501,
    SystemStatus = 211,
    TransactionFailed = 554,
    UserNotLocalTryAlternatePath = 551,
    UserNotLocalWillForward = 251,
  }

} // end of System.Net.Mail
