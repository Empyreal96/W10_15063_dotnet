// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaSource3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Playback;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(3047099803, 19310, 16877, 187, 180, 124, 117, 9, 169, 148, 173)]
  [ExclusiveTo(typeof (MediaSource))]
  internal interface IMediaSource3 : IMediaSource2, IMediaPlaybackSource, IClosable
  {
    event TypedEventHandler<MediaSource, MediaSourceStateChangedEventArgs> StateChanged;

    MediaSourceState State { get; }

    void Reset();
  }
}
