// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMeetingInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.Appointments;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailMeetingInfo))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(834682793, 31027, 16735, 162, 117, 209, 101, 186, 7, 2, 107)]
  internal interface IEmailMeetingInfo
  {
    bool AllowNewTimeProposal { get; set; }

    string AppointmentRoamingId { get; set; }

    IReference<DateTime> AppointmentOriginalStartTime { get; set; }

    TimeSpan Duration { get; set; }

    bool IsAllDay { get; set; }

    bool IsResponseRequested { get; set; }

    string Location { get; set; }

    IReference<DateTime> ProposedStartTime { get; set; }

    IReference<TimeSpan> ProposedDuration { get; set; }

    IReference<DateTime> RecurrenceStartTime { get; set; }

    AppointmentRecurrence Recurrence { get; set; }

    ulong RemoteChangeNumber { get; set; }

    DateTime StartTime { get; set; }
  }
}
