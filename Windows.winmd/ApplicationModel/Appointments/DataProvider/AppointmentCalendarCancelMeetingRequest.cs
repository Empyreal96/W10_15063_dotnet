// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.DataProvider.AppointmentCalendarCancelMeetingRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.DataProvider
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  public sealed class AppointmentCalendarCancelMeetingRequest : 
    IAppointmentCalendarCancelMeetingRequest
  {
    public extern string AppointmentCalendarLocalId { [MethodImpl] get; }

    public extern string AppointmentLocalId { [MethodImpl] get; }

    public extern IReference<DateTime> AppointmentOriginalStartTime { [MethodImpl] get; }

    public extern string Subject { [MethodImpl] get; }

    public extern string Comment { [MethodImpl] get; }

    public extern bool NotifyInvitees { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportCompletedAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportFailedAsync();
  }
}
