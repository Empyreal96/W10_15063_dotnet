// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.DataProvider.IAppointmentCalendarForwardMeetingRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.DataProvider
{
  [ExclusiveTo(typeof (AppointmentCalendarForwardMeetingRequest))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2196106838, 9910, 16979, 138, 143, 108, 245, 242, 255, 120, 132)]
  internal interface IAppointmentCalendarForwardMeetingRequest
  {
    string AppointmentCalendarLocalId { get; }

    string AppointmentLocalId { get; }

    IReference<DateTime> AppointmentOriginalStartTime { get; }

    IVectorView<AppointmentInvitee> Invitees { get; }

    string Subject { get; }

    string ForwardHeader { get; }

    string Comment { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync();

    [RemoteAsync]
    IAsyncAction ReportFailedAsync();
  }
}
