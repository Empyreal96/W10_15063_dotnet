// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IMediaStore
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Media
{
  [ExclusiveTo(typeof (MediaStore))]
  [Guid(450726895, 16480, 14261, 149, 78, 93, 37, 58, 19, 237, 155)]
  [Version(100859904)]
  internal interface IMediaStore
  {
    string Id { get; }

    Guid Guid { get; }

    [Overload("CreateMusicAudioQuery")]
    AudioQueryResult CreateMusicAudioQuery();

    [Overload("CreateMusicAudioQueryEx")]
    AudioQueryResult CreateMusicAudioQuery(StorageLocationFilter storageFilter);

    [Overload("CreatePodcastAudioQuery")]
    AudioQueryResult CreatePodcastAudioQuery();

    [Overload("CreatePodcastAudioQueryEx")]
    AudioQueryResult CreatePodcastAudioQuery(StorageLocationFilter storageFilter);

    [Overload("CreateRecentAddedAudioQuery")]
    AudioQueryResult CreateRecentAddedAudioQuery();

    [Overload("CreateRecentAddedAudioQueryEx")]
    AudioQueryResult CreateRecentAddedAudioQuery(StorageLocationFilter storageFilter);

    [Overload("CreateFrequentPlayedAudioQuery")]
    AudioQueryResult CreateFrequentPlayedAudioQuery();

    [Overload("CreateFrequentPlayedAudioQueryEx")]
    AudioQueryResult CreateFrequentPlayedAudioQuery(
      StorageLocationFilter storageFilter);

    [Overload("CreateRecentPlayedAudioQuery")]
    AudioQueryResult CreateRecentPlayedAudioQuery();

    [Overload("CreateRecentPlayedAudioQueryEx")]
    AudioQueryResult CreateRecentPlayedAudioQuery(
      StorageLocationFilter storageFilter);

    [Overload("CreateFavoriteAudioQuery")]
    AudioQueryResult CreateFavoriteAudioQuery();

    [Overload("CreateFavoriteAudioQueryEx")]
    AudioQueryResult CreateFavoriteAudioQuery(StorageLocationFilter storageLocation);

    [Overload("CreateAlbumQuery")]
    AlbumQueryResult CreateAlbumQuery();

    [Overload("CreateArtistQuery")]
    ArtistQueryResult CreateArtistQuery();

    [Overload("CreateAlbumArtistQuery")]
    ArtistQueryResult CreateAlbumArtistQuery();

    [Overload("CreateGenreQuery")]
    GenreQueryResult CreateGenreQuery();

    PlaylistQueryResult CreatePlaylistQuery();

    [Overload("CreateVideoQuery")]
    VideoQueryResult CreateVideoQuery();

    [Overload("CreateVideoQueryEx")]
    VideoQueryResult CreateVideoQuery(StorageLocationFilter storageFilter);

    [Overload("CreatePodcastVideoQuery")]
    VideoQueryResult CreatePodcastVideoQuery();

    [Overload("CreatePodcastVideoQueryEx")]
    VideoQueryResult CreatePodcastVideoQuery(StorageLocationFilter storageFilter);

    [Overload("CreatePictureQuery")]
    PictureQueryResult CreatePictureQuery();

    [Overload("CreatePictureQueryEx")]
    PictureQueryResult CreatePictureQuery(StorageLocationFilter storageFilter);

    [Overload("CreateFavoritePictureQuery")]
    PictureQueryResult CreateFavoritePictureQuery();

    [Overload("CreateFavoritePictureQueryEx")]
    PictureQueryResult CreateFavoritePictureQuery(
      StorageLocationFilter storageFilter);

    MediaItemQueryResult CreateFavoritePictureVideoQuery();

    MediaItemQueryResult CreateFavoritePictureVideoQueryEx(
      StorageLocationFilter storageFilter);

    PictureAlbumQueryResult CreatePictureAlbumQuery();

    PictureAlbumQueryResult CreateRootPictureAlbumQuery();

    PodcastSeriesQueryResult CreatePodcastSeriesQuery();

    CartEntryQueryResult CreateCartEntriesQuery();

    MediaItemQueryResult CreateTaggedPictureQuery(uint tagValue);

    Audio CreateAudio(string name);

    Album CreateAlbum(string name);

    Artist CreateArtist(string name);

    Genre CreateGenre(string name);

    Playlist CreatePlaylist(string name);

    Video CreateVideo(string name);

    Picture CreatePicture(string name);

    PictureAlbum CreatePictureAlbum(string parentPictureAlbumId, string name);

    PodcastSeries CreatePodcastSeries(string name);

    Event CreateEvent(string pictureAlbumId, global::Windows.Foundation.DateTime start);

    CartEntry CreateCartEntry(string name);

    IAsyncOperation<Audio> GetAudioAsync(string id);

    IAsyncOperation<Album> GetAlbumAsync(string id);

    IAsyncOperation<Artist> GetArtistAsync(string id);

    IAsyncOperation<Genre> GetGenreAsync(string id);

    IAsyncOperation<Playlist> GetPlaylistAsync(string id);

    IAsyncOperation<Video> GetVideoAsync(string id);

    IAsyncOperation<Picture> GetPictureAsync(string id);

    IAsyncOperation<PictureAlbum> GetPictureAlbumAsync(string id);

    IAsyncOperation<PodcastSeries> GetPodcastSeriesAsync(string id);

    IAsyncOperation<Event> GetEventAsync(string id);

    IAsyncOperation<CartEntry> GetCartEntryAsync(string id);

    IAsyncOperation<Audio> GetAudioByMediaIdAsync(Guid mediaId);

    IAsyncOperation<Album> GetAlbumByMediaIdAsync(Guid mediaId);

    IAsyncOperation<Artist> GetArtistByMediaIdAsync(Guid mediaId);

    IAsyncOperation<CartEntry> GetCartEntryByMediaIdAsync(Guid mediaId);

    IAsyncOperation<PictureAlbum> GetSpecialPictureAlbumAsync(
      SpecialPictureAlbumType type);

    IAsyncOperation<Video> GetVideoByRemoteIdAsync(string remoteId);

    IAsyncOperation<Picture> GetPictureByRemoteIdAsync(string remoteId);

    IAsyncOperation<PictureAlbum> GetPictureAlbumByRemoteIdAsync(
      string remoteId);

    IAsyncAction DeleteItemAsync(string id);

    IAsyncAction SavePictureAlbumsAsync(IIterable<PictureAlbum> pictureAlbums);

    IAsyncAction SavePicturesAsync(IIterable<Picture> pictures);

    IAsyncAction SaveVideosAsync(IIterable<Video> videos);

    IAsyncAction DeleteBackingFilesForPhotosAsync();

    IAsyncAction DeleteAsync();

    IAsyncAction SaveAsync();

    IAsyncAction CopyItemsAsync(IIterable<string> items, CopyDestinationType type);

    IAsyncOperation<BulkCopyStateName> GetCopyStateNameAsync();

    IAsyncAction CancelAllPendingCopiesAsync();

    IAsyncOperation<string> SubscribeToNotificationsAsync(NotificationTypeFlags flags);

    IAsyncAction UnsubscribeToNotificationsAsync(string notificationName);

    VideoQueryResult CreatePersonalVideoQuery();

    [Overload("CreateAlbumQueryWithFilter")]
    AlbumQueryResult CreateAlbumQuery(StorageLocationFilter storageLocation);

    [Overload("CreateArtistQueryWithFilter")]
    ArtistQueryResult CreateArtistQuery(StorageLocationFilter storageLocation);

    [Overload("CreateAlbumArtistQueryWithFilter")]
    ArtistQueryResult CreateAlbumArtistQuery(StorageLocationFilter storageLocation);

    [Overload("CreateGenreQueryWithFilter")]
    GenreQueryResult CreateGenreQuery(StorageLocationFilter storageLocation);
  }
}
