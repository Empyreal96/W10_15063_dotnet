// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.IPhoneCallHistoryManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [ExclusiveTo(typeof (PhoneCallHistoryManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4121352761, 45855, 20293, 172, 142, 27, 8, 137, 60, 27, 80)]
  internal interface IPhoneCallHistoryManagerStatics
  {
    [RemoteAsync]
    IAsyncOperation<PhoneCallHistoryStore> RequestStoreAsync(
      PhoneCallHistoryStoreAccessType accessType);
  }
}
