// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentInvitee
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [Guid(331286422, 38978, 18779, 176, 231, 239, 143, 121, 192, 112, 29)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AppointmentInvitee))]
  internal interface IAppointmentInvitee : IAppointmentParticipant
  {
    AppointmentParticipantRole Role { get; set; }

    AppointmentParticipantResponse Response { get; set; }
  }
}
