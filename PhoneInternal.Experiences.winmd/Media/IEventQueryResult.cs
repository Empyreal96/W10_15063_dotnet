// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IEventQueryResult
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
  [Guid(1080595615, 28362, 15191, 151, 2, 226, 232, 64, 208, 173, 253)]
  [ExclusiveTo(typeof (EventQueryResult))]
  internal interface IEventQueryResult
  {
    IVector<string> FetchProperties { get; }

    IVector<string> FetchExtraProperties { get; }

    IAsyncOperation<uint> GetEventsCountAsync();

    [Overload("GetEventsAsync")]
    IAsyncOperation<IVector<Event>> GetEventsAsync();

    [Overload("GetEventsAsyncEx")]
    IAsyncOperation<IVector<Event>> GetEventsAsync(int count);

    IAsyncAction MoveLastAsync();

    IAsyncOperation<Buffer> GetBookmarkAsync();

    IAsyncAction MoveToBookmarkAsync(Buffer pPosition);
  }
}
