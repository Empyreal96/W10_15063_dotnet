// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentCalendar
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.ApplicationModel.Appointments
{
  [Guid(1383301533, 33593, 15695, 160, 47, 100, 8, 68, 82, 187, 93)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AppointmentCalendar))]
  internal interface IAppointmentCalendar
  {
    Color DisplayColor { get; }

    string DisplayName { get; set; }

    string LocalId { get; }

    bool IsHidden { get; }

    AppointmentCalendarOtherAppReadAccess OtherAppReadAccess { get; set; }

    AppointmentCalendarOtherAppWriteAccess OtherAppWriteAccess { get; set; }

    string SourceDisplayName { get; }

    AppointmentSummaryCardView SummaryCardView { get; set; }

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

    [RemoteAsync]
    IAsyncOperation<IVectorView<AppointmentException>> FindExceptionsFromMasterAsync(
      string masterLocalId);

    [Overload("FindAllInstancesAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<Appointment>> FindAllInstancesAsync(
      string masterLocalId,
      DateTime rangeStart,
      TimeSpan rangeLength);

    [Overload("FindAllInstancesAsyncWithOptions")]
    IAsyncOperation<IVectorView<Appointment>> FindAllInstancesAsync(
      string masterLocalId,
      DateTime rangeStart,
      TimeSpan rangeLength,
      FindAppointmentsOptions pOptions);

    [RemoteAsync]
    IAsyncOperation<Appointment> GetAppointmentAsync(string localId);

    [RemoteAsync]
    IAsyncOperation<Appointment> GetAppointmentInstanceAsync(
      string localId,
      DateTime instanceStartTime);

    [RemoteAsync]
    [Overload("FindUnexpandedAppointmentsAsync")]
    IAsyncOperation<IVectorView<Appointment>> FindUnexpandedAppointmentsAsync();

    [Overload("FindUnexpandedAppointmentsAsyncWithOptions")]
    IAsyncOperation<IVectorView<Appointment>> FindUnexpandedAppointmentsAsync(
      FindAppointmentsOptions options);

    [RemoteAsync]
    IAsyncAction DeleteAsync();

    [RemoteAsync]
    IAsyncAction SaveAsync();

    [RemoteAsync]
    IAsyncAction DeleteAppointmentAsync(string localId);

    [RemoteAsync]
    IAsyncAction DeleteAppointmentInstanceAsync(
      string localId,
      DateTime instanceStartTime);

    IAsyncAction SaveAppointmentAsync(Appointment pAppointment);
  }
}
