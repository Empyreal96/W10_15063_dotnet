// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMseStreamSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (MseStreamSource))]
  [WebHostHidden]
  [Guid(2964593037, 756, 18723, 136, 221, 129, 188, 63, 54, 15, 250)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMseStreamSource : IMediaSource
  {
    event TypedEventHandler<MseStreamSource, object> Opened;

    event TypedEventHandler<MseStreamSource, object> Ended;

    event TypedEventHandler<MseStreamSource, object> Closed;

    MseSourceBufferList SourceBuffers { get; }

    MseSourceBufferList ActiveSourceBuffers { get; }

    MseReadyState ReadyState { get; }

    IReference<TimeSpan> Duration { get; set; }

    MseSourceBuffer AddSourceBuffer(string mimeType);

    void RemoveSourceBuffer(MseSourceBuffer buffer);

    void EndOfStream(MseEndOfStreamStatus status);
  }
}
