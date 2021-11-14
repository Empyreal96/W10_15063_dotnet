// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.PodcastSeries
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Media
{
  [Threading(ThreadingModel.Both)]
  [Version(100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PodcastSeries : IMediaItem, IPodcastSeries
  {
    public extern string Id { [MethodImpl] get; }

    [MethodImpl]
    public extern void SetExtraProperties(IIterable<IKeyValuePair<string, object>> props);

    [MethodImpl]
    public extern IAsyncOperation<IMap<string, object>> GetExtraPropertiesAsync(
      IIterable<string> propNames);

    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    public extern string Url { [MethodImpl] get; [MethodImpl] set; }

    public extern string Copyright { [MethodImpl] get; [MethodImpl] set; }

    public extern string Description { [MethodImpl] get; [MethodImpl] set; }

    public extern string ImageUrl { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsSubscribed { [MethodImpl] get; [MethodImpl] set; }

    public extern uint SubscriptionState { [MethodImpl] get; [MethodImpl] set; }

    public extern uint EpisodesToKeep { [MethodImpl] get; [MethodImpl] set; }

    public extern uint SubscribeOrder { [MethodImpl] get; [MethodImpl] set; }

    public extern string Author { [MethodImpl] get; [MethodImpl] set; }

    public extern string HomePageUrl { [MethodImpl] get; [MethodImpl] set; }

    public extern uint MediaType { [MethodImpl] get; [MethodImpl] set; }

    public extern DateTime LastPlayed { [MethodImpl] get; [MethodImpl] set; }

    public extern DateTime LastFeedUpdate { [MethodImpl] get; [MethodImpl] set; }

    public extern DateTime LastSyncDate { [MethodImpl] get; [MethodImpl] set; }

    public extern uint EpisodeCount { [MethodImpl] get; [MethodImpl] set; }

    public extern uint NewEpisodeCount { [MethodImpl] get; [MethodImpl] set; }

    public extern uint LegacyId { [MethodImpl] get; }

    [Overload("LoadPropertiesAsync")]
    [MethodImpl]
    public extern IAsyncAction LoadPropertiesAsync();

    [Overload("LoadPropertiesAsyncEx")]
    [MethodImpl]
    public extern IAsyncAction LoadPropertiesAsync(IIterable<string> props);

    [MethodImpl]
    public extern IAsyncAction DeleteAsync();

    [MethodImpl]
    public extern IAsyncAction SaveAsync();

    [Overload("GetAudioContentsQuery")]
    [MethodImpl]
    public extern AudioQueryResult GetAudioContentsQuery();

    [Overload("GetAudioContentsQueryEx")]
    [MethodImpl]
    public extern AudioQueryResult GetAudioContentsQuery(
      StorageLocationFilter storageFilter);

    [Overload("GetVideoContentsQuery")]
    [MethodImpl]
    public extern VideoQueryResult GetVideoContentsQuery();

    [Overload("GetVideoContentsQueryEx")]
    [MethodImpl]
    public extern VideoQueryResult GetVideoContentsQuery(
      StorageLocationFilter storageFilter);
  }
}
