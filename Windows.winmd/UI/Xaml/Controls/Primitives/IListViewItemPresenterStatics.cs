// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IListViewItemPresenterStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Guid(1694803290, 5597, 17147, 170, 93, 45, 140, 226, 233, 194, 148)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ListViewItemPresenter))]
  internal interface IListViewItemPresenterStatics
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

    DependencyProperty ListViewItemPresenterHorizontalContentAlignmentProperty { [Deprecated("Use ContentPresenter.HorizontalContentAlignment instead of ListViewItemPresenterHorizontalContentAlignment. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    DependencyProperty ListViewItemPresenterVerticalContentAlignmentProperty { [Deprecated("Use ContentPresenter.VerticalContentAlignment instead of ListViewItemPresenterVerticalContentAlignment. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    DependencyProperty ListViewItemPresenterPaddingProperty { [Deprecated("Use ContentPresenter.Padding instead of GridViewItemPresenterPadding. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    DependencyProperty PointerOverBackgroundMarginProperty { get; }

    DependencyProperty ContentMarginProperty { get; }
  }
}
