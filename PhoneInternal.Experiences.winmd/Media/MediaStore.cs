// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.MediaStore
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Media
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Version(100859904)]
  public sealed class MediaStore : IMediaStore
  {
    public extern string Id { [MethodImpl] get; }

    public extern Guid Guid { [MethodImpl] get; }

    [Overload("CreateMusicAudioQuery")]
    [MethodImpl]
    public extern AudioQueryResult CreateMusicAudioQuery();

    [Overload("CreateMusicAudioQueryEx")]
    [MethodImpl]
    public extern AudioQueryResult CreateMusicAudioQuery(
      StorageLocationFilter storageFilter);

    [Overload("CreatePodcastAudioQuery")]
    [MethodImpl]
    public extern AudioQueryResult CreatePodcastAudioQuery();

    [Overload("CreatePodcastAudioQueryEx")]
    [MethodImpl]
    public extern AudioQueryResult CreatePodcastAudioQuery(
      StorageLocationFilter storageFilter);

    [Overload("CreateRecentAddedAudioQuery")]
    [MethodImpl]
    public extern AudioQueryResult CreateRecentAddedAudioQuery();

    [Overload("CreateRecentAddedAudioQueryEx")]
    [MethodImpl]
    public extern AudioQueryResult CreateRecentAddedAudioQuery(
      StorageLocationFilter storageFilter);

    [Overload("CreateFrequentPlayedAudioQuery")]
    [MethodImpl]
    public extern AudioQueryResult CreateFrequentPlayedAudioQuery();

    [Overload("CreateFrequentPlayedAudioQueryEx")]
    [MethodImpl]
    public extern AudioQueryResult CreateFrequentPlayedAudioQuery(
      StorageLocationFilter storageFilter);

    [Overload("CreateRecentPlayedAudioQuery")]
    [MethodImpl]
    public extern AudioQueryResult CreateRecentPlayedAudioQuery();

    [Overload("CreateRecentPlayedAudioQueryEx")]
    [MethodImpl]
    public extern AudioQueryResult CreateRecentPlayedAudioQuery(
      StorageLocationFilter storageFilter);

    [Overload("CreateFavoriteAudioQuery")]
    [MethodImpl]
    public extern AudioQueryResult CreateFavoriteAudioQuery();

    [Overload("CreateFavoriteAudioQueryEx")]
    [MethodImpl]
    public extern AudioQueryResult CreateFavoriteAudioQuery(
      StorageLocationFilter storageLocation);

    [Overload("CreateAlbumQuery")]
    [MethodImpl]
    public extern AlbumQueryResult CreateAlbumQuery();

    [Overload("CreateArtistQuery")]
    [MethodImpl]
    public extern ArtistQueryResult CreateArtistQuery();

    [Overload("CreateAlbumArtistQuery")]
    [MethodImpl]
    public extern ArtistQueryResult CreateAlbumArtistQuery();

    [Overload("CreateGenreQuery")]
    [MethodImpl]
    public extern GenreQueryResult CreateGenreQuery();

    [MethodImpl]
    public extern PlaylistQueryResult CreatePlaylistQuery();

    [Overload("CreateVideoQuery")]
    [MethodImpl]
    public extern VideoQueryResult CreateVideoQuery();

    [Overload("CreateVideoQueryEx")]
    [MethodImpl]
    public extern VideoQueryResult CreateVideoQuery(
      StorageLocationFilter storageFilter);

    [Overload("CreatePodcastVideoQuery")]
    [MethodImpl]
    public extern VideoQueryResult CreatePodcastVideoQuery();

    [Overload("CreatePodcastVideoQueryEx")]
    [MethodImpl]
    public extern VideoQueryResult CreatePodcastVideoQuery(
      StorageLocationFilter storageFilter);

    [Overload("CreatePictureQuery")]
    [MethodImpl]
    public extern PictureQueryResult CreatePictureQuery();

    [Overload("CreatePictureQueryEx")]
    [MethodImpl]
    public extern PictureQueryResult CreatePictureQuery(
      StorageLocationFilter storageFilter);

    [Overload("CreateFavoritePictureQuery")]
    [MethodImpl]
    public extern PictureQueryResult CreateFavoritePictureQuery();

    [Overload("CreateFavoritePictureQueryEx")]
    [MethodImpl]
    public extern PictureQueryResult CreateFavoritePictureQuery(
      StorageLocationFilter storageFilter);

    [MethodImpl]
    public extern MediaItemQueryResult CreateFavoritePictureVideoQuery();

    [MethodImpl]
    public extern MediaItemQueryResult CreateFavoritePictureVideoQueryEx(
      StorageLocationFilter storageFilter);

    [MethodImpl]
    public extern PictureAlbumQueryResult CreatePictureAlbumQuery();

    [MethodImpl]
    public extern PictureAlbumQueryResult CreateRootPictureAlbumQuery();

    [MethodImpl]
    public extern PodcastSeriesQueryResult CreatePodcastSeriesQuery();

    [MethodImpl]
    public extern CartEntryQueryResult CreateCartEntriesQuery();

    [MethodImpl]
    public extern MediaItemQueryResult CreateTaggedPictureQuery(uint tagValue);

    [MethodImpl]
    public extern Audio CreateAudio(string name);

    [MethodImpl]
    public extern Album CreateAlbum(string name);

    [MethodImpl]
    public extern Artist CreateArtist(string name);

    [MethodImpl]
    public extern Genre CreateGenre(string name);

    [MethodImpl]
    public extern Playlist CreatePlaylist(string name);

    [MethodImpl]
    public extern Video CreateVideo(string name);

    [MethodImpl]
    public extern Picture CreatePicture(string name);

    [MethodImpl]
    public extern PictureAlbum CreatePictureAlbum(
      string parentPictureAlbumId,
      string name);

    [MethodImpl]
    public extern PodcastSeries CreatePodcastSeries(string name);

    [MethodImpl]
    public extern Event CreateEvent(string pictureAlbumId, global::Windows.Foundation.DateTime start);

    [MethodImpl]
    public extern CartEntry CreateCartEntry(string name);

    [MethodImpl]
    public extern IAsyncOperation<Audio> GetAudioAsync(string id);

    [MethodImpl]
    public extern IAsyncOperation<Album> GetAlbumAsync(string id);

    [MethodImpl]
    public extern IAsyncOperation<Artist> GetArtistAsync(string id);

    [MethodImpl]
    public extern IAsyncOperation<Genre> GetGenreAsync(string id);

    [MethodImpl]
    public extern IAsyncOperation<Playlist> GetPlaylistAsync(string id);

    [MethodImpl]
    public extern IAsyncOperation<Video> GetVideoAsync(string id);

    [MethodImpl]
    public extern IAsyncOperation<Picture> GetPictureAsync(string id);

    [MethodImpl]
    public extern IAsyncOperation<PictureAlbum> GetPictureAlbumAsync(
      string id);

    [MethodImpl]
    public extern IAsyncOperation<PodcastSeries> GetPodcastSeriesAsync(
      string id);

    [MethodImpl]
    public extern IAsyncOperation<Event> GetEventAsync(string id);

    [MethodImpl]
    public extern IAsyncOperation<CartEntry> GetCartEntryAsync(string id);

    [MethodImpl]
    public extern IAsyncOperation<Audio> GetAudioByMediaIdAsync(Guid mediaId);

    [MethodImpl]
    public extern IAsyncOperation<Album> GetAlbumByMediaIdAsync(Guid mediaId);

    [MethodImpl]
    public extern IAsyncOperation<Artist> GetArtistByMediaIdAsync(Guid mediaId);

    [MethodImpl]
    public extern IAsyncOperation<CartEntry> GetCartEntryByMediaIdAsync(
      Guid mediaId);

    [MethodImpl]
    public extern IAsyncOperation<PictureAlbum> GetSpecialPictureAlbumAsync(
      SpecialPictureAlbumType type);

    [MethodImpl]
    public extern IAsyncOperation<Video> GetVideoByRemoteIdAsync(string remoteId);

    [MethodImpl]
    public extern IAsyncOperation<Picture> GetPictureByRemoteIdAsync(
      string remoteId);

    [MethodImpl]
    public extern IAsyncOperation<PictureAlbum> GetPictureAlbumByRemoteIdAsync(
      string remoteId);

    [MethodImpl]
    public extern IAsyncAction DeleteItemAsync(string id);

    [MethodImpl]
    public extern IAsyncAction SavePictureAlbumsAsync(
      IIterable<PictureAlbum> pictureAlbums);

    [MethodImpl]
    public extern IAsyncAction SavePicturesAsync(IIterable<Picture> pictures);

    [MethodImpl]
    public extern IAsyncAction SaveVideosAsync(IIterable<Video> videos);

    [MethodImpl]
    public extern IAsyncAction DeleteBackingFilesForPhotosAsync();

    [MethodImpl]
    public extern IAsyncAction DeleteAsync();

    [MethodImpl]
    public extern IAsyncAction SaveAsync();

    [MethodImpl]
    public extern IAsyncAction CopyItemsAsync(
      IIterable<string> items,
      CopyDestinationType type);

    [MethodImpl]
    public extern IAsyncOperation<BulkCopyStateName> GetCopyStateNameAsync();

    [MethodImpl]
    public extern IAsyncAction CancelAllPendingCopiesAsync();

    [MethodImpl]
    public extern IAsyncOperation<string> SubscribeToNotificationsAsync(
      NotificationTypeFlags flags);

    [MethodImpl]
    public extern IAsyncAction UnsubscribeToNotificationsAsync(string notificationName);

    [MethodImpl]
    public extern VideoQueryResult CreatePersonalVideoQuery();

    [Overload("CreateAlbumQueryWithFilter")]
    [MethodImpl]
    public extern AlbumQueryResult CreateAlbumQuery(
      StorageLocationFilter storageLocation);

    [Overload("CreateArtistQueryWithFilter")]
    [MethodImpl]
    public extern ArtistQueryResult CreateArtistQuery(
      StorageLocationFilter storageLocation);

    [Overload("CreateAlbumArtistQueryWithFilter")]
    [MethodImpl]
    public extern ArtistQueryResult CreateAlbumArtistQuery(
      StorageLocationFilter storageLocation);

    [Overload("CreateGenreQueryWithFilter")]
    [MethodImpl]
    public extern GenreQueryResult CreateGenreQuery(
      StorageLocationFilter storageLocation);
  }
}
