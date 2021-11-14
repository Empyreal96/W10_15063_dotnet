// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.Appointment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class Appointment : IAppointment, IAppointment2, IAppointment3
  {
    [MethodImpl]
    public extern Appointment();

    public extern DateTime StartTime { [MethodImpl] get; [MethodImpl] set; }

    public extern TimeSpan Duration { [MethodImpl] get; [MethodImpl] set; }

    public extern string Location { [MethodImpl] get; [MethodImpl] set; }

    public extern string Subject { [MethodImpl] get; [MethodImpl] set; }

    public extern string Details { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<TimeSpan> Reminder { [MethodImpl] get; [MethodImpl] set; }

    public extern AppointmentOrganizer Organizer { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<AppointmentInvitee> Invitees { [MethodImpl] get; }

    public extern AppointmentRecurrence Recurrence { [MethodImpl] get; [MethodImpl] set; }

    public extern AppointmentBusyStatus BusyStatus { [MethodImpl] get; [MethodImpl] set; }

    public extern bool AllDay { [MethodImpl] get; [MethodImpl] set; }

    public extern AppointmentSensitivity Sensitivity { [MethodImpl] get; [MethodImpl] set; }

    public extern Uri Uri { [MethodImpl] get; [MethodImpl] set; }

    public extern string LocalId { [MethodImpl] get; }

    public extern string CalendarId { [MethodImpl] get; }

    public extern string RoamingId { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<DateTime> OriginalStartTime { [MethodImpl] get; }

    public extern bool IsResponseRequested { [MethodImpl] get; [MethodImpl] set; }

    public extern bool AllowNewTimeProposal { [MethodImpl] get; [MethodImpl] set; }

    public extern string OnlineMeetingLink { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<DateTime> ReplyTime { [MethodImpl] get; [MethodImpl] set; }

    public extern AppointmentParticipantResponse UserResponse { [MethodImpl] get; [MethodImpl] set; }

    public extern bool HasInvitees { [MethodImpl] get; }

    public extern bool IsCanceledMeeting { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsOrganizedByUser { [MethodImpl] get; [MethodImpl] set; }

    public extern ulong ChangeNumber { [MethodImpl] get; }

    public extern ulong RemoteChangeNumber { [MethodImpl] get; [MethodImpl] set; }

    public extern AppointmentDetailsKind DetailsKind { [MethodImpl] get; [MethodImpl] set; }
  }
}
