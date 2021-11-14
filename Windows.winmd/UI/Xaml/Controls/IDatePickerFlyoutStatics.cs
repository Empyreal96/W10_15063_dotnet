// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IDatePickerFlyoutStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3445031799, 22597, 19474, 140, 16, 89, 45, 159, 204, 124, 217)]
  [ExclusiveTo(typeof (DatePickerFlyout))]
  [WebHostHidden]
  internal interface IDatePickerFlyoutStatics
  {
    DependencyProperty CalendarIdentifierProperty { get; }

    DependencyProperty DateProperty { get; }

    DependencyProperty DayVisibleProperty { get; }

    DependencyProperty MonthVisibleProperty { get; }

    DependencyProperty YearVisibleProperty { get; }

    DependencyProperty MinYearProperty { get; }

    DependencyProperty MaxYearProperty { get; }
  }
}
