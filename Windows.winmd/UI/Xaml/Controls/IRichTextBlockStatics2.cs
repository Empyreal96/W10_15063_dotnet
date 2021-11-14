// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichTextBlockStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (RichTextBlock))]
  [Guid(224473569, 44841, 18638, 138, 175, 116, 236, 194, 139, 251, 176)]
  internal interface IRichTextBlockStatics2
  {
    DependencyProperty MaxLinesProperty { get; }

    DependencyProperty TextLineBoundsProperty { get; }

    DependencyProperty SelectionHighlightColorProperty { get; }

    DependencyProperty OpticalMarginAlignmentProperty { get; }

    DependencyProperty IsColorFontEnabledProperty { get; }

    DependencyProperty TextReadingOrderProperty { get; }
  }
}
