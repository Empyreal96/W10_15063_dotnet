// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IPictureAlbum
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace PhoneInternal.Experiences.Media
{
  [Guid(4202279572, 62401, 14691, 132, 38, 74, 60, 156, 48, 206, 107)]
  [Version(100859904)]
  [ExclusiveTo(typeof (PictureAlbum))]
  internal interface IPictureAlbum : IMediaItem
  {
    string Name { get; set; }

    uint LegacyId { get; }

    string ParentPictureAlbumId { get; set; }

    string CoverPictureId { get; set; }

    string CoverImagePath { get; }

    IRandomAccessStreamReference CoverImage { get; set; }

    Uri CoverImageUrl { get; set; }

    string RemoteId { get; set; }

    DateTime CreationTime { get; set; }

    bool RequiresAuthentication { get; set; }

    string RevisionStamp { get; set; }

    DateTime LastModifiedTime { get; }

    SpecialPictureAlbumType PictureAlbumType { get; }

    [Overload("LoadPropertiesAsync")]
    IAsyncAction LoadPropertiesAsync();

    [Overload("LoadPropertiesAsyncEx")]
    IAsyncAction LoadPropertiesAsync(IIterable<string> props);

    IAsyncAction DeleteAsync(DeleteOption option);

    IAsyncAction SaveAsync();

    PictureAlbumQueryResult GetPictureAlbumsQuery(
      StorageLocationFilter storageFilter);

    EventQueryResult GetEventsQuery();

    MediaItemQueryResult GetContentsQuery(StorageLocationFilter storageFilter);

    IAsyncAction SetCoverImageInternalAsync(IInputStream pValue);
  }
}
