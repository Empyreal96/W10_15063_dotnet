// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IVideoStabilizationEffect
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Capture;
using Windows.Media.Devices;
using Windows.Media.MediaProperties;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(134784592, 38552, 20055, 135, 123, 189, 124, 178, 238, 15, 138)]
  [ExclusiveTo(typeof (VideoStabilizationEffect))]
  internal interface IVideoStabilizationEffect : IMediaExtension
  {
    bool Enabled { set; get; }

    event TypedEventHandler<VideoStabilizationEffect, VideoStabilizationEffectEnabledChangedEventArgs> EnabledChanged;

    VideoStreamConfiguration GetRecommendedStreamConfiguration(
      VideoDeviceController controller,
      VideoEncodingProperties desiredProperties);
  }
}
