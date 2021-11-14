// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMailboxSyncManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailMailboxSyncManager))]
  [Guid(1367000410, 13713, 19293, 133, 188, 199, 29, 222, 134, 34, 99)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IEmailMailboxSyncManager
  {
    EmailMailboxSyncStatus Status { get; }

    DateTime LastSuccessfulSyncTime { get; }

    DateTime LastAttemptedSyncTime { get; }

    [RemoteAsync]
    IAsyncOperation<bool> SyncAsync();

    event TypedEventHandler<EmailMailboxSyncManager, object> SyncStatusChanged;
  }
}
