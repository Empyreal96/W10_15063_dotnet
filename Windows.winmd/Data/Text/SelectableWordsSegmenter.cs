// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.SelectableWordsSegmenter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [Activatable(typeof (ISelectableWordsSegmenterFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SelectableWordsSegmenter : ISelectableWordsSegmenter
  {
    [MethodImpl]
    public extern SelectableWordsSegmenter(string language);

    public extern string ResolvedLanguage { [MethodImpl] get; }

    [MethodImpl]
    public extern SelectableWordSegment GetTokenAt(
      string text,
      uint startIndex);

    [MethodImpl]
    public extern IVectorView<SelectableWordSegment> GetTokens(
      string text);

    [MethodImpl]
    public extern void Tokenize(
      string text,
      uint startIndex,
      SelectableWordSegmentsTokenizingHandler handler);
  }
}
