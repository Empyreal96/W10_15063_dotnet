// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.VariableSizedWrapGrid
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IVariableSizedWrapGridStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class VariableSizedWrapGrid : Panel, IVariableSizedWrapGrid
  {
    [MethodImpl]
    public extern VariableSizedWrapGrid();

    public extern double ItemHeight { [MethodImpl] get; [MethodImpl] set; }

    public extern double ItemWidth { [MethodImpl] get; [MethodImpl] set; }

    public extern Orientation Orientation { [MethodImpl] get; [MethodImpl] set; }

    public extern HorizontalAlignment HorizontalChildrenAlignment { [MethodImpl] get; [MethodImpl] set; }

    public extern VerticalAlignment VerticalChildrenAlignment { [MethodImpl] get; [MethodImpl] set; }

    public extern int MaximumRowsOrColumns { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty ItemHeightProperty { [MethodImpl] get; }

    public static extern DependencyProperty ItemWidthProperty { [MethodImpl] get; }

    public static extern DependencyProperty OrientationProperty { [MethodImpl] get; }

    public static extern DependencyProperty HorizontalChildrenAlignmentProperty { [MethodImpl] get; }

    public static extern DependencyProperty VerticalChildrenAlignmentProperty { [MethodImpl] get; }

    public static extern DependencyProperty MaximumRowsOrColumnsProperty { [MethodImpl] get; }

    public static extern DependencyProperty RowSpanProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern int GetRowSpan(UIElement element);

    [MethodImpl]
    public static extern void SetRowSpan(UIElement element, int value);

    public static extern DependencyProperty ColumnSpanProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern int GetColumnSpan(UIElement element);

    [MethodImpl]
    public static extern void SetColumnSpan(UIElement element, int value);
  }
}
