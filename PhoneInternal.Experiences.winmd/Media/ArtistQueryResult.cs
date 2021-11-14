// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.ArtistQueryResult
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
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ArtistQueryResult : IArtistQueryResult
  {
    public extern IVector<string> FetchProperties { [MethodImpl] get; }

    public extern IVector<string> FetchExtraProperties { [MethodImpl] get; }

    [MethodImpl]
    public extern IAsyncOperation<uint> GetArtistCountAsync();

    [Overload("GetArtistsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVector<Artist>> GetArtistsAsync();

    [Overload("GetArtistsAsyncEx")]
    [MethodImpl]
    public extern IAsyncOperation<IVector<Artist>> GetArtistsAsync(
      int count);

    [MethodImpl]
    public extern IAsyncAction MoveLastAsync();

    [MethodImpl]
    public extern IAsyncOperation<IVector<short>> GetSortGroupsAsync();

    [MethodImpl]
    public extern ArtistQueryResult GetSortGroupQuery(short groupId);

    [MethodImpl]
    public extern IAsyncOperation<Buffer> GetBookmarkAsync();

    [MethodImpl]
    public extern IAsyncAction MoveToBookmarkAsync(Buffer pPosition);
  }
}
