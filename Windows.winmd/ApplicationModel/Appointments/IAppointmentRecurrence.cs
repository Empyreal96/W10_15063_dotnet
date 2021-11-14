// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.IAppointmentRecurrence
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3631955587, 5542, 18555, 185, 89, 12, 54, 30, 96, 233, 84)]
  [ExclusiveTo(typeof (AppointmentRecurrence))]
  internal interface IAppointmentRecurrence
  {
    AppointmentRecurrenceUnit Unit { get; set; }

    IReference<uint> Occurrences { get; set; }

    IReference<DateTime> Until { get; set; }

    uint Interval { get; set; }

    AppointmentDaysOfWeek DaysOfWeek { get; set; }

    AppointmentWeekOfMonth WeekOfMonth { get; set; }

    uint Month { get; set; }

    uint Day { get; set; }
  }
}
