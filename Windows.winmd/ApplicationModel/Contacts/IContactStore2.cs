// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactStore2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(416160802, 60373, 19451, 182, 144, 95, 79, 39, 196, 240, 232)]
  [ExclusiveTo(typeof (ContactStore))]
  internal interface IContactStore2 : IContactStore
  {
    ContactChangeTracker ChangeTracker { get; }

    event TypedEventHandler<ContactStore, ContactChangedEventArgs> ContactChanged;

    AggregateContactManager AggregateContactManager { get; }

    [RemoteAsync]
    IAsyncOperation<IVectorView<ContactList>> FindContactListsAsync();

    [RemoteAsync]
    IAsyncOperation<ContactList> GetContactListAsync(string contactListId);

    [RemoteAsync]
    [Overload("CreateContactListAsync")]
    IAsyncOperation<ContactList> CreateContactListAsync(string displayName);

    [RemoteAsync]
    IAsyncOperation<Contact> GetMeContactAsync();

    [Overload("GetContactReader")]
    ContactReader GetContactReader();

    [Overload("GetContactReaderWithOptions")]
    ContactReader GetContactReader(ContactQueryOptions options);

    [RemoteAsync]
    [Overload("CreateContactListInAccountAsync")]
    IAsyncOperation<ContactList> CreateContactListAsync(
      string displayName,
      string userDataAccountId);
  }
}
