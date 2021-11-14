// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.AudioDeviceController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Capture;
using Windows.Media.MediaProperties;

namespace Windows.Media.Devices
{
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class AudioDeviceController : IAudioDeviceController, IMediaDeviceController
  {
    public extern bool Muted { [MethodImpl] set; [MethodImpl] get; }

    public extern float VolumePercent { [MethodImpl] set; [MethodImpl] get; }

    [MethodImpl]
    public extern IVectorView<IMediaEncodingProperties> GetAvailableMediaStreamProperties(
      MediaStreamType mediaStreamType);

    [MethodImpl]
    public extern IMediaEncodingProperties GetMediaStreamProperties(
      MediaStreamType mediaStreamType);

    [MethodImpl]
    public extern IAsyncAction SetMediaStreamPropertiesAsync(
      MediaStreamType mediaStreamType,
      IMediaEncodingProperties mediaEncodingProperties);
  }
}
