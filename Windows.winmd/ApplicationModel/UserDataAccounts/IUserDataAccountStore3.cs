// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.IUserDataAccountStore3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (UserDataAccountStore))]
  [Guid(2168635540, 62409, 18315, 177, 23, 101, 133, 190, 187, 103, 137)]
  internal interface IUserDataAccountStore3 : IUserDataAccountStore
  {
    [Overload("CreateAccountWithPackageRelativeAppIdAndEnterpriseIdAsync")]
    [RemoteAsync]
    IAsyncOperation<UserDataAccount> CreateAccountAsync(
      string userDisplayName,
      string packageRelativeAppId,
      string enterpriseId);
  }
}
