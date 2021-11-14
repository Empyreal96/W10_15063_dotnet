// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.DataProvider.IAppointmentCalendarSyncManagerSyncRequestEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.DataProvider
{
  [Guid(3390555895, 644, 20189, 135, 186, 77, 143, 105, 220, 245, 192)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (AppointmentCalendarSyncManagerSyncRequestEventArgs))]
  internal interface IAppointmentCalendarSyncManagerSyncRequestEventArgs
  {
    AppointmentCalendarSyncManagerSyncRequest Request { get; }

    Deferral GetDeferral();
  }
}
