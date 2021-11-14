// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.ICalendar
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [ExclusiveTo(typeof (Calendar))]
  [Guid(3392152093, 34521, 16635, 162, 107, 212, 78, 183, 207, 8, 234)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICalendar
  {
    Calendar Clone();

    void SetToMin();

    void SetToMax();

    IVectorView<string> Languages { get; }

    string NumeralSystem { get; set; }

    string GetCalendarSystem();

    void ChangeCalendarSystem(string value);

    string GetClock();

    void ChangeClock(string value);

    DateTime GetDateTime();

    void SetDateTime(DateTime value);

    void SetToNow();

    int FirstEra { get; }

    int LastEra { get; }

    int NumberOfEras { get; }

    int Era { get; set; }

    void AddEras(int eras);

    [Overload("EraAsFullString")]
    string EraAsString();

    [Overload("EraAsString")]
    string EraAsString(int idealLength);

    int FirstYearInThisEra { get; }

    int LastYearInThisEra { get; }

    int NumberOfYearsInThisEra { get; }

    int Year { get; set; }

    void AddYears(int years);

    string YearAsString();

    string YearAsTruncatedString(int remainingDigits);

    string YearAsPaddedString(int minDigits);

    int FirstMonthInThisYear { get; }

    int LastMonthInThisYear { get; }

    int NumberOfMonthsInThisYear { get; }

    int Month { get; set; }

    void AddMonths(int months);

    [Overload("MonthAsFullString")]
    string MonthAsString();

    [Overload("MonthAsString")]
    string MonthAsString(int idealLength);

    [Overload("MonthAsFullSoloString")]
    string MonthAsSoloString();

    [Overload("MonthAsSoloString")]
    string MonthAsSoloString(int idealLength);

    string MonthAsNumericString();

    string MonthAsPaddedNumericString(int minDigits);

    void AddWeeks(int weeks);

    int FirstDayInThisMonth { get; }

    int LastDayInThisMonth { get; }

    int NumberOfDaysInThisMonth { get; }

    int Day { get; set; }

    void AddDays(int days);

    string DayAsString();

    string DayAsPaddedString(int minDigits);

    DayOfWeek DayOfWeek { get; }

    [Overload("DayOfWeekAsFullString")]
    string DayOfWeekAsString();

    [Overload("DayOfWeekAsString")]
    string DayOfWeekAsString(int idealLength);

    [Overload("DayOfWeekAsFullSoloString")]
    string DayOfWeekAsSoloString();

    [Overload("DayOfWeekAsSoloString")]
    string DayOfWeekAsSoloString(int idealLength);

    int FirstPeriodInThisDay { get; }

    int LastPeriodInThisDay { get; }

    int NumberOfPeriodsInThisDay { get; }

    int Period { get; set; }

    void AddPeriods(int periods);

    [Overload("PeriodAsFullString")]
    string PeriodAsString();

    [Overload("PeriodAsString")]
    string PeriodAsString(int idealLength);

    int FirstHourInThisPeriod { get; }

    int LastHourInThisPeriod { get; }

    int NumberOfHoursInThisPeriod { get; }

    int Hour { get; set; }

    void AddHours(int hours);

    string HourAsString();

    string HourAsPaddedString(int minDigits);

    int Minute { get; set; }

    void AddMinutes(int minutes);

    string MinuteAsString();

    string MinuteAsPaddedString(int minDigits);

    int Second { get; set; }

    void AddSeconds(int seconds);

    string SecondAsString();

    string SecondAsPaddedString(int minDigits);

    int Nanosecond { get; set; }

    void AddNanoseconds(int nanoseconds);

    string NanosecondAsString();

    string NanosecondAsPaddedString(int minDigits);

    int Compare(Calendar other);

    int CompareDateTime(DateTime other);

    void CopyTo(Calendar other);

    int FirstMinuteInThisHour { get; }

    int LastMinuteInThisHour { get; }

    int NumberOfMinutesInThisHour { get; }

    int FirstSecondInThisMinute { get; }

    int LastSecondInThisMinute { get; }

    int NumberOfSecondsInThisMinute { get; }

    string ResolvedLanguage { get; }

    bool IsDaylightSavingTime { get; }
  }
}
