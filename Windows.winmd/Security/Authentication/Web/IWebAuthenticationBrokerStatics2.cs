// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.IWebAuthenticationBrokerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web
{
  [Guid(1942879134, 5351, 16858, 169, 113, 170, 244, 65, 11, 98, 30)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WebAuthenticationBroker))]
  internal interface IWebAuthenticationBrokerStatics2
  {
    [Overload("AuthenticateAndContinue")]
    void AuthenticateAndContinue(Uri requestUri);

    [Overload("AuthenticateWithCallbackUriAndContinue")]
    void AuthenticateAndContinue(Uri requestUri, Uri callbackUri);

    [Overload("AuthenticateWithCallbackUriContinuationDataAndOptionsAndContinue")]
    void AuthenticateAndContinue(
      Uri requestUri,
      Uri callbackUri,
      ValueSet continuationData,
      WebAuthenticationOptions options);

    [Overload("AuthenticateSilentlyAsync")]
    [RemoteAsync]
    IAsyncOperation<WebAuthenticationResult> AuthenticateSilentlyAsync(
      Uri requestUri);

    [RemoteAsync]
    [Overload("AuthenticateSilentlyWithOptionsAsync")]
    IAsyncOperation<WebAuthenticationResult> AuthenticateSilentlyAsync(
      Uri requestUri,
      WebAuthenticationOptions options);
  }
}
