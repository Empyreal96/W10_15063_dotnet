// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Calendar.IAppointmentStoreStaticsInternal
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System;
using Windows.ApplicationModel.Appointments;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Calendar
{
  [Version(100859904)]
  [ExclusiveTo(typeof (AppointmentStoreInternal))]
  [Guid(1682722630, 56901, 17781, 189, 25, 89, 124, 157, 47, 192, 187)]
  internal interface IAppointmentStoreStaticsInternal
  {
    SearchAppointmentResult CreateAppointmentSearch(string searchString);

    IAsyncOperation<AppointmentCalendar> GetMostRecentlyUsedAppointmentCalendarAsync();

    IAsyncAction SetMostRecentlyUsedAppointmentCalendarAsync(string calendarId);

    IAsyncOperation<AppointmentStore> CreateOrGetAppointmentStoreByProductIdAsync(
      Guid productId);
  }
}
