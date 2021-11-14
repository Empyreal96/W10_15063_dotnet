// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ColorAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [Static(typeof (IColorAnimationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ColorAnimation : Timeline, IColorAnimation
  {
    [MethodImpl]
    public extern ColorAnimation();

    public extern IReference<Color> From { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<Color> To { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<Color> By { [MethodImpl] get; [MethodImpl] set; }

    public extern EasingFunctionBase EasingFunction { [MethodImpl] get; [MethodImpl] set; }

    public extern bool EnableDependentAnimation { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty FromProperty { [MethodImpl] get; }

    public static extern DependencyProperty ToProperty { [MethodImpl] get; }

    public static extern DependencyProperty ByProperty { [MethodImpl] get; }

    public static extern DependencyProperty EasingFunctionProperty { [MethodImpl] get; }

    public static extern DependencyProperty EnableDependentAnimationProperty { [MethodImpl] get; }
  }
}
