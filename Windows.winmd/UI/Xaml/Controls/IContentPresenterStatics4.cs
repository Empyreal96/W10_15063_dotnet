// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentPresenterStatics4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContentPresenter))]
  [WebHostHidden]
  [Guid(4287357586, 44840, 18411, 165, 195, 220, 68, 206, 212, 15, 210)]
  internal interface IContentPresenterStatics4
  {
    DependencyProperty TextWrappingProperty { get; }

    DependencyProperty MaxLinesProperty { get; }

    DependencyProperty LineStackingStrategyProperty { get; }

    DependencyProperty LineHeightProperty { get; }

    DependencyProperty BorderBrushProperty { get; }

    DependencyProperty BorderThicknessProperty { get; }

    DependencyProperty CornerRadiusProperty { get; }

    DependencyProperty PaddingProperty { get; }

    DependencyProperty BackgroundProperty { get; }

    DependencyProperty HorizontalContentAlignmentProperty { get; }

    DependencyProperty VerticalContentAlignmentProperty { get; }
  }
}
