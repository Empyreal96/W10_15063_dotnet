// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactQueryTextSearch
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(4158912971, 43351, 17307, 160, 183, 28, 2, 161, 150, 63, 240)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContactQueryTextSearch))]
  internal interface IContactQueryTextSearch
  {
    ContactQuerySearchFields Fields { get; set; }

    string Text { get; set; }

    ContactQuerySearchScope SearchScope { get; set; }
  }
}
