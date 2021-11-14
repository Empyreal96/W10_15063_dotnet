// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICanvasStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(1087265862, 10594, 17519, 170, 251, 76, 220, 72, 105, 57, 201)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Canvas))]
  internal interface ICanvasStatics
  {
    DependencyProperty LeftProperty { [IndependentlyAnimatable] get; }

    double GetLeft(UIElement element);

    void SetLeft(UIElement element, double length);

    DependencyProperty TopProperty { [IndependentlyAnimatable] get; }

    double GetTop(UIElement element);

    void SetTop(UIElement element, double length);

    DependencyProperty ZIndexProperty { get; }

    int GetZIndex(UIElement element);

    void SetZIndex(UIElement element, int value);
  }
}
