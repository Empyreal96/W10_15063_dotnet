// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.DataProvider.IContactListSyncManagerSyncRequestEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts.DataProvider
{
  [ExclusiveTo(typeof (ContactListSyncManagerSyncRequestEventArgs))]
  [Guid(361647532, 17517, 20240, 175, 194, 2, 104, 62, 197, 51, 166)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IContactListSyncManagerSyncRequestEventArgs
  {
    ContactListSyncManagerSyncRequest Request { get; }

    Deferral GetDeferral();
  }
}
