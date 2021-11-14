// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentManagerForUser
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.UI.Popups;

namespace Windows.ApplicationModel.Appointments
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class AppointmentManagerForUser : IAppointmentManagerForUser
  {
    [RemoteAsync]
    [Overload("ShowAddAppointmentAsync")]
    [MethodImpl]
    public extern IAsyncOperation<string> ShowAddAppointmentAsync(
      Appointment appointment,
      Rect selection);

    [Overload("ShowAddAppointmentWithPlacementAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> ShowAddAppointmentAsync(
      Appointment appointment,
      Rect selection,
      Placement preferredPlacement);

    [Overload("ShowReplaceAppointmentAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> ShowReplaceAppointmentAsync(
      string appointmentId,
      Appointment appointment,
      Rect selection);

    [Overload("ShowReplaceAppointmentWithPlacementAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> ShowReplaceAppointmentAsync(
      string appointmentId,
      Appointment appointment,
      Rect selection,
      Placement preferredPlacement);

    [Overload("ShowReplaceAppointmentWithPlacementAndDateAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> ShowReplaceAppointmentAsync(
      string appointmentId,
      Appointment appointment,
      Rect selection,
      Placement preferredPlacement,
      DateTime instanceStartDate);

    [RemoteAsync]
    [Overload("ShowRemoveAppointmentAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> ShowRemoveAppointmentAsync(
      string appointmentId,
      Rect selection);

    [RemoteAsync]
    [Overload("ShowRemoveAppointmentWithPlacementAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> ShowRemoveAppointmentAsync(
      string appointmentId,
      Rect selection,
      Placement preferredPlacement);

    [Overload("ShowRemoveAppointmentWithPlacementAndDateAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> ShowRemoveAppointmentAsync(
      string appointmentId,
      Rect selection,
      Placement preferredPlacement,
      DateTime instanceStartDate);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ShowTimeFrameAsync(
      DateTime timeToShow,
      TimeSpan duration);

    [RemoteAsync]
    [Overload("ShowAppointmentDetailsAsync")]
    [MethodImpl]
    public extern IAsyncAction ShowAppointmentDetailsAsync(string appointmentId);

    [Overload("ShowAppointmentDetailsWithDateAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ShowAppointmentDetailsAsync(
      string appointmentId,
      DateTime instanceStartDate);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> ShowEditNewAppointmentAsync(
      Appointment appointment);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AppointmentStore> RequestStoreAsync(
      AppointmentStoreAccessType options);

    public extern User User { [MethodImpl] get; }
  }
}
