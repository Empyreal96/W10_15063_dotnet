// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IPictureAlbumQueryResult
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
  [Guid(601409532, 54979, 14092, 130, 133, 0, 100, 84, 183, 183, 244)]
  [ExclusiveTo(typeof (PictureAlbumQueryResult))]
  internal interface IPictureAlbumQueryResult
  {
    IVector<string> FetchProperties { get; }

    IVector<string> FetchExtraProperties { get; }

    IAsyncOperation<uint> GetPictureAlbumCountAsync();

    [Overload("GetPictureAlbumsAsync")]
    IAsyncOperation<IVector<PictureAlbum>> GetPictureAlbumsAsync();

    [Overload("GetPictureAlbumsAsyncEx")]
    IAsyncOperation<IVector<PictureAlbum>> GetPictureAlbumsAsync(
      int count);

    IAsyncAction MoveLastAsync();

    IAsyncOperation<Buffer> GetBookmarkAsync();

    IAsyncAction MoveToBookmarkAsync(Buffer pPosition);
  }
}
