// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.IPhoneCallHistoryManagerForUser
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Calls
{
  [Guid(3643131171, 62815, 17235, 157, 180, 2, 5, 165, 38, 90, 85)]
  [ExclusiveTo(typeof (PhoneCallHistoryManagerForUser))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IPhoneCallHistoryManagerForUser
  {
    [RemoteAsync]
    IAsyncOperation<PhoneCallHistoryStore> RequestStoreAsync(
      PhoneCallHistoryStoreAccessType accessType);

    User User { get; }
  }
}
