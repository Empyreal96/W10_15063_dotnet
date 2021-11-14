// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IGlyphsStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(273193639, 5653, 18995, 170, 2, 215, 239, 42, 239, 199, 57)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Glyphs))]
  internal interface IGlyphsStatics2
  {
    DependencyProperty IsColorFontEnabledProperty { get; }

    DependencyProperty ColorFontPaletteIndexProperty { get; }
  }
}
