// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.ILowLagPhotoSequenceControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Devices
{
  [ExclusiveTo(typeof (LowLagPhotoSequenceControl))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1037013149, 27926, 16540, 186, 254, 185, 165, 148, 198, 253, 230)]
  internal interface ILowLagPhotoSequenceControl
  {
    bool Supported { get; }

    uint MaxPastPhotos { get; }

    float MaxPhotosPerSecond { get; }

    uint PastPhotoLimit { get; set; }

    float PhotosPerSecondLimit { get; set; }

    MediaRatio GetHighestConcurrentFrameRate(IMediaEncodingProperties captureProperties);

    MediaRatio GetCurrentFrameRate();

    bool ThumbnailEnabled { get; set; }

    MediaThumbnailFormat ThumbnailFormat { get; set; }

    uint DesiredThumbnailSize { get; set; }

    uint HardwareAcceleratedThumbnailSupported { get; }
  }
}
