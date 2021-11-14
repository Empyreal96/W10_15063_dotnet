// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IAlbum
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
  [Guid(3869404093, 58347, 15295, 136, 48, 244, 159, 53, 118, 118, 217)]
  [Version(100859904)]
  [ExclusiveTo(typeof (Album))]
  internal interface IAlbum : IMediaItem
  {
    string Name { get; set; }

    uint LegacyId { get; }

    global::Windows.Foundation.DateTime Date { get; set; }

    string ArtistId { get; set; }

    string ArtistName { get; }

    Guid MediaId { get; set; }

    IRandomAccessStreamReference AlbumArtLarge { get; set; }

    IRandomAccessStreamReference AlbumArtSmall { get; set; }

    [Overload("LoadPropertiesAsync")]
    IAsyncAction LoadPropertiesAsync();

    [Overload("LoadPropertiesAsyncEx")]
    IAsyncAction LoadPropertiesAsync(IIterable<string> props);

    IAsyncAction DeleteAsync();

    IAsyncAction SaveAsync();

    [Overload("GetTracksQuery")]
    AudioQueryResult GetTracksQuery();

    [Overload("GetTracksQueryEx")]
    AudioQueryResult GetTracksQuery(StorageLocationFilter storageFilter);

    IAsyncOperation<Artist> GetArtistAsync();
  }
}
