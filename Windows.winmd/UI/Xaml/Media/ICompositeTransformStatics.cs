// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ICompositeTransformStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(790170632, 33382, 18799, 150, 83, 161, 139, 212, 248, 54, 170)]
  [ExclusiveTo(typeof (CompositeTransform))]
  internal interface ICompositeTransformStatics
  {
    DependencyProperty CenterXProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty CenterYProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty ScaleXProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty ScaleYProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty SkewXProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty SkewYProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty RotationProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty TranslateXProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty TranslateYProperty { [ConditionallyIndependentlyAnimatable] get; }
  }
}
