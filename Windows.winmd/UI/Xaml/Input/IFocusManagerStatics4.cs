// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IFocusManagerStatics4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [Guid(690450076, 7276, 16714, 186, 28, 150, 239, 213, 150, 43, 205)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (FocusManager))]
  internal interface IFocusManagerStatics4
  {
    [Overload("TryMoveFocusWithOptions")]
    bool TryMoveFocus(
      FocusNavigationDirection focusNavigationDirection,
      FindNextElementOptions focusNavigationOptions);

    [Overload("FindNextElement")]
    DependencyObject FindNextElement(
      FocusNavigationDirection focusNavigationDirection);

    DependencyObject FindFirstFocusableElement(DependencyObject searchScope);

    DependencyObject FindLastFocusableElement(DependencyObject searchScope);

    [Overload("FindNextElementWithOptions")]
    DependencyObject FindNextElement(
      FocusNavigationDirection focusNavigationDirection,
      FindNextElementOptions focusNavigationOptions);
  }
}
