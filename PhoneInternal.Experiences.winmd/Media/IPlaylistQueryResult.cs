// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IPlaylistQueryResult
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace PhoneInternal.Experiences.Media
{
  [ExclusiveTo(typeof (PlaylistQueryResult))]
  [Guid(1244712779, 13355, 13425, 185, 150, 164, 123, 185, 229, 174, 127)]
  [Version(100859904)]
  internal interface IPlaylistQueryResult
  {
    IAsyncOperation<uint> GetPlaylistCountAsync();

    [Overload("GetPlaylistsAsync")]
    IAsyncOperation<IVector<Playlist>> GetPlaylistsAsync();

    [Overload("GetPlaylistsAsyncEx")]
    IAsyncOperation<IVector<Playlist>> GetPlaylistsAsync(int count);

    IAsyncAction MoveLastAsync();

    IAsyncOperation<Buffer> GetBookmarkAsync();

    IAsyncAction MoveToBookmarkAsync(Buffer pPosition);
  }
}
