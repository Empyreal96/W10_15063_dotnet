// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IScrollViewer2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1693040144, 19921, 18765, 171, 247, 203, 211, 197, 119, 73, 29)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ScrollViewer))]
  internal interface IScrollViewer2
  {
    UIElement TopLeftHeader { get; set; }

    UIElement LeftHeader { get; set; }

    UIElement TopHeader { get; set; }

    event EventHandler<ScrollViewerViewChangingEventArgs> ViewChanging;

    [Overload("ChangeView")]
    bool ChangeView(
      IReference<double> horizontalOffset,
      IReference<double> verticalOffset,
      IReference<float> zoomFactor);

    [Overload("ChangeViewWithOptionalAnimation")]
    bool ChangeView(
      IReference<double> horizontalOffset,
      IReference<double> verticalOffset,
      IReference<float> zoomFactor,
      bool disableAnimation);
  }
}
