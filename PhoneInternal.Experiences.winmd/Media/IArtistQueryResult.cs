// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IArtistQueryResult
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace PhoneInternal.Experiences.Media
{
  [Guid(3935614563, 39647, 13254, 145, 9, 36, 91, 36, 26, 17, 21)]
  [Version(100859904)]
  [ExclusiveTo(typeof (ArtistQueryResult))]
  internal interface IArtistQueryResult
  {
    IVector<string> FetchProperties { get; }

    IVector<string> FetchExtraProperties { get; }

    IAsyncOperation<uint> GetArtistCountAsync();

    [Overload("GetArtistsAsync")]
    IAsyncOperation<IVector<Artist>> GetArtistsAsync();

    [Overload("GetArtistsAsyncEx")]
    IAsyncOperation<IVector<Artist>> GetArtistsAsync(int count);

    IAsyncAction MoveLastAsync();

    IAsyncOperation<IVector<short>> GetSortGroupsAsync();

    ArtistQueryResult GetSortGroupQuery(short groupId);

    IAsyncOperation<Buffer> GetBookmarkAsync();

    IAsyncAction MoveToBookmarkAsync(Buffer pPosition);
  }
}
