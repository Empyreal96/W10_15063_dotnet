// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentStore2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [Guid(633637920, 7233, 16975, 128, 132, 103, 193, 207, 224, 168, 84)]
  [ExclusiveTo(typeof (AppointmentStore))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAppointmentStore2 : IAppointmentStore
  {
    event TypedEventHandler<AppointmentStore, AppointmentStoreChangedEventArgs> StoreChanged;

    [RemoteAsync]
    [Overload("CreateAppointmentCalendarInAccountAsync")]
    IAsyncOperation<AppointmentCalendar> CreateAppointmentCalendarAsync(
      string name,
      string userDataAccountId);
  }
}
