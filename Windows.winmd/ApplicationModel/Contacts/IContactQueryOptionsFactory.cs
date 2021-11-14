// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactQueryOptionsFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1413462599, 36071, 18123, 157, 172, 154, 164, 42, 27, 200, 226)]
  [ExclusiveTo(typeof (ContactQueryOptions))]
  internal interface IContactQueryOptionsFactory
  {
    ContactQueryOptions CreateWithText(string text);

    ContactQueryOptions CreateWithTextAndFields(
      string text,
      ContactQuerySearchFields fields);
  }
}
