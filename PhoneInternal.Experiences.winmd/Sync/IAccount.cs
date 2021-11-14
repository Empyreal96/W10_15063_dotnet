// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Sync.IAccount
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Sync
{
  [Guid(1775106031, 32980, 17791, 155, 167, 227, 57, 201, 11, 103, 53)]
  [ExclusiveTo(typeof (Account))]
  [Version(100859904)]
  internal interface IAccount
  {
    Guid Id { get; }

    string PublicId { get; }

    string Name { get; set; }

    string Icon { get; set; }

    string EmailAddress { get; set; }

    string Password { get; set; }

    AccountType Type { get; }

    PartnershipType PartnershipType { get; }

    Guid PartnershipTypePublicId { get; }

    IAsyncOperation<IVector<string>> GetTrustedIssuersAsync();

    IAsyncOperation<IVector<string>> GetAllEmailsAsync();

    IAsyncOperation<AccountErrorInformation> GetAccountErrorInformationAsync();

    IAsyncOperation<AccountSyncScheduleInformation> GetAccountSyncScheduleInformationAsync();

    IAsyncAction LoadPropertiesAsync(IIterable<string> propIds);

    PropertySet GetProperties(IIterable<string> propIds);

    void SetProperties(PropertySet props);

    IAsyncOperation<AccountStatus> GetStatusAsync();

    IAsyncOperation<string> GetStatusDescriptionAsync(string resourceQualifier);

    IAsyncAction SetStatusAsync(AccountStatus status);

    IAsyncAction SyncAccountAsync();

    IAsyncAction SyncAccountAndWaitForCompletionAsync();

    IAsyncAction DeleteAccountAsync();

    IAsyncAction SaveAsync();

    event TypedEventHandler<object, AccountChangedEventArgs> AccountChangedEvent;
  }
}
