// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IAudio
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace PhoneInternal.Experiences.Media
{
  [Guid(4033574123, 21701, 14152, 153, 232, 45, 25, 23, 2, 160, 50)]
  [Version(100859904)]
  [ExclusiveTo(typeof (Audio))]
  internal interface IAudio : IMediaItem
  {
    string Name { get; set; }

    uint LegacyId { get; }

    string Description { get; set; }

    uint AlbumTrackIndex { get; set; }

    uint Duration { get; set; }

    string AlbumId { get; set; }

    string ArtistId { get; set; }

    string AlbumName { get; }

    string ArtistName { get; }

    string GenreId { get; set; }

    string PodcastSeriesId { get; set; }

    global::Windows.Foundation.Uri ThumbnailLargeUrl { get; set; }

    Guid MediaId { get; set; }

    AudioType Type { get; set; }

    bool IsDrm { get; set; }

    StorageLocationFlags StorageLocation { get; set; }

    IRandomAccessStreamReference Content { get; set; }

    string FilePath { get; set; }

    uint FileSize { get; set; }

    uint FormatCode { get; set; }

    global::Windows.Foundation.Uri Uri { get; set; }

    global::Windows.Foundation.DateTime Date { get; set; }

    MediaRating Rating { get; set; }

    bool InCollection { get; set; }

    bool IsDisabled { get; set; }

    uint PlayCount { get; set; }

    uint DownloadState { get; set; }

    uint DownloadType { get; set; }

    global::Windows.Foundation.DateTime DatePlayed { get; set; }

    global::Windows.Foundation.DateTime DateFavorite { get; set; }

    global::Windows.Foundation.DateTime DateAdded { get; set; }

    Guid PlaylistEntryId { get; set; }

    uint MediaRights { get; set; }

    Guid ActionableId { get; set; }

    [Overload("LoadPropertiesAsync")]
    IAsyncAction LoadPropertiesAsync();

    [Overload("LoadPropertiesAsyncEx")]
    IAsyncAction LoadPropertiesAsync(IIterable<string> props);

    IAsyncAction DeleteAsync(DeleteOption option);

    IAsyncAction RemoveLocalContentAsync();

    IAsyncAction SaveAsync();

    IAsyncOperation<Artist> GetArtistAsync();

    IAsyncOperation<Album> GetAlbumAsync();

    IAsyncOperation<PodcastSeries> GetPodcastSeriesAsync();

    IAsyncAction MakeFilePathValidAsync();

    bool IsAcquiredItem { get; set; }

    uint Bookmark { get; set; }
  }
}
