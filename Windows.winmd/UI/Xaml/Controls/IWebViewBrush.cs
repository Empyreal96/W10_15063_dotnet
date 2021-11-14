// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewBrush
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (WebViewBrush))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1088974709, 3316, 19314, 164, 214, 207, 93, 21, 120, 1, 22)]
  [WebHostHidden]
  internal interface IWebViewBrush
  {
    string SourceName { get; set; }

    void Redraw();

    void SetSource(WebView source);
  }
}
