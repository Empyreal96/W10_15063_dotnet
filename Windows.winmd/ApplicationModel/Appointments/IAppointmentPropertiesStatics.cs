// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentPropertiesStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(622075881, 26798, 15022, 133, 95, 188, 68, 65, 202, 162, 52)]
  [ExclusiveTo(typeof (AppointmentProperties))]
  internal interface IAppointmentPropertiesStatics
  {
    string Subject { get; }

    string Location { get; }

    string StartTime { get; }

    string Duration { get; }

    string Reminder { get; }

    string BusyStatus { get; }

    string Sensitivity { get; }

    string OriginalStartTime { get; }

    string IsResponseRequested { get; }

    string AllowNewTimeProposal { get; }

    string AllDay { get; }

    string Details { get; }

    string OnlineMeetingLink { get; }

    string ReplyTime { get; }

    string Organizer { get; }

    string UserResponse { get; }

    string HasInvitees { get; }

    string IsCanceledMeeting { get; }

    string IsOrganizedByUser { get; }

    string Recurrence { get; }

    string Uri { get; }

    string Invitees { get; }

    IVector<string> DefaultProperties { get; }
  }
}
