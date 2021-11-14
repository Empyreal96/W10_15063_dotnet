// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ContinuumNavigationTransitionInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IContinuumNavigationTransitionInfoStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class ContinuumNavigationTransitionInfo : 
    NavigationTransitionInfo,
    IContinuumNavigationTransitionInfo
  {
    [MethodImpl]
    public extern ContinuumNavigationTransitionInfo();

    public extern UIElement ExitElement { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty ExitElementProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsEntranceElementProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool GetIsEntranceElement(UIElement element);

    [MethodImpl]
    public static extern void SetIsEntranceElement(UIElement element, bool value);

    public static extern DependencyProperty IsExitElementProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool GetIsExitElement(UIElement element);

    [MethodImpl]
    public static extern void SetIsExitElement(UIElement element, bool value);

    public static extern DependencyProperty ExitElementContainerProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool GetExitElementContainer(ListViewBase element);

    [MethodImpl]
    public static extern void SetExitElementContainer(ListViewBase element, bool value);
  }
}
