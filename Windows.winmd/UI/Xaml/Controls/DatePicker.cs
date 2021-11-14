// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.DatePicker
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Controls
{
  [Composable(typeof (IDatePickerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IDatePickerStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContentProperty(Name = "Header")]
  [Static(typeof (IDatePickerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public class DatePicker : Control, IDatePicker, IDatePicker2
  {
    [MethodImpl]
    public extern DatePicker();

    public extern object Header { [MethodImpl] get; [MethodImpl] set; }

    public extern DataTemplate HeaderTemplate { [MethodImpl] get; [MethodImpl] set; }

    public extern string CalendarIdentifier { [MethodImpl] get; [MethodImpl] set; }

    public extern DateTime Date { [MethodImpl] get; [MethodImpl] set; }

    public extern bool DayVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern bool MonthVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern bool YearVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern string DayFormat { [MethodImpl] get; [MethodImpl] set; }

    public extern string MonthFormat { [MethodImpl] get; [MethodImpl] set; }

    public extern string YearFormat { [MethodImpl] get; [MethodImpl] set; }

    public extern DateTime MinYear { [MethodImpl] get; [MethodImpl] set; }

    public extern DateTime MaxYear { [MethodImpl] get; [MethodImpl] set; }

    public extern Orientation Orientation { [MethodImpl] get; [MethodImpl] set; }

    public extern event EventHandler<DatePickerValueChangedEventArgs> DateChanged;

    public extern LightDismissOverlayMode LightDismissOverlayMode { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty LightDismissOverlayModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty HeaderProperty { [MethodImpl] get; }

    public static extern DependencyProperty HeaderTemplateProperty { [MethodImpl] get; }

    public static extern DependencyProperty CalendarIdentifierProperty { [MethodImpl] get; }

    public static extern DependencyProperty DateProperty { [MethodImpl] get; }

    public static extern DependencyProperty DayVisibleProperty { [MethodImpl] get; }

    public static extern DependencyProperty MonthVisibleProperty { [MethodImpl] get; }

    public static extern DependencyProperty YearVisibleProperty { [MethodImpl] get; }

    public static extern DependencyProperty DayFormatProperty { [MethodImpl] get; }

    public static extern DependencyProperty MonthFormatProperty { [MethodImpl] get; }

    public static extern DependencyProperty YearFormatProperty { [MethodImpl] get; }

    public static extern DependencyProperty MinYearProperty { [MethodImpl] get; }

    public static extern DependencyProperty MaxYearProperty { [MethodImpl] get; }

    public static extern DependencyProperty OrientationProperty { [MethodImpl] get; }
  }
}
