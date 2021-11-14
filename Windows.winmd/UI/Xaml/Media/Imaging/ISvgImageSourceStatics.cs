// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.ISvgImageSourceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  [WebHostHidden]
  [ExclusiveTo(typeof (SvgImageSource))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2623944910, 48849, 19115, 172, 187, 211, 226, 24, 93, 49, 90)]
  internal interface ISvgImageSourceStatics
  {
    DependencyProperty UriSourceProperty { get; }

    DependencyProperty RasterizePixelWidthProperty { get; }

    DependencyProperty RasterizePixelHeightProperty { get; }
  }
}
