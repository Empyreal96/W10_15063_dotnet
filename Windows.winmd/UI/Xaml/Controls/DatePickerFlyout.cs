// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.DatePickerFlyout
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IDatePickerFlyoutStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IDatePickerFlyoutStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DatePickerFlyout : PickerFlyoutBase, IDatePickerFlyout, IDatePickerFlyout2
  {
    [MethodImpl]
    public extern DatePickerFlyout();

    public extern string CalendarIdentifier { [MethodImpl] get; [MethodImpl] set; }

    public extern DateTime Date { [MethodImpl] get; [MethodImpl] set; }

    public extern bool DayVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern bool MonthVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern bool YearVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern DateTime MinYear { [MethodImpl] get; [MethodImpl] set; }

    public extern DateTime MaxYear { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<DatePickerFlyout, DatePickedEventArgs> DatePicked;

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IReference<DateTime>> ShowAtAsync(
      FrameworkElement target);

    public extern string DayFormat { [MethodImpl] get; [MethodImpl] set; }

    public extern string MonthFormat { [MethodImpl] get; [MethodImpl] set; }

    public extern string YearFormat { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty DayFormatProperty { [MethodImpl] get; }

    public static extern DependencyProperty MonthFormatProperty { [MethodImpl] get; }

    public static extern DependencyProperty YearFormatProperty { [MethodImpl] get; }

    public static extern DependencyProperty CalendarIdentifierProperty { [MethodImpl] get; }

    public static extern DependencyProperty DateProperty { [MethodImpl] get; }

    public static extern DependencyProperty DayVisibleProperty { [MethodImpl] get; }

    public static extern DependencyProperty MonthVisibleProperty { [MethodImpl] get; }

    public static extern DependencyProperty YearVisibleProperty { [MethodImpl] get; }

    public static extern DependencyProperty MinYearProperty { [MethodImpl] get; }

    public static extern DependencyProperty MaxYearProperty { [MethodImpl] get; }
  }
}
