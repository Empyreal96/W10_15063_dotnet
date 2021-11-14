// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactLocationField
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IContactLocationFieldFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ContactLocationField : IContactLocationField, IContactField
  {
    [MethodImpl]
    public extern ContactLocationField(string unstructuredAddress);

    [MethodImpl]
    public extern ContactLocationField(string unstructuredAddress, ContactFieldCategory category);

    [MethodImpl]
    public extern ContactLocationField(
      string unstructuredAddress,
      ContactFieldCategory category,
      string street,
      string city,
      string region,
      string country,
      string postalCode);

    public extern string UnstructuredAddress { [MethodImpl] get; }

    public extern string Street { [MethodImpl] get; }

    public extern string City { [MethodImpl] get; }

    public extern string Region { [MethodImpl] get; }

    public extern string Country { [MethodImpl] get; }

    public extern string PostalCode { [MethodImpl] get; }

    public extern ContactFieldType Type { [MethodImpl] get; }

    public extern ContactFieldCategory Category { [MethodImpl] get; }

    public extern string Name { [MethodImpl] get; }

    public extern string Value { [MethodImpl] get; }
  }
}
