// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactList2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (ContactList))]
  [Guid(3409527732, 17744, 19915, 146, 41, 64, 255, 145, 251, 2, 3)]
  internal interface IContactList2
  {
    [RemoteAsync]
    IAsyncAction RegisterSyncManagerAsync();

    bool SupportsServerSearch { set; }

    ContactListSyncConstraints SyncConstraints { get; }
  }
}
