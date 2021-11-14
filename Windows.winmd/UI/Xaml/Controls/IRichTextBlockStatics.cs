// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichTextBlockStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (RichTextBlock))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1227720764, 44522, 17212, 190, 28, 32, 138, 22, 66, 98, 190)]
  internal interface IRichTextBlockStatics
  {
    DependencyProperty FontSizeProperty { get; }

    DependencyProperty FontFamilyProperty { get; }

    DependencyProperty FontWeightProperty { get; }

    DependencyProperty FontStyleProperty { get; }

    DependencyProperty FontStretchProperty { get; }

    DependencyProperty ForegroundProperty { get; }

    DependencyProperty TextWrappingProperty { get; }

    DependencyProperty TextTrimmingProperty { get; }

    DependencyProperty TextAlignmentProperty { get; }

    DependencyProperty PaddingProperty { get; }

    DependencyProperty LineHeightProperty { get; }

    DependencyProperty LineStackingStrategyProperty { get; }

    DependencyProperty CharacterSpacingProperty { get; }

    DependencyProperty OverflowContentTargetProperty { get; }

    DependencyProperty IsTextSelectionEnabledProperty { get; }

    DependencyProperty HasOverflowContentProperty { get; }

    DependencyProperty SelectedTextProperty { get; }

    DependencyProperty TextIndentProperty { get; }
  }
}
