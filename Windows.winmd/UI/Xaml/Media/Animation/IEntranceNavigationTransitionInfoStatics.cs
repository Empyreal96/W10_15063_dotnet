// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IEntranceNavigationTransitionInfoStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (EntranceNavigationTransitionInfo))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(4182295162, 16585, 18079, 143, 51, 191, 69, 200, 129, 31, 33)]
  internal interface IEntranceNavigationTransitionInfoStatics
  {
    DependencyProperty IsTargetElementProperty { get; }

    bool GetIsTargetElement(UIElement element);

    void SetIsTargetElement(UIElement element, bool value);
  }
}
