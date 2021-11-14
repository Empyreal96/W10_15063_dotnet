// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IMediaItemQueryResult
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
  [Guid(3901258864, 34119, 14746, 169, 125, 230, 91, 37, 255, 99, 223)]
  [ExclusiveTo(typeof (MediaItemQueryResult))]
  internal interface IMediaItemQueryResult
  {
    IVector<string> FetchProperties { get; }

    IVector<string> FetchExtraProperties { get; }

    IAsyncOperation<uint> GetItemCountAsync();

    [Overload("GetItemsAsync")]
    IAsyncOperation<IVector<IMediaItem>> GetItemsAsync();

    [Overload("GetItemsAsyncEx")]
    IAsyncOperation<IVector<IMediaItem>> GetItemsAsync(int count);

    IAsyncAction MoveLastAsync();

    IAsyncOperation<Buffer> GetBookmarkAsync();

    IAsyncAction MoveToBookmarkAsync(Buffer pPosition);
  }
}
