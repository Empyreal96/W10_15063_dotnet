// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IVisualTreeHelperStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (VisualTreeHelper))]
  [WebHostHidden]
  [Guid(3881261252, 53853, 19229, 151, 31, 89, 111, 23, 241, 43, 170)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVisualTreeHelperStatics
  {
    [DefaultOverload]
    [Overload("FindElementsInHostCoordinatesPoint")]
    IIterable<UIElement> FindElementsInHostCoordinates(
      Point intersectingPoint,
      UIElement subtree);

    [Overload("FindElementsInHostCoordinatesRect")]
    IIterable<UIElement> FindElementsInHostCoordinates(
      Rect intersectingRect,
      UIElement subtree);

    [DefaultOverload]
    [Overload("FindAllElementsInHostCoordinatesPoint")]
    IIterable<UIElement> FindElementsInHostCoordinates(
      Point intersectingPoint,
      UIElement subtree,
      bool includeAllElements);

    [Overload("FindAllElementsInHostCoordinatesRect")]
    IIterable<UIElement> FindElementsInHostCoordinates(
      Rect intersectingRect,
      UIElement subtree,
      bool includeAllElements);

    DependencyObject GetChild(DependencyObject reference, int childIndex);

    int GetChildrenCount(DependencyObject reference);

    DependencyObject GetParent(DependencyObject reference);

    void DisconnectChildrenRecursive(UIElement element);
  }
}
