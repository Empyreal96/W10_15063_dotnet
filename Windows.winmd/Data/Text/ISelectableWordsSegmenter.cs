// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.ISelectableWordsSegmenter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [ExclusiveTo(typeof (SelectableWordsSegmenter))]
  [Guid(4141625831, 19219, 17861, 136, 151, 125, 113, 38, 158, 8, 93)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISelectableWordsSegmenter
  {
    string ResolvedLanguage { get; }

    SelectableWordSegment GetTokenAt(string text, uint startIndex);

    IVectorView<SelectableWordSegment> GetTokens(string text);

    void Tokenize(string text, uint startIndex, SelectableWordSegmentsTokenizingHandler handler);
  }
}
