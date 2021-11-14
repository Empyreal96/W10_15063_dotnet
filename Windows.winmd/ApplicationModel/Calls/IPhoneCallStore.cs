// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.IPhoneCallStore
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [ContractVersion(typeof (CallsPhoneContract), 65536)]
  [ExclusiveTo(typeof (PhoneCallStore))]
  [Guid(1600194376, 6310, 16755, 134, 209, 40, 190, 157, 198, 45, 186)]
  internal interface IPhoneCallStore
  {
    [RemoteAsync]
    IAsyncOperation<bool> IsEmergencyPhoneNumberAsync(string number);

    [RemoteAsync]
    IAsyncOperation<Guid> GetDefaultLineAsync();

    PhoneLineWatcher RequestLineWatcher();
  }
}
