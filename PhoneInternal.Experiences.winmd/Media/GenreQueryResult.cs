// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.GenreQueryResult
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
  public sealed class GenreQueryResult : IGenreQueryResult
  {
    [MethodImpl]
    public extern IAsyncOperation<uint> GetGenreCountAsync();

    [Overload("GetGenresAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVector<Genre>> GetGenresAsync();

    [Overload("GetGenresAsyncEx")]
    [MethodImpl]
    public extern IAsyncOperation<IVector<Genre>> GetGenresAsync(
      int count);

    [MethodImpl]
    public extern IAsyncAction MoveLastAsync();

    [MethodImpl]
    public extern IAsyncOperation<Buffer> GetBookmarkAsync();

    [MethodImpl]
    public extern IAsyncAction MoveToBookmarkAsync(Buffer pPosition);
  }
}
