// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentParticipant
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [Guid(1633560834, 38680, 18043, 131, 251, 178, 147, 161, 145, 33, 222)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IAppointmentParticipant
  {
    string DisplayName { get; set; }

    string Address { get; set; }
  }
}
