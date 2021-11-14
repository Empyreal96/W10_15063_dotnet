// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.IWebAuthenticationBrokerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web
{
  [ExclusiveTo(typeof (WebAuthenticationBroker))]
  [Guid(789880602, 58995, 16565, 188, 34, 32, 26, 104, 100, 163, 123)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWebAuthenticationBrokerStatics
  {
    [Overload("AuthenticateWithCallbackUriAsync")]
    [RemoteAsync]
    IAsyncOperation<WebAuthenticationResult> AuthenticateAsync(
      WebAuthenticationOptions options,
      Uri requestUri,
      Uri callbackUri);

    [RemoteAsync]
    [Overload("AuthenticateWithoutCallbackUriAsync")]
    IAsyncOperation<WebAuthenticationResult> AuthenticateAsync(
      WebAuthenticationOptions options,
      Uri requestUri);

    Uri GetCurrentApplicationCallbackUri();
  }
}
