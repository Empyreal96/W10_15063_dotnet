// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IDatePickerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(405699689, 8470, 19559, 181, 19, 113, 51, 100, 131, 29, 121)]
  [WebHostHidden]
  [ExclusiveTo(typeof (DatePicker))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDatePickerStatics
  {
    DependencyProperty HeaderProperty { get; }

    DependencyProperty HeaderTemplateProperty { get; }

    DependencyProperty CalendarIdentifierProperty { get; }

    DependencyProperty DateProperty { get; }

    DependencyProperty DayVisibleProperty { get; }

    DependencyProperty MonthVisibleProperty { get; }

    DependencyProperty YearVisibleProperty { get; }

    DependencyProperty DayFormatProperty { get; }

    DependencyProperty MonthFormatProperty { get; }

    DependencyProperty YearFormatProperty { get; }

    DependencyProperty MinYearProperty { get; }

    DependencyProperty MaxYearProperty { get; }

    DependencyProperty OrientationProperty { get; }
  }
}
