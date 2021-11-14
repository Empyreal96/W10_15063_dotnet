// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.PhoneCallHistoryStore
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class PhoneCallHistoryStore : IPhoneCallHistoryStore
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PhoneCallHistoryEntry> GetEntryAsync(
      string callHistoryEntryId);

    [Overload("GetEntryReader")]
    [MethodImpl]
    public extern PhoneCallHistoryEntryReader GetEntryReader();

    [Overload("GetEntryReaderWithOptions")]
    [MethodImpl]
    public extern PhoneCallHistoryEntryReader GetEntryReader(
      PhoneCallHistoryEntryQueryOptions queryOptions);

    [MethodImpl]
    public extern IAsyncAction SaveEntryAsync(PhoneCallHistoryEntry callHistoryEntry);

    [MethodImpl]
    public extern IAsyncAction DeleteEntryAsync(PhoneCallHistoryEntry callHistoryEntry);

    [MethodImpl]
    public extern IAsyncAction DeleteEntriesAsync(
      IIterable<PhoneCallHistoryEntry> callHistoryEntries);

    [MethodImpl]
    public extern IAsyncAction MarkEntryAsSeenAsync(
      PhoneCallHistoryEntry callHistoryEntry);

    [MethodImpl]
    public extern IAsyncAction MarkEntriesAsSeenAsync(
      IIterable<PhoneCallHistoryEntry> callHistoryEntries);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<uint> GetUnseenCountAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction MarkAllAsSeenAsync();

    [MethodImpl]
    public extern IAsyncOperation<uint> GetSourcesUnseenCountAsync(
      IIterable<string> sourceIds);

    [MethodImpl]
    public extern IAsyncAction MarkSourcesAsSeenAsync(IIterable<string> sourceIds);
  }
}
