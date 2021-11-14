// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IPlaneProjectionStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PlaneProjection))]
  [Guid(2912001127, 15324, 18517, 137, 105, 209, 249, 163, 173, 194, 125)]
  [WebHostHidden]
  internal interface IPlaneProjectionStatics
  {
    DependencyProperty LocalOffsetXProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty LocalOffsetYProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty LocalOffsetZProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty RotationXProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty RotationYProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty RotationZProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty CenterOfRotationXProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty CenterOfRotationYProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty CenterOfRotationZProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty GlobalOffsetXProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty GlobalOffsetYProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty GlobalOffsetZProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty ProjectionMatrixProperty { get; }
  }
}
