// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.INavigationThemeTransition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2285077644, 20151, 16882, 135, 153, 158, 239, 10, 33, 59, 115)]
  [ExclusiveTo(typeof (NavigationThemeTransition))]
  internal interface INavigationThemeTransition
  {
    NavigationTransitionInfo DefaultNavigationTransitionInfo { get; set; }
  }
}
