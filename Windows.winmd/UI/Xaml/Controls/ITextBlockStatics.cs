// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBlockStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (TextBlock))]
  [WebHostHidden]
  [Guid(423542850, 43079, 17746, 180, 232, 219, 54, 101, 91, 132, 10)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITextBlockStatics
  {
    DependencyProperty FontSizeProperty { get; }

    DependencyProperty FontFamilyProperty { get; }

    DependencyProperty FontWeightProperty { get; }

    DependencyProperty FontStyleProperty { get; }

    DependencyProperty FontStretchProperty { get; }

    DependencyProperty CharacterSpacingProperty { get; }

    DependencyProperty ForegroundProperty { get; }

    DependencyProperty TextWrappingProperty { get; }

    DependencyProperty TextTrimmingProperty { get; }

    DependencyProperty TextAlignmentProperty { get; }

    DependencyProperty TextProperty { get; }

    DependencyProperty PaddingProperty { get; }

    DependencyProperty LineHeightProperty { get; }

    DependencyProperty LineStackingStrategyProperty { get; }

    DependencyProperty IsTextSelectionEnabledProperty { get; }

    DependencyProperty SelectedTextProperty { get; }
  }
}
