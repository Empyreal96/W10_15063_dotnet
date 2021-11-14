// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.Calendar
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [Activatable(typeof (ICalendarFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (ICalendarFactory2), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class Calendar : ICalendar, ITimeZoneOnCalendar
  {
    [MethodImpl]
    public extern Calendar(
      IIterable<string> languages,
      string calendar,
      string clock,
      string timeZoneId);

    [MethodImpl]
    public extern Calendar(IIterable<string> languages);

    [MethodImpl]
    public extern Calendar(IIterable<string> languages, string calendar, string clock);

    [MethodImpl]
    public extern Calendar();

    [MethodImpl]
    public extern Calendar Clone();

    [MethodImpl]
    public extern void SetToMin();

    [MethodImpl]
    public extern void SetToMax();

    public extern IVectorView<string> Languages { [MethodImpl] get; }

    public extern string NumeralSystem { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern string GetCalendarSystem();

    [MethodImpl]
    public extern void ChangeCalendarSystem(string value);

    [MethodImpl]
    public extern string GetClock();

    [MethodImpl]
    public extern void ChangeClock(string value);

    [MethodImpl]
    public extern DateTime GetDateTime();

    [MethodImpl]
    public extern void SetDateTime(DateTime value);

    [MethodImpl]
    public extern void SetToNow();

    public extern int FirstEra { [MethodImpl] get; }

    public extern int LastEra { [MethodImpl] get; }

    public extern int NumberOfEras { [MethodImpl] get; }

    public extern int Era { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void AddEras(int eras);

    [Overload("EraAsFullString")]
    [MethodImpl]
    public extern string EraAsString();

    [Overload("EraAsString")]
    [MethodImpl]
    public extern string EraAsString(int idealLength);

    public extern int FirstYearInThisEra { [MethodImpl] get; }

    public extern int LastYearInThisEra { [MethodImpl] get; }

    public extern int NumberOfYearsInThisEra { [MethodImpl] get; }

    public extern int Year { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void AddYears(int years);

    [MethodImpl]
    public extern string YearAsString();

    [MethodImpl]
    public extern string YearAsTruncatedString(int remainingDigits);

    [MethodImpl]
    public extern string YearAsPaddedString(int minDigits);

    public extern int FirstMonthInThisYear { [MethodImpl] get; }

    public extern int LastMonthInThisYear { [MethodImpl] get; }

    public extern int NumberOfMonthsInThisYear { [MethodImpl] get; }

    public extern int Month { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void AddMonths(int months);

    [Overload("MonthAsFullString")]
    [MethodImpl]
    public extern string MonthAsString();

    [Overload("MonthAsString")]
    [MethodImpl]
    public extern string MonthAsString(int idealLength);

    [Overload("MonthAsFullSoloString")]
    [MethodImpl]
    public extern string MonthAsSoloString();

    [Overload("MonthAsSoloString")]
    [MethodImpl]
    public extern string MonthAsSoloString(int idealLength);

    [MethodImpl]
    public extern string MonthAsNumericString();

    [MethodImpl]
    public extern string MonthAsPaddedNumericString(int minDigits);

    [MethodImpl]
    public extern void AddWeeks(int weeks);

    public extern int FirstDayInThisMonth { [MethodImpl] get; }

    public extern int LastDayInThisMonth { [MethodImpl] get; }

    public extern int NumberOfDaysInThisMonth { [MethodImpl] get; }

    public extern int Day { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void AddDays(int days);

    [MethodImpl]
    public extern string DayAsString();

    [MethodImpl]
    public extern string DayAsPaddedString(int minDigits);

    public extern DayOfWeek DayOfWeek { [MethodImpl] get; }

    [Overload("DayOfWeekAsFullString")]
    [MethodImpl]
    public extern string DayOfWeekAsString();

    [Overload("DayOfWeekAsString")]
    [MethodImpl]
    public extern string DayOfWeekAsString(int idealLength);

    [Overload("DayOfWeekAsFullSoloString")]
    [MethodImpl]
    public extern string DayOfWeekAsSoloString();

    [Overload("DayOfWeekAsSoloString")]
    [MethodImpl]
    public extern string DayOfWeekAsSoloString(int idealLength);

    public extern int FirstPeriodInThisDay { [MethodImpl] get; }

    public extern int LastPeriodInThisDay { [MethodImpl] get; }

    public extern int NumberOfPeriodsInThisDay { [MethodImpl] get; }

    public extern int Period { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void AddPeriods(int periods);

    [Overload("PeriodAsFullString")]
    [MethodImpl]
    public extern string PeriodAsString();

    [Overload("PeriodAsString")]
    [MethodImpl]
    public extern string PeriodAsString(int idealLength);

    public extern int FirstHourInThisPeriod { [MethodImpl] get; }

    public extern int LastHourInThisPeriod { [MethodImpl] get; }

    public extern int NumberOfHoursInThisPeriod { [MethodImpl] get; }

    public extern int Hour { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void AddHours(int hours);

    [MethodImpl]
    public extern string HourAsString();

    [MethodImpl]
    public extern string HourAsPaddedString(int minDigits);

    public extern int Minute { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void AddMinutes(int minutes);

    [MethodImpl]
    public extern string MinuteAsString();

    [MethodImpl]
    public extern string MinuteAsPaddedString(int minDigits);

    public extern int Second { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void AddSeconds(int seconds);

    [MethodImpl]
    public extern string SecondAsString();

    [MethodImpl]
    public extern string SecondAsPaddedString(int minDigits);

    public extern int Nanosecond { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void AddNanoseconds(int nanoseconds);

    [MethodImpl]
    public extern string NanosecondAsString();

    [MethodImpl]
    public extern string NanosecondAsPaddedString(int minDigits);

    [MethodImpl]
    public extern int Compare(Calendar other);

    [MethodImpl]
    public extern int CompareDateTime(DateTime other);

    [MethodImpl]
    public extern void CopyTo(Calendar other);

    public extern int FirstMinuteInThisHour { [MethodImpl] get; }

    public extern int LastMinuteInThisHour { [MethodImpl] get; }

    public extern int NumberOfMinutesInThisHour { [MethodImpl] get; }

    public extern int FirstSecondInThisMinute { [MethodImpl] get; }

    public extern int LastSecondInThisMinute { [MethodImpl] get; }

    public extern int NumberOfSecondsInThisMinute { [MethodImpl] get; }

    public extern string ResolvedLanguage { [MethodImpl] get; }

    public extern bool IsDaylightSavingTime { [MethodImpl] get; }

    [MethodImpl]
    public extern string GetTimeZone();

    [MethodImpl]
    public extern void ChangeTimeZone(string timeZoneId);

    [Overload("TimeZoneAsFullString")]
    [MethodImpl]
    public extern string TimeZoneAsString();

    [Overload("TimeZoneAsString")]
    [MethodImpl]
    public extern string TimeZoneAsString(int idealLength);
  }
}
