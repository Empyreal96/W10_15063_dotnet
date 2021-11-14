// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCapturePauseResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ExclusiveTo(typeof (MediaCapturePauseResult))]
  [Guid(2932112547, 17527, 19204, 160, 111, 44, 28, 81, 130, 254, 157)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IMediaCapturePauseResult
  {
    VideoFrame LastFrame { get; }

    TimeSpan RecordDuration { get; }
  }
}
