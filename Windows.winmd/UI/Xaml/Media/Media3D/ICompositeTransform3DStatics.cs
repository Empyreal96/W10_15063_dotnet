// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Media3D.ICompositeTransform3DStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Media.Media3D
{
  [WebHostHidden]
  [Guid(3720301927, 10789, 18675, 152, 8, 197, 30, 195, 213, 91, 236)]
  [ExclusiveTo(typeof (CompositeTransform3D))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICompositeTransform3DStatics
  {
    DependencyProperty CenterXProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty CenterYProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty CenterZProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty RotationXProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty RotationYProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty RotationZProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty ScaleXProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty ScaleYProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty ScaleZProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty TranslateXProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty TranslateYProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty TranslateZProperty { [ConditionallyIndependentlyAnimatable] get; }
  }
}
