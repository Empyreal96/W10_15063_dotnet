// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IPodcastSeriesQueryResult
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
  [ExclusiveTo(typeof (PodcastSeriesQueryResult))]
  [Guid(1835840441, 19614, 12843, 149, 238, 253, 251, 37, 12, 136, 175)]
  internal interface IPodcastSeriesQueryResult
  {
    IVector<string> FetchProperties { get; }

    IVector<string> FetchExtraProperties { get; }

    IAsyncOperation<uint> GetPodcastSeriesCountAsync();

    [Overload("GetPodcastSeriesAsync")]
    IAsyncOperation<IVector<PodcastSeries>> GetPodcastSeriesAsync();

    [Overload("GetPodcastSeriesAsyncEx")]
    IAsyncOperation<IVector<PodcastSeries>> GetPodcastSeriesAsync(
      int count);

    IAsyncAction MoveLastAsync();

    IAsyncOperation<Buffer> GetBookmarkAsync();

    IAsyncAction MoveToBookmarkAsync(Buffer pPosition);
  }
}
