// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IUIElement5
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml
{
  [Guid(2397936578, 42380, 17491, 175, 15, 169, 46, 224, 109, 3, 23)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (UIElement))]
  [WebHostHidden]
  internal interface IUIElement5
  {
    IVector<XamlLight> Lights { get; }

    KeyTipPlacementMode KeyTipPlacementMode { get; set; }

    double KeyTipHorizontalOffset { get; set; }

    double KeyTipVerticalOffset { get; set; }

    XYFocusKeyboardNavigationMode XYFocusKeyboardNavigation { get; set; }

    XYFocusNavigationStrategy XYFocusUpNavigationStrategy { get; set; }

    XYFocusNavigationStrategy XYFocusDownNavigationStrategy { get; set; }

    XYFocusNavigationStrategy XYFocusLeftNavigationStrategy { get; set; }

    XYFocusNavigationStrategy XYFocusRightNavigationStrategy { get; set; }

    ElementHighContrastAdjustment HighContrastAdjustment { get; set; }

    KeyboardNavigationMode TabFocusNavigation { get; set; }

    event TypedEventHandler<UIElement, GettingFocusEventArgs> GettingFocus;

    event TypedEventHandler<UIElement, LosingFocusEventArgs> LosingFocus;

    event TypedEventHandler<UIElement, NoFocusCandidateFoundEventArgs> NoFocusCandidateFound;

    [Overload("StartBringIntoView")]
    void StartBringIntoView();

    [Overload("StartBringIntoViewWithOptions")]
    void StartBringIntoView(BringIntoViewOptions options);
  }
}
