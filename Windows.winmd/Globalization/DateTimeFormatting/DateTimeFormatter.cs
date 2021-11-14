// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.DateTimeFormatting.DateTimeFormatter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.DateTimeFormatting
{
  [Static(typeof (IDateTimeFormatterStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IDateTimeFormatterFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  public sealed class DateTimeFormatter : IDateTimeFormatter, IDateTimeFormatter2
  {
    [MethodImpl]
    public extern DateTimeFormatter(string formatTemplate);

    [MethodImpl]
    public extern DateTimeFormatter(string formatTemplate, IIterable<string> languages);

    [MethodImpl]
    public extern DateTimeFormatter(
      string formatTemplate,
      IIterable<string> languages,
      string geographicRegion,
      string calendar,
      string clock);

    [MethodImpl]
    public extern DateTimeFormatter(
      YearFormat yearFormat,
      MonthFormat monthFormat,
      DayFormat dayFormat,
      DayOfWeekFormat dayOfWeekFormat);

    [MethodImpl]
    public extern DateTimeFormatter(
      HourFormat hourFormat,
      MinuteFormat minuteFormat,
      SecondFormat secondFormat);

    [MethodImpl]
    public extern DateTimeFormatter(
      YearFormat yearFormat,
      MonthFormat monthFormat,
      DayFormat dayFormat,
      DayOfWeekFormat dayOfWeekFormat,
      HourFormat hourFormat,
      MinuteFormat minuteFormat,
      SecondFormat secondFormat,
      IIterable<string> languages);

    [MethodImpl]
    public extern DateTimeFormatter(
      YearFormat yearFormat,
      MonthFormat monthFormat,
      DayFormat dayFormat,
      DayOfWeekFormat dayOfWeekFormat,
      HourFormat hourFormat,
      MinuteFormat minuteFormat,
      SecondFormat secondFormat,
      IIterable<string> languages,
      string geographicRegion,
      string calendar,
      string clock);

    public extern IVectorView<string> Languages { [MethodImpl] get; }

    public extern string GeographicRegion { [MethodImpl] get; }

    public extern string Calendar { [MethodImpl] get; }

    public extern string Clock { [MethodImpl] get; }

    public extern string NumeralSystem { [MethodImpl] get; [MethodImpl] set; }

    public extern IVectorView<string> Patterns { [MethodImpl] get; }

    public extern string Template { [MethodImpl] get; }

    [MethodImpl]
    public extern string Format(DateTime value);

    public extern YearFormat IncludeYear { [MethodImpl] get; }

    public extern MonthFormat IncludeMonth { [MethodImpl] get; }

    public extern DayOfWeekFormat IncludeDayOfWeek { [MethodImpl] get; }

    public extern DayFormat IncludeDay { [MethodImpl] get; }

    public extern HourFormat IncludeHour { [MethodImpl] get; }

    public extern MinuteFormat IncludeMinute { [MethodImpl] get; }

    public extern SecondFormat IncludeSecond { [MethodImpl] get; }

    public extern string ResolvedLanguage { [MethodImpl] get; }

    public extern string ResolvedGeographicRegion { [MethodImpl] get; }

    [Overload("FormatUsingTimeZone")]
    [MethodImpl]
    public extern string Format(DateTime datetime, string timeZoneId);

    public static extern DateTimeFormatter LongDate { [MethodImpl] get; }

    public static extern DateTimeFormatter LongTime { [MethodImpl] get; }

    public static extern DateTimeFormatter ShortDate { [MethodImpl] get; }

    public static extern DateTimeFormatter ShortTime { [MethodImpl] get; }
  }
}
