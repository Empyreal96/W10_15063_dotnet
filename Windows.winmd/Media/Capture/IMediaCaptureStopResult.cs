// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCaptureStopResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ExclusiveTo(typeof (MediaCaptureStopResult))]
  [Guid(4191906346, 41106, 19153, 151, 212, 242, 1, 249, 208, 130, 219)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IMediaCaptureStopResult
  {
    VideoFrame LastFrame { get; }

    TimeSpan RecordDuration { get; }
  }
}
