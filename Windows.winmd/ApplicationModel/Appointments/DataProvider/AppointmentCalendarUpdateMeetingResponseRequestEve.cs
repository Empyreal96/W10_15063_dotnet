// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.DataProvider.AppointmentCalendarUpdateMeetingResponseRequestEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.DataProvider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AppointmentCalendarUpdateMeetingResponseRequestEventArgs : 
    IAppointmentCalendarUpdateMeetingResponseRequestEventArgs
  {
    public extern AppointmentCalendarUpdateMeetingResponseRequest Request { [MethodImpl] get; }

    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
