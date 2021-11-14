// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IArtist
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
  [Guid(217370178, 60580, 13705, 172, 14, 159, 45, 124, 147, 91, 154)]
  [ExclusiveTo(typeof (Artist))]
  internal interface IArtist : IMediaItem
  {
    string Name { get; set; }

    uint LegacyId { get; }

    Guid MediaId { get; set; }

    IRandomAccessStreamReference ArtistArt { get; set; }

    [Overload("LoadPropertiesAsync")]
    IAsyncAction LoadPropertiesAsync();

    [Overload("LoadPropertiesAsyncEx")]
    IAsyncAction LoadPropertiesAsync(IIterable<string> props);

    IAsyncAction DeleteAsync();

    IAsyncAction SaveAsync();

    [Overload("GetTracksQuery")]
    AudioQueryResult GetTracksQuery();

    [Overload("GetTracksQueryEx")]
    AudioQueryResult GetTracksQuery(
      TrackOrder order,
      StorageLocationFilter storageLocation);

    AlbumQueryResult GetAlbumsQuery();
  }
}
