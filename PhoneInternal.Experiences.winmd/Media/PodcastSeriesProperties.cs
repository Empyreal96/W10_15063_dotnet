// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.PodcastSeriesProperties
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Media
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IPodcastSeriesPropertiesStatics), 100859904)]
  [Version(100859904)]
  [Threading(ThreadingModel.Both)]
  public static class PodcastSeriesProperties
  {
    public static extern string Name { [MethodImpl] get; }

    public static extern string LegacyId { [MethodImpl] get; }

    public static extern string Url { [MethodImpl] get; }

    public static extern string Copyright { [MethodImpl] get; }

    public static extern string Description { [MethodImpl] get; }

    public static extern string ImageUrl { [MethodImpl] get; }

    public static extern string IsSubscribed { [MethodImpl] get; }

    public static extern string SubscriptionState { [MethodImpl] get; }

    public static extern string EpisodesToKeep { [MethodImpl] get; }

    public static extern string SubscribeOrder { [MethodImpl] get; }

    public static extern string Author { [MethodImpl] get; }

    public static extern string HomePageUrl { [MethodImpl] get; }

    public static extern string MediaType { [MethodImpl] get; }

    public static extern string LastPlayed { [MethodImpl] get; }

    public static extern string LastFeedUpdate { [MethodImpl] get; }

    public static extern string LastSyncDate { [MethodImpl] get; }

    public static extern string EpisodeCount { [MethodImpl] get; }

    public static extern string NewEpisodeCount { [MethodImpl] get; }
  }
}
