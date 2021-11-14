// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.ITextCharacterFormat
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1524560859, 1531, 17453, 128, 101, 100, 42, 254, 160, 44, 237)]
  [WebHostHidden]
  public interface ITextCharacterFormat
  {
    FormatEffect AllCaps { get; set; }

    Color BackgroundColor { get; set; }

    FormatEffect Bold { get; set; }

    FontStretch FontStretch { get; set; }

    FontStyle FontStyle { get; set; }

    Color ForegroundColor { get; set; }

    FormatEffect Hidden { get; set; }

    FormatEffect Italic { get; set; }

    float Kerning { get; set; }

    string LanguageTag { get; set; }

    LinkType LinkType { get; }

    string Name { get; set; }

    FormatEffect Outline { get; set; }

    float Position { get; set; }

    FormatEffect ProtectedText { get; set; }

    float Size { get; set; }

    FormatEffect SmallCaps { get; set; }

    float Spacing { get; set; }

    FormatEffect Strikethrough { get; set; }

    FormatEffect Subscript { get; set; }

    FormatEffect Superscript { get; set; }

    TextScript TextScript { get; set; }

    UnderlineType Underline { get; set; }

    int Weight { get; set; }

    void SetClone(ITextCharacterFormat value);

    ITextCharacterFormat GetClone();

    bool IsEqual(ITextCharacterFormat format);
  }
}
