// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentCalendar2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.ApplicationModel.Appointments
{
  [Guid(417850402, 9319, 19996, 164, 89, 216, 162, 147, 3, 208, 146)]
  [ExclusiveTo(typeof (AppointmentCalendar))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAppointmentCalendar2 : IAppointmentCalendar
  {
    AppointmentCalendarSyncManager SyncManager { get; }

    string RemoteId { get; set; }

    new Color DisplayColor { set; }

    new bool IsHidden { set; }

    string UserDataAccountId { get; }

    bool CanCreateOrUpdateAppointments { get; set; }

    bool CanCancelMeetings { get; set; }

    bool CanForwardMeetings { get; set; }

    bool CanProposeNewTimeForMeetings { get; set; }

    bool CanUpdateMeetingResponses { get; set; }

    bool CanNotifyInvitees { get; set; }

    bool MustNofityInvitees { get; set; }

    IAsyncOperation<bool> TryCreateOrUpdateAppointmentAsync(
      Appointment appointment,
      bool notifyInvitees);

    IAsyncOperation<bool> TryCancelMeetingAsync(
      Appointment meeting,
      string subject,
      string comment,
      bool notifyInvitees);

    IAsyncOperation<bool> TryForwardMeetingAsync(
      Appointment meeting,
      IIterable<AppointmentInvitee> invitees,
      string subject,
      string forwardHeader,
      string comment);

    IAsyncOperation<bool> TryProposeNewTimeForMeetingAsync(
      Appointment meeting,
      DateTime newStartTime,
      TimeSpan newDuration,
      string subject,
      string comment);

    IAsyncOperation<bool> TryUpdateMeetingResponseAsync(
      Appointment meeting,
      AppointmentParticipantResponse response,
      string subject,
      string comment,
      bool sendUpdate);
  }
}
