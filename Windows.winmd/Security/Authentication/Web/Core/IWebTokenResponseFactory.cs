// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.IWebTokenResponseFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Security.Authentication.Web.Core
{
  [Guid(2875979768, 21584, 20214, 151, 247, 5, 43, 4, 49, 192, 240)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WebTokenResponse))]
  internal interface IWebTokenResponseFactory
  {
    WebTokenResponse CreateWithToken(string token);

    WebTokenResponse CreateWithTokenAndAccount(string token, WebAccount webAccount);

    WebTokenResponse CreateWithTokenAccountAndError(
      string token,
      WebAccount webAccount,
      WebProviderError error);
  }
}
