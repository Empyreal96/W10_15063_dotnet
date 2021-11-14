// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.IWebTokenRequestResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Core
{
  [Guid(3240788741, 53752, 17539, 141, 84, 56, 254, 41, 39, 132, 255)]
  [ExclusiveTo(typeof (WebTokenRequestResult))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWebTokenRequestResult
  {
    IVectorView<WebTokenResponse> ResponseData { get; }

    WebTokenRequestStatus ResponseStatus { get; }

    WebProviderError ResponseError { get; }

    [RemoteAsync]
    IAsyncAction InvalidateCacheAsync();
  }
}
