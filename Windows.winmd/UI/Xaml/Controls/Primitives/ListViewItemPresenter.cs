// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Static(typeof (IListViewItemPresenterStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IListViewItemPresenterFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IListViewItemPresenterStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public class ListViewItemPresenter : 
    ContentPresenter,
    IListViewItemPresenter,
    IListViewItemPresenter2
  {
    [MethodImpl]
    public extern ListViewItemPresenter();

    public extern bool SelectionCheckMarkVisualEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush CheckHintBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush CheckSelectingBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush CheckBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush DragBackground { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush DragForeground { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush FocusBorderBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush PlaceholderBackground { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush PointerOverBackground { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush SelectedBackground { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush SelectedForeground { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush SelectedPointerOverBackground { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush SelectedPointerOverBorderBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Thickness SelectedBorderThickness { [MethodImpl] get; [MethodImpl] set; }

    public extern double DisabledOpacity { [MethodImpl] get; [MethodImpl] set; }

    public extern double DragOpacity { [MethodImpl] get; [MethodImpl] set; }

    public extern double ReorderHintOffset { [MethodImpl] get; [MethodImpl] set; }

    public extern HorizontalAlignment ListViewItemPresenterHorizontalContentAlignment { [Deprecated("Use ContentPresenter.HorizontalContentAlignment instead of ListViewItemPresenterHorizontalContentAlignment. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("Use ContentPresenter.HorizontalContentAlignment instead of ListViewItemPresenterHorizontalContentAlignment. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    public extern VerticalAlignment ListViewItemPresenterVerticalContentAlignment { [Deprecated("Use ContentPresenter.VerticalContentAlignment instead of ListViewItemPresenterVerticalContentAlignment. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("Use ContentPresenter.VerticalContentAlignment instead of ListViewItemPresenterVerticalContentAlignment. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    public extern Thickness ListViewItemPresenterPadding { [Deprecated("Use ContentPresenter.Padding instead of GridViewItemPresenterPadding. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("Use ContentPresenter.Padding instead of GridViewItemPresenterPadding. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    public extern Thickness PointerOverBackgroundMargin { [MethodImpl] get; [MethodImpl] set; }

    public extern Thickness ContentMargin { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush SelectedPressedBackground { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush PressedBackground { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush CheckBoxBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush FocusSecondaryBorderBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern ListViewItemPresenterCheckMode CheckMode { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush PointerOverForeground { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty SelectedPressedBackgroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty PressedBackgroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty CheckBoxBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty FocusSecondaryBorderBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty CheckModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty PointerOverForegroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectionCheckMarkVisualEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty CheckHintBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty CheckSelectingBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty CheckBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty DragBackgroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty DragForegroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty FocusBorderBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty PlaceholderBackgroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty PointerOverBackgroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectedBackgroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectedForegroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectedPointerOverBackgroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectedPointerOverBorderBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectedBorderThicknessProperty { [MethodImpl] get; }

    public static extern DependencyProperty DisabledOpacityProperty { [MethodImpl] get; }

    public static extern DependencyProperty DragOpacityProperty { [MethodImpl] get; }

    public static extern DependencyProperty ReorderHintOffsetProperty { [MethodImpl] get; }

    public static extern DependencyProperty ListViewItemPresenterHorizontalContentAlignmentProperty { [Deprecated("Use ContentPresenter.HorizontalContentAlignment instead of ListViewItemPresenterHorizontalContentAlignment. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public static extern DependencyProperty ListViewItemPresenterVerticalContentAlignmentProperty { [Deprecated("Use ContentPresenter.VerticalContentAlignment instead of ListViewItemPresenterVerticalContentAlignment. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public static extern DependencyProperty ListViewItemPresenterPaddingProperty { [Deprecated("Use ContentPresenter.Padding instead of GridViewItemPresenterPadding. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public static extern DependencyProperty PointerOverBackgroundMarginProperty { [MethodImpl] get; }

    public static extern DependencyProperty ContentMarginProperty { [MethodImpl] get; }
  }
}
