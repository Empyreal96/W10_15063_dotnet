// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactFieldFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(2246218047, 3658, 19006, 137, 148, 64, 106, 231, 237, 100, 110)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IContactFieldFactory
  {
    [Overload("CreateField_Default")]
    ContactField CreateField(string value, ContactFieldType type);

    [Overload("CreateField_Category")]
    ContactField CreateField(
      string value,
      ContactFieldType type,
      ContactFieldCategory category);

    [Overload("CreateField_Custom")]
    ContactField CreateField(
      string name,
      string value,
      ContactFieldType type,
      ContactFieldCategory category);
  }
}
