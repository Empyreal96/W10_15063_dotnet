// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.WebAuthenticationBroker
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web
{
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IWebAuthenticationBrokerStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IWebAuthenticationBrokerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class WebAuthenticationBroker
  {
    [Overload("AuthenticateAndContinue")]
    [MethodImpl]
    public static extern void AuthenticateAndContinue(Uri requestUri);

    [Overload("AuthenticateWithCallbackUriAndContinue")]
    [MethodImpl]
    public static extern void AuthenticateAndContinue(Uri requestUri, Uri callbackUri);

    [Overload("AuthenticateWithCallbackUriContinuationDataAndOptionsAndContinue")]
    [MethodImpl]
    public static extern void AuthenticateAndContinue(
      Uri requestUri,
      Uri callbackUri,
      ValueSet continuationData,
      WebAuthenticationOptions options);

    [RemoteAsync]
    [Overload("AuthenticateSilentlyAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<WebAuthenticationResult> AuthenticateSilentlyAsync(
      Uri requestUri);

    [RemoteAsync]
    [Overload("AuthenticateSilentlyWithOptionsAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<WebAuthenticationResult> AuthenticateSilentlyAsync(
      Uri requestUri,
      WebAuthenticationOptions options);

    [RemoteAsync]
    [Overload("AuthenticateWithCallbackUriAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<WebAuthenticationResult> AuthenticateAsync(
      WebAuthenticationOptions options,
      Uri requestUri,
      Uri callbackUri);

    [Overload("AuthenticateWithoutCallbackUriAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<WebAuthenticationResult> AuthenticateAsync(
      WebAuthenticationOptions options,
      Uri requestUri);

    [MethodImpl]
    public static extern Uri GetCurrentApplicationCallbackUri();
  }
}
