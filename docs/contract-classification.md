# Contract Classification

Contract                                          | Bucket     |Comment
--------------------------------------------------|------------|----------------------------------------------------------
Microsoft.CSharp                                  | Core       | Late Binder
Microsoft.VisualBasic                             | Core       |
Microsoft.Win32.Registry                          | Extension  |
Microsoft.Win32.SafeHandles                       | Core       | We should consider merging with S.R.
System.AppContext                                 | Core       | Lightweight AppDomain
System.CodeDom                                    | Legacy     | Just indented text writer
System.Collections                                | Core       |
System.Collections.Concurrent                     | Core       |
System.Collections.NonGeneric                     | Legacy     |
System.Collections.Specialized                    | Legacy     |
System.ComponentModel                             | Legacy     | Probably used for view models
System.ComponentModel.Annotations                 | Core       |
System.ComponentModel.EventBasedAsync             | Legacy     |
System.ComponentModel.Primitives                  | Legacy     | We should consider merging with S.CM.TypeConverter
System.ComponentModel.TypeConverter               | Legacy     |
System.Console                                    | Core       |
System.Data.Common                                | Extension  | Move DBNull to System.Runtime
System.Data.SqlClient                             | Extension  |
System.Deployment                                 | Legacy     |
System.Diagnostics.Contracts                      | Core       | Consider moving PureAttribute to S.R.
System.Diagnostics.Debug                          | Core       |
System.Diagnostics.FileVersionInfo                | Extension  | Not really x-plat, it's quite specific to Win32 version resource, consider merging with S.IO.FS
System.Diagnostics.Process                        | Legacy     |
System.Diagnostics.StackTrace                     | Core       | Consider moving to S.R.
System.Diagnostics.SymbolStore                    | Legacy     | COM interfaces to read PDB information
System.Diagnostics.TextWriterTraceListener        | Core       | Consider combining with S.D.TraceSource
System.Diagnostics.TraceSource                    | Core       |
System.Diagnostics.Tracing                        | Core       |
System.Globalization                              | Core       | But move TimeZone into its own bucket
System.Globalization.Calendars                    | Core       |
System.Globalization.Extensions                   | Core       | Consider merging with S.Glob
System.IO                                         | Core       |
System.IO.Compression                             | Core       |
System.IO.Compression.ZipFile                     | Core       |
System.IO.FileSystem                              | Core       | Move FileIOPermissionAttribute to CAS
System.IO.FileSystem.DriveInfo                    | Core       | Consider merging with S.IO.FileSystem
System.IO.FileSystem.Primitives                   | Core       | Consider merging with S.IO.FileSystem
System.IO.FileSystem.Watcher                      | Legacy     |
System.IO.MemoryMappedFiles                       | Extension  |
System.IO.Pipes                                   | Extension  |
System.IO.UnmanagedMemoryStream                   | Core       |
System.Linq                                       | Core       |
System.Linq.Expressions                           | Core       |
System.Linq.Parallel                              | Extension  |
System.Linq.Queryable                             | Extension  |
System.Net                                        | ?          | Seems to be a grab bag right now
System.Net.Http                                   | Core       |
System.Net.Http.WinHttpHandler                    | Extension  |
System.Net.HttpListener                           | Extension  |
System.Net.Mail                                   | Extension  |
System.Net.Mime                                   | Extension  |
System.Net.NameResolution                         | Extension  |
System.Net.NetworkInformation                     | Extension  |
System.Net.Ping                                   | Extension  |
System.Net.Primitives                             | Core       |
System.Net.Requests                               | Legacy     |
System.Net.Security                               | Extension  |
System.Net.Security.Permissions                   | Legacy     |
System.Net.Sockets                                | Core       |
System.Net.WebClient                              | Legacy     |
System.Net.WebHeaderCollection                    | Legacy     |
System.Net.WebSockets                             | Extension  |
System.Net.WebSockets.Client                      | Extension  |
System.Numerics.Vectors                           | Core       |
System.ObjectModel                                | Core       |
System.Reflection.DispatchProxy                   | Extension  |
System.Reflection.Primitives                      | Core       | Consider moving to S.R.
System.Reflection.TypeExtensions                  | Core       | Consider moving to S.R.
System.Resources.Reader                           | Core       |
System.Resources.ResourceManager                  | Core       |
System.Resources.Writer                           | Extension  |
System.Runtime                                    | Core       |
System.Runtime.CompilerServices.VisualC           | Legacy     |
System.Runtime.ConstrainedExecution               | Legacy     |
System.Runtime.Extensions                         | Core       |
System.Runtime.Handles                            | Core       |
System.Runtime.InteropServices                    | Core       |
System.Runtime.InteropServices.RuntimeInformation | Core       |
System.Runtime.IsolatedStorage                    | Legacy     |
System.Runtime.Loader                             | Extension  |
System.Runtime.Numerics                           | Core       |
System.Runtime.Remoting                           | Legacy     |
System.Runtime.Serialization.Json                 | Legacy     |
System.Runtime.Serialization.Primitives           | Extension  |
System.Runtime.Serialization.Xml                  | Extension  |
System.Runtime.Versioning                         | Legacy     |
System.Security.AccessControl                     | Extension  |
System.Security.Claims                            | Extension  |
System.Security.Cryptography.Algorithms           | Core       |
System.Security.Cryptography.Csp                  | Extension  |
System.Security.Cryptography.Encoding             | Core       |
System.Security.Cryptography.Primitives           | Core       |
System.Security.Cryptography.X509Certificates     | Extension  |
System.Security.Permissions                       | Legacy     |
System.Security.Principal                         | Core       |
System.Security.Principal.Windows                 | Extension  |
System.Security.SecureString                      | Legacy     | Windows only
System.ServiceProcess.ServiceController           | Extension  | Windows only
System.Text.Encoding                              | Core       |
System.Text.Encoding.CodePages                    | Extension  |
System.Text.Encoding.Extensions                   | Core       |
System.Text.RegularExpressions                    | Core       |
System.Threading                                  | Core       |
System.Threading.AccessControl                    | Extension  |
System.Threading.Overlapped                       | Extension  | Windows only
System.Threading.Security                         | ?          | The contract seems misnamed
System.Threading.Tasks.Parallel                   | Core       |
System.Threading.Thread                           | Core       |
System.Threading.ThreadPool                       | Core       |
System.Threading.Timer                            | Core       |
System.Timer                                      | Extension  |
System.Xml.ReaderWriter                           | Core       |
System.Xml.XDocument                              | Core       |
System.Xml.XmlDocument                            | Legacy     |
System.Xml.XmlSerializer                          | Extension  |
System.Xml.XPath                                  | Extension  |
System.Xml.XPath.XDocument                        | Extension  |
System.Xml.XPath.XmlDocument                      | Legacy     |