// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IMediaDeviceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2855115328, 37023, 19386, 191, 139, 12, 13, 41, 111, 20, 240)]
  [ExclusiveTo(typeof (MediaDevice))]
  internal interface IMediaDeviceStatics
  {
    string GetAudioCaptureSelector();

    string GetAudioRenderSelector();

    string GetVideoCaptureSelector();

    string GetDefaultAudioCaptureId(AudioDeviceRole role);

    string GetDefaultAudioRenderId(AudioDeviceRole role);

    event TypedEventHandler<object, DefaultAudioCaptureDeviceChangedEventArgs> DefaultAudioCaptureDeviceChanged;

    event TypedEventHandler<object, DefaultAudioRenderDeviceChangedEventArgs> DefaultAudioRenderDeviceChanged;
  }
}
