// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.EventQueryResult
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
  [MarshalingBehavior(MarshalingType.Agile)]
  [Version(100859904)]
  [Threading(ThreadingModel.Both)]
  public sealed class EventQueryResult : IEventQueryResult
  {
    public extern IVector<string> FetchProperties { [MethodImpl] get; }

    public extern IVector<string> FetchExtraProperties { [MethodImpl] get; }

    [MethodImpl]
    public extern IAsyncOperation<uint> GetEventsCountAsync();

    [Overload("GetEventsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVector<Event>> GetEventsAsync();

    [Overload("GetEventsAsyncEx")]
    [MethodImpl]
    public extern IAsyncOperation<IVector<Event>> GetEventsAsync(
      int count);

    [MethodImpl]
    public extern IAsyncAction MoveLastAsync();

    [MethodImpl]
    public extern IAsyncOperation<Buffer> GetBookmarkAsync();

    [MethodImpl]
    public extern IAsyncAction MoveToBookmarkAsync(Buffer pPosition);
  }
}
