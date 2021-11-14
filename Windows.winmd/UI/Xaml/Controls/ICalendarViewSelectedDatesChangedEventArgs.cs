// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICalendarViewSelectedDatesChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CalendarViewSelectedDatesChangedEventArgs))]
  [Guid(3999295990, 5103, 18582, 143, 252, 83, 2, 177, 177, 117, 57)]
  [WebHostHidden]
  internal interface ICalendarViewSelectedDatesChangedEventArgs
  {
    IVectorView<DateTime> AddedDates { get; }

    IVectorView<DateTime> RemovedDates { get; }
  }
}
