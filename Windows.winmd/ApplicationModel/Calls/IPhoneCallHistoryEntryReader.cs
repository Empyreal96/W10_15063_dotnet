// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.IPhoneCallHistoryEntryReader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [Guid(1642915006, 36230, 18335, 132, 4, 169, 132, 105, 32, 254, 230)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PhoneCallHistoryEntryReader))]
  internal interface IPhoneCallHistoryEntryReader
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<PhoneCallHistoryEntry>> ReadBatchAsync();
  }
}
