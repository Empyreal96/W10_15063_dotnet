// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.DateTimeFormatting.IDateTimeFormatter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.DateTimeFormatting
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DateTimeFormatter))]
  [Guid(2515454480, 29664, 20043, 161, 131, 61, 106, 208, 186, 53, 236)]
  internal interface IDateTimeFormatter
  {
    IVectorView<string> Languages { get; }

    string GeographicRegion { get; }

    string Calendar { get; }

    string Clock { get; }

    string NumeralSystem { get; set; }

    IVectorView<string> Patterns { get; }

    string Template { get; }

    string Format(DateTime value);

    YearFormat IncludeYear { get; }

    MonthFormat IncludeMonth { get; }

    DayOfWeekFormat IncludeDayOfWeek { get; }

    DayFormat IncludeDay { get; }

    HourFormat IncludeHour { get; }

    MinuteFormat IncludeMinute { get; }

    SecondFormat IncludeSecond { get; }

    string ResolvedLanguage { get; }

    string ResolvedGeographicRegion { get; }
  }
}
