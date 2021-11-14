// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.UserDataAccountStore
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class UserDataAccountStore : 
    IUserDataAccountStore,
    IUserDataAccountStore2,
    IUserDataAccountStore3
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<UserDataAccount>> FindAccountsAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<UserDataAccount> GetAccountAsync(
      string id);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<UserDataAccount> CreateAccountAsync(
      string userDisplayName);

    [RemoteAsync]
    [Overload("CreateAccountWithPackageRelativeAppIdAsync")]
    [MethodImpl]
    public extern IAsyncOperation<UserDataAccount> CreateAccountAsync(
      string userDisplayName,
      string packageRelativeAppId);

    public extern event TypedEventHandler<UserDataAccountStore, UserDataAccountStoreChangedEventArgs> StoreChanged;

    [RemoteAsync]
    [Overload("CreateAccountWithPackageRelativeAppIdAndEnterpriseIdAsync")]
    [MethodImpl]
    public extern IAsyncOperation<UserDataAccount> CreateAccountAsync(
      string userDisplayName,
      string packageRelativeAppId,
      string enterpriseId);
  }
}
