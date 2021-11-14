// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentManagerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [ExclusiveTo(typeof (AppointmentManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(176289293, 53327, 16436, 175, 114, 163, 101, 115, 180, 95, 240)]
  internal interface IAppointmentManagerStatics2
  {
    [Overload("ShowAppointmentDetailsAsync")]
    [RemoteAsync]
    IAsyncAction ShowAppointmentDetailsAsync(string appointmentId);

    [Overload("ShowAppointmentDetailsWithDateAsync")]
    [RemoteAsync]
    IAsyncAction ShowAppointmentDetailsAsync(
      string appointmentId,
      DateTime instanceStartDate);

    [RemoteAsync]
    IAsyncOperation<string> ShowEditNewAppointmentAsync(Appointment appointment);

    [RemoteAsync]
    IAsyncOperation<AppointmentStore> RequestStoreAsync(
      AppointmentStoreAccessType options);
  }
}
