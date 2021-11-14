// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IPodcastSeriesPropertiesStatics
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Media
{
  [Guid(2245197792, 27537, 13660, 175, 87, 50, 249, 249, 153, 71, 153)]
  [ExclusiveTo(typeof (PodcastSeriesProperties))]
  [Version(100859904)]
  internal interface IPodcastSeriesPropertiesStatics
  {
    string Name { get; }

    string LegacyId { get; }

    string Url { get; }

    string Copyright { get; }

    string Description { get; }

    string ImageUrl { get; }

    string IsSubscribed { get; }

    string SubscriptionState { get; }

    string EpisodesToKeep { get; }

    string SubscribeOrder { get; }

    string Author { get; }

    string HomePageUrl { get; }

    string MediaType { get; }

    string LastPlayed { get; }

    string LastFeedUpdate { get; }

    string LastSyncDate { get; }

    string EpisodeCount { get; }

    string NewEpisodeCount { get; }
  }
}
