// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentCalendarSyncManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [ExclusiveTo(typeof (AppointmentCalendarSyncManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(723628960, 19199, 17298, 188, 95, 86, 69, 255, 207, 251, 23)]
  internal interface IAppointmentCalendarSyncManager
  {
    AppointmentCalendarSyncStatus Status { get; }

    DateTime LastSuccessfulSyncTime { get; }

    DateTime LastAttemptedSyncTime { get; }

    [RemoteAsync]
    IAsyncOperation<bool> SyncAsync();

    event TypedEventHandler<AppointmentCalendarSyncManager, object> SyncStatusChanged;
  }
}
