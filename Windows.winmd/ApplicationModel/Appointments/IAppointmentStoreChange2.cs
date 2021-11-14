// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentStoreChange2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [ExclusiveTo(typeof (AppointmentStoreChange))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3011317198, 21009, 17410, 166, 8, 169, 111, 231, 11, 142, 226)]
  internal interface IAppointmentStoreChange2 : IAppointmentStoreChange
  {
    AppointmentCalendar AppointmentCalendar { get; }
  }
}
