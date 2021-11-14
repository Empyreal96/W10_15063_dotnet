// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IVideo
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
  [Version(100859904)]
  [Guid(1890338638, 29416, 14271, 174, 235, 66, 59, 64, 17, 250, 54)]
  [ExclusiveTo(typeof (Video))]
  internal interface IVideo : IMediaItem
  {
    string Name { get; set; }

    string Description { get; set; }

    uint LegacyId { get; }

    uint Duration { get; set; }

    uint Width { set; get; }

    uint Height { get; set; }

    uint BitRate { get; set; }

    uint FrameRate { get; set; }

    VideoType Type { get; set; }

    string PodcastSeriesId { get; set; }

    string PictureAlbumId { get; set; }

    string ThumbnailSmallPath { get; }

    global::Windows.Foundation.Uri ThumbnailSmallUrl { get; set; }

    string ThumbnailLargePath { get; }

    global::Windows.Foundation.Uri ThumbnailLargeUrl { get; set; }

    global::Windows.Foundation.Uri ContentUrl { get; set; }

    IRandomAccessStreamReference ThumbnailSmall { get; set; }

    IRandomAccessStreamReference ThumbnailLarge { get; set; }

    IRandomAccessStreamReference Content { get; set; }

    string FilePath { get; set; }

    uint FileSize { get; set; }

    uint DownloadState { get; set; }

    uint DownloadType { get; set; }

    uint PlayCount { get; set; }

    StorageLocationFlags StorageLocation { get; set; }

    uint FormatCode { get; set; }

    string RemoteId { get; set; }

    global::Windows.Foundation.DateTime CreationTime { get; set; }

    global::Windows.Foundation.DateTime DateAdded { get; set; }

    Guid CaptureAppId { get; set; }

    Guid PersistentUniqueId { get; set; }

    MediaRating Rating { get; set; }

    [Overload("LoadPropertiesAsync")]
    IAsyncAction LoadPropertiesAsync();

    [Overload("LoadPropertiesAsyncEx")]
    IAsyncAction LoadPropertiesAsync(IIterable<string> props);

    IAsyncAction DeleteAsync();

    IAsyncAction SaveAsync();

    IAsyncOperation<PodcastSeries> GetPodcastSeriesAsync();

    IAsyncOperation<PictureAlbum> GetPictureAlbumAsync();

    IAsyncOperation<IRandomAccessStream> OpenContentStreamAsync();

    void AddTag(uint value);

    IAsyncOperation<bool> IsTagSetAsync(uint value);

    IAsyncAction RemoveTagAsync(uint value);

    IAsyncAction MakeFilePathValidAsync();

    IAsyncAction SetImageStreamInternalAsync(PhotoStreamType type, IInputStream pValue);

    bool IsAcquiredItem { get; set; }

    uint Bookmark { get; set; }
  }
}
