// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.IUserDataAccountManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UserDataAccountManager))]
  [Guid(228297194, 6440, 18976, 134, 213, 60, 115, 127, 125, 195, 176)]
  internal interface IUserDataAccountManagerStatics
  {
    [RemoteAsync]
    IAsyncOperation<UserDataAccountStore> RequestStoreAsync(
      UserDataAccountStoreAccessType storeAccessType);

    [RemoteAsync]
    IAsyncOperation<string> ShowAddAccountAsync(
      UserDataAccountContentKinds contentKinds);

    [RemoteAsync]
    IAsyncAction ShowAccountSettingsAsync(string id);

    [RemoteAsync]
    IAsyncAction ShowAccountErrorResolverAsync(string id);
  }
}
