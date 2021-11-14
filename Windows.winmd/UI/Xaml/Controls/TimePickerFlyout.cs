// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.TimePickerFlyout
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ITimePickerFlyoutStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class TimePickerFlyout : PickerFlyoutBase, ITimePickerFlyout
  {
    [MethodImpl]
    public extern TimePickerFlyout();

    public extern string ClockIdentifier { [MethodImpl] get; [MethodImpl] set; }

    public extern TimeSpan Time { [MethodImpl] get; [MethodImpl] set; }

    public extern int MinuteIncrement { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<TimePickerFlyout, TimePickedEventArgs> TimePicked;

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IReference<TimeSpan>> ShowAtAsync(
      FrameworkElement target);

    public static extern DependencyProperty ClockIdentifierProperty { [MethodImpl] get; }

    public static extern DependencyProperty TimeProperty { [MethodImpl] get; }

    public static extern DependencyProperty MinuteIncrementProperty { [MethodImpl] get; }
  }
}
