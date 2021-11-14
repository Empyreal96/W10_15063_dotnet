// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IScrollBar
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4118472394, 53670, 19344, 164, 233, 84, 223, 27, 168, 210, 236)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ScrollBar))]
  internal interface IScrollBar
  {
    Orientation Orientation { get; set; }

    double ViewportSize { get; set; }

    ScrollingIndicatorMode IndicatorMode { get; set; }

    event ScrollEventHandler Scroll;
  }
}
