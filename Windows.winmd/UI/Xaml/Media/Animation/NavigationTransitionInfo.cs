// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.NavigationTransitionInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Composable(typeof (INavigationTransitionInfoFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class NavigationTransitionInfo : 
    DependencyObject,
    INavigationTransitionInfo,
    INavigationTransitionInfoOverrides
  {
    [MethodImpl]
    protected extern NavigationTransitionInfo();

    [MethodImpl]
    extern string INavigationTransitionInfoOverrides.GetNavigationStateCore();

    [MethodImpl]
    extern void INavigationTransitionInfoOverrides.SetNavigationStateCore(
      string navigationState);
  }
}
