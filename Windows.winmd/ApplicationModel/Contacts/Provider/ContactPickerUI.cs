// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.Provider.ContactPickerUI
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ContactPickerUI : IContactPickerUI, IContactPickerUI2
  {
    [Deprecated("AddContact may be altered or unavailable for releases after Windows 8.1. Instead, use AddContact without the ID.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern AddContactResult AddContact(string id, Contact contact);

    [MethodImpl]
    public extern void RemoveContact(string id);

    [MethodImpl]
    public extern bool ContainsContact(string id);

    public extern IVectorView<string> DesiredFields { [Deprecated("DesiredFields may be altered or unavailable for releases after Windows 8.1. Instead, use DesiredFieldsWithContactFieldType.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern ContactSelectionMode SelectionMode { [MethodImpl] get; }

    public extern event TypedEventHandler<ContactPickerUI, ContactRemovedEventArgs> ContactRemoved;

    [MethodImpl]
    public extern AddContactResult AddContact(Contact contact);

    public extern IVector<ContactFieldType> DesiredFieldsWithContactFieldType { [MethodImpl] get; }
  }
}
