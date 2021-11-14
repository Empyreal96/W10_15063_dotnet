// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactLocationFieldFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(4154012375, 12255, 17406, 143, 24, 65, 137, 115, 144, 188, 254)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IContactLocationFieldFactory
  {
    [Overload("CreateLocation_Default")]
    ContactLocationField CreateLocation(string unstructuredAddress);

    [Overload("CreateLocation_Category")]
    ContactLocationField CreateLocation(
      string unstructuredAddress,
      ContactFieldCategory category);

    [Overload("CreateLocation_All")]
    ContactLocationField CreateLocation(
      string unstructuredAddress,
      ContactFieldCategory category,
      string street,
      string city,
      string region,
      string country,
      string postalCode);
  }
}
