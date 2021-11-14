// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICalendarDatePickerDateChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1624837554, 20496, 18106, 132, 45, 164, 21, 44, 101, 4, 231)]
  [ExclusiveTo(typeof (CalendarDatePickerDateChangedEventArgs))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICalendarDatePickerDateChangedEventArgs
  {
    IReference<DateTime> NewDate { get; }

    IReference<DateTime> OldDate { get; }
  }
}
