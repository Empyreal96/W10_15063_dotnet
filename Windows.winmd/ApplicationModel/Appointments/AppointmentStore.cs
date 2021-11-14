// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentStore
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.ApplicationModel.Appointments
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AppointmentStore : IAppointmentStore, IAppointmentStore2
  {
    public extern AppointmentStoreChangeTracker ChangeTracker { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AppointmentCalendar> CreateAppointmentCalendarAsync(
      string name);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AppointmentCalendar> GetAppointmentCalendarAsync(
      string calendarId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<Appointment> GetAppointmentAsync(
      string localId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<Appointment> GetAppointmentInstanceAsync(
      string localId,
      DateTime instanceStartTime);

    [Overload("FindAppointmentCalendarsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<AppointmentCalendar>> FindAppointmentCalendarsAsync();

    [RemoteAsync]
    [Overload("FindAppointmentCalendarsAsyncWithOptions")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<AppointmentCalendar>> FindAppointmentCalendarsAsync(
      FindAppointmentCalendarsOptions options);

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

    [Overload("FindConflictAsync")]
    [MethodImpl]
    public extern IAsyncOperation<AppointmentConflictResult> FindConflictAsync(
      Appointment appointment);

    [Overload("FindConflictAsyncWithInstanceStart")]
    [MethodImpl]
    public extern IAsyncOperation<AppointmentConflictResult> FindConflictAsync(
      Appointment appointment,
      DateTime instanceStartTime);

    [MethodImpl]
    public extern IAsyncAction MoveAppointmentAsync(
      Appointment appointment,
      AppointmentCalendar destinationCalendar);

    [MethodImpl]
    public extern IAsyncOperation<string> ShowAddAppointmentAsync(
      Appointment appointment,
      Rect selection);

    [Overload("ShowReplaceAppointmentAsync")]
    [MethodImpl]
    public extern IAsyncOperation<string> ShowReplaceAppointmentAsync(
      string localId,
      Appointment appointment,
      Rect selection);

    [Overload("ShowReplaceAppointmentWithPlacementAndDateAsync")]
    [MethodImpl]
    public extern IAsyncOperation<string> ShowReplaceAppointmentAsync(
      string localId,
      Appointment appointment,
      Rect selection,
      Placement preferredPlacement,
      DateTime instanceStartDate);

    [Overload("ShowRemoveAppointmentAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> ShowRemoveAppointmentAsync(
      string localId,
      Rect selection);

    [RemoteAsync]
    [Overload("ShowRemoveAppointmentWithPlacementAndDateAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> ShowRemoveAppointmentAsync(
      string localId,
      Rect selection,
      Placement preferredPlacement,
      DateTime instanceStartDate);

    [RemoteAsync]
    [Overload("ShowAppointmentDetailsAsync")]
    [MethodImpl]
    public extern IAsyncAction ShowAppointmentDetailsAsync(string localId);

    [Overload("ShowAppointmentDetailsWithDateAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ShowAppointmentDetailsAsync(
      string localId,
      DateTime instanceStartDate);

    [MethodImpl]
    public extern IAsyncOperation<string> ShowEditNewAppointmentAsync(
      Appointment appointment);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<string>> FindLocalIdsFromRoamingIdAsync(
      string roamingId);

    public extern event TypedEventHandler<AppointmentStore, AppointmentStoreChangedEventArgs> StoreChanged;

    [Overload("CreateAppointmentCalendarInAccountAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AppointmentCalendar> CreateAppointmentCalendarAsync(
      string name,
      string userDataAccountId);
  }
}
