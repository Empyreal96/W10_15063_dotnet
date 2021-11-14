// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Sync.IAccountsManagerStatics
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace PhoneInternal.Experiences.Sync
{
  [Version(100859904)]
  [Guid(682148860, 30094, 19139, 190, 113, 116, 97, 162, 165, 37, 188)]
  [ExclusiveTo(typeof (AccountsManager))]
  internal interface IAccountsManagerStatics
  {
    IAsyncOperation<Account> CreateAccountAsync(
      AccountType type,
      PropertySet props);

    IAsyncOperation<IVector<Account>> GetAccountsAsync();

    IAsyncOperation<IVector<Account>> GetAccountsWithFilterAsync(
      AccountQueryFilter filter);

    IAsyncOperation<Account> GetAccountAsync(Guid accountId);

    IAsyncOperation<Account> GetAccountByUserDataAccountIdAsync(
      string userDataAccountId);

    IVector<PartnershipType> GetPartnershipTypes(
      AccountSyncContentType accountSyncContentType);

    IVector<AccountSyncContentType> GetSupportedContentTypes(
      PartnershipType partnershipType);

    Account TryGetExistingAccount(PartnershipType partnershipType, string email);

    WebAuthSettings GetWebAuthSettings(PartnershipType partnershipType);

    IAsyncOperation<IVectorView<Certificate>> GetClientAuthenticationCertificatesAsync();

    bool IsMsaEasi(string msaUsername);

    IAsyncOperation<string> ConvertWebAccountIdFromAppSpecificIdAsync(
      PartnershipType partnershipType,
      string appId);

    IAsyncOperation<string> ConvertWebAccountIdToAppSpecificIdAsync(
      PartnershipType partnershipType,
      string realId);

    event TypedEventHandler<object, AccountChangedEventArgs> AccountChangedEvent;
  }
}
