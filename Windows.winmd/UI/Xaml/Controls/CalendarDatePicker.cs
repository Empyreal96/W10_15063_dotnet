// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.CalendarDatePicker
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.UI.Xaml.Controls
{
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (ICalendarDatePickerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICalendarDatePickerStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ICalendarDatePickerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public class CalendarDatePicker : Control, ICalendarDatePicker, ICalendarDatePicker2
  {
    [MethodImpl]
    public extern CalendarDatePicker();

    public extern IReference<DateTime> Date { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsCalendarOpen { [MethodImpl] get; [MethodImpl] set; }

    public extern string DateFormat { [MethodImpl] get; [MethodImpl] set; }

    public extern string PlaceholderText { [MethodImpl] get; [MethodImpl] set; }

    public extern object Header { [MethodImpl] get; [MethodImpl] set; }

    public extern DataTemplate HeaderTemplate { [MethodImpl] get; [MethodImpl] set; }

    public extern Style CalendarViewStyle { [MethodImpl] get; [MethodImpl] set; }

    public extern DateTime MinDate { [MethodImpl] get; [MethodImpl] set; }

    public extern DateTime MaxDate { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsTodayHighlighted { [MethodImpl] get; [MethodImpl] set; }

    public extern CalendarViewDisplayMode DisplayMode { [MethodImpl] get; [MethodImpl] set; }

    public extern DayOfWeek FirstDayOfWeek { [MethodImpl] get; [MethodImpl] set; }

    public extern string DayOfWeekFormat { [MethodImpl] get; [MethodImpl] set; }

    public extern string CalendarIdentifier { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsOutOfScopeEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsGroupLabelVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern event CalendarViewDayItemChangingEventHandler CalendarViewDayItemChanging;

    public extern event TypedEventHandler<CalendarDatePicker, CalendarDatePickerDateChangedEventArgs> DateChanged;

    public extern event EventHandler<object> Opened;

    public extern event EventHandler<object> Closed;

    [MethodImpl]
    public extern void SetDisplayDate(DateTime date);

    [MethodImpl]
    public extern void SetYearDecadeDisplayDimensions(int columns, int rows);

    public extern LightDismissOverlayMode LightDismissOverlayMode { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty LightDismissOverlayModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty DateProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsCalendarOpenProperty { [MethodImpl] get; }

    public static extern DependencyProperty DateFormatProperty { [MethodImpl] get; }

    public static extern DependencyProperty PlaceholderTextProperty { [MethodImpl] get; }

    public static extern DependencyProperty HeaderProperty { [MethodImpl] get; }

    public static extern DependencyProperty HeaderTemplateProperty { [MethodImpl] get; }

    public static extern DependencyProperty CalendarViewStyleProperty { [MethodImpl] get; }

    public static extern DependencyProperty MinDateProperty { [MethodImpl] get; }

    public static extern DependencyProperty MaxDateProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsTodayHighlightedProperty { [MethodImpl] get; }

    public static extern DependencyProperty DisplayModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty FirstDayOfWeekProperty { [MethodImpl] get; }

    public static extern DependencyProperty DayOfWeekFormatProperty { [MethodImpl] get; }

    public static extern DependencyProperty CalendarIdentifierProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsOutOfScopeEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsGroupLabelVisibleProperty { [MethodImpl] get; }
  }
}
