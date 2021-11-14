// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactPicker2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactPicker))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3008369103, 23791, 19748, 170, 12, 52, 12, 82, 8, 114, 93)]
  internal interface IContactPicker2
  {
    IVector<ContactFieldType> DesiredFieldsWithContactFieldType { get; }

    IAsyncOperation<Contact> PickContactAsync();

    IAsyncOperation<IVector<Contact>> PickContactsAsync();
  }
}
