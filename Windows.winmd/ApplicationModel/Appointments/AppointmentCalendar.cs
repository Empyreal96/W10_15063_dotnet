// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentCalendar
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.ApplicationModel.Appointments
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class AppointmentCalendar : 
    IAppointmentCalendar,
    IAppointmentCalendar2,
    IAppointmentCalendar3
  {
    public extern Color DisplayColor { [MethodImpl] get; [MethodImpl] set; }

    public extern string DisplayName { [MethodImpl] get; [MethodImpl] set; }

    public extern string LocalId { [MethodImpl] get; }

    public extern bool IsHidden { [MethodImpl] get; [MethodImpl] set; }

    public extern AppointmentCalendarOtherAppReadAccess OtherAppReadAccess { [MethodImpl] get; [MethodImpl] set; }

    public extern AppointmentCalendarOtherAppWriteAccess OtherAppWriteAccess { [MethodImpl] get; [MethodImpl] set; }

    public extern string SourceDisplayName { [MethodImpl] get; }

    public extern AppointmentSummaryCardView SummaryCardView { [MethodImpl] get; [MethodImpl] set; }

    [RemoteAsync]
    [Overload("FindAppointmentsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<Appointment>> FindAppointmentsAsync(
      DateTime rangeStart,
      TimeSpan rangeLength);

    [Overload("FindAppointmentsAsyncWithOptions")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<Appointment>> FindAppointmentsAsync(
      DateTime rangeStart,
      TimeSpan rangeLength,
      FindAppointmentsOptions options);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<AppointmentException>> FindExceptionsFromMasterAsync(
      string masterLocalId);

    [RemoteAsync]
    [Overload("FindAllInstancesAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<Appointment>> FindAllInstancesAsync(
      string masterLocalId,
      DateTime rangeStart,
      TimeSpan rangeLength);

    [Overload("FindAllInstancesAsyncWithOptions")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<Appointment>> FindAllInstancesAsync(
      string masterLocalId,
      DateTime rangeStart,
      TimeSpan rangeLength,
      FindAppointmentsOptions pOptions);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<Appointment> GetAppointmentAsync(
      string localId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<Appointment> GetAppointmentInstanceAsync(
      string localId,
      DateTime instanceStartTime);

    [Overload("FindUnexpandedAppointmentsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<Appointment>> FindUnexpandedAppointmentsAsync();

    [Overload("FindUnexpandedAppointmentsAsyncWithOptions")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<Appointment>> FindUnexpandedAppointmentsAsync(
      FindAppointmentsOptions options);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SaveAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAppointmentAsync(string localId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAppointmentInstanceAsync(
      string localId,
      DateTime instanceStartTime);

    [MethodImpl]
    public extern IAsyncAction SaveAppointmentAsync(Appointment pAppointment);

    public extern AppointmentCalendarSyncManager SyncManager { [MethodImpl] get; }

    public extern string RemoteId { [MethodImpl] get; [MethodImpl] set; }

    public extern string UserDataAccountId { [MethodImpl] get; }

    public extern bool CanCreateOrUpdateAppointments { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CanCancelMeetings { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CanForwardMeetings { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CanProposeNewTimeForMeetings { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CanUpdateMeetingResponses { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CanNotifyInvitees { [MethodImpl] get; [MethodImpl] set; }

    public extern bool MustNofityInvitees { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern IAsyncOperation<bool> TryCreateOrUpdateAppointmentAsync(
      Appointment appointment,
      bool notifyInvitees);

    [MethodImpl]
    public extern IAsyncOperation<bool> TryCancelMeetingAsync(
      Appointment meeting,
      string subject,
      string comment,
      bool notifyInvitees);

    [MethodImpl]
    public extern IAsyncOperation<bool> TryForwardMeetingAsync(
      Appointment meeting,
      IIterable<AppointmentInvitee> invitees,
      string subject,
      string forwardHeader,
      string comment);

    [MethodImpl]
    public extern IAsyncOperation<bool> TryProposeNewTimeForMeetingAsync(
      Appointment meeting,
      DateTime newStartTime,
      TimeSpan newDuration,
      string subject,
      string comment);

    [MethodImpl]
    public extern IAsyncOperation<bool> TryUpdateMeetingResponseAsync(
      Appointment meeting,
      AppointmentParticipantResponse response,
      string subject,
      string comment,
      bool sendUpdate);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RegisterSyncManagerAsync();
  }
}
