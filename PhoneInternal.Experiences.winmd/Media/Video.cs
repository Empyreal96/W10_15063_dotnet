// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.Video
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
  [Version(100859904)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class Video : IVideoWithGeoData, IVideo, IMediaItem
  {
    public extern int Latitude { [MethodImpl] get; [MethodImpl] set; }

    public extern int Longitude { [MethodImpl] get; [MethodImpl] set; }

    public extern int Heading { [MethodImpl] get; [MethodImpl] set; }

    public extern int Altitude { [MethodImpl] get; [MethodImpl] set; }

    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    public extern string Description { [MethodImpl] get; [MethodImpl] set; }

    public extern uint LegacyId { [MethodImpl] get; }

    public extern uint Duration { [MethodImpl] get; [MethodImpl] set; }

    public extern uint Width { [MethodImpl] set; [MethodImpl] get; }

    public extern uint Height { [MethodImpl] get; [MethodImpl] set; }

    public extern uint BitRate { [MethodImpl] get; [MethodImpl] set; }

    public extern uint FrameRate { [MethodImpl] get; [MethodImpl] set; }

    public extern VideoType Type { [MethodImpl] get; [MethodImpl] set; }

    public extern string PodcastSeriesId { [MethodImpl] get; [MethodImpl] set; }

    public extern string PictureAlbumId { [MethodImpl] get; [MethodImpl] set; }

    public extern string ThumbnailSmallPath { [MethodImpl] get; }

    public extern global::Windows.Foundation.Uri ThumbnailSmallUrl { [MethodImpl] get; [MethodImpl] set; }

    public extern string ThumbnailLargePath { [MethodImpl] get; }

    public extern global::Windows.Foundation.Uri ThumbnailLargeUrl { [MethodImpl] get; [MethodImpl] set; }

    public extern global::Windows.Foundation.Uri ContentUrl { [MethodImpl] get; [MethodImpl] set; }

    public extern IRandomAccessStreamReference ThumbnailSmall { [MethodImpl] get; [MethodImpl] set; }

    public extern IRandomAccessStreamReference ThumbnailLarge { [MethodImpl] get; [MethodImpl] set; }

    public extern IRandomAccessStreamReference Content { [MethodImpl] get; [MethodImpl] set; }

    public extern string FilePath { [MethodImpl] get; [MethodImpl] set; }

    public extern uint FileSize { [MethodImpl] get; [MethodImpl] set; }

    public extern uint DownloadState { [MethodImpl] get; [MethodImpl] set; }

    public extern uint DownloadType { [MethodImpl] get; [MethodImpl] set; }

    public extern uint PlayCount { [MethodImpl] get; [MethodImpl] set; }

    public extern StorageLocationFlags StorageLocation { [MethodImpl] get; [MethodImpl] set; }

    public extern uint FormatCode { [MethodImpl] get; [MethodImpl] set; }

    public extern string RemoteId { [MethodImpl] get; [MethodImpl] set; }

    public extern global::Windows.Foundation.DateTime CreationTime { [MethodImpl] get; [MethodImpl] set; }

    public extern global::Windows.Foundation.DateTime DateAdded { [MethodImpl] get; [MethodImpl] set; }

    public extern Guid CaptureAppId { [MethodImpl] get; [MethodImpl] set; }

    public extern Guid PersistentUniqueId { [MethodImpl] get; [MethodImpl] set; }

    public extern MediaRating Rating { [MethodImpl] get; [MethodImpl] set; }

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

    [MethodImpl]
    public extern IAsyncOperation<PodcastSeries> GetPodcastSeriesAsync();

    [MethodImpl]
    public extern IAsyncOperation<PictureAlbum> GetPictureAlbumAsync();

    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStream> OpenContentStreamAsync();

    [MethodImpl]
    public extern void AddTag(uint value);

    [MethodImpl]
    public extern IAsyncOperation<bool> IsTagSetAsync(uint value);

    [MethodImpl]
    public extern IAsyncAction RemoveTagAsync(uint value);

    [MethodImpl]
    public extern IAsyncAction MakeFilePathValidAsync();

    [MethodImpl]
    public extern IAsyncAction SetImageStreamInternalAsync(
      PhotoStreamType type,
      IInputStream pValue);

    public extern bool IsAcquiredItem { [MethodImpl] get; [MethodImpl] set; }

    public extern uint Bookmark { [MethodImpl] get; [MethodImpl] set; }

    public extern string Id { [MethodImpl] get; }

    [MethodImpl]
    public extern void SetExtraProperties(IIterable<IKeyValuePair<string, object>> props);

    [MethodImpl]
    public extern IAsyncOperation<IMap<string, object>> GetExtraPropertiesAsync(
      IIterable<string> propNames);
  }
}
