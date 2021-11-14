// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICalendarViewDayItemStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3282164671, 48520, 18571, 185, 22, 208, 13, 105, 177, 115, 90)]
  [ExclusiveTo(typeof (CalendarViewDayItem))]
  internal interface ICalendarViewDayItemStatics
  {
    DependencyProperty IsBlackoutProperty { get; }

    DependencyProperty DateProperty { get; }
  }
}
