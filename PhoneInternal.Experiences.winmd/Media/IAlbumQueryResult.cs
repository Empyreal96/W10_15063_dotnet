// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IAlbumQueryResult
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace PhoneInternal.Experiences.Media
{
  [Version(100859904)]
  [ExclusiveTo(typeof (AlbumQueryResult))]
  [Guid(1301940730, 28846, 12824, 157, 187, 179, 33, 253, 246, 142, 193)]
  internal interface IAlbumQueryResult
  {
    IVector<string> FetchProperties { get; }

    IVector<string> FetchExtraProperties { get; }

    IAsyncOperation<uint> GetAlbumCountAsync();

    [Overload("GetAlbumsAsync")]
    IAsyncOperation<IVector<Album>> GetAlbumsAsync();

    [Overload("GetAlbumsAsyncEx")]
    IAsyncOperation<IVector<Album>> GetAlbumsAsync(int count);

    IAsyncAction MoveLastAsync();

    IAsyncOperation<IVector<short>> GetSortGroupsAsync();

    AlbumQueryResult GetSortGroupQuery(short groupId);

    IAsyncOperation<Buffer> GetBookmarkAsync();

    IAsyncAction MoveToBookmarkAsync(Buffer pPosition);
  }
}
