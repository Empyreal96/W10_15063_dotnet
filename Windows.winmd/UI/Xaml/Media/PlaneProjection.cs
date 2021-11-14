// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.PlaneProjection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Media.Media3D;

namespace Windows.UI.Xaml.Media
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IPlaneProjectionStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public sealed class PlaneProjection : Projection, IPlaneProjection
  {
    [MethodImpl]
    public extern PlaneProjection();

    public extern double LocalOffsetX { [MethodImpl] get; [MethodImpl] set; }

    public extern double LocalOffsetY { [MethodImpl] get; [MethodImpl] set; }

    public extern double LocalOffsetZ { [MethodImpl] get; [MethodImpl] set; }

    public extern double RotationX { [MethodImpl] get; [MethodImpl] set; }

    public extern double RotationY { [MethodImpl] get; [MethodImpl] set; }

    public extern double RotationZ { [MethodImpl] get; [MethodImpl] set; }

    public extern double CenterOfRotationX { [MethodImpl] get; [MethodImpl] set; }

    public extern double CenterOfRotationY { [MethodImpl] get; [MethodImpl] set; }

    public extern double CenterOfRotationZ { [MethodImpl] get; [MethodImpl] set; }

    public extern double GlobalOffsetX { [MethodImpl] get; [MethodImpl] set; }

    public extern double GlobalOffsetY { [MethodImpl] get; [MethodImpl] set; }

    public extern double GlobalOffsetZ { [MethodImpl] get; [MethodImpl] set; }

    public extern Matrix3D ProjectionMatrix { [MethodImpl] get; }

    public static extern DependencyProperty LocalOffsetXProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty LocalOffsetYProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty LocalOffsetZProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty RotationXProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty RotationYProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty RotationZProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty CenterOfRotationXProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty CenterOfRotationYProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty CenterOfRotationZProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty GlobalOffsetXProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty GlobalOffsetYProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty GlobalOffsetZProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty ProjectionMatrixProperty { [MethodImpl] get; }
  }
}
