// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.UserDataAccountManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.UserDataAccounts
{
  [Static(typeof (IUserDataAccountManagerStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IUserDataAccountManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class UserDataAccountManager
  {
    [MethodImpl]
    public static extern UserDataAccountManagerForUser GetForUser(
      User user);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<UserDataAccountStore> RequestStoreAsync(
      UserDataAccountStoreAccessType storeAccessType);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> ShowAddAccountAsync(
      UserDataAccountContentKinds contentKinds);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction ShowAccountSettingsAsync(string id);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction ShowAccountErrorResolverAsync(string id);
  }
}
