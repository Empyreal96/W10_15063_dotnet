// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.DataProvider.IAppointmentCalendarForwardMeetingRequestEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.DataProvider
{
  [Guid(822678810, 9122, 17149, 156, 130, 201, 166, 13, 89, 248, 168)]
  [ExclusiveTo(typeof (AppointmentCalendarForwardMeetingRequestEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAppointmentCalendarForwardMeetingRequestEventArgs
  {
    AppointmentCalendarForwardMeetingRequest Request { get; }

    Deferral GetDeferral();
  }
}
