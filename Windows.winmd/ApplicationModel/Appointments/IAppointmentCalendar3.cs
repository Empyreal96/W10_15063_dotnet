// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentCalendar3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [ExclusiveTo(typeof (AppointmentCalendar))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3944993323, 42629, 17070, 132, 149, 179, 17, 154, 219, 65, 103)]
  internal interface IAppointmentCalendar3
  {
    [RemoteAsync]
    IAsyncAction RegisterSyncManagerAsync();
  }
}
