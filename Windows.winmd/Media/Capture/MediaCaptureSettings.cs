// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.MediaCaptureSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class MediaCaptureSettings : IMediaCaptureSettings, IMediaCaptureSettings2
  {
    public extern string AudioDeviceId { [MethodImpl] get; }

    public extern string VideoDeviceId { [MethodImpl] get; }

    public extern StreamingCaptureMode StreamingCaptureMode { [MethodImpl] get; }

    public extern PhotoCaptureSource PhotoCaptureSource { [MethodImpl] get; }

    public extern VideoDeviceCharacteristic VideoDeviceCharacteristic { [MethodImpl] get; }

    public extern bool ConcurrentRecordAndPhotoSupported { [MethodImpl] get; }

    public extern bool ConcurrentRecordAndPhotoSequenceSupported { [MethodImpl] get; }

    public extern bool CameraSoundRequiredForRegion { [MethodImpl] get; }

    public extern IReference<uint> Horizontal35mmEquivalentFocalLength { [MethodImpl] get; }

    public extern IReference<int> PitchOffsetDegrees { [MethodImpl] get; }

    public extern IReference<uint> Vertical35mmEquivalentFocalLength { [MethodImpl] get; }

    public extern MediaCategory MediaCategory { [MethodImpl] get; }

    public extern AudioProcessing AudioProcessing { [MethodImpl] get; }
  }
}
