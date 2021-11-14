// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IAppointmentPropertiesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IAppointmentPropertiesStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public static class AppointmentProperties
  {
    public static extern string ChangeNumber { [MethodImpl] get; }

    public static extern string RemoteChangeNumber { [MethodImpl] get; }

    public static extern string DetailsKind { [MethodImpl] get; }

    public static extern string Subject { [MethodImpl] get; }

    public static extern string Location { [MethodImpl] get; }

    public static extern string StartTime { [MethodImpl] get; }

    public static extern string Duration { [MethodImpl] get; }

    public static extern string Reminder { [MethodImpl] get; }

    public static extern string BusyStatus { [MethodImpl] get; }

    public static extern string Sensitivity { [MethodImpl] get; }

    public static extern string OriginalStartTime { [MethodImpl] get; }

    public static extern string IsResponseRequested { [MethodImpl] get; }

    public static extern string AllowNewTimeProposal { [MethodImpl] get; }

    public static extern string AllDay { [MethodImpl] get; }

    public static extern string Details { [MethodImpl] get; }

    public static extern string OnlineMeetingLink { [MethodImpl] get; }

    public static extern string ReplyTime { [MethodImpl] get; }

    public static extern string Organizer { [MethodImpl] get; }

    public static extern string UserResponse { [MethodImpl] get; }

    public static extern string HasInvitees { [MethodImpl] get; }

    public static extern string IsCanceledMeeting { [MethodImpl] get; }

    public static extern string IsOrganizedByUser { [MethodImpl] get; }

    public static extern string Recurrence { [MethodImpl] get; }

    public static extern string Uri { [MethodImpl] get; }

    public static extern string Invitees { [MethodImpl] get; }

    public static extern IVector<string> DefaultProperties { [MethodImpl] get; }
  }
}
