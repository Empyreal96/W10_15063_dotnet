// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.PointAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Static(typeof (IPointAnimationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public sealed class PointAnimation : Timeline, IPointAnimation
  {
    [MethodImpl]
    public extern PointAnimation();

    public extern IReference<Point> From { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<Point> To { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<Point> By { [MethodImpl] get; [MethodImpl] set; }

    public extern EasingFunctionBase EasingFunction { [MethodImpl] get; [MethodImpl] set; }

    public extern bool EnableDependentAnimation { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty FromProperty { [MethodImpl] get; }

    public static extern DependencyProperty ToProperty { [MethodImpl] get; }

    public static extern DependencyProperty ByProperty { [MethodImpl] get; }

    public static extern DependencyProperty EasingFunctionProperty { [MethodImpl] get; }

    public static extern DependencyProperty EnableDependentAnimationProperty { [MethodImpl] get; }
  }
}
