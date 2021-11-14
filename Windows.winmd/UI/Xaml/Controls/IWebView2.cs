// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebView2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.Web;
using Windows.Web.Http;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (WebView))]
  [Guid(3565254046, 16127, 17506, 130, 61, 253, 82, 249, 186, 76, 200)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IWebView2
  {
    bool CanGoBack { get; }

    bool CanGoForward { get; }

    string DocumentTitle { get; }

    event TypedEventHandler<WebView, WebViewNavigationStartingEventArgs> NavigationStarting;

    event TypedEventHandler<WebView, WebViewContentLoadingEventArgs> ContentLoading;

    event TypedEventHandler<WebView, WebViewDOMContentLoadedEventArgs> DOMContentLoaded;

    void GoForward();

    void GoBack();

    void Refresh();

    void Stop();

    [RemoteAsync]
    IAsyncAction CapturePreviewToStreamAsync(IRandomAccessStream stream);

    [RemoteAsync]
    IAsyncOperation<string> InvokeScriptAsync(
      string scriptName,
      IIterable<string> arguments);

    [RemoteAsync]
    IAsyncOperation<DataPackage> CaptureSelectedContentToDataPackageAsync();

    void NavigateToLocalStreamUri(Uri source, IUriToStreamResolver streamResolver);

    Uri BuildLocalStreamUri(string contentIdentifier, string relativePath);

    Color DefaultBackgroundColor { get; set; }

    event TypedEventHandler<WebView, WebViewNavigationCompletedEventArgs> NavigationCompleted;

    event TypedEventHandler<WebView, WebViewNavigationStartingEventArgs> FrameNavigationStarting;

    event TypedEventHandler<WebView, WebViewContentLoadingEventArgs> FrameContentLoading;

    event TypedEventHandler<WebView, WebViewDOMContentLoadedEventArgs> FrameDOMContentLoaded;

    event TypedEventHandler<WebView, WebViewNavigationCompletedEventArgs> FrameNavigationCompleted;

    event TypedEventHandler<WebView, WebViewLongRunningScriptDetectedEventArgs> LongRunningScriptDetected;

    event TypedEventHandler<WebView, object> UnsafeContentWarningDisplaying;

    event TypedEventHandler<WebView, WebViewUnviewableContentIdentifiedEventArgs> UnviewableContentIdentified;

    void NavigateWithHttpRequestMessage(HttpRequestMessage requestMessage);

    bool Focus(FocusState value);
  }
}
