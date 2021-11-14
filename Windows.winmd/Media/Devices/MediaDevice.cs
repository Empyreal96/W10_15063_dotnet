// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.MediaDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IMediaDeviceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.MTA)]
  public static class MediaDevice
  {
    [MethodImpl]
    public static extern string GetAudioCaptureSelector();

    [MethodImpl]
    public static extern string GetAudioRenderSelector();

    [MethodImpl]
    public static extern string GetVideoCaptureSelector();

    [MethodImpl]
    public static extern string GetDefaultAudioCaptureId(AudioDeviceRole role);

    [MethodImpl]
    public static extern string GetDefaultAudioRenderId(AudioDeviceRole role);

    public static extern event TypedEventHandler<object, DefaultAudioCaptureDeviceChangedEventArgs> DefaultAudioCaptureDeviceChanged;

    public static extern event TypedEventHandler<object, DefaultAudioRenderDeviceChangedEventArgs> DefaultAudioRenderDeviceChanged;
  }
}
