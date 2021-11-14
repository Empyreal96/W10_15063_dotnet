// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.ICalendarFactory2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [ExclusiveTo(typeof (Calendar))]
  [Guid(3024828300, 51838, 17808, 158, 114, 234, 43, 236, 26, 81, 21)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICalendarFactory2
  {
    Calendar CreateCalendarWithTimeZone(
      IIterable<string> languages,
      string calendar,
      string clock,
      string timeZoneId);
  }
}
