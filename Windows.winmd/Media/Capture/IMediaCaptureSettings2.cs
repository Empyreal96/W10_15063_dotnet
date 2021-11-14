// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCaptureSettings2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1872657659, 64159, 19219, 156, 190, 90, 185, 79, 31, 52, 147)]
  [ExclusiveTo(typeof (MediaCaptureSettings))]
  internal interface IMediaCaptureSettings2
  {
    bool ConcurrentRecordAndPhotoSupported { get; }

    bool ConcurrentRecordAndPhotoSequenceSupported { get; }

    bool CameraSoundRequiredForRegion { get; }

    IReference<uint> Horizontal35mmEquivalentFocalLength { get; }

    IReference<int> PitchOffsetDegrees { get; }

    IReference<uint> Vertical35mmEquivalentFocalLength { get; }

    MediaCategory MediaCategory { get; }

    AudioProcessing AudioProcessing { get; }
  }
}
