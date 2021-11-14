// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.PictureAlbum
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace PhoneInternal.Experiences.Media
{
  [Version(100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class PictureAlbum : IMediaItem, IPictureAlbum
  {
    public extern string Id { [MethodImpl] get; }

    [MethodImpl]
    public extern void SetExtraProperties(IIterable<IKeyValuePair<string, object>> props);

    [MethodImpl]
    public extern IAsyncOperation<IMap<string, object>> GetExtraPropertiesAsync(
      IIterable<string> propNames);

    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    public extern uint LegacyId { [MethodImpl] get; }

    public extern string ParentPictureAlbumId { [MethodImpl] get; [MethodImpl] set; }

    public extern string CoverPictureId { [MethodImpl] get; [MethodImpl] set; }

    public extern string CoverImagePath { [MethodImpl] get; }

    public extern IRandomAccessStreamReference CoverImage { [MethodImpl] get; [MethodImpl] set; }

    public extern Uri CoverImageUrl { [MethodImpl] get; [MethodImpl] set; }

    public extern string RemoteId { [MethodImpl] get; [MethodImpl] set; }

    public extern DateTime CreationTime { [MethodImpl] get; [MethodImpl] set; }

    public extern bool RequiresAuthentication { [MethodImpl] get; [MethodImpl] set; }

    public extern string RevisionStamp { [MethodImpl] get; [MethodImpl] set; }

    public extern DateTime LastModifiedTime { [MethodImpl] get; }

    public extern SpecialPictureAlbumType PictureAlbumType { [MethodImpl] get; }

    [Overload("LoadPropertiesAsync")]
    [MethodImpl]
    public extern IAsyncAction LoadPropertiesAsync();

    [Overload("LoadPropertiesAsyncEx")]
    [MethodImpl]
    public extern IAsyncAction LoadPropertiesAsync(IIterable<string> props);

    [MethodImpl]
    public extern IAsyncAction DeleteAsync(DeleteOption option);

    [MethodImpl]
    public extern IAsyncAction SaveAsync();

    [MethodImpl]
    public extern PictureAlbumQueryResult GetPictureAlbumsQuery(
      StorageLocationFilter storageFilter);

    [MethodImpl]
    public extern EventQueryResult GetEventsQuery();

    [MethodImpl]
    public extern MediaItemQueryResult GetContentsQuery(
      StorageLocationFilter storageFilter);

    [MethodImpl]
    public extern IAsyncAction SetCoverImageInternalAsync(IInputStream pValue);
  }
}
