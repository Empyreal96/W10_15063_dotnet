// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentCalendarSyncManager2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (AppointmentCalendarSyncManager))]
  [Guid(1685399725, 3369, 19580, 170, 167, 191, 153, 104, 5, 83, 124)]
  internal interface IAppointmentCalendarSyncManager2
  {
    AppointmentCalendarSyncStatus Status { set; }

    DateTime LastSuccessfulSyncTime { set; }

    DateTime LastAttemptedSyncTime { set; }
  }
}
