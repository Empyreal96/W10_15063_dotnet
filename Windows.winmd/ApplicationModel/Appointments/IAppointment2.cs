// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointment2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [Guid(1585813564, 21519, 13394, 155, 92, 13, 215, 173, 76, 101, 162)]
  [ExclusiveTo(typeof (Appointment))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAppointment2 : IAppointment
  {
    string LocalId { get; }

    string CalendarId { get; }

    string RoamingId { get; set; }

    IReference<DateTime> OriginalStartTime { get; }

    bool IsResponseRequested { get; set; }

    bool AllowNewTimeProposal { get; set; }

    string OnlineMeetingLink { get; set; }

    IReference<DateTime> ReplyTime { get; set; }

    AppointmentParticipantResponse UserResponse { get; set; }

    bool HasInvitees { get; }

    bool IsCanceledMeeting { get; set; }

    bool IsOrganizedByUser { get; set; }
  }
}
