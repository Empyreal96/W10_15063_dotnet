// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactFieldFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ContactFieldFactory : 
    IContactFieldFactory,
    IContactLocationFieldFactory,
    IContactInstantMessageFieldFactory
  {
    [MethodImpl]
    public extern ContactFieldFactory();

    [Overload("CreateField_Default")]
    [MethodImpl]
    public extern ContactField CreateField(string value, ContactFieldType type);

    [Overload("CreateField_Category")]
    [MethodImpl]
    public extern ContactField CreateField(
      string value,
      ContactFieldType type,
      ContactFieldCategory category);

    [Overload("CreateField_Custom")]
    [MethodImpl]
    public extern ContactField CreateField(
      string name,
      string value,
      ContactFieldType type,
      ContactFieldCategory category);

    [Overload("CreateLocation_Default")]
    [MethodImpl]
    public extern ContactLocationField CreateLocation(string unstructuredAddress);

    [Overload("CreateLocation_Category")]
    [MethodImpl]
    public extern ContactLocationField CreateLocation(
      string unstructuredAddress,
      ContactFieldCategory category);

    [Overload("CreateLocation_All")]
    [MethodImpl]
    public extern ContactLocationField CreateLocation(
      string unstructuredAddress,
      ContactFieldCategory category,
      string street,
      string city,
      string region,
      string country,
      string postalCode);

    [Overload("CreateInstantMessage_Default")]
    [MethodImpl]
    public extern ContactInstantMessageField CreateInstantMessage(
      string userName);

    [Overload("CreateInstantMessage_Category")]
    [MethodImpl]
    public extern ContactInstantMessageField CreateInstantMessage(
      string userName,
      ContactFieldCategory category);

    [Overload("CreateInstantMessage_All")]
    [MethodImpl]
    public extern ContactInstantMessageField CreateInstantMessage(
      string userName,
      ContactFieldCategory category,
      string service,
      string displayText,
      Uri verb);
  }
}
