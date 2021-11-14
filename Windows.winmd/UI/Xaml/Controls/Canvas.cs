// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Canvas
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ICanvasStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (ICanvasFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class Canvas : Panel, ICanvas
  {
    [MethodImpl]
    public extern Canvas();

    public static extern DependencyProperty LeftProperty { [IndependentlyAnimatable, MethodImpl] get; }

    [MethodImpl]
    public static extern double GetLeft(UIElement element);

    [MethodImpl]
    public static extern void SetLeft(UIElement element, double length);

    public static extern DependencyProperty TopProperty { [IndependentlyAnimatable, MethodImpl] get; }

    [MethodImpl]
    public static extern double GetTop(UIElement element);

    [MethodImpl]
    public static extern void SetTop(UIElement element, double length);

    public static extern DependencyProperty ZIndexProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern int GetZIndex(UIElement element);

    [MethodImpl]
    public static extern void SetZIndex(UIElement element, int value);
  }
}
