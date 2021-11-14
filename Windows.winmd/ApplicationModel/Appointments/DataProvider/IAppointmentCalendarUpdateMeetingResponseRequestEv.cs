// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.DataProvider.IAppointmentCalendarUpdateMeetingResponseRequestEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.DataProvider
{
  [ExclusiveTo(typeof (AppointmentCalendarUpdateMeetingResponseRequestEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2289408131, 38847, 18333, 174, 213, 11, 232, 206, 86, 125, 30)]
  internal interface IAppointmentCalendarUpdateMeetingResponseRequestEventArgs
  {
    AppointmentCalendarUpdateMeetingResponseRequest Request { get; }

    Deferral GetDeferral();
  }
}
