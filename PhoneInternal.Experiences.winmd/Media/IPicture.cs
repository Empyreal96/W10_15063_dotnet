// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IPicture
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
  [ExclusiveTo(typeof (Picture))]
  [Guid(1701324985, 15201, 14478, 150, 82, 75, 164, 220, 191, 31, 123)]
  internal interface IPicture : IMediaItem
  {
    string Name { get; set; }

    string Description { get; set; }

    uint LegacyId { get; }

    uint Width { get; set; }

    uint Height { get; set; }

    IRandomAccessStreamReference ThumbnailSmall { get; set; }

    string ThumbnailSmallPath { get; }

    IRandomAccessStreamReference ThumbnailLarge { get; set; }

    string ThumbnailLargePath { get; }

    IRandomAccessStreamReference Content { get; set; }

    global::Windows.Foundation.Uri ThumbnailSmallUrl { get; set; }

    global::Windows.Foundation.Uri ThumbnailLargeUrl { get; set; }

    global::Windows.Foundation.Uri ContentUrl { get; set; }

    string RemoteId { get; set; }

    global::Windows.Foundation.DateTime CreationTime { get; set; }

    string FilePath { get; set; }

    string PictureAlbumId { get; set; }

    StorageLocationFlags StorageLocation { get; set; }

    uint FormatCode { get; set; }

    uint Orientation { get; set; }

    int Latitude { get; set; }

    int Longitude { get; set; }

    int Heading { get; set; }

    int Altitude { get; set; }

    Guid CaptureAppId { get; set; }

    Guid PersistentUniqueId { get; set; }

    MediaRating Rating { get; set; }

    [Overload("LoadPropertiesAsync")]
    IAsyncAction LoadPropertiesAsync();

    [Overload("LoadPropertiesAsyncEx")]
    IAsyncAction LoadPropertiesAsync(IIterable<string> props);

    IAsyncAction DeleteAsync();

    IAsyncAction SaveAsync();

    IAsyncOperation<PictureAlbum> GetPictureAlbumAsync();

    IAsyncOperation<IRandomAccessStream> OpenContentStreamAsync();

    void AddTag(uint value);

    IAsyncOperation<bool> IsTagSetAsync(uint value);

    IAsyncAction RemoveTagAsync(uint value);

    IAsyncAction MakeFilePathValidAsync();

    IAsyncAction SetImageStreamInternalAsync(PhotoStreamType type, IInputStream pValue);

    bool IsAcquiredItem { get; set; }
  }
}
