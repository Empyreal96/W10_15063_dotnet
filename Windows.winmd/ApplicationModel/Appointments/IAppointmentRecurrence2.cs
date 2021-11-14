// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentRecurrence2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [ExclusiveTo(typeof (AppointmentRecurrence))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1039377120, 1447, 20304, 159, 134, 176, 63, 148, 54, 37, 77)]
  internal interface IAppointmentRecurrence2 : IAppointmentRecurrence
  {
    RecurrenceType RecurrenceType { get; }

    string TimeZone { get; set; }
  }
}
