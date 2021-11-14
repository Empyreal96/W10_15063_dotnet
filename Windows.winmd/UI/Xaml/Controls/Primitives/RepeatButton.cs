// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.RepeatButton
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IRepeatButtonStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class RepeatButton : ButtonBase, IRepeatButton
  {
    [MethodImpl]
    public extern RepeatButton();

    public extern int Delay { [MethodImpl] get; [MethodImpl] set; }

    public extern int Interval { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty DelayProperty { [MethodImpl] get; }

    public static extern DependencyProperty IntervalProperty { [MethodImpl] get; }
  }
}
