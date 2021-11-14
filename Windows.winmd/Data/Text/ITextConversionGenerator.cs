// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.ITextConversionGenerator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [Guid(56650334, 10921, 19126, 175, 139, 165, 98, 182, 58, 137, 146)]
  [ExclusiveTo(typeof (TextConversionGenerator))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITextConversionGenerator
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
