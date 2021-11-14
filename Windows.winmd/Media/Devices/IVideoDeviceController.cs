// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IVideoDeviceController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Capture;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VideoDeviceController))]
  [Guid(2572506485, 11822, 16568, 182, 199, 248, 45, 16, 1, 50, 16)]
  internal interface IVideoDeviceController : IMediaDeviceController
  {
    MediaDeviceControl Brightness { get; }

    MediaDeviceControl Contrast { get; }

    MediaDeviceControl Hue { get; }

    MediaDeviceControl WhiteBalance { get; }

    MediaDeviceControl BacklightCompensation { get; }

    MediaDeviceControl Pan { get; }

    MediaDeviceControl Tilt { get; }

    MediaDeviceControl Zoom { get; }

    MediaDeviceControl Roll { get; }

    MediaDeviceControl Exposure { get; }

    MediaDeviceControl Focus { get; }

    bool TrySetPowerlineFrequency(PowerlineFrequency value);

    bool TryGetPowerlineFrequency(out PowerlineFrequency value);
  }
}
