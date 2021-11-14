// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.WebView
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Navigation;
using Windows.Web;
using Windows.Web.Http;

namespace Windows.UI.Xaml.Controls
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IWebViewStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IWebViewStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Activatable(typeof (IWebViewFactory4), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IWebViewStatics5), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IWebViewStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IWebViewStatics4), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class WebView : 
    FrameworkElement,
    IWebView,
    IWebView2,
    IWebView3,
    IWebView4,
    IWebView5
  {
    [MethodImpl]
    public extern WebView(WebViewExecutionMode executionMode);

    [MethodImpl]
    public extern WebView();

    public extern Uri Source { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<Uri> AllowedScriptNotifyUris { [Deprecated("AllowedScriptNotifyUris is unavailable for releases beginning with Windows 8.1. Instead, list URIs under ApplicationContentUriRules in the package manifest. For more info, see the AllowedScriptNotifyUris documentation.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("AllowedScriptNotifyUris is unavailable for releases beginning with Windows 8.1. Instead, list URIs under ApplicationContentUriRules in the package manifest. For more info, see the AllowedScriptNotifyUris documentation.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    public extern DataPackage DataTransferPackage { [Deprecated("Use CaptureSelectedContentToDataPackageAsync instead of DataTransferPackage. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern event LoadCompletedEventHandler LoadCompleted;

    public extern event NotifyEventHandler ScriptNotify;

    public extern event WebViewNavigationFailedEventHandler NavigationFailed;

    [Deprecated("Use InvokeScriptAsync instead of InvokeScript. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern string InvokeScript(string scriptName, string[] arguments);

    [MethodImpl]
    public extern void Navigate(Uri source);

    [MethodImpl]
    public extern void NavigateToString(string text);

    public extern bool CanGoBack { [MethodImpl] get; }

    public extern bool CanGoForward { [MethodImpl] get; }

    public extern string DocumentTitle { [MethodImpl] get; }

    public extern event TypedEventHandler<WebView, WebViewNavigationStartingEventArgs> NavigationStarting;

    public extern event TypedEventHandler<WebView, WebViewContentLoadingEventArgs> ContentLoading;

    public extern event TypedEventHandler<WebView, WebViewDOMContentLoadedEventArgs> DOMContentLoaded;

    [MethodImpl]
    public extern void GoForward();

    [MethodImpl]
    public extern void GoBack();

    [MethodImpl]
    public extern void Refresh();

    [MethodImpl]
    public extern void Stop();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction CapturePreviewToStreamAsync(IRandomAccessStream stream);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> InvokeScriptAsync(
      string scriptName,
      IIterable<string> arguments);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DataPackage> CaptureSelectedContentToDataPackageAsync();

    [MethodImpl]
    public extern void NavigateToLocalStreamUri(Uri source, IUriToStreamResolver streamResolver);

    [MethodImpl]
    public extern Uri BuildLocalStreamUri(string contentIdentifier, string relativePath);

    public extern Color DefaultBackgroundColor { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<WebView, WebViewNavigationCompletedEventArgs> NavigationCompleted;

    public extern event TypedEventHandler<WebView, WebViewNavigationStartingEventArgs> FrameNavigationStarting;

    public extern event TypedEventHandler<WebView, WebViewContentLoadingEventArgs> FrameContentLoading;

    public extern event TypedEventHandler<WebView, WebViewDOMContentLoadedEventArgs> FrameDOMContentLoaded;

    public extern event TypedEventHandler<WebView, WebViewNavigationCompletedEventArgs> FrameNavigationCompleted;

    public extern event TypedEventHandler<WebView, WebViewLongRunningScriptDetectedEventArgs> LongRunningScriptDetected;

    public extern event TypedEventHandler<WebView, object> UnsafeContentWarningDisplaying;

    public extern event TypedEventHandler<WebView, WebViewUnviewableContentIdentifiedEventArgs> UnviewableContentIdentified;

    [MethodImpl]
    public extern void NavigateWithHttpRequestMessage(HttpRequestMessage requestMessage);

    [MethodImpl]
    public extern bool Focus(FocusState value);

    public extern bool ContainsFullScreenElement { [MethodImpl] get; }

    public extern event TypedEventHandler<WebView, object> ContainsFullScreenElementChanged;

    public extern WebViewExecutionMode ExecutionMode { [MethodImpl] get; }

    public extern IVector<WebViewDeferredPermissionRequest> DeferredPermissionRequests { [MethodImpl] get; }

    public extern WebViewSettings Settings { [MethodImpl] get; }

    public extern event TypedEventHandler<WebView, WebViewUnsupportedUriSchemeIdentifiedEventArgs> UnsupportedUriSchemeIdentified;

    public extern event TypedEventHandler<WebView, WebViewNewWindowRequestedEventArgs> NewWindowRequested;

    public extern event TypedEventHandler<WebView, WebViewPermissionRequestedEventArgs> PermissionRequested;

    [MethodImpl]
    public extern void AddWebAllowedObject(string name, object pObject);

    [MethodImpl]
    public extern WebViewDeferredPermissionRequest DeferredPermissionRequestById(
      uint id);

    public extern DependencyObject XYFocusLeft { [MethodImpl] get; [MethodImpl] set; }

    public extern DependencyObject XYFocusRight { [MethodImpl] get; [MethodImpl] set; }

    public extern DependencyObject XYFocusUp { [MethodImpl] get; [MethodImpl] set; }

    public extern DependencyObject XYFocusDown { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty XYFocusLeftProperty { [MethodImpl] get; }

    public static extern DependencyProperty XYFocusRightProperty { [MethodImpl] get; }

    public static extern DependencyProperty XYFocusUpProperty { [MethodImpl] get; }

    public static extern DependencyProperty XYFocusDownProperty { [MethodImpl] get; }

    public static extern WebViewExecutionMode DefaultExecutionMode { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction ClearTemporaryWebDataAsync();

    public static extern DependencyProperty ContainsFullScreenElementProperty { [MethodImpl] get; }

    public static extern DependencyProperty CanGoBackProperty { [MethodImpl] get; }

    public static extern DependencyProperty CanGoForwardProperty { [MethodImpl] get; }

    public static extern DependencyProperty DocumentTitleProperty { [MethodImpl] get; }

    public static extern DependencyProperty DefaultBackgroundColorProperty { [MethodImpl] get; }

    public static extern IVector<Uri> AnyScriptNotifyUri { [Deprecated("AnyScriptNotifyUri is unavailable for releases beginning with Windows 8.1. Instead, list URIs under ApplicationContentUriRules in the package manifest. For more info, see the AnyScriptNotifyUri documentation.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public static extern DependencyProperty SourceProperty { [MethodImpl] get; }

    public static extern DependencyProperty AllowedScriptNotifyUrisProperty { [Deprecated("AllowedScriptNotifyUris is unavailable for releases beginning with Windows 8.1. Instead, list URIs under ApplicationContentUriRules in the package manifest. For more info, see the AllowedScriptNotifyUris documentation.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public static extern DependencyProperty DataTransferPackageProperty { [Deprecated("Use CaptureSelectedContentToDataPackageAsync instead of DataTransferPackage. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
