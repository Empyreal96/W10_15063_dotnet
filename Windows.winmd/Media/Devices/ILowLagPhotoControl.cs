// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.ILowLagPhotoControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (LowLagPhotoControl))]
  [Guid(1834765776, 64223, 16733, 174, 230, 59, 170, 82, 147, 0, 201)]
  internal interface ILowLagPhotoControl
  {
    MediaRatio GetHighestConcurrentFrameRate(IMediaEncodingProperties captureProperties);

    MediaRatio GetCurrentFrameRate();

    bool ThumbnailEnabled { get; set; }

    MediaThumbnailFormat ThumbnailFormat { get; set; }

    uint DesiredThumbnailSize { get; set; }

    uint HardwareAcceleratedThumbnailSupported { get; }
  }
}
