// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.ApplicationModel.Appointments
{
  [ExclusiveTo(typeof (AppointmentManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(976288257, 23616, 18845, 179, 63, 164, 48, 80, 247, 79, 196)]
  internal interface IAppointmentManagerStatics
  {
    [Overload("ShowAddAppointmentAsync")]
    [RemoteAsync]
    IAsyncOperation<string> ShowAddAppointmentAsync(
      Appointment appointment,
      Rect selection);

    [Overload("ShowAddAppointmentWithPlacementAsync")]
    [RemoteAsync]
    IAsyncOperation<string> ShowAddAppointmentAsync(
      Appointment appointment,
      Rect selection,
      Placement preferredPlacement);

    [Overload("ShowReplaceAppointmentAsync")]
    [RemoteAsync]
    IAsyncOperation<string> ShowReplaceAppointmentAsync(
      string appointmentId,
      Appointment appointment,
      Rect selection);

    [Overload("ShowReplaceAppointmentWithPlacementAsync")]
    [RemoteAsync]
    IAsyncOperation<string> ShowReplaceAppointmentAsync(
      string appointmentId,
      Appointment appointment,
      Rect selection,
      Placement preferredPlacement);

    [RemoteAsync]
    [Overload("ShowReplaceAppointmentWithPlacementAndDateAsync")]
    IAsyncOperation<string> ShowReplaceAppointmentAsync(
      string appointmentId,
      Appointment appointment,
      Rect selection,
      Placement preferredPlacement,
      DateTime instanceStartDate);

    [Overload("ShowRemoveAppointmentAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> ShowRemoveAppointmentAsync(
      string appointmentId,
      Rect selection);

    [RemoteAsync]
    [Overload("ShowRemoveAppointmentWithPlacementAsync")]
    IAsyncOperation<bool> ShowRemoveAppointmentAsync(
      string appointmentId,
      Rect selection,
      Placement preferredPlacement);

    [RemoteAsync]
    [Overload("ShowRemoveAppointmentWithPlacementAndDateAsync")]
    IAsyncOperation<bool> ShowRemoveAppointmentAsync(
      string appointmentId,
      Rect selection,
      Placement preferredPlacement,
      DateTime instanceStartDate);

    [RemoteAsync]
    IAsyncAction ShowTimeFrameAsync(DateTime timeToShow, TimeSpan duration);
  }
}
