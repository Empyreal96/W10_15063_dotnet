// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.IWebAuthenticationCoreManagerHelper
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Authentication.Web.Core;
using Windows.Security.Credentials;
using Windows.UI.Xaml;

namespace Windows.ApplicationModel.Store.Preview
{
  [Guid(111478053, 59157, 16675, 146, 118, 157, 111, 134, 91, 165, 95)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (WebAuthenticationCoreManagerHelper))]
  internal interface IWebAuthenticationCoreManagerHelper
  {
    [Overload("RequestTokenWithUIElementHostingAsync")]
    [RemoteAsync]
    IAsyncOperation<WebTokenRequestResult> RequestTokenWithUIElementHostingAsync(
      WebTokenRequest request,
      UIElement uiElement);

    [RemoteAsync]
    [Overload("RequestTokenWithUIElementHostingAndWebAccountAsync")]
    IAsyncOperation<WebTokenRequestResult> RequestTokenWithUIElementHostingAsync(
      WebTokenRequest request,
      WebAccount webAccount,
      UIElement uiElement);
  }
}
