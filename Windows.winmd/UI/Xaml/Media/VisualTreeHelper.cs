// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.VisualTreeHelper
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IVisualTreeHelperStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IVisualTreeHelperStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VisualTreeHelper : IVisualTreeHelper
  {
    [MethodImpl]
    public static extern IVectorView<Popup> GetOpenPopups(Window window);

    [Overload("FindElementsInHostCoordinatesPoint")]
    [DefaultOverload]
    [MethodImpl]
    public static extern IIterable<UIElement> FindElementsInHostCoordinates(
      Point intersectingPoint,
      UIElement subtree);

    [Overload("FindElementsInHostCoordinatesRect")]
    [MethodImpl]
    public static extern IIterable<UIElement> FindElementsInHostCoordinates(
      Rect intersectingRect,
      UIElement subtree);

    [DefaultOverload]
    [Overload("FindAllElementsInHostCoordinatesPoint")]
    [MethodImpl]
    public static extern IIterable<UIElement> FindElementsInHostCoordinates(
      Point intersectingPoint,
      UIElement subtree,
      bool includeAllElements);

    [Overload("FindAllElementsInHostCoordinatesRect")]
    [MethodImpl]
    public static extern IIterable<UIElement> FindElementsInHostCoordinates(
      Rect intersectingRect,
      UIElement subtree,
      bool includeAllElements);

    [MethodImpl]
    public static extern DependencyObject GetChild(
      DependencyObject reference,
      int childIndex);

    [MethodImpl]
    public static extern int GetChildrenCount(DependencyObject reference);

    [MethodImpl]
    public static extern DependencyObject GetParent(DependencyObject reference);

    [MethodImpl]
    public static extern void DisconnectChildrenRecursive(UIElement element);
  }
}
