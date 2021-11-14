// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactListSyncManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(342787006, 31013, 19148, 157, 229, 33, 221, 208, 111, 134, 116)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContactListSyncManager))]
  internal interface IContactListSyncManager
  {
    ContactListSyncStatus Status { get; }

    DateTime LastSuccessfulSyncTime { get; }

    DateTime LastAttemptedSyncTime { get; }

    [RemoteAsync]
    IAsyncOperation<bool> SyncAsync();

    event TypedEventHandler<ContactListSyncManager, object> SyncStatusChanged;
  }
}
