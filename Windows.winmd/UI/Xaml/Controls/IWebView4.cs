// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebView4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3800187836, 26611, 17962, 180, 224, 59, 191, 108, 61, 171, 11)]
  [ExclusiveTo(typeof (WebView))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IWebView4
  {
    WebViewExecutionMode ExecutionMode { get; }

    IVector<WebViewDeferredPermissionRequest> DeferredPermissionRequests { get; }

    WebViewSettings Settings { get; }

    event TypedEventHandler<WebView, WebViewUnsupportedUriSchemeIdentifiedEventArgs> UnsupportedUriSchemeIdentified;

    event TypedEventHandler<WebView, WebViewNewWindowRequestedEventArgs> NewWindowRequested;

    event TypedEventHandler<WebView, WebViewPermissionRequestedEventArgs> PermissionRequested;

    void AddWebAllowedObject(string name, object pObject);

    WebViewDeferredPermissionRequest DeferredPermissionRequestById(
      uint id);
  }
}
