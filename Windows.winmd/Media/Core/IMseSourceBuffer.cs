// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMseSourceBuffer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (MseSourceBuffer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(203072483, 57229, 16505, 163, 254, 104, 73, 24, 75, 78, 47)]
  internal interface IMseSourceBuffer
  {
    event TypedEventHandler<MseSourceBuffer, object> UpdateStarting;

    event TypedEventHandler<MseSourceBuffer, object> Updated;

    event TypedEventHandler<MseSourceBuffer, object> UpdateEnded;

    event TypedEventHandler<MseSourceBuffer, object> ErrorOccurred;

    event TypedEventHandler<MseSourceBuffer, object> Aborted;

    MseAppendMode Mode { get; set; }

    bool IsUpdating { get; }

    IVectorView<MseTimeRange> Buffered { get; }

    TimeSpan TimestampOffset { get; set; }

    TimeSpan AppendWindowStart { get; set; }

    IReference<TimeSpan> AppendWindowEnd { get; set; }

    void AppendBuffer(IBuffer buffer);

    [Overload("AppendStream")]
    void AppendStream(IInputStream stream);

    [Overload("AppendStreamMaxSize")]
    void AppendStream(IInputStream stream, ulong maxSize);

    void Abort();

    void Remove(TimeSpan start, IReference<TimeSpan> end);
  }
}
