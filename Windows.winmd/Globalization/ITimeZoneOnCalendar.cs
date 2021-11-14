// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.ITimeZoneOnCalendar
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Calendar))]
  [Guid(3141281253, 18127, 17175, 163, 245, 2, 98, 26, 213, 68, 120)]
  internal interface ITimeZoneOnCalendar
  {
    string GetTimeZone();

    void ChangeTimeZone(string timeZoneId);

    [Overload("TimeZoneAsFullString")]
    string TimeZoneAsString();

    [Overload("TimeZoneAsString")]
    string TimeZoneAsString(int idealLength);
  }
}
