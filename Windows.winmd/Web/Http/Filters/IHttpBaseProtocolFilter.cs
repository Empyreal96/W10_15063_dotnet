// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Filters.IHttpBaseProtocolFilter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Web.Http.Filters
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1908972297, 57649, 19284, 165, 60, 235, 67, 255, 55, 233, 187)]
  [ExclusiveTo(typeof (HttpBaseProtocolFilter))]
  internal interface IHttpBaseProtocolFilter : IHttpFilter, IClosable
  {
    bool AllowAutoRedirect { get; set; }

    bool AllowUI { get; set; }

    bool AutomaticDecompression { get; set; }

    HttpCacheControl CacheControl { get; }

    HttpCookieManager CookieManager { get; }

    Certificate ClientCertificate { get; set; }

    IVector<ChainValidationResult> IgnorableServerCertificateErrors { get; }

    uint MaxConnectionsPerServer { get; set; }

    PasswordCredential ProxyCredential { get; set; }

    PasswordCredential ServerCredential { get; set; }

    bool UseProxy { get; set; }
  }
}
