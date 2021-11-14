// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICalendarDatePickerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(967037585, 44971, 19348, 131, 149, 186, 123, 135, 78, 60, 140)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CalendarDatePicker))]
  internal interface ICalendarDatePickerStatics
  {
    DependencyProperty DateProperty { get; }

    DependencyProperty IsCalendarOpenProperty { get; }

    DependencyProperty DateFormatProperty { get; }

    DependencyProperty PlaceholderTextProperty { get; }

    DependencyProperty HeaderProperty { get; }

    DependencyProperty HeaderTemplateProperty { get; }

    DependencyProperty CalendarViewStyleProperty { get; }

    DependencyProperty MinDateProperty { get; }

    DependencyProperty MaxDateProperty { get; }

    DependencyProperty IsTodayHighlightedProperty { get; }

    DependencyProperty DisplayModeProperty { get; }

    DependencyProperty FirstDayOfWeekProperty { get; }

    DependencyProperty DayOfWeekFormatProperty { get; }

    DependencyProperty CalendarIdentifierProperty { get; }

    DependencyProperty IsOutOfScopeEnabledProperty { get; }

    DependencyProperty IsGroupLabelVisibleProperty { get; }
  }
}
