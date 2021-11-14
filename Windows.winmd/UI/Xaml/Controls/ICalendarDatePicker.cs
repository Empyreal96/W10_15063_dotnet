// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICalendarDatePicker
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (CalendarDatePicker))]
  [Guid(1674166639, 26252, 17553, 148, 68, 212, 93, 139, 244, 250, 41)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICalendarDatePicker
  {
    IReference<DateTime> Date { get; set; }

    bool IsCalendarOpen { get; set; }

    string DateFormat { get; set; }

    string PlaceholderText { get; set; }

    object Header { get; set; }

    DataTemplate HeaderTemplate { get; set; }

    Style CalendarViewStyle { get; set; }

    DateTime MinDate { get; set; }

    DateTime MaxDate { get; set; }

    bool IsTodayHighlighted { get; set; }

    CalendarViewDisplayMode DisplayMode { get; set; }

    DayOfWeek FirstDayOfWeek { get; set; }

    string DayOfWeekFormat { get; set; }

    string CalendarIdentifier { get; set; }

    bool IsOutOfScopeEnabled { get; set; }

    bool IsGroupLabelVisible { get; set; }

    event CalendarViewDayItemChangingEventHandler CalendarViewDayItemChanging;

    event TypedEventHandler<CalendarDatePicker, CalendarDatePickerDateChangedEventArgs> DateChanged;

    event EventHandler<object> Opened;

    event EventHandler<object> Closed;

    void SetDisplayDate(DateTime date);

    void SetYearDecadeDisplayDimensions(int columns, int rows);
  }
}
