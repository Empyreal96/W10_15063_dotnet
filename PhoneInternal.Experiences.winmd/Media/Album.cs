// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.Album
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
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Version(100859904)]
  public sealed class Album : IMediaItem, IAlbum
  {
    public extern string Id { [MethodImpl] get; }

    [MethodImpl]
    public extern void SetExtraProperties(IIterable<IKeyValuePair<string, object>> props);

    [MethodImpl]
    public extern IAsyncOperation<IMap<string, object>> GetExtraPropertiesAsync(
      IIterable<string> propNames);

    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    public extern uint LegacyId { [MethodImpl] get; }

    public extern global::Windows.Foundation.DateTime Date { [MethodImpl] get; [MethodImpl] set; }

    public extern string ArtistId { [MethodImpl] get; [MethodImpl] set; }

    public extern string ArtistName { [MethodImpl] get; }

    public extern Guid MediaId { [MethodImpl] get; [MethodImpl] set; }

    public extern IRandomAccessStreamReference AlbumArtLarge { [MethodImpl] get; [MethodImpl] set; }

    public extern IRandomAccessStreamReference AlbumArtSmall { [MethodImpl] get; [MethodImpl] set; }

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

    [Overload("GetTracksQuery")]
    [MethodImpl]
    public extern AudioQueryResult GetTracksQuery();

    [Overload("GetTracksQueryEx")]
    [MethodImpl]
    public extern AudioQueryResult GetTracksQuery(
      StorageLocationFilter storageFilter);

    [MethodImpl]
    public extern IAsyncOperation<Artist> GetArtistAsync();
  }
}
