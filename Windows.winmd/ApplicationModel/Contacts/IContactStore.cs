// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactStore
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(740428560, 14956, 17043, 185, 188, 254, 152, 127, 110, 13, 82)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContactStore))]
  internal interface IContactStore
  {
    [Overload("FindContactsAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<Contact>> FindContactsAsync();

    [Overload("FindContactsWithSearchTextAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<Contact>> FindContactsAsync(
      string searchText);

    [RemoteAsync]
    IAsyncOperation<Contact> GetContactAsync(string contactId);
  }
}
