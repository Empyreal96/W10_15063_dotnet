// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IDatePickerFlyout
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(4227021594, 41892, 19960, 146, 40, 35, 165, 172, 39, 223, 78)]
  [ExclusiveTo(typeof (DatePickerFlyout))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDatePickerFlyout
  {
    string CalendarIdentifier { get; set; }

    DateTime Date { get; set; }

    bool DayVisible { get; set; }

    bool MonthVisible { get; set; }

    bool YearVisible { get; set; }

    DateTime MinYear { get; set; }

    DateTime MaxYear { get; set; }

    event TypedEventHandler<DatePickerFlyout, DatePickedEventArgs> DatePicked;

    [RemoteAsync]
    IAsyncOperation<IReference<DateTime>> ShowAtAsync(
      FrameworkElement target);
  }
}
