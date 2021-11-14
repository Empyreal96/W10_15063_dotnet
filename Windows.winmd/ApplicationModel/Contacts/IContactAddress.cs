// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactAddress
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2537149338, 17102, 18546, 141, 112, 48, 99, 170, 88, 75, 112)]
  [ExclusiveTo(typeof (ContactAddress))]
  internal interface IContactAddress
  {
    string StreetAddress { get; set; }

    string Locality { get; set; }

    string Region { get; set; }

    string Country { get; set; }

    string PostalCode { get; set; }

    ContactAddressKind Kind { get; set; }

    string Description { get; set; }
  }
}
