// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.IPhoneCallManagerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [ContractVersion(typeof (CallsPhoneContract), 65536)]
  [Guid(3353594044, 9072, 17180, 152, 253, 67, 190, 95, 3, 8, 109)]
  [ExclusiveTo(typeof (PhoneCallManager))]
  internal interface IPhoneCallManagerStatics2
  {
    event EventHandler<object> CallStateChanged;

    bool IsCallActive { get; }

    bool IsCallIncoming { get; }

    void ShowPhoneCallSettingsUI();

    [RemoteAsync]
    IAsyncOperation<PhoneCallStore> RequestStoreAsync();
  }
}
