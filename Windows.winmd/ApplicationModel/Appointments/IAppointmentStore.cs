// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentStore
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.ApplicationModel.Appointments
{
  [Guid(2757857676, 31303, 19862, 150, 201, 21, 205, 138, 5, 167, 53)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AppointmentStore))]
  internal interface IAppointmentStore
  {
    AppointmentStoreChangeTracker ChangeTracker { get; }

    [RemoteAsync]
    IAsyncOperation<AppointmentCalendar> CreateAppointmentCalendarAsync(
      string name);

    [RemoteAsync]
    IAsyncOperation<AppointmentCalendar> GetAppointmentCalendarAsync(
      string calendarId);

    [RemoteAsync]
    IAsyncOperation<Appointment> GetAppointmentAsync(string localId);

    [RemoteAsync]
    IAsyncOperation<Appointment> GetAppointmentInstanceAsync(
      string localId,
      DateTime instanceStartTime);

    [RemoteAsync]
    [Overload("FindAppointmentCalendarsAsync")]
    IAsyncOperation<IVectorView<AppointmentCalendar>> FindAppointmentCalendarsAsync();

    [RemoteAsync]
    [Overload("FindAppointmentCalendarsAsyncWithOptions")]
    IAsyncOperation<IVectorView<AppointmentCalendar>> FindAppointmentCalendarsAsync(
      FindAppointmentCalendarsOptions options);

    [Overload("FindAppointmentsAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<Appointment>> FindAppointmentsAsync(
      DateTime rangeStart,
      TimeSpan rangeLength);

    [Overload("FindAppointmentsAsyncWithOptions")]
    IAsyncOperation<IVectorView<Appointment>> FindAppointmentsAsync(
      DateTime rangeStart,
      TimeSpan rangeLength,
      FindAppointmentsOptions options);

    [Overload("FindConflictAsync")]
    IAsyncOperation<AppointmentConflictResult> FindConflictAsync(
      Appointment appointment);

    [Overload("FindConflictAsyncWithInstanceStart")]
    IAsyncOperation<AppointmentConflictResult> FindConflictAsync(
      Appointment appointment,
      DateTime instanceStartTime);

    IAsyncAction MoveAppointmentAsync(
      Appointment appointment,
      AppointmentCalendar destinationCalendar);

    IAsyncOperation<string> ShowAddAppointmentAsync(
      Appointment appointment,
      Rect selection);

    [Overload("ShowReplaceAppointmentAsync")]
    IAsyncOperation<string> ShowReplaceAppointmentAsync(
      string localId,
      Appointment appointment,
      Rect selection);

    [Overload("ShowReplaceAppointmentWithPlacementAndDateAsync")]
    IAsyncOperation<string> ShowReplaceAppointmentAsync(
      string localId,
      Appointment appointment,
      Rect selection,
      Placement preferredPlacement,
      DateTime instanceStartDate);

    [Overload("ShowRemoveAppointmentAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> ShowRemoveAppointmentAsync(string localId, Rect selection);

    [Overload("ShowRemoveAppointmentWithPlacementAndDateAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> ShowRemoveAppointmentAsync(
      string localId,
      Rect selection,
      Placement preferredPlacement,
      DateTime instanceStartDate);

    [Overload("ShowAppointmentDetailsAsync")]
    [RemoteAsync]
    IAsyncAction ShowAppointmentDetailsAsync(string localId);

    [Overload("ShowAppointmentDetailsWithDateAsync")]
    [RemoteAsync]
    IAsyncAction ShowAppointmentDetailsAsync(string localId, DateTime instanceStartDate);

    IAsyncOperation<string> ShowEditNewAppointmentAsync(Appointment appointment);

    [RemoteAsync]
    IAsyncOperation<IVectorView<string>> FindLocalIdsFromRoamingIdAsync(
      string roamingId);
  }
}
