// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.TextPredictionGenerator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (ITextPredictionGeneratorFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class TextPredictionGenerator : ITextPredictionGenerator
  {
    [MethodImpl]
    public extern TextPredictionGenerator(string languageTag);

    public extern string ResolvedLanguage { [MethodImpl] get; }

    public extern bool LanguageAvailableButNotInstalled { [MethodImpl] get; }

    [Overload("GetCandidatesAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<string>> GetCandidatesAsync(
      string input);

    [Overload("GetCandidatesWithMaxCountAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<string>> GetCandidatesAsync(
      string input,
      uint maxCandidates);
  }
}
