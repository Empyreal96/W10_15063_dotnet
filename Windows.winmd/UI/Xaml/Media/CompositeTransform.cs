// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.CompositeTransform
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Media
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ICompositeTransformStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class CompositeTransform : Transform, ICompositeTransform
  {
    [MethodImpl]
    public extern CompositeTransform();

    public extern double CenterX { [MethodImpl] get; [MethodImpl] set; }

    public extern double CenterY { [MethodImpl] get; [MethodImpl] set; }

    public extern double ScaleX { [MethodImpl] get; [MethodImpl] set; }

    public extern double ScaleY { [MethodImpl] get; [MethodImpl] set; }

    public extern double SkewX { [MethodImpl] get; [MethodImpl] set; }

    public extern double SkewY { [MethodImpl] get; [MethodImpl] set; }

    public extern double Rotation { [MethodImpl] get; [MethodImpl] set; }

    public extern double TranslateX { [MethodImpl] get; [MethodImpl] set; }

    public extern double TranslateY { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty CenterXProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty CenterYProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty ScaleXProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty ScaleYProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty SkewXProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty SkewYProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty RotationProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty TranslateXProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty TranslateYProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }
  }
}
