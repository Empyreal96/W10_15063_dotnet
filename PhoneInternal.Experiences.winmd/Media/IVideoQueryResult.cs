// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IVideoQueryResult
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
  [ExclusiveTo(typeof (VideoQueryResult))]
  [Guid(2843952721, 42664, 13293, 159, 102, 62, 30, 86, 45, 63, 202)]
  internal interface IVideoQueryResult
  {
    IVector<string> FetchProperties { get; }

    IVector<string> FetchExtraProperties { get; }

    IAsyncOperation<uint> GetVideoCountAsync();

    [Overload("GetVideosAsync")]
    IAsyncOperation<IVector<Video>> GetVideosAsync();

    [Overload("GetVideosAsyncEx")]
    IAsyncOperation<IVector<Video>> GetVideosAsync(int count);

    IAsyncAction MoveLastAsync();

    IAsyncOperation<Buffer> GetBookmarkAsync();

    IAsyncAction MoveToBookmarkAsync(Buffer pPosition);
  }
}
