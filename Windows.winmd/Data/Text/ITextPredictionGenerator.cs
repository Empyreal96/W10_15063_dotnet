// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.ITextPredictionGenerator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [ExclusiveTo(typeof (TextPredictionGenerator))]
  [Guid(1588374279, 44017, 19638, 157, 158, 50, 111, 43, 70, 135, 86)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITextPredictionGenerator
  {
    string ResolvedLanguage { get; }

    bool LanguageAvailableButNotInstalled { get; }

    [RemoteAsync]
    [Overload("GetCandidatesAsync")]
    IAsyncOperation<IVectorView<string>> GetCandidatesAsync(string input);

    [RemoteAsync]
    [Overload("GetCandidatesWithMaxCountAsync")]
    IAsyncOperation<IVectorView<string>> GetCandidatesAsync(
      string input,
      uint maxCandidates);
  }
}
