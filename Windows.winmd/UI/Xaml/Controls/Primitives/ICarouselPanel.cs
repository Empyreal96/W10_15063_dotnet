// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ICarouselPanel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CarouselPanel))]
  [Guid(3735779506, 14139, 16721, 135, 133, 229, 68, 208, 217, 54, 43)]
  [WebHostHidden]
  internal interface ICarouselPanel
  {
    bool CanVerticallyScroll { get; set; }

    bool CanHorizontallyScroll { get; set; }

    double ExtentWidth { get; }

    double ExtentHeight { get; }

    double ViewportWidth { get; }

    double ViewportHeight { get; }

    double HorizontalOffset { get; }

    double VerticalOffset { get; }

    object ScrollOwner { get; set; }

    void LineUp();

    void LineDown();

    void LineLeft();

    void LineRight();

    void PageUp();

    void PageDown();

    void PageLeft();

    void PageRight();

    void MouseWheelUp();

    void MouseWheelDown();

    void MouseWheelLeft();

    void MouseWheelRight();

    void SetHorizontalOffset(double offset);

    void SetVerticalOffset(double offset);

    Rect MakeVisible(UIElement visual, Rect rectangle);
  }
}
