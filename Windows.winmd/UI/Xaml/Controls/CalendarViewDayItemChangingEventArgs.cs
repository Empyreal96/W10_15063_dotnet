// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.CalendarViewDayItemChangingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CalendarViewDayItemChangingEventArgs : ICalendarViewDayItemChangingEventArgs
  {
    public extern bool InRecycleQueue { [MethodImpl] get; }

    public extern CalendarViewDayItem Item { [MethodImpl] get; }

    public extern uint Phase { [MethodImpl] get; }

    [Overload("RegisterUpdateCallback")]
    [MethodImpl]
    public extern void RegisterUpdateCallback(
      TypedEventHandler<CalendarView, CalendarViewDayItemChangingEventArgs> callback);

    [Overload("RegisterUpdateCallbackWithPhase")]
    [MethodImpl]
    public extern void RegisterUpdateCallback(
      uint callbackPhase,
      TypedEventHandler<CalendarView, CalendarViewDayItemChangingEventArgs> callback);
  }
}
