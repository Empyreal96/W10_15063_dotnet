// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.Provider.IContactPickerUI2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts.Provider
{
  [ExclusiveTo(typeof (ContactPickerUI))]
  [Guid(1849990696, 31525, 18841, 155, 11, 135, 84, 0, 161, 232, 200)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContactPickerUI2
  {
    AddContactResult AddContact(Contact contact);

    IVector<ContactFieldType> DesiredFieldsWithContactFieldType { get; }
  }
}
