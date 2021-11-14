// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IRotateTransformStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RotateTransform))]
  [WebHostHidden]
  [Guid(2704403338, 20899, 16822, 185, 211, 161, 14, 66, 144, 84, 171)]
  internal interface IRotateTransformStatics
  {
    DependencyProperty CenterXProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty CenterYProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty AngleProperty { [ConditionallyIndependentlyAnimatable] get; }
  }
}
