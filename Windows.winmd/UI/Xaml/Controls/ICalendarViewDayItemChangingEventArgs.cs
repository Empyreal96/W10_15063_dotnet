// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICalendarViewDayItemChangingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1930716774, 8113, 17657, 183, 173, 77, 232, 89, 236, 197, 101)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CalendarViewDayItemChangingEventArgs))]
  internal interface ICalendarViewDayItemChangingEventArgs
  {
    bool InRecycleQueue { get; }

    CalendarViewDayItem Item { get; }

    uint Phase { get; }

    [Overload("RegisterUpdateCallback")]
    void RegisterUpdateCallback(
      TypedEventHandler<CalendarView, CalendarViewDayItemChangingEventArgs> callback);

    [Overload("RegisterUpdateCallbackWithPhase")]
    void RegisterUpdateCallback(
      uint callbackPhase,
      TypedEventHandler<CalendarView, CalendarViewDayItemChangingEventArgs> callback);
  }
}
