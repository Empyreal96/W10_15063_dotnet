// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IFrameworkElementStatics4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (FrameworkElement))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [Guid(2621550933, 50648, 18019, 191, 242, 216, 213, 79, 181, 219, 179)]
  internal interface IFrameworkElementStatics4
  {
    DependencyProperty AllowFocusOnInteractionProperty { get; }

    DependencyProperty FocusVisualMarginProperty { get; }

    DependencyProperty FocusVisualSecondaryThicknessProperty { get; }

    DependencyProperty FocusVisualPrimaryThicknessProperty { get; }

    DependencyProperty FocusVisualSecondaryBrushProperty { get; }

    DependencyProperty FocusVisualPrimaryBrushProperty { get; }

    DependencyProperty AllowFocusWhenDisabledProperty { get; }
  }
}
