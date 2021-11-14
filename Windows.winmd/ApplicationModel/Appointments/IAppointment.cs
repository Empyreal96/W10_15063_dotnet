// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [ExclusiveTo(typeof (Appointment))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3707776815, 11229, 16502, 144, 163, 34, 194, 117, 49, 41, 101)]
  internal interface IAppointment
  {
    DateTime StartTime { get; set; }

    TimeSpan Duration { get; set; }

    string Location { get; set; }

    string Subject { get; set; }

    string Details { get; set; }

    IReference<TimeSpan> Reminder { get; set; }

    AppointmentOrganizer Organizer { get; set; }

    IVector<AppointmentInvitee> Invitees { get; }

    AppointmentRecurrence Recurrence { get; set; }

    AppointmentBusyStatus BusyStatus { get; set; }

    bool AllDay { get; set; }

    AppointmentSensitivity Sensitivity { get; set; }

    Uri Uri { get; set; }
  }
}
