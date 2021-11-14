// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlaybackList2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [Guid(235517048, 24586, 17012, 161, 75, 11, 103, 35, 208, 244, 139)]
  [ExclusiveTo(typeof (MediaPlaybackList))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IMediaPlaybackList2 : IMediaPlaybackList, IMediaPlaybackSource
  {
    IReference<TimeSpan> MaxPrefetchTime { get; set; }

    MediaPlaybackItem StartingItem { get; set; }

    IVectorView<MediaPlaybackItem> ShuffledItems { get; }

    void SetShuffledItems(IIterable<MediaPlaybackItem> value);
  }
}
