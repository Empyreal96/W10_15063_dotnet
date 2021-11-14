// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaSource4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Playback;
using Windows.Media.Streaming.Adaptive;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3182406999, 36607, 19555, 133, 166, 132, 222, 10, 227, 228, 242)]
  [ExclusiveTo(typeof (MediaSource))]
  internal interface IMediaSource4 : IMediaSource3, IMediaSource2, IMediaPlaybackSource, IClosable
  {
    AdaptiveMediaSource AdaptiveMediaSource { get; }

    MediaStreamSource MediaStreamSource { get; }

    MseStreamSource MseStreamSource { get; }

    Uri Uri { get; }

    [RemoteAsync]
    IAsyncAction OpenAsync();
  }
}
