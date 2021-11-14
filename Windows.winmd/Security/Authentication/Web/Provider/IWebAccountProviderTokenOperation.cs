// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebAccountProviderTokenOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Provider
{
  [Guid(2512786366, 8244, 19512, 148, 52, 210, 108, 20, 178, 180, 178)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IWebAccountProviderTokenOperation : IWebAccountProviderOperation
  {
    WebProviderTokenRequest ProviderRequest { get; }

    IVector<WebProviderTokenResponse> ProviderResponses { get; }

    DateTime CacheExpirationTime { set; get; }
  }
}
