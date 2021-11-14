// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.CommonNavigationTransitionInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ICommonNavigationTransitionInfoStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CommonNavigationTransitionInfo : 
    NavigationTransitionInfo,
    ICommonNavigationTransitionInfo
  {
    [MethodImpl]
    public extern CommonNavigationTransitionInfo();

    public extern bool IsStaggeringEnabled { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty IsStaggeringEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsStaggerElementProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool GetIsStaggerElement(UIElement element);

    [MethodImpl]
    public static extern void SetIsStaggerElement(UIElement element, bool value);
  }
}
