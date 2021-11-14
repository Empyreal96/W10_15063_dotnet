// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.IUnicodeCharactersStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UnicodeCharacters))]
  [Guid(2542837383, 37521, 20369, 182, 200, 182, 227, 89, 215, 167, 251)]
  internal interface IUnicodeCharactersStatics
  {
    uint GetCodepointFromSurrogatePair(uint highSurrogate, uint lowSurrogate);

    void GetSurrogatePairFromCodepoint(
      uint codepoint,
      out char highSurrogate,
      out char lowSurrogate);

    bool IsHighSurrogate(uint codepoint);

    bool IsLowSurrogate(uint codepoint);

    bool IsSupplementary(uint codepoint);

    bool IsNoncharacter(uint codepoint);

    bool IsWhitespace(uint codepoint);

    bool IsAlphabetic(uint codepoint);

    bool IsCased(uint codepoint);

    bool IsUppercase(uint codepoint);

    bool IsLowercase(uint codepoint);

    bool IsIdStart(uint codepoint);

    bool IsIdContinue(uint codepoint);

    bool IsGraphemeBase(uint codepoint);

    bool IsGraphemeExtend(uint codepoint);

    UnicodeNumericType GetNumericType(uint codepoint);

    UnicodeGeneralCategory GetGeneralCategory(uint codepoint);
  }
}
