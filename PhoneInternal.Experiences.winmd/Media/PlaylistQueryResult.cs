// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.PlaylistQueryResult
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
  [Threading(ThreadingModel.Both)]
  [Version(100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PlaylistQueryResult : IPlaylistQueryResult
  {
    [MethodImpl]
    public extern IAsyncOperation<uint> GetPlaylistCountAsync();

    [Overload("GetPlaylistsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVector<Playlist>> GetPlaylistsAsync();

    [Overload("GetPlaylistsAsyncEx")]
    [MethodImpl]
    public extern IAsyncOperation<IVector<Playlist>> GetPlaylistsAsync(
      int count);

    [MethodImpl]
    public extern IAsyncAction MoveLastAsync();

    [MethodImpl]
    public extern IAsyncOperation<Buffer> GetBookmarkAsync();

    [MethodImpl]
    public extern IAsyncAction MoveToBookmarkAsync(Buffer pPosition);
  }
}
