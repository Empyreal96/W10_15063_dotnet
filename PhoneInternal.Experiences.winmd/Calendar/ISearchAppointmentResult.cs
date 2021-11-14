// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Calendar.ISearchAppointmentResult
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.ApplicationModel.Appointments;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Calendar
{
  [Guid(922614821, 8967, 16837, 185, 149, 227, 134, 55, 198, 248, 76)]
  [Version(100859904)]
  [ExclusiveTo(typeof (SearchAppointmentResult))]
  internal interface ISearchAppointmentResult
  {
    IAsyncOperation<IVector<Appointment>> GetNextMatchedAppointmentsAsync(
      uint count);
  }
}
