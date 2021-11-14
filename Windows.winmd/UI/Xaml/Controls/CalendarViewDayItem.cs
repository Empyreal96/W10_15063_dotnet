// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.CalendarViewDayItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ICalendarViewDayItemStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (ICalendarViewDayItemFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class CalendarViewDayItem : Control, ICalendarViewDayItem
  {
    [MethodImpl]
    public extern CalendarViewDayItem();

    public extern bool IsBlackout { [MethodImpl] get; [MethodImpl] set; }

    public extern DateTime Date { [MethodImpl] get; }

    [MethodImpl]
    public extern void SetDensityColors(IIterable<Color> colors);

    public static extern DependencyProperty IsBlackoutProperty { [MethodImpl] get; }

    public static extern DependencyProperty DateProperty { [MethodImpl] get; }
  }
}
