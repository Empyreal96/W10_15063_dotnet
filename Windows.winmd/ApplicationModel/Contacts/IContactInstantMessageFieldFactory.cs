// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactInstantMessageFieldFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(3121309588, 37283, 19378, 177, 185, 105, 165, 223, 240, 186, 9)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IContactInstantMessageFieldFactory
  {
    [Overload("CreateInstantMessage_Default")]
    ContactInstantMessageField CreateInstantMessage(string userName);

    [Overload("CreateInstantMessage_Category")]
    ContactInstantMessageField CreateInstantMessage(
      string userName,
      ContactFieldCategory category);

    [Overload("CreateInstantMessage_All")]
    ContactInstantMessageField CreateInstantMessage(
      string userName,
      ContactFieldCategory category,
      string service,
      string displayText,
      Uri verb);
  }
}
