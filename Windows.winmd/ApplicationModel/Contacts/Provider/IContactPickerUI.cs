// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.Provider.IContactPickerUI
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts.Provider
{
  [ExclusiveTo(typeof (ContactPickerUI))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3805025126, 53094, 17348, 169, 106, 165, 161, 18, 219, 71, 70)]
  internal interface IContactPickerUI
  {
    [Deprecated("AddContact may be altered or unavailable for releases after Windows 8.1. Instead, use AddContact without the ID.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    AddContactResult AddContact(string id, Contact contact);

    void RemoveContact(string id);

    bool ContainsContact(string id);

    IVectorView<string> DesiredFields { [Deprecated("DesiredFields may be altered or unavailable for releases after Windows 8.1. Instead, use DesiredFieldsWithContactFieldType.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    ContactSelectionMode SelectionMode { get; }

    event TypedEventHandler<ContactPickerUI, ContactRemovedEventArgs> ContactRemoved;
  }
}
