// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.ICalendarFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Calendar))]
  [Guid(2213905426, 58731, 19573, 166, 110, 15, 99, 213, 119, 88, 166)]
  internal interface ICalendarFactory
  {
    Calendar CreateCalendarDefaultCalendarAndClock(IIterable<string> languages);

    Calendar CreateCalendar(IIterable<string> languages, string calendar, string clock);
  }
}
