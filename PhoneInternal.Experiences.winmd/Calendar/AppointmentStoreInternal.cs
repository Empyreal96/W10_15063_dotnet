// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Calendar.AppointmentStoreInternal
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Appointments;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Calendar
{
  [Version(100859904)]
  [Static(typeof (IAppointmentStoreStaticsInternal), 100859904)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public static class AppointmentStoreInternal
  {
    [MethodImpl]
    public static extern SearchAppointmentResult CreateAppointmentSearch(
      string searchString);

    [MethodImpl]
    public static extern IAsyncOperation<AppointmentCalendar> GetMostRecentlyUsedAppointmentCalendarAsync();

    [MethodImpl]
    public static extern IAsyncAction SetMostRecentlyUsedAppointmentCalendarAsync(
      string calendarId);

    [MethodImpl]
    public static extern IAsyncOperation<AppointmentStore> CreateOrGetAppointmentStoreByProductIdAsync(
      Guid productId);
  }
}
