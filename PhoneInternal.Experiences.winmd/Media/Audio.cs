// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.Audio
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace PhoneInternal.Experiences.Media
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Version(100859904)]
  public sealed class Audio : IMediaItem, IAudio
  {
    public extern string Id { [MethodImpl] get; }

    [MethodImpl]
    public extern void SetExtraProperties(IIterable<IKeyValuePair<string, object>> props);

    [MethodImpl]
    public extern IAsyncOperation<IMap<string, object>> GetExtraPropertiesAsync(
      IIterable<string> propNames);

    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    public extern uint LegacyId { [MethodImpl] get; }

    public extern string Description { [MethodImpl] get; [MethodImpl] set; }

    public extern uint AlbumTrackIndex { [MethodImpl] get; [MethodImpl] set; }

    public extern uint Duration { [MethodImpl] get; [MethodImpl] set; }

    public extern string AlbumId { [MethodImpl] get; [MethodImpl] set; }

    public extern string ArtistId { [MethodImpl] get; [MethodImpl] set; }

    public extern string AlbumName { [MethodImpl] get; }

    public extern string ArtistName { [MethodImpl] get; }

    public extern string GenreId { [MethodImpl] get; [MethodImpl] set; }

    public extern string PodcastSeriesId { [MethodImpl] get; [MethodImpl] set; }

    public extern global::Windows.Foundation.Uri ThumbnailLargeUrl { [MethodImpl] get; [MethodImpl] set; }

    public extern Guid MediaId { [MethodImpl] get; [MethodImpl] set; }

    public extern AudioType Type { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsDrm { [MethodImpl] get; [MethodImpl] set; }

    public extern StorageLocationFlags StorageLocation { [MethodImpl] get; [MethodImpl] set; }

    public extern IRandomAccessStreamReference Content { [MethodImpl] get; [MethodImpl] set; }

    public extern string FilePath { [MethodImpl] get; [MethodImpl] set; }

    public extern uint FileSize { [MethodImpl] get; [MethodImpl] set; }

    public extern uint FormatCode { [MethodImpl] get; [MethodImpl] set; }

    public extern global::Windows.Foundation.Uri Uri { [MethodImpl] get; [MethodImpl] set; }

    public extern global::Windows.Foundation.DateTime Date { [MethodImpl] get; [MethodImpl] set; }

    public extern MediaRating Rating { [MethodImpl] get; [MethodImpl] set; }

    public extern bool InCollection { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsDisabled { [MethodImpl] get; [MethodImpl] set; }

    public extern uint PlayCount { [MethodImpl] get; [MethodImpl] set; }

    public extern uint DownloadState { [MethodImpl] get; [MethodImpl] set; }

    public extern uint DownloadType { [MethodImpl] get; [MethodImpl] set; }

    public extern global::Windows.Foundation.DateTime DatePlayed { [MethodImpl] get; [MethodImpl] set; }

    public extern global::Windows.Foundation.DateTime DateFavorite { [MethodImpl] get; [MethodImpl] set; }

    public extern global::Windows.Foundation.DateTime DateAdded { [MethodImpl] get; [MethodImpl] set; }

    public extern Guid PlaylistEntryId { [MethodImpl] get; [MethodImpl] set; }

    public extern uint MediaRights { [MethodImpl] get; [MethodImpl] set; }

    public extern Guid ActionableId { [MethodImpl] get; [MethodImpl] set; }

    [Overload("LoadPropertiesAsync")]
    [MethodImpl]
    public extern IAsyncAction LoadPropertiesAsync();

    [Overload("LoadPropertiesAsyncEx")]
    [MethodImpl]
    public extern IAsyncAction LoadPropertiesAsync(IIterable<string> props);

    [MethodImpl]
    public extern IAsyncAction DeleteAsync(DeleteOption option);

    [MethodImpl]
    public extern IAsyncAction RemoveLocalContentAsync();

    [MethodImpl]
    public extern IAsyncAction SaveAsync();

    [MethodImpl]
    public extern IAsyncOperation<Artist> GetArtistAsync();

    [MethodImpl]
    public extern IAsyncOperation<Album> GetAlbumAsync();

    [MethodImpl]
    public extern IAsyncOperation<PodcastSeries> GetPodcastSeriesAsync();

    [MethodImpl]
    public extern IAsyncAction MakeFilePathValidAsync();

    public extern bool IsAcquiredItem { [MethodImpl] get; [MethodImpl] set; }

    public extern uint Bookmark { [MethodImpl] get; [MethodImpl] set; }
  }
}
