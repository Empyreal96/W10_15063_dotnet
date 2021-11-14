// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailMeetingInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Appointments;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class EmailMeetingInfo : IEmailMeetingInfo, IEmailMeetingInfo2
  {
    [MethodImpl]
    public extern EmailMeetingInfo();

    public extern bool AllowNewTimeProposal { [MethodImpl] get; [MethodImpl] set; }

    public extern string AppointmentRoamingId { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<DateTime> AppointmentOriginalStartTime { [MethodImpl] get; [MethodImpl] set; }

    public extern TimeSpan Duration { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsAllDay { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsResponseRequested { [MethodImpl] get; [MethodImpl] set; }

    public extern string Location { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<DateTime> ProposedStartTime { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<TimeSpan> ProposedDuration { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<DateTime> RecurrenceStartTime { [MethodImpl] get; [MethodImpl] set; }

    public extern AppointmentRecurrence Recurrence { [MethodImpl] get; [MethodImpl] set; }

    public extern ulong RemoteChangeNumber { [MethodImpl] get; [MethodImpl] set; }

    public extern DateTime StartTime { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsReportedOutOfDateByServer { [MethodImpl] get; }
  }
}
