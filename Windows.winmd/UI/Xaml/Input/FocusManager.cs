// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.FocusManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IFocusManagerStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IFocusManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IFocusManagerStatics4), 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IFocusManagerStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class FocusManager : IFocusManager
  {
    [Overload("TryMoveFocusWithOptions")]
    [MethodImpl]
    public static extern bool TryMoveFocus(
      FocusNavigationDirection focusNavigationDirection,
      FindNextElementOptions focusNavigationOptions);

    [Overload("FindNextElement")]
    [MethodImpl]
    public static extern DependencyObject FindNextElement(
      FocusNavigationDirection focusNavigationDirection);

    [MethodImpl]
    public static extern DependencyObject FindFirstFocusableElement(
      DependencyObject searchScope);

    [MethodImpl]
    public static extern DependencyObject FindLastFocusableElement(
      DependencyObject searchScope);

    [Overload("FindNextElementWithOptions")]
    [MethodImpl]
    public static extern DependencyObject FindNextElement(
      FocusNavigationDirection focusNavigationDirection,
      FindNextElementOptions focusNavigationOptions);

    [Overload("FindNextFocusableElement")]
    [MethodImpl]
    public static extern UIElement FindNextFocusableElement(
      FocusNavigationDirection focusNavigationDirection);

    [Overload("FindNextFocusableElementWithHint")]
    [MethodImpl]
    public static extern UIElement FindNextFocusableElement(
      FocusNavigationDirection focusNavigationDirection,
      Rect hintRect);

    [Overload("TryMoveFocus")]
    [MethodImpl]
    public static extern bool TryMoveFocus(FocusNavigationDirection focusNavigationDirection);

    [MethodImpl]
    public static extern object GetFocusedElement();
  }
}
