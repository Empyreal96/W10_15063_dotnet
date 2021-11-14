// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.SystemAccess.IUserDataAccountSystemAccessManagerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts.SystemAccess
{
  [ExclusiveTo(typeof (UserDataAccountSystemAccessManager))]
  [Guid(2487190861, 19278, 17311, 131, 211, 151, 155, 39, 192, 90, 199)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IUserDataAccountSystemAccessManagerStatics2
  {
    [RemoteAsync]
    IAsyncAction SuppressLocalAccountWithAccountAsync(string userDataAccountId);

    [RemoteAsync]
    IAsyncOperation<string> CreateDeviceAccountAsync(
      DeviceAccountConfiguration account);

    [RemoteAsync]
    IAsyncAction DeleteDeviceAccountAsync(string accountId);

    [RemoteAsync]
    IAsyncOperation<DeviceAccountConfiguration> GetDeviceAccountConfigurationAsync(
      string accountId);
  }
}
