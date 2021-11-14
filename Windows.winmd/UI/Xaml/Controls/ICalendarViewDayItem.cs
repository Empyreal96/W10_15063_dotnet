// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICalendarViewDayItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CalendarViewDayItem))]
  [Guid(266022341, 12993, 19343, 190, 252, 1, 123, 85, 91, 50, 210)]
  internal interface ICalendarViewDayItem
  {
    bool IsBlackout { get; set; }

    DateTime Date { get; }

    void SetDensityColors(IIterable<Color> colors);
  }
}
