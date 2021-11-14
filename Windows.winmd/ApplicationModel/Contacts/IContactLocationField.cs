// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactLocationField
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(2663387010, 43886, 19254, 137, 227, 178, 59, 192, 161, 218, 204)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContactLocationField))]
  internal interface IContactLocationField : IContactField
  {
    string UnstructuredAddress { get; }

    string Street { get; }

    string City { get; }

    string Region { get; }

    string Country { get; }

    string PostalCode { get; }
  }
}
