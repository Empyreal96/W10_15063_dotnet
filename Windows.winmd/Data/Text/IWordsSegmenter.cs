// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.IWordsSegmenter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [Guid(2259997905, 45822, 20020, 168, 29, 102, 100, 3, 0, 69, 79)]
  [ExclusiveTo(typeof (WordsSegmenter))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWordsSegmenter
  {
    string ResolvedLanguage { get; }

    WordSegment GetTokenAt(string text, uint startIndex);

    IVectorView<WordSegment> GetTokens(string text);

    void Tokenize(string text, uint startIndex, WordSegmentsTokenizingHandler handler);
  }
}
