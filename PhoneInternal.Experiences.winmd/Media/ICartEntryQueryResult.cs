// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.ICartEntryQueryResult
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
  [Guid(2709610776, 13492, 19387, 180, 157, 209, 153, 23, 106, 25, 157)]
  [ExclusiveTo(typeof (CartEntryQueryResult))]
  internal interface ICartEntryQueryResult
  {
    IVector<string> FetchProperties { get; }

    IVector<string> FetchExtraProperties { get; }

    IAsyncOperation<uint> GetCartEntriesCountAsync();

    [Overload("GetCartEntriesAsync")]
    IAsyncOperation<IVector<CartEntry>> GetCartEntriesAsync();

    [Overload("GetCartEntriesAsyncEx")]
    IAsyncOperation<IVector<CartEntry>> GetCartEntriesAsync(int count);

    IAsyncAction MoveLastAsync();

    IAsyncOperation<Buffer> GetBookmarkAsync();

    IAsyncAction MoveToBookmarkAsync(Buffer pPosition);
  }
}
