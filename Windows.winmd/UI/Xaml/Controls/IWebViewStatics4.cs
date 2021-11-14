// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewStatics4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (WebView))]
  [Guid(1152489392, 46918, 16627, 153, 54, 78, 187, 255, 107, 71, 184)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWebViewStatics4
  {
    WebViewExecutionMode DefaultExecutionMode { get; }

    [RemoteAsync]
    IAsyncAction ClearTemporaryWebDataAsync();
  }
}
