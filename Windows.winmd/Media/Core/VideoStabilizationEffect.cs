// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.VideoStabilizationEffect
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Capture;
using Windows.Media.Devices;
using Windows.Media.MediaProperties;

namespace Windows.Media.Core
{
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class VideoStabilizationEffect : IVideoStabilizationEffect, IMediaExtension
  {
    public extern bool Enabled { [MethodImpl] set; [MethodImpl] get; }

    public extern event TypedEventHandler<VideoStabilizationEffect, VideoStabilizationEffectEnabledChangedEventArgs> EnabledChanged;

    [MethodImpl]
    public extern VideoStreamConfiguration GetRecommendedStreamConfiguration(
      VideoDeviceController controller,
      VideoEncodingProperties desiredProperties);

    [MethodImpl]
    public extern void SetProperties(IPropertySet configuration);
  }
}
