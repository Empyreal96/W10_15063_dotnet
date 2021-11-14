// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactListSyncManager2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactListSyncManager))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2841186887, 47957, 20003, 129, 40, 55, 1, 52, 168, 93, 13)]
  internal interface IContactListSyncManager2
  {
    ContactListSyncStatus Status { set; }

    DateTime LastSuccessfulSyncTime { set; }

    DateTime LastAttemptedSyncTime { set; }
  }
}
