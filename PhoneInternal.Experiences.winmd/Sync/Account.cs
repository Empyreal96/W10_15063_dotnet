// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Sync.Account
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Sync
{
  [Version(100859904)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class Account : IAccount
  {
    public extern Guid Id { [MethodImpl] get; }

    public extern string PublicId { [MethodImpl] get; }

    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    public extern string Icon { [MethodImpl] get; [MethodImpl] set; }

    public extern string EmailAddress { [MethodImpl] get; [MethodImpl] set; }

    public extern string Password { [MethodImpl] get; [MethodImpl] set; }

    public extern AccountType Type { [MethodImpl] get; }

    public extern PartnershipType PartnershipType { [MethodImpl] get; }

    public extern Guid PartnershipTypePublicId { [MethodImpl] get; }

    [MethodImpl]
    public extern IAsyncOperation<IVector<string>> GetTrustedIssuersAsync();

    [MethodImpl]
    public extern IAsyncOperation<IVector<string>> GetAllEmailsAsync();

    [MethodImpl]
    public extern IAsyncOperation<AccountErrorInformation> GetAccountErrorInformationAsync();

    [MethodImpl]
    public extern IAsyncOperation<AccountSyncScheduleInformation> GetAccountSyncScheduleInformationAsync();

    [MethodImpl]
    public extern IAsyncAction LoadPropertiesAsync(IIterable<string> propIds);

    [MethodImpl]
    public extern PropertySet GetProperties(IIterable<string> propIds);

    [MethodImpl]
    public extern void SetProperties(PropertySet props);

    [MethodImpl]
    public extern IAsyncOperation<AccountStatus> GetStatusAsync();

    [MethodImpl]
    public extern IAsyncOperation<string> GetStatusDescriptionAsync(
      string resourceQualifier);

    [MethodImpl]
    public extern IAsyncAction SetStatusAsync(AccountStatus status);

    [MethodImpl]
    public extern IAsyncAction SyncAccountAsync();

    [MethodImpl]
    public extern IAsyncAction SyncAccountAndWaitForCompletionAsync();

    [MethodImpl]
    public extern IAsyncAction DeleteAccountAsync();

    [MethodImpl]
    public extern IAsyncAction SaveAsync();

    public extern event TypedEventHandler<object, AccountChangedEventArgs> AccountChangedEvent;
  }
}
