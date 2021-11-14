// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.EntranceNavigationTransitionInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Static(typeof (IEntranceNavigationTransitionInfoStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public sealed class EntranceNavigationTransitionInfo : 
    NavigationTransitionInfo,
    IEntranceNavigationTransitionInfo
  {
    [MethodImpl]
    public extern EntranceNavigationTransitionInfo();

    public static extern DependencyProperty IsTargetElementProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool GetIsTargetElement(UIElement element);

    [MethodImpl]
    public static extern void SetIsTargetElement(UIElement element, bool value);
  }
}
