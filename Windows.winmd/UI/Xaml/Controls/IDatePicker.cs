// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IDatePicker
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (DatePicker))]
  [Guid(114964806, 2232, 16643, 139, 138, 9, 62, 253, 106, 118, 87)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDatePicker
  {
    object Header { get; set; }

    DataTemplate HeaderTemplate { get; set; }

    string CalendarIdentifier { get; set; }

    DateTime Date { get; set; }

    bool DayVisible { get; set; }

    bool MonthVisible { get; set; }

    bool YearVisible { get; set; }

    string DayFormat { get; set; }

    string MonthFormat { get; set; }

    string YearFormat { get; set; }

    DateTime MinYear { get; set; }

    DateTime MaxYear { get; set; }

    Orientation Orientation { get; set; }

    event EventHandler<DatePickerValueChangedEventArgs> DateChanged;
  }
}
