// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IGridViewItemPresenterStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Guid(3914922180, 10110, 19058, 160, 30, 158, 22, 136, 152, 1, 120)]
  [ExclusiveTo(typeof (GridViewItemPresenter))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGridViewItemPresenterStatics
  {
    DependencyProperty SelectionCheckMarkVisualEnabledProperty { get; }

    DependencyProperty CheckHintBrushProperty { get; }

    DependencyProperty CheckSelectingBrushProperty { get; }

    DependencyProperty CheckBrushProperty { get; }

    DependencyProperty DragBackgroundProperty { get; }

    DependencyProperty DragForegroundProperty { get; }

    DependencyProperty FocusBorderBrushProperty { get; }

    DependencyProperty PlaceholderBackgroundProperty { get; }

    DependencyProperty PointerOverBackgroundProperty { get; }

    DependencyProperty SelectedBackgroundProperty { get; }

    DependencyProperty SelectedForegroundProperty { get; }

    DependencyProperty SelectedPointerOverBackgroundProperty { get; }

    DependencyProperty SelectedPointerOverBorderBrushProperty { get; }

    DependencyProperty SelectedBorderThicknessProperty { get; }

    DependencyProperty DisabledOpacityProperty { get; }

    DependencyProperty DragOpacityProperty { get; }

    DependencyProperty ReorderHintOffsetProperty { get; }

    DependencyProperty GridViewItemPresenterHorizontalContentAlignmentProperty { [Deprecated("Use ContentPresenter.HorizontalContentAlignment instead of GridViewItemPresenterHorizontalContentAlignment. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    DependencyProperty GridViewItemPresenterVerticalContentAlignmentProperty { [Deprecated("Use ContentPresenter.VerticalContentAlignment instead of GridViewItemPresenterVerticalContentAlignment. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    DependencyProperty GridViewItemPresenterPaddingProperty { [Deprecated("Use ContentPresenter.Padding instead of GridViewItemPresenterPadding. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    DependencyProperty PointerOverBackgroundMarginProperty { get; }

    DependencyProperty ContentMarginProperty { get; }
  }
}
