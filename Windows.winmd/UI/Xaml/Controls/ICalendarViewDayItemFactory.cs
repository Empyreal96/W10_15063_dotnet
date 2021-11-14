// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICalendarViewDayItemFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(1645292508, 7471, 20036, 155, 175, 22, 101, 116, 149, 33, 242)]
  [ExclusiveTo(typeof (CalendarViewDayItem))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICalendarViewDayItemFactory
  {
    CalendarViewDayItem CreateInstance(object outer, out object inner);
  }
}
