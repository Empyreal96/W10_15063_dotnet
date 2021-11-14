// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IFocusManagerStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [WebHostHidden]
  [Guid(1619025599, 45385, 16765, 131, 241, 186, 235, 86, 14, 42, 71)]
  [ExclusiveTo(typeof (FocusManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFocusManagerStatics3
  {
    [Overload("FindNextFocusableElement")]
    UIElement FindNextFocusableElement(FocusNavigationDirection focusNavigationDirection);

    [Overload("FindNextFocusableElementWithHint")]
    UIElement FindNextFocusableElement(
      FocusNavigationDirection focusNavigationDirection,
      Rect hintRect);
  }
}
