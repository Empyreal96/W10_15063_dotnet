// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.CalendarView
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Globalization;
using Windows.UI.Text;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [Static(typeof (ICalendarViewStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (ICalendarViewFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class CalendarView : Control, ICalendarView
  {
    [MethodImpl]
    public extern CalendarView();

    public extern string CalendarIdentifier { [MethodImpl] get; [MethodImpl] set; }

    public extern string DayOfWeekFormat { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsGroupLabelVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern CalendarViewDisplayMode DisplayMode { [MethodImpl] get; [MethodImpl] set; }

    public extern DayOfWeek FirstDayOfWeek { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsOutOfScopeEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsTodayHighlighted { [MethodImpl] get; [MethodImpl] set; }

    public extern DateTime MaxDate { [MethodImpl] get; [MethodImpl] set; }

    public extern DateTime MinDate { [MethodImpl] get; [MethodImpl] set; }

    public extern int NumberOfWeeksInView { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<DateTime> SelectedDates { [MethodImpl] get; }

    public extern CalendarViewSelectionMode SelectionMode { [MethodImpl] get; [MethodImpl] set; }

    public extern CalendarViewTemplateSettings TemplateSettings { [MethodImpl] get; }

    public extern Brush FocusBorderBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush SelectedHoverBorderBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush SelectedPressedBorderBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush SelectedBorderBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush HoverBorderBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush PressedBorderBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush CalendarItemBorderBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush OutOfScopeBackground { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush CalendarItemBackground { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush PressedForeground { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush TodayForeground { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush BlackoutForeground { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush SelectedForeground { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush OutOfScopeForeground { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush CalendarItemForeground { [MethodImpl] get; [MethodImpl] set; }

    public extern FontFamily DayItemFontFamily { [MethodImpl] get; [MethodImpl] set; }

    public extern double DayItemFontSize { [MethodImpl] get; [MethodImpl] set; }

    public extern FontStyle DayItemFontStyle { [MethodImpl] get; [MethodImpl] set; }

    public extern FontWeight DayItemFontWeight { [MethodImpl] get; [MethodImpl] set; }

    public extern FontWeight TodayFontWeight { [MethodImpl] get; [MethodImpl] set; }

    public extern FontFamily FirstOfMonthLabelFontFamily { [MethodImpl] get; [MethodImpl] set; }

    public extern double FirstOfMonthLabelFontSize { [MethodImpl] get; [MethodImpl] set; }

    public extern FontStyle FirstOfMonthLabelFontStyle { [MethodImpl] get; [MethodImpl] set; }

    public extern FontWeight FirstOfMonthLabelFontWeight { [MethodImpl] get; [MethodImpl] set; }

    public extern FontFamily MonthYearItemFontFamily { [MethodImpl] get; [MethodImpl] set; }

    public extern double MonthYearItemFontSize { [MethodImpl] get; [MethodImpl] set; }

    public extern FontStyle MonthYearItemFontStyle { [MethodImpl] get; [MethodImpl] set; }

    public extern FontWeight MonthYearItemFontWeight { [MethodImpl] get; [MethodImpl] set; }

    public extern FontFamily FirstOfYearDecadeLabelFontFamily { [MethodImpl] get; [MethodImpl] set; }

    public extern double FirstOfYearDecadeLabelFontSize { [MethodImpl] get; [MethodImpl] set; }

    public extern FontStyle FirstOfYearDecadeLabelFontStyle { [MethodImpl] get; [MethodImpl] set; }

    public extern FontWeight FirstOfYearDecadeLabelFontWeight { [MethodImpl] get; [MethodImpl] set; }

    public extern HorizontalAlignment HorizontalDayItemAlignment { [MethodImpl] get; [MethodImpl] set; }

    public extern VerticalAlignment VerticalDayItemAlignment { [MethodImpl] get; [MethodImpl] set; }

    public extern HorizontalAlignment HorizontalFirstOfMonthLabelAlignment { [MethodImpl] get; [MethodImpl] set; }

    public extern VerticalAlignment VerticalFirstOfMonthLabelAlignment { [MethodImpl] get; [MethodImpl] set; }

    public extern Thickness CalendarItemBorderThickness { [MethodImpl] get; [MethodImpl] set; }

    public extern Style CalendarViewDayItemStyle { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<CalendarView, CalendarViewDayItemChangingEventArgs> CalendarViewDayItemChanging;

    public extern event TypedEventHandler<CalendarView, CalendarViewSelectedDatesChangedEventArgs> SelectedDatesChanged;

    [MethodImpl]
    public extern void SetDisplayDate(DateTime date);

    [MethodImpl]
    public extern void SetYearDecadeDisplayDimensions(int columns, int rows);

    public static extern DependencyProperty CalendarIdentifierProperty { [MethodImpl] get; }

    public static extern DependencyProperty DayOfWeekFormatProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsGroupLabelVisibleProperty { [MethodImpl] get; }

    public static extern DependencyProperty DisplayModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty FirstDayOfWeekProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsOutOfScopeEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsTodayHighlightedProperty { [MethodImpl] get; }

    public static extern DependencyProperty MaxDateProperty { [MethodImpl] get; }

    public static extern DependencyProperty MinDateProperty { [MethodImpl] get; }

    public static extern DependencyProperty NumberOfWeeksInViewProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectedDatesProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectionModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty TemplateSettingsProperty { [MethodImpl] get; }

    public static extern DependencyProperty FocusBorderBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectedHoverBorderBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectedPressedBorderBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectedBorderBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty HoverBorderBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty PressedBorderBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty CalendarItemBorderBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty OutOfScopeBackgroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty CalendarItemBackgroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty PressedForegroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty TodayForegroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty BlackoutForegroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectedForegroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty OutOfScopeForegroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty CalendarItemForegroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty DayItemFontFamilyProperty { [MethodImpl] get; }

    public static extern DependencyProperty DayItemFontSizeProperty { [MethodImpl] get; }

    public static extern DependencyProperty DayItemFontStyleProperty { [MethodImpl] get; }

    public static extern DependencyProperty DayItemFontWeightProperty { [MethodImpl] get; }

    public static extern DependencyProperty TodayFontWeightProperty { [MethodImpl] get; }

    public static extern DependencyProperty FirstOfMonthLabelFontFamilyProperty { [MethodImpl] get; }

    public static extern DependencyProperty FirstOfMonthLabelFontSizeProperty { [MethodImpl] get; }

    public static extern DependencyProperty FirstOfMonthLabelFontStyleProperty { [MethodImpl] get; }

    public static extern DependencyProperty FirstOfMonthLabelFontWeightProperty { [MethodImpl] get; }

    public static extern DependencyProperty MonthYearItemFontFamilyProperty { [MethodImpl] get; }

    public static extern DependencyProperty MonthYearItemFontSizeProperty { [MethodImpl] get; }

    public static extern DependencyProperty MonthYearItemFontStyleProperty { [MethodImpl] get; }

    public static extern DependencyProperty MonthYearItemFontWeightProperty { [MethodImpl] get; }

    public static extern DependencyProperty FirstOfYearDecadeLabelFontFamilyProperty { [MethodImpl] get; }

    public static extern DependencyProperty FirstOfYearDecadeLabelFontSizeProperty { [MethodImpl] get; }

    public static extern DependencyProperty FirstOfYearDecadeLabelFontStyleProperty { [MethodImpl] get; }

    public static extern DependencyProperty FirstOfYearDecadeLabelFontWeightProperty { [MethodImpl] get; }

    public static extern DependencyProperty HorizontalDayItemAlignmentProperty { [MethodImpl] get; }

    public static extern DependencyProperty VerticalDayItemAlignmentProperty { [MethodImpl] get; }

    public static extern DependencyProperty HorizontalFirstOfMonthLabelAlignmentProperty { [MethodImpl] get; }

    public static extern DependencyProperty VerticalFirstOfMonthLabelAlignmentProperty { [MethodImpl] get; }

    public static extern DependencyProperty CalendarItemBorderThicknessProperty { [MethodImpl] get; }

    public static extern DependencyProperty CalendarViewDayItemStyleProperty { [MethodImpl] get; }
  }
}
