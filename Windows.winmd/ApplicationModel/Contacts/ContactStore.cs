// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactStore
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ContactStore : IContactStore, IContactStore2
  {
    [Overload("FindContactsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<Contact>> FindContactsAsync();

    [Overload("FindContactsWithSearchTextAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<Contact>> FindContactsAsync(
      string searchText);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<Contact> GetContactAsync(string contactId);

    public extern ContactChangeTracker ChangeTracker { [MethodImpl] get; }

    public extern event TypedEventHandler<ContactStore, ContactChangedEventArgs> ContactChanged;

    public extern AggregateContactManager AggregateContactManager { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ContactList>> FindContactListsAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ContactList> GetContactListAsync(
      string contactListId);

    [RemoteAsync]
    [Overload("CreateContactListAsync")]
    [MethodImpl]
    public extern IAsyncOperation<ContactList> CreateContactListAsync(
      string displayName);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<Contact> GetMeContactAsync();

    [Overload("GetContactReader")]
    [MethodImpl]
    public extern ContactReader GetContactReader();

    [Overload("GetContactReaderWithOptions")]
    [MethodImpl]
    public extern ContactReader GetContactReader(ContactQueryOptions options);

    [Overload("CreateContactListInAccountAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ContactList> CreateContactListAsync(
      string displayName,
      string userDataAccountId);
  }
}
