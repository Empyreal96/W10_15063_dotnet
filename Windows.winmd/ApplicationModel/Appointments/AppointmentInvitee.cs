// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentInvitee
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class AppointmentInvitee : IAppointmentInvitee, IAppointmentParticipant
  {
    [MethodImpl]
    public extern AppointmentInvitee();

    public extern AppointmentParticipantRole Role { [MethodImpl] get; [MethodImpl] set; }

    public extern AppointmentParticipantResponse Response { [MethodImpl] get; [MethodImpl] set; }

    public extern string DisplayName { [MethodImpl] get; [MethodImpl] set; }

    public extern string Address { [MethodImpl] get; [MethodImpl] set; }
  }
}
