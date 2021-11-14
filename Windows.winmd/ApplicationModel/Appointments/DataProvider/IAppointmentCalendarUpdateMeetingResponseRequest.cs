// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.DataProvider.IAppointmentCalendarUpdateMeetingResponseRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.DataProvider
{
  [Guid(2741854348, 49821, 19348, 176, 134, 126, 159, 247, 189, 132, 160)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (AppointmentCalendarUpdateMeetingResponseRequest))]
  internal interface IAppointmentCalendarUpdateMeetingResponseRequest
  {
    string AppointmentCalendarLocalId { get; }

    string AppointmentLocalId { get; }

    IReference<DateTime> AppointmentOriginalStartTime { get; }

    AppointmentParticipantResponse Response { get; }

    string Subject { get; }

    string Comment { get; }

    bool SendUpdate { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync();

    [RemoteAsync]
    IAsyncAction ReportFailedAsync();
  }
}
