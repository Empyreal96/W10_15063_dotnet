// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewFactory4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (WebView))]
  [Guid(2196614232, 61034, 19611, 163, 160, 147, 71, 167, 208, 239, 76)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWebViewFactory4
  {
    WebView CreateInstanceWithExecutionMode(WebViewExecutionMode executionMode);
  }
}
