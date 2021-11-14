// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.DoubleAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Static(typeof (IDoubleAnimationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DoubleAnimation : Timeline, IDoubleAnimation
  {
    [MethodImpl]
    public extern DoubleAnimation();

    public extern IReference<double> From { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<double> To { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<double> By { [MethodImpl] get; [MethodImpl] set; }

    public extern EasingFunctionBase EasingFunction { [MethodImpl] get; [MethodImpl] set; }

    public extern bool EnableDependentAnimation { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty FromProperty { [MethodImpl] get; }

    public static extern DependencyProperty ToProperty { [MethodImpl] get; }

    public static extern DependencyProperty ByProperty { [MethodImpl] get; }

    public static extern DependencyProperty EasingFunctionProperty { [MethodImpl] get; }

    public static extern DependencyProperty EnableDependentAnimationProperty { [MethodImpl] get; }
  }
}
