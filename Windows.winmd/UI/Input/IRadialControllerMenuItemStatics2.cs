// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IRadialControllerMenuItemStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ExclusiveTo(typeof (RadialControllerMenuItem))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(213610686, 32318, 18621, 190, 4, 44, 127, 202, 169, 193, 255)]
  internal interface IRadialControllerMenuItemStatics2
  {
    [Overload("CreateFromFontGlyph")]
    RadialControllerMenuItem CreateFromFontGlyph(
      string displayText,
      string glyph,
      string fontFamily);

    [Overload("CreateFromFontGlyphWithUri")]
    RadialControllerMenuItem CreateFromFontGlyph(
      string displayText,
      string glyph,
      string fontFamily,
      Uri fontUri);
  }
}
