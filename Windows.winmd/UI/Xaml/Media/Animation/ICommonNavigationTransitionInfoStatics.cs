// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ICommonNavigationTransitionInfoStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [ExclusiveTo(typeof (CommonNavigationTransitionInfo))]
  [Guid(507444787, 20670, 17475, 136, 60, 229, 98, 114, 1, 194, 229)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICommonNavigationTransitionInfoStatics
  {
    DependencyProperty IsStaggeringEnabledProperty { get; }

    DependencyProperty IsStaggerElementProperty { get; }

    bool GetIsStaggerElement(UIElement element);

    void SetIsStaggerElement(UIElement element, bool value);
  }
}
