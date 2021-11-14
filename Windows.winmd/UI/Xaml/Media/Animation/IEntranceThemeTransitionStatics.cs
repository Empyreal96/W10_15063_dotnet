// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IEntranceThemeTransitionStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(936117623, 65432, 19181, 184, 110, 94, 194, 55, 2, 248, 119)]
  [ExclusiveTo(typeof (EntranceThemeTransition))]
  internal interface IEntranceThemeTransitionStatics
  {
    DependencyProperty FromHorizontalOffsetProperty { get; }

    DependencyProperty FromVerticalOffsetProperty { get; }

    DependencyProperty IsStaggeringEnabledProperty { get; }
  }
}
