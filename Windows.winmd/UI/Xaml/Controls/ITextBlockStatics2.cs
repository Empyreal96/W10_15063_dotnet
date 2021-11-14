// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBlockStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2282752795, 65316, 19347, 160, 230, 240, 41, 201, 72, 113, 241)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TextBlock))]
  internal interface ITextBlockStatics2
  {
    DependencyProperty SelectionHighlightColorProperty { get; }

    DependencyProperty MaxLinesProperty { get; }

    DependencyProperty TextLineBoundsProperty { get; }

    DependencyProperty OpticalMarginAlignmentProperty { get; }

    DependencyProperty IsColorFontEnabledProperty { get; }

    DependencyProperty TextReadingOrderProperty { get; }
  }
}
