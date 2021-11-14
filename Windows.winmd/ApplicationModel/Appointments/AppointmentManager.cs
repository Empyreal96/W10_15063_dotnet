// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentManager
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
  [Static(typeof (IAppointmentManagerStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IAppointmentManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAppointmentManagerStatics3), 196608, "Windows.Foundation.UniversalApiContract")]
  public static class AppointmentManager
  {
    [MethodImpl]
    public static extern AppointmentManagerForUser GetForUser(User user);

    [RemoteAsync]
    [Overload("ShowAppointmentDetailsAsync")]
    [MethodImpl]
    public static extern IAsyncAction ShowAppointmentDetailsAsync(string appointmentId);

    [RemoteAsync]
    [Overload("ShowAppointmentDetailsWithDateAsync")]
    [MethodImpl]
    public static extern IAsyncAction ShowAppointmentDetailsAsync(
      string appointmentId,
      DateTime instanceStartDate);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> ShowEditNewAppointmentAsync(
      Appointment appointment);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<AppointmentStore> RequestStoreAsync(
      AppointmentStoreAccessType options);

    [Overload("ShowAddAppointmentAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> ShowAddAppointmentAsync(
      Appointment appointment,
      Rect selection);

    [Overload("ShowAddAppointmentWithPlacementAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> ShowAddAppointmentAsync(
      Appointment appointment,
      Rect selection,
      Placement preferredPlacement);

    [Overload("ShowReplaceAppointmentAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> ShowReplaceAppointmentAsync(
      string appointmentId,
      Appointment appointment,
      Rect selection);

    [Overload("ShowReplaceAppointmentWithPlacementAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> ShowReplaceAppointmentAsync(
      string appointmentId,
      Appointment appointment,
      Rect selection,
      Placement preferredPlacement);

    [Overload("ShowReplaceAppointmentWithPlacementAndDateAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> ShowReplaceAppointmentAsync(
      string appointmentId,
      Appointment appointment,
      Rect selection,
      Placement preferredPlacement,
      DateTime instanceStartDate);

    [RemoteAsync]
    [Overload("ShowRemoveAppointmentAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<bool> ShowRemoveAppointmentAsync(
      string appointmentId,
      Rect selection);

    [Overload("ShowRemoveAppointmentWithPlacementAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> ShowRemoveAppointmentAsync(
      string appointmentId,
      Rect selection,
      Placement preferredPlacement);

    [RemoteAsync]
    [Overload("ShowRemoveAppointmentWithPlacementAndDateAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<bool> ShowRemoveAppointmentAsync(
      string appointmentId,
      Rect selection,
      Placement preferredPlacement,
      DateTime instanceStartDate);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction ShowTimeFrameAsync(
      DateTime timeToShow,
      TimeSpan duration);
  }
}
