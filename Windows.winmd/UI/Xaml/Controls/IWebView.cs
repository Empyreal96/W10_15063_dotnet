// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebView
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Navigation;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (WebView))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1482869830, 8061, 18331, 146, 166, 222, 120, 88, 254, 141, 84)]
  internal interface IWebView
  {
    Uri Source { get; set; }

    IVector<Uri> AllowedScriptNotifyUris { [Deprecated("AllowedScriptNotifyUris is unavailable for releases beginning with Windows 8.1. Instead, list URIs under ApplicationContentUriRules in the package manifest. For more info, see the AllowedScriptNotifyUris documentation.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("AllowedScriptNotifyUris is unavailable for releases beginning with Windows 8.1. Instead, list URIs under ApplicationContentUriRules in the package manifest. For more info, see the AllowedScriptNotifyUris documentation.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; }

    DataPackage DataTransferPackage { [Deprecated("Use CaptureSelectedContentToDataPackageAsync instead of DataTransferPackage. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    event LoadCompletedEventHandler LoadCompleted;

    event NotifyEventHandler ScriptNotify;

    event WebViewNavigationFailedEventHandler NavigationFailed;

    [Deprecated("Use InvokeScriptAsync instead of InvokeScript. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    string InvokeScript(string scriptName, string[] arguments);

    void Navigate(Uri source);

    void NavigateToString(string text);
  }
}
