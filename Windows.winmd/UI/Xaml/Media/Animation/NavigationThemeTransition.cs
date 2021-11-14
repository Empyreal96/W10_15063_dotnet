// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.NavigationThemeTransition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Media.Animation
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContentProperty(Name = "DefaultNavigationTransitionInfo")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (INavigationThemeTransitionStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class NavigationThemeTransition : Transition, INavigationThemeTransition
  {
    [MethodImpl]
    public extern NavigationThemeTransition();

    public extern NavigationTransitionInfo DefaultNavigationTransitionInfo { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty DefaultNavigationTransitionInfoProperty { [MethodImpl] get; }
  }
}
