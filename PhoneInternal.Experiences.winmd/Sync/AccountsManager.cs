// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Sync.AccountsManager
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace PhoneInternal.Experiences.Sync
{
  [Threading(ThreadingModel.Both)]
  [Version(100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IAccountsManagerStatics), 100859904)]
  public static class AccountsManager
  {
    [MethodImpl]
    public static extern IAsyncOperation<Account> CreateAccountAsync(
      AccountType type,
      PropertySet props);

    [MethodImpl]
    public static extern IAsyncOperation<IVector<Account>> GetAccountsAsync();

    [MethodImpl]
    public static extern IAsyncOperation<IVector<Account>> GetAccountsWithFilterAsync(
      AccountQueryFilter filter);

    [MethodImpl]
    public static extern IAsyncOperation<Account> GetAccountAsync(
      Guid accountId);

    [MethodImpl]
    public static extern IAsyncOperation<Account> GetAccountByUserDataAccountIdAsync(
      string userDataAccountId);

    [MethodImpl]
    public static extern IVector<PartnershipType> GetPartnershipTypes(
      AccountSyncContentType accountSyncContentType);

    [MethodImpl]
    public static extern IVector<AccountSyncContentType> GetSupportedContentTypes(
      PartnershipType partnershipType);

    [MethodImpl]
    public static extern Account TryGetExistingAccount(
      PartnershipType partnershipType,
      string email);

    [MethodImpl]
    public static extern WebAuthSettings GetWebAuthSettings(
      PartnershipType partnershipType);

    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<Certificate>> GetClientAuthenticationCertificatesAsync();

    [MethodImpl]
    public static extern bool IsMsaEasi(string msaUsername);

    [MethodImpl]
    public static extern IAsyncOperation<string> ConvertWebAccountIdFromAppSpecificIdAsync(
      PartnershipType partnershipType,
      string appId);

    [MethodImpl]
    public static extern IAsyncOperation<string> ConvertWebAccountIdToAppSpecificIdAsync(
      PartnershipType partnershipType,
      string realId);

    public static extern event TypedEventHandler<object, AccountChangedEventArgs> AccountChangedEvent;
  }
}
