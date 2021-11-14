// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IFontIconStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(3015605238, 5223, 16518, 187, 203, 78, 33, 217, 122, 123, 77)]
  [ExclusiveTo(typeof (FontIcon))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFontIconStatics
  {
    DependencyProperty GlyphProperty { get; }

    DependencyProperty FontSizeProperty { get; }

    DependencyProperty FontFamilyProperty { get; }

    DependencyProperty FontWeightProperty { get; }

    DependencyProperty FontStyleProperty { get; }
  }
}
