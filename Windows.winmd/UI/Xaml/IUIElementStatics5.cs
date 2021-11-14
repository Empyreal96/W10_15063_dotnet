// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IUIElementStatics5
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1505590673, 36771, 19557, 186, 27, 64, 223, 56, 85, 108, 187)]
  [ExclusiveTo(typeof (UIElement))]
  [WebHostHidden]
  internal interface IUIElementStatics5
  {
    DependencyProperty LightsProperty { get; }

    DependencyProperty KeyTipPlacementModeProperty { get; }

    DependencyProperty KeyTipHorizontalOffsetProperty { get; }

    DependencyProperty KeyTipVerticalOffsetProperty { get; }

    DependencyProperty XYFocusKeyboardNavigationProperty { get; }

    DependencyProperty XYFocusUpNavigationStrategyProperty { get; }

    DependencyProperty XYFocusDownNavigationStrategyProperty { get; }

    DependencyProperty XYFocusLeftNavigationStrategyProperty { get; }

    DependencyProperty XYFocusRightNavigationStrategyProperty { get; }

    DependencyProperty HighContrastAdjustmentProperty { get; }

    DependencyProperty TabFocusNavigationProperty { get; }
  }
}
