// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IGlyphs2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [ExclusiveTo(typeof (Glyphs))]
  [WebHostHidden]
  [Guid(2861301340, 14164, 19438, 187, 225, 68, 3, 238, 155, 134, 240)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGlyphs2
  {
    bool IsColorFontEnabled { get; set; }

    int ColorFontPaletteIndex { get; set; }
  }
}
