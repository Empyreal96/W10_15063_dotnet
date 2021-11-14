// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.DataProvider.IAppointmentCalendarCreateOrUpdateAppointmentRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.DataProvider
{
  [ExclusiveTo(typeof (AppointmentCalendarCreateOrUpdateAppointmentRequest))]
  [Guid(778236594, 51862, 18604, 145, 36, 64, 107, 25, 254, 250, 112)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAppointmentCalendarCreateOrUpdateAppointmentRequest
  {
    string AppointmentCalendarLocalId { get; }

    Appointment Appointment { get; }

    bool NotifyInvitees { get; }

    IVectorView<string> ChangedProperties { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync(Appointment createdOrUpdatedAppointment);

    [RemoteAsync]
    IAsyncAction ReportFailedAsync();
  }
}
