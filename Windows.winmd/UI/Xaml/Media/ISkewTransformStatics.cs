// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ISkewTransformStatics
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
  [ExclusiveTo(typeof (SkewTransform))]
  [Guid(3973127539, 22036, 19249, 182, 175, 190, 174, 16, 16, 86, 36)]
  internal interface ISkewTransformStatics
  {
    DependencyProperty CenterXProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty CenterYProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty AngleXProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty AngleYProperty { [ConditionallyIndependentlyAnimatable] get; }
  }
}
