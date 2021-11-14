// Decompiled with JetBrains decompiler
// Type: Windows.Phone.PersonalInformation.IContactAddress
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.PersonalInformation
{
  [ExclusiveTo(typeof (ContactAddress))]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Guid(1596258599, 38057, 17570, 161, 85, 45, 11, 55, 209, 220, 205)]
  internal interface IContactAddress
  {
    string Country { get; set; }

    string Locality { get; set; }

    string Region { get; set; }

    string PostalCode { get; set; }

    string StreetAddress { get; set; }
  }
}
