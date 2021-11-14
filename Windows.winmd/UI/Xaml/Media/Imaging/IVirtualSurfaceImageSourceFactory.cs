// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.IVirtualSurfaceImageSourceFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  [ExclusiveTo(typeof (VirtualSurfaceImageSource))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(984752426, 49068, 4576, 138, 146, 105, 228, 71, 36, 1, 155)]
  internal interface IVirtualSurfaceImageSourceFactory
  {
    VirtualSurfaceImageSource CreateInstanceWithDimensions(
      int pixelWidth,
      int pixelHeight);

    VirtualSurfaceImageSource CreateInstanceWithDimensionsAndOpacity(
      int pixelWidth,
      int pixelHeight,
      bool isOpaque);
  }
}
