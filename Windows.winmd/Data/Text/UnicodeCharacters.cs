// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.UnicodeCharacters
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IUnicodeCharactersStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public static class UnicodeCharacters
  {
    [MethodImpl]
    public static extern uint GetCodepointFromSurrogatePair(uint highSurrogate, uint lowSurrogate);

    [MethodImpl]
    public static extern void GetSurrogatePairFromCodepoint(
      uint codepoint,
      out char highSurrogate,
      out char lowSurrogate);

    [MethodImpl]
    public static extern bool IsHighSurrogate(uint codepoint);

    [MethodImpl]
    public static extern bool IsLowSurrogate(uint codepoint);

    [MethodImpl]
    public static extern bool IsSupplementary(uint codepoint);

    [MethodImpl]
    public static extern bool IsNoncharacter(uint codepoint);

    [MethodImpl]
    public static extern bool IsWhitespace(uint codepoint);

    [MethodImpl]
    public static extern bool IsAlphabetic(uint codepoint);

    [MethodImpl]
    public static extern bool IsCased(uint codepoint);

    [MethodImpl]
    public static extern bool IsUppercase(uint codepoint);

    [MethodImpl]
    public static extern bool IsLowercase(uint codepoint);

    [MethodImpl]
    public static extern bool IsIdStart(uint codepoint);

    [MethodImpl]
    public static extern bool IsIdContinue(uint codepoint);

    [MethodImpl]
    public static extern bool IsGraphemeBase(uint codepoint);

    [MethodImpl]
    public static extern bool IsGraphemeExtend(uint codepoint);

    [MethodImpl]
    public static extern UnicodeNumericType GetNumericType(uint codepoint);

    [MethodImpl]
    public static extern UnicodeGeneralCategory GetGeneralCategory(
      uint codepoint);
  }
}
