// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.SkewTransform
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Media
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ISkewTransformStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SkewTransform : Transform, ISkewTransform
  {
    [MethodImpl]
    public extern SkewTransform();

    public extern double CenterX { [MethodImpl] get; [MethodImpl] set; }

    public extern double CenterY { [MethodImpl] get; [MethodImpl] set; }

    public extern double AngleX { [MethodImpl] get; [MethodImpl] set; }

    public extern double AngleY { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty CenterXProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty CenterYProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty AngleXProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty AngleYProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }
  }
}
