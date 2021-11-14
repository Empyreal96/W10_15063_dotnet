// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IContinuumNavigationTransitionInfoStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (ContinuumNavigationTransitionInfo))]
  [Guid(1042668883, 45455, 19441, 179, 188, 146, 245, 22, 242, 153, 3)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContinuumNavigationTransitionInfoStatics
  {
    DependencyProperty ExitElementProperty { get; }

    DependencyProperty IsEntranceElementProperty { get; }

    bool GetIsEntranceElement(UIElement element);

    void SetIsEntranceElement(UIElement element, bool value);

    DependencyProperty IsExitElementProperty { get; }

    bool GetIsExitElement(UIElement element);

    void SetIsExitElement(UIElement element, bool value);

    DependencyProperty ExitElementContainerProperty { get; }

    bool GetExitElementContainer(ListViewBase element);

    void SetExitElementContainer(ListViewBase element, bool value);
  }
}
