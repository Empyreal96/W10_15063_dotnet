// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.IBitmapDecoder
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  [Guid(2901353146, 7540, 19601, 157, 252, 150, 32, 116, 82, 51, 230)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BitmapDecoder))]
  internal interface IBitmapDecoder
  {
    BitmapPropertiesView BitmapContainerProperties { get; }

    BitmapCodecInformation DecoderInformation { get; }

    uint FrameCount { get; }

    [RemoteAsync]
    IAsyncOperation<ImageStream> GetPreviewAsync();

    [RemoteAsync]
    IAsyncOperation<BitmapFrame> GetFrameAsync(uint frameIndex);
  }
}
