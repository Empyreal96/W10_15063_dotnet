// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.ISurfaceImageSourceFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  [Guid(984752426, 61285, 19039, 191, 172, 115, 153, 62, 140, 18, 201)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (SurfaceImageSource))]
  internal interface ISurfaceImageSourceFactory
  {
    SurfaceImageSource CreateInstanceWithDimensions(
      int pixelWidth,
      int pixelHeight,
      object outer,
      out object inner);

    SurfaceImageSource CreateInstanceWithDimensionsAndOpacity(
      int pixelWidth,
      int pixelHeight,
      bool isOpaque,
      object outer,
      out object inner);
  }
}
