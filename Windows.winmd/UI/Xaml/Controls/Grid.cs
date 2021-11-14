// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Grid
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IGridStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IGridFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IGridStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public class Grid : Panel, IGrid, IGrid2
  {
    [MethodImpl]
    public extern Grid();

    public extern RowDefinitionCollection RowDefinitions { [MethodImpl] get; }

    public extern ColumnDefinitionCollection ColumnDefinitions { [MethodImpl] get; }

    public extern Brush BorderBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Thickness BorderThickness { [MethodImpl] get; [MethodImpl] set; }

    public extern CornerRadius CornerRadius { [MethodImpl] get; [MethodImpl] set; }

    public extern Thickness Padding { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty BorderBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty BorderThicknessProperty { [MethodImpl] get; }

    public static extern DependencyProperty CornerRadiusProperty { [MethodImpl] get; }

    public static extern DependencyProperty PaddingProperty { [MethodImpl] get; }

    public static extern DependencyProperty RowProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern int GetRow(FrameworkElement element);

    [MethodImpl]
    public static extern void SetRow(FrameworkElement element, int value);

    public static extern DependencyProperty ColumnProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern int GetColumn(FrameworkElement element);

    [MethodImpl]
    public static extern void SetColumn(FrameworkElement element, int value);

    public static extern DependencyProperty RowSpanProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern int GetRowSpan(FrameworkElement element);

    [MethodImpl]
    public static extern void SetRowSpan(FrameworkElement element, int value);

    public static extern DependencyProperty ColumnSpanProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern int GetColumnSpan(FrameworkElement element);

    [MethodImpl]
    public static extern void SetColumnSpan(FrameworkElement element, int value);
  }
}
