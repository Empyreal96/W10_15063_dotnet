// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.WrapGrid
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IWrapGridStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WrapGrid : OrientedVirtualizingPanel, IWrapGrid
  {
    [MethodImpl]
    public extern WrapGrid();

    public extern double ItemWidth { [MethodImpl] get; [MethodImpl] set; }

    public extern double ItemHeight { [MethodImpl] get; [MethodImpl] set; }

    public extern Orientation Orientation { [MethodImpl] get; [MethodImpl] set; }

    public extern HorizontalAlignment HorizontalChildrenAlignment { [MethodImpl] get; [MethodImpl] set; }

    public extern VerticalAlignment VerticalChildrenAlignment { [MethodImpl] get; [MethodImpl] set; }

    public extern int MaximumRowsOrColumns { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty ItemWidthProperty { [MethodImpl] get; }

    public static extern DependencyProperty ItemHeightProperty { [MethodImpl] get; }

    public static extern DependencyProperty OrientationProperty { [MethodImpl] get; }

    public static extern DependencyProperty HorizontalChildrenAlignmentProperty { [MethodImpl] get; }

    public static extern DependencyProperty VerticalChildrenAlignmentProperty { [MethodImpl] get; }

    public static extern DependencyProperty MaximumRowsOrColumnsProperty { [MethodImpl] get; }
  }
}
