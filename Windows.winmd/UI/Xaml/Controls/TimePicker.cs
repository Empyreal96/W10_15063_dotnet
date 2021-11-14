// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.TimePicker
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (ITimePickerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ITimePickerStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ContentProperty(Name = "Header")]
  [Static(typeof (ITimePickerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class TimePicker : Control, ITimePicker, ITimePicker2
  {
    [MethodImpl]
    public extern TimePicker();

    public extern object Header { [MethodImpl] get; [MethodImpl] set; }

    public extern DataTemplate HeaderTemplate { [MethodImpl] get; [MethodImpl] set; }

    public extern string ClockIdentifier { [MethodImpl] get; [MethodImpl] set; }

    public extern int MinuteIncrement { [MethodImpl] get; [MethodImpl] set; }

    public extern TimeSpan Time { [MethodImpl] get; [MethodImpl] set; }

    public extern event EventHandler<TimePickerValueChangedEventArgs> TimeChanged;

    public extern LightDismissOverlayMode LightDismissOverlayMode { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty LightDismissOverlayModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty HeaderProperty { [MethodImpl] get; }

    public static extern DependencyProperty HeaderTemplateProperty { [MethodImpl] get; }

    public static extern DependencyProperty ClockIdentifierProperty { [MethodImpl] get; }

    public static extern DependencyProperty MinuteIncrementProperty { [MethodImpl] get; }

    public static extern DependencyProperty TimeProperty { [MethodImpl] get; }
  }
}
