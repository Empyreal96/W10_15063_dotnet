// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Appointments.AppointmentRecurrence
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Appointments
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class AppointmentRecurrence : 
    IAppointmentRecurrence,
    IAppointmentRecurrence2,
    IAppointmentRecurrence3
  {
    [MethodImpl]
    public extern AppointmentRecurrence();

    public extern AppointmentRecurrenceUnit Unit { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<uint> Occurrences { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<DateTime> Until { [MethodImpl] get; [MethodImpl] set; }

    public extern uint Interval { [MethodImpl] get; [MethodImpl] set; }

    public extern AppointmentDaysOfWeek DaysOfWeek { [MethodImpl] get; [MethodImpl] set; }

    public extern AppointmentWeekOfMonth WeekOfMonth { [MethodImpl] get; [MethodImpl] set; }

    public extern uint Month { [MethodImpl] get; [MethodImpl] set; }

    public extern uint Day { [MethodImpl] get; [MethodImpl] set; }

    public extern RecurrenceType RecurrenceType { [MethodImpl] get; }

    public extern string TimeZone { [MethodImpl] get; [MethodImpl] set; }

    public extern string CalendarIdentifier { [MethodImpl] get; }
  }
}
