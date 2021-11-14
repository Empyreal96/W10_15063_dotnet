// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.TextConversionGenerator
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
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (ITextConversionGeneratorFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class TextConversionGenerator : ITextConversionGenerator
  {
    [MethodImpl]
    public extern TextConversionGenerator(string languageTag);

    public extern string ResolvedLanguage { [MethodImpl] get; }

    public extern bool LanguageAvailableButNotInstalled { [MethodImpl] get; }

    [Overload("GetCandidatesAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<string>> GetCandidatesAsync(
      string input);

    [RemoteAsync]
    [Overload("GetCandidatesWithMaxCountAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<string>> GetCandidatesAsync(
      string input,
      uint maxCandidates);
  }
}
