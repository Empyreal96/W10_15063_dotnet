// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.IUserDataAccountStore2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts
{
  [Guid(2984292087, 38240, 17969, 138, 240, 6, 29, 48, 22, 20, 105)]
  [ExclusiveTo(typeof (UserDataAccountStore))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IUserDataAccountStore2 : IUserDataAccountStore
  {
    [Overload("CreateAccountWithPackageRelativeAppIdAsync")]
    [RemoteAsync]
    IAsyncOperation<UserDataAccount> CreateAccountAsync(
      string userDisplayName,
      string packageRelativeAppId);

    event TypedEventHandler<UserDataAccountStore, UserDataAccountStoreChangedEventArgs> StoreChanged;
  }
}
