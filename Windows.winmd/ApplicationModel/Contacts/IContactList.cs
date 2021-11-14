// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactList
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContactList))]
  [Guid(383642741, 14636, 18501, 157, 251, 81, 163, 231, 239, 62, 66)]
  internal interface IContactList
  {
    string Id { get; }

    string DisplayName { get; set; }

    string SourceDisplayName { get; }

    bool IsHidden { get; set; }

    ContactListOtherAppReadAccess OtherAppReadAccess { get; set; }

    ContactListOtherAppWriteAccess OtherAppWriteAccess { get; set; }

    ContactChangeTracker ChangeTracker { get; }

    ContactListSyncManager SyncManager { get; }

    bool SupportsServerSearch { get; }

    string UserDataAccountId { get; }

    event TypedEventHandler<ContactList, ContactChangedEventArgs> ContactChanged;

    [RemoteAsync]
    IAsyncAction SaveAsync();

    [RemoteAsync]
    IAsyncAction DeleteAsync();

    [RemoteAsync]
    IAsyncOperation<Contact> GetContactFromRemoteIdAsync(string remoteId);

    [RemoteAsync]
    IAsyncOperation<Contact> GetMeContactAsync();

    [Overload("GetContactReader")]
    ContactReader GetContactReader();

    [Overload("GetContactReaderWithOptions")]
    ContactReader GetContactReader(ContactQueryOptions options);

    IAsyncAction SaveContactAsync(Contact contact);

    IAsyncAction DeleteContactAsync(Contact contact);

    [RemoteAsync]
    IAsyncOperation<Contact> GetContactAsync(string contactId);
  }
}
