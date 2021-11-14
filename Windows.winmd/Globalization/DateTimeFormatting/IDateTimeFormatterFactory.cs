// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.DateTimeFormatting.IDateTimeFormatterFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.DateTimeFormatting
{
  [ExclusiveTo(typeof (DateTimeFormatter))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3968698963, 6702, 16685, 136, 21, 59, 116, 95, 177, 162, 160)]
  internal interface IDateTimeFormatterFactory
  {
    DateTimeFormatter CreateDateTimeFormatter(string formatTemplate);

    DateTimeFormatter CreateDateTimeFormatterLanguages(
      string formatTemplate,
      IIterable<string> languages);

    DateTimeFormatter CreateDateTimeFormatterContext(
      string formatTemplate,
      IIterable<string> languages,
      string geographicRegion,
      string calendar,
      string clock);

    DateTimeFormatter CreateDateTimeFormatterDate(
      YearFormat yearFormat,
      MonthFormat monthFormat,
      DayFormat dayFormat,
      DayOfWeekFormat dayOfWeekFormat);

    DateTimeFormatter CreateDateTimeFormatterTime(
      HourFormat hourFormat,
      MinuteFormat minuteFormat,
      SecondFormat secondFormat);

    DateTimeFormatter CreateDateTimeFormatterDateTimeLanguages(
      YearFormat yearFormat,
      MonthFormat monthFormat,
      DayFormat dayFormat,
      DayOfWeekFormat dayOfWeekFormat,
      HourFormat hourFormat,
      MinuteFormat minuteFormat,
      SecondFormat secondFormat,
      IIterable<string> languages);

    DateTimeFormatter CreateDateTimeFormatterDateTimeContext(
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
  }
}
