// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.MediaCaptureInitializationSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Capture.Frames;
using Windows.Media.Core;

namespace Windows.Media.Capture
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MediaCaptureInitializationSettings : 
    IMediaCaptureInitializationSettings,
    IMediaCaptureInitializationSettings2,
    IMediaCaptureInitializationSettings3,
    IMediaCaptureInitializationSettings4,
    IMediaCaptureInitializationSettings5,
    IMediaCaptureInitializationSettings6
  {
    [MethodImpl]
    public extern MediaCaptureInitializationSettings();

    public extern string AudioDeviceId { [MethodImpl] set; [MethodImpl] get; }

    public extern string VideoDeviceId { [MethodImpl] set; [MethodImpl] get; }

    public extern StreamingCaptureMode StreamingCaptureMode { [MethodImpl] set; [MethodImpl] get; }

    public extern PhotoCaptureSource PhotoCaptureSource { [MethodImpl] set; [MethodImpl] get; }

    public extern MediaCategory MediaCategory { [MethodImpl] set; [MethodImpl] get; }

    public extern AudioProcessing AudioProcessing { [MethodImpl] set; [MethodImpl] get; }

    public extern IMediaSource AudioSource { [MethodImpl] set; [MethodImpl] get; }

    public extern IMediaSource VideoSource { [MethodImpl] set; [MethodImpl] get; }

    public extern MediaCaptureVideoProfile VideoProfile { [MethodImpl] get; [MethodImpl] set; }

    public extern MediaCaptureVideoProfileMediaDescription PreviewMediaDescription { [MethodImpl] get; [MethodImpl] set; }

    public extern MediaCaptureVideoProfileMediaDescription RecordMediaDescription { [MethodImpl] get; [MethodImpl] set; }

    public extern MediaCaptureVideoProfileMediaDescription PhotoMediaDescription { [MethodImpl] get; [MethodImpl] set; }

    public extern MediaFrameSourceGroup SourceGroup { [MethodImpl] get; [MethodImpl] set; }

    public extern MediaCaptureSharingMode SharingMode { [MethodImpl] get; [MethodImpl] set; }

    public extern MediaCaptureMemoryPreference MemoryPreference { [MethodImpl] get; [MethodImpl] set; }

    public extern bool AlwaysPlaySystemShutterSound { [MethodImpl] get; [MethodImpl] set; }
  }
}
