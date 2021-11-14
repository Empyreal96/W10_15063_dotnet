// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Media3D.CompositeTransform3D
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Media.Media3D
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ICompositeTransform3DStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public sealed class CompositeTransform3D : Transform3D, ICompositeTransform3D
  {
    [MethodImpl]
    public extern CompositeTransform3D();

    public extern double CenterX { [MethodImpl] get; [MethodImpl] set; }

    public extern double CenterY { [MethodImpl] get; [MethodImpl] set; }

    public extern double CenterZ { [MethodImpl] get; [MethodImpl] set; }

    public extern double RotationX { [MethodImpl] get; [MethodImpl] set; }

    public extern double RotationY { [MethodImpl] get; [MethodImpl] set; }

    public extern double RotationZ { [MethodImpl] get; [MethodImpl] set; }

    public extern double ScaleX { [MethodImpl] get; [MethodImpl] set; }

    public extern double ScaleY { [MethodImpl] get; [MethodImpl] set; }

    public extern double ScaleZ { [MethodImpl] get; [MethodImpl] set; }

    public extern double TranslateX { [MethodImpl] get; [MethodImpl] set; }

    public extern double TranslateY { [MethodImpl] get; [MethodImpl] set; }

    public extern double TranslateZ { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty CenterXProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty CenterYProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty CenterZProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty RotationXProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty RotationYProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty RotationZProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty ScaleXProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty ScaleYProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty ScaleZProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty TranslateXProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty TranslateYProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty TranslateZProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }
  }
}
