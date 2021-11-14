// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.WordsSegmenter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IWordsSegmenterFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class WordsSegmenter : IWordsSegmenter
  {
    [MethodImpl]
    public extern WordsSegmenter(string language);

    public extern string ResolvedLanguage { [MethodImpl] get; }

    [MethodImpl]
    public extern WordSegment GetTokenAt(string text, uint startIndex);

    [MethodImpl]
    public extern IVectorView<WordSegment> GetTokens(string text);

    [MethodImpl]
    public extern void Tokenize(
      string text,
      uint startIndex,
      WordSegmentsTokenizingHandler handler);
  }
}
