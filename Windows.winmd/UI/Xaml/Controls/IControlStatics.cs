// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IControlStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Control))]
  [Guid(1195061339, 34685, 19509, 143, 202, 70, 160, 95, 150, 96, 122)]
  [WebHostHidden]
  internal interface IControlStatics
  {
    DependencyProperty FontSizeProperty { get; }

    DependencyProperty FontFamilyProperty { get; }

    DependencyProperty FontWeightProperty { get; }

    DependencyProperty FontStyleProperty { get; }

    DependencyProperty FontStretchProperty { get; }

    DependencyProperty CharacterSpacingProperty { get; }

    DependencyProperty ForegroundProperty { get; }

    DependencyProperty IsTabStopProperty { get; }

    DependencyProperty IsEnabledProperty { get; }

    DependencyProperty TabIndexProperty { get; }

    DependencyProperty TabNavigationProperty { get; }

    DependencyProperty TemplateProperty { get; }

    DependencyProperty PaddingProperty { get; }

    DependencyProperty HorizontalContentAlignmentProperty { get; }

    DependencyProperty VerticalContentAlignmentProperty { get; }

    DependencyProperty BackgroundProperty { get; }

    DependencyProperty BorderThicknessProperty { get; }

    DependencyProperty BorderBrushProperty { get; }

    DependencyProperty DefaultStyleKeyProperty { get; }

    DependencyProperty FocusStateProperty { get; }
  }
}
