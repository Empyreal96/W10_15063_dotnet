// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MseSourceBuffer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Core
{
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MseSourceBuffer : IMseSourceBuffer
  {
    public extern event TypedEventHandler<MseSourceBuffer, object> UpdateStarting;

    public extern event TypedEventHandler<MseSourceBuffer, object> Updated;

    public extern event TypedEventHandler<MseSourceBuffer, object> UpdateEnded;

    public extern event TypedEventHandler<MseSourceBuffer, object> ErrorOccurred;

    public extern event TypedEventHandler<MseSourceBuffer, object> Aborted;

    public extern MseAppendMode Mode { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsUpdating { [MethodImpl] get; }

    public extern IVectorView<MseTimeRange> Buffered { [MethodImpl] get; }

    public extern TimeSpan TimestampOffset { [MethodImpl] get; [MethodImpl] set; }

    public extern TimeSpan AppendWindowStart { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<TimeSpan> AppendWindowEnd { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void AppendBuffer(IBuffer buffer);

    [Overload("AppendStream")]
    [MethodImpl]
    public extern void AppendStream(IInputStream stream);

    [Overload("AppendStreamMaxSize")]
    [MethodImpl]
    public extern void AppendStream(IInputStream stream, ulong maxSize);

    [MethodImpl]
    public extern void Abort();

    [MethodImpl]
    public extern void Remove(TimeSpan start, IReference<TimeSpan> end);
  }
}
