// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Filters.HttpBaseProtocolFilter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Web.Http.Filters
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class HttpBaseProtocolFilter : 
    IHttpBaseProtocolFilter,
    IHttpFilter,
    IClosable,
    IHttpBaseProtocolFilter2,
    IHttpBaseProtocolFilter3,
    IHttpBaseProtocolFilter4
  {
    [MethodImpl]
    public extern HttpBaseProtocolFilter();

    public extern bool AllowAutoRedirect { [MethodImpl] get; [MethodImpl] set; }

    public extern bool AllowUI { [MethodImpl] get; [MethodImpl] set; }

    public extern bool AutomaticDecompression { [MethodImpl] get; [MethodImpl] set; }

    public extern HttpCacheControl CacheControl { [MethodImpl] get; }

    public extern HttpCookieManager CookieManager { [MethodImpl] get; }

    public extern Certificate ClientCertificate { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<ChainValidationResult> IgnorableServerCertificateErrors { [MethodImpl] get; }

    public extern uint MaxConnectionsPerServer { [MethodImpl] get; [MethodImpl] set; }

    public extern PasswordCredential ProxyCredential { [MethodImpl] get; [MethodImpl] set; }

    public extern PasswordCredential ServerCredential { [MethodImpl] get; [MethodImpl] set; }

    public extern bool UseProxy { [MethodImpl] get; [MethodImpl] set; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<HttpResponseMessage, HttpProgress> SendRequestAsync(
      HttpRequestMessage request);

    [MethodImpl]
    public extern void Close();

    public extern HttpVersion MaxVersion { [MethodImpl] get; [MethodImpl] set; }

    public extern HttpCookieUsageBehavior CookieUsageBehavior { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<HttpBaseProtocolFilter, HttpServerCustomValidationRequestedEventArgs> ServerCustomValidationRequested;

    [MethodImpl]
    public extern void ClearAuthenticationCache();
  }
}
