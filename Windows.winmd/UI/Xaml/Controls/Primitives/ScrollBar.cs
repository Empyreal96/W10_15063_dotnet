// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ScrollBar
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IScrollBarStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ScrollBar : RangeBase, IScrollBar
  {
    [MethodImpl]
    public extern ScrollBar();

    public extern Orientation Orientation { [MethodImpl] get; [MethodImpl] set; }

    public extern double ViewportSize { [MethodImpl] get; [MethodImpl] set; }

    public extern ScrollingIndicatorMode IndicatorMode { [MethodImpl] get; [MethodImpl] set; }

    public extern event ScrollEventHandler Scroll;

    public static extern DependencyProperty OrientationProperty { [MethodImpl] get; }

    public static extern DependencyProperty ViewportSizeProperty { [MethodImpl] get; }

    public static extern DependencyProperty IndicatorModeProperty { [MethodImpl] get; }
  }
}
