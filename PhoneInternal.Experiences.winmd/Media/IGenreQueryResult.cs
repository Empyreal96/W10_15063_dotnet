// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IGenreQueryResult
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace PhoneInternal.Experiences.Media
{
  [Guid(995365830, 37069, 12727, 166, 240, 93, 14, 92, 195, 237, 204)]
  [ExclusiveTo(typeof (GenreQueryResult))]
  [Version(100859904)]
  internal interface IGenreQueryResult
  {
    IAsyncOperation<uint> GetGenreCountAsync();

    [Overload("GetGenresAsync")]
    IAsyncOperation<IVector<Genre>> GetGenresAsync();

    [Overload("GetGenresAsyncEx")]
    IAsyncOperation<IVector<Genre>> GetGenresAsync(int count);

    IAsyncAction MoveLastAsync();

    IAsyncOperation<Buffer> GetBookmarkAsync();

    IAsyncAction MoveToBookmarkAsync(Buffer pPosition);
  }
}
