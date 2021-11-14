// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IScaleTransformStatics
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
  [ExclusiveTo(typeof (ScaleTransform))]
  [Guid(2643736308, 16551, 18141, 151, 90, 7, 211, 55, 205, 133, 46)]
  internal interface IScaleTransformStatics
  {
    DependencyProperty CenterXProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty CenterYProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty ScaleXProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty ScaleYProperty { [ConditionallyIndependentlyAnimatable] get; }
  }
}
