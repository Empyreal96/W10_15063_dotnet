// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.WebViewBrush
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [Static(typeof (IWebViewBrushStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WebViewBrush : TileBrush, IWebViewBrush
  {
    [MethodImpl]
    public extern WebViewBrush();

    public extern string SourceName { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void Redraw();

    [MethodImpl]
    public extern void SetSource(WebView source);

    public static extern DependencyProperty SourceNameProperty { [MethodImpl] get; }
  }
}
