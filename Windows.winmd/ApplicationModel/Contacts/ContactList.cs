// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactList
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ContactList : IContactList, IContactList2
  {
    public extern string Id { [MethodImpl] get; }

    public extern string DisplayName { [MethodImpl] get; [MethodImpl] set; }

    public extern string SourceDisplayName { [MethodImpl] get; }

    public extern bool IsHidden { [MethodImpl] get; [MethodImpl] set; }

    public extern ContactListOtherAppReadAccess OtherAppReadAccess { [MethodImpl] get; [MethodImpl] set; }

    public extern ContactListOtherAppWriteAccess OtherAppWriteAccess { [MethodImpl] get; [MethodImpl] set; }

    public extern ContactChangeTracker ChangeTracker { [MethodImpl] get; }

    public extern ContactListSyncManager SyncManager { [MethodImpl] get; }

    public extern bool SupportsServerSearch { [MethodImpl] get; [MethodImpl] set; }

    public extern string UserDataAccountId { [MethodImpl] get; }

    public extern event TypedEventHandler<ContactList, ContactChangedEventArgs> ContactChanged;

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SaveAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<Contact> GetContactFromRemoteIdAsync(
      string remoteId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<Contact> GetMeContactAsync();

    [Overload("GetContactReader")]
    [MethodImpl]
    public extern ContactReader GetContactReader();

    [Overload("GetContactReaderWithOptions")]
    [MethodImpl]
    public extern ContactReader GetContactReader(ContactQueryOptions options);

    [MethodImpl]
    public extern IAsyncAction SaveContactAsync(Contact contact);

    [MethodImpl]
    public extern IAsyncAction DeleteContactAsync(Contact contact);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<Contact> GetContactAsync(string contactId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RegisterSyncManagerAsync();

    public extern ContactListSyncConstraints SyncConstraints { [MethodImpl] get; }
  }
}
