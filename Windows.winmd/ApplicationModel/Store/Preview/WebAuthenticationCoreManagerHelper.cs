// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.WebAuthenticationCoreManagerHelper
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Authentication.Web.Core;
using Windows.Security.Credentials;
using Windows.UI.Xaml;

namespace Windows.ApplicationModel.Store.Preview
{
  [Static(typeof (IWebAuthenticationCoreManagerHelper), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public static class WebAuthenticationCoreManagerHelper
  {
    [Overload("RequestTokenWithUIElementHostingAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<WebTokenRequestResult> RequestTokenWithUIElementHostingAsync(
      WebTokenRequest request,
      UIElement uiElement);

    [Overload("RequestTokenWithUIElementHostingAndWebAccountAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<WebTokenRequestResult> RequestTokenWithUIElementHostingAsync(
      WebTokenRequest request,
      WebAccount webAccount,
      UIElement uiElement);
  }
}
