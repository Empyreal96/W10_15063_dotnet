// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IPodcastSeries
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Media
{
  [Version(100859904)]
  [ExclusiveTo(typeof (PodcastSeries))]
  [Guid(1079243790, 41025, 12559, 173, 49, 157, 239, 198, 13, 6, 121)]
  internal interface IPodcastSeries : IMediaItem
  {
    string Name { get; set; }

    string Url { get; set; }

    string Copyright { get; set; }

    string Description { get; set; }

    string ImageUrl { get; set; }

    bool IsSubscribed { get; set; }

    uint SubscriptionState { get; set; }

    uint EpisodesToKeep { get; set; }

    uint SubscribeOrder { get; set; }

    string Author { get; set; }

    string HomePageUrl { get; set; }

    uint MediaType { get; set; }

    DateTime LastPlayed { get; set; }

    DateTime LastFeedUpdate { get; set; }

    DateTime LastSyncDate { get; set; }

    uint EpisodeCount { get; set; }

    uint NewEpisodeCount { get; set; }

    uint LegacyId { get; }

    [Overload("LoadPropertiesAsync")]
    IAsyncAction LoadPropertiesAsync();

    [Overload("LoadPropertiesAsyncEx")]
    IAsyncAction LoadPropertiesAsync(IIterable<string> props);

    IAsyncAction DeleteAsync();

    IAsyncAction SaveAsync();

    [Overload("GetAudioContentsQuery")]
    AudioQueryResult GetAudioContentsQuery();

    [Overload("GetAudioContentsQueryEx")]
    AudioQueryResult GetAudioContentsQuery(StorageLocationFilter storageFilter);

    [Overload("GetVideoContentsQuery")]
    VideoQueryResult GetVideoContentsQuery();

    [Overload("GetVideoContentsQueryEx")]
    VideoQueryResult GetVideoContentsQuery(StorageLocationFilter storageFilter);
  }
}
