// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.TextReverseConversionGenerator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (ITextReverseConversionGeneratorFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class TextReverseConversionGenerator : 
    ITextReverseConversionGenerator,
    ITextReverseConversionGenerator2
  {
    [MethodImpl]
    public extern TextReverseConversionGenerator(string languageTag);

    public extern string ResolvedLanguage { [MethodImpl] get; }

    public extern bool LanguageAvailableButNotInstalled { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> ConvertBackAsync(string input);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<TextPhoneme>> GetPhonemesAsync(
      string input);
  }
}
