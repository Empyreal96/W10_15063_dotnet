// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.SwipeBackThemeAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ISwipeBackThemeAnimationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class SwipeBackThemeAnimation : Timeline, ISwipeBackThemeAnimation
  {
    [MethodImpl]
    public extern SwipeBackThemeAnimation();

    public extern string TargetName { [MethodImpl] get; [MethodImpl] set; }

    public extern double FromHorizontalOffset { [MethodImpl] get; [MethodImpl] set; }

    public extern double FromVerticalOffset { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty TargetNameProperty { [MethodImpl] get; }

    public static extern DependencyProperty FromHorizontalOffsetProperty { [MethodImpl] get; }

    public static extern DependencyProperty FromVerticalOffsetProperty { [MethodImpl] get; }
  }
}
