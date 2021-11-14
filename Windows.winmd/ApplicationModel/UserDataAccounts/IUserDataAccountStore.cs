// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.IUserDataAccountStore
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts
{
  [Guid(544452781, 32010, 20086, 191, 69, 35, 104, 249, 120, 165, 154)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UserDataAccountStore))]
  internal interface IUserDataAccountStore
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<UserDataAccount>> FindAccountsAsync();

    [RemoteAsync]
    IAsyncOperation<UserDataAccount> GetAccountAsync(string id);

    [RemoteAsync]
    IAsyncOperation<UserDataAccount> CreateAccountAsync(
      string userDisplayName);
  }
}
