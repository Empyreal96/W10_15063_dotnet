// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.IUserDataAccountManagerForUser
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.UserDataAccounts
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1453779163, 56207, 16811, 166, 95, 140, 89, 113, 170, 201, 130)]
  [ExclusiveTo(typeof (UserDataAccountManagerForUser))]
  internal interface IUserDataAccountManagerForUser
  {
    [RemoteAsync]
    IAsyncOperation<UserDataAccountStore> RequestStoreAsync(
      UserDataAccountStoreAccessType storeAccessType);

    User User { get; }
  }
}
