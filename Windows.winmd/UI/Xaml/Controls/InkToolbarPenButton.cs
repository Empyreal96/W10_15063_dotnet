// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.InkToolbarPenButton
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [Static(typeof (IInkToolbarPenButtonStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (IInkToolbarPenButtonFactory), CompositionType.Protected, 196608, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public class InkToolbarPenButton : InkToolbarToolButton, IInkToolbarPenButton
  {
    public extern IVector<Brush> Palette { [MethodImpl] get; [MethodImpl] set; }

    public extern double MinStrokeWidth { [MethodImpl] get; [MethodImpl] set; }

    public extern double MaxStrokeWidth { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush SelectedBrush { [MethodImpl] get; }

    public extern int SelectedBrushIndex { [MethodImpl] get; [MethodImpl] set; }

    public extern double SelectedStrokeWidth { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty PaletteProperty { [MethodImpl] get; }

    public static extern DependencyProperty MinStrokeWidthProperty { [MethodImpl] get; }

    public static extern DependencyProperty MaxStrokeWidthProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectedBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectedBrushIndexProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectedStrokeWidthProperty { [MethodImpl] get; }
  }
}
