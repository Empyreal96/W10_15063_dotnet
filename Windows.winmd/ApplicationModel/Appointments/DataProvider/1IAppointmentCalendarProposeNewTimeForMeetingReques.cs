// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.DataProvider.IAppointmentCalendarProposeNewTimeForMeetingRequestEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.DataProvider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (AppointmentCalendarProposeNewTimeForMeetingRequestEventArgs))]
  [Guid(3537336280, 65233, 17024, 163, 186, 46, 31, 71, 96, 154, 162)]
  internal interface IAppointmentCalendarProposeNewTimeForMeetingRequestEventArgs
  {
    AppointmentCalendarProposeNewTimeForMeetingRequest Request { get; }

    Deferral GetDeferral();
  }
}
