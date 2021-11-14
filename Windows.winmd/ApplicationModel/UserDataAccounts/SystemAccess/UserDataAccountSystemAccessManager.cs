// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.SystemAccess.UserDataAccountSystemAccessManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts.SystemAccess
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IUserDataAccountSystemAccessManagerStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IUserDataAccountSystemAccessManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class UserDataAccountSystemAccessManager
  {
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction SuppressLocalAccountWithAccountAsync(
      string userDataAccountId);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> CreateDeviceAccountAsync(
      DeviceAccountConfiguration account);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction DeleteDeviceAccountAsync(string accountId);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<DeviceAccountConfiguration> GetDeviceAccountConfigurationAsync(
      string accountId);

    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<string>> AddAndShowDeviceAccountsAsync(
      IIterable<DeviceAccountConfiguration> accounts);
  }
}
