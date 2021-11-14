// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.IPhoneCallHistoryStore
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [Guid(797998520, 46094, 16939, 133, 69, 203, 25, 16, 166, 28, 82)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PhoneCallHistoryStore))]
  internal interface IPhoneCallHistoryStore
  {
    [RemoteAsync]
    IAsyncOperation<PhoneCallHistoryEntry> GetEntryAsync(
      string callHistoryEntryId);

    [Overload("GetEntryReader")]
    PhoneCallHistoryEntryReader GetEntryReader();

    [Overload("GetEntryReaderWithOptions")]
    PhoneCallHistoryEntryReader GetEntryReader(
      PhoneCallHistoryEntryQueryOptions queryOptions);

    IAsyncAction SaveEntryAsync(PhoneCallHistoryEntry callHistoryEntry);

    IAsyncAction DeleteEntryAsync(PhoneCallHistoryEntry callHistoryEntry);

    IAsyncAction DeleteEntriesAsync(
      IIterable<PhoneCallHistoryEntry> callHistoryEntries);

    IAsyncAction MarkEntryAsSeenAsync(PhoneCallHistoryEntry callHistoryEntry);

    IAsyncAction MarkEntriesAsSeenAsync(
      IIterable<PhoneCallHistoryEntry> callHistoryEntries);

    [RemoteAsync]
    IAsyncOperation<uint> GetUnseenCountAsync();

    [RemoteAsync]
    IAsyncAction MarkAllAsSeenAsync();

    IAsyncOperation<uint> GetSourcesUnseenCountAsync(IIterable<string> sourceIds);

    IAsyncAction MarkSourcesAsSeenAsync(IIterable<string> sourceIds);
  }
}
