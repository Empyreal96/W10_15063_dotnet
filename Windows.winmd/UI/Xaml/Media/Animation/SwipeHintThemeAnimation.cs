// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.SwipeHintThemeAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ISwipeHintThemeAnimationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SwipeHintThemeAnimation : Timeline, ISwipeHintThemeAnimation
  {
    [MethodImpl]
    public extern SwipeHintThemeAnimation();

    public extern string TargetName { [MethodImpl] get; [MethodImpl] set; }

    public extern double ToHorizontalOffset { [MethodImpl] get; [MethodImpl] set; }

    public extern double ToVerticalOffset { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty TargetNameProperty { [MethodImpl] get; }

    public static extern DependencyProperty ToHorizontalOffsetProperty { [MethodImpl] get; }

    public static extern DependencyProperty ToVerticalOffsetProperty { [MethodImpl] get; }
  }
}
