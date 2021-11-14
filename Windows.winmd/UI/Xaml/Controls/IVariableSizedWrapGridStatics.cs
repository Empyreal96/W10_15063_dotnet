// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IVariableSizedWrapGridStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(4271749209, 33063, 19183, 183, 162, 148, 152, 71, 72, 110, 150)]
  [ExclusiveTo(typeof (VariableSizedWrapGrid))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVariableSizedWrapGridStatics
  {
    DependencyProperty ItemHeightProperty { get; }

    DependencyProperty ItemWidthProperty { get; }

    DependencyProperty OrientationProperty { get; }

    DependencyProperty HorizontalChildrenAlignmentProperty { get; }

    DependencyProperty VerticalChildrenAlignmentProperty { get; }

    DependencyProperty MaximumRowsOrColumnsProperty { get; }

    DependencyProperty RowSpanProperty { get; }

    int GetRowSpan(UIElement element);

    void SetRowSpan(UIElement element, int value);

    DependencyProperty ColumnSpanProperty { get; }

    int GetColumnSpan(UIElement element);

    void SetColumnSpan(UIElement element, int value);
  }
}
