// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentRecurrence3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2315228889, 55885, 18967, 141, 210, 28, 235, 194, 181, 255, 157)]
  [ExclusiveTo(typeof (AppointmentRecurrence))]
  internal interface IAppointmentRecurrence3 : IAppointmentRecurrence2, IAppointmentRecurrence
  {
    string CalendarIdentifier { get; }
  }
}
