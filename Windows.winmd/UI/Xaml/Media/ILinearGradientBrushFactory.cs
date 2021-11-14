// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ILinearGradientBrushFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (LinearGradientBrush))]
  [WebHostHidden]
  [Guid(182486556, 7802, 20461, 152, 87, 234, 140, 170, 121, 132, 144)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ILinearGradientBrushFactory
  {
    LinearGradientBrush CreateInstanceWithGradientStopCollectionAndAngle(
      GradientStopCollection gradientStopCollection,
      double angle);
  }
}
