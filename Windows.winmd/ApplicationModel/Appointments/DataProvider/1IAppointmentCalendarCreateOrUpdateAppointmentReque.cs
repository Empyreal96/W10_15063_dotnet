// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.DataProvider.IAppointmentCalendarCreateOrUpdateAppointmentRequestEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments.DataProvider
{
  [ExclusiveTo(typeof (AppointmentCalendarCreateOrUpdateAppointmentRequestEventArgs))]
  [Guid(3482185000, 46, 19447, 142, 157, 94, 32, 212, 154, 163, 186)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAppointmentCalendarCreateOrUpdateAppointmentRequestEventArgs
  {
    AppointmentCalendarCreateOrUpdateAppointmentRequest Request { get; }

    Deferral GetDeferral();
  }
}
