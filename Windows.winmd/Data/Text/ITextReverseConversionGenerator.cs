// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.ITextReverseConversionGenerator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TextReverseConversionGenerator))]
  [Guid(1374156052, 40017, 19846, 174, 27, 180, 152, 251, 173, 131, 19)]
  internal interface ITextReverseConversionGenerator
  {
    string ResolvedLanguage { get; }

    bool LanguageAvailableButNotInstalled { get; }

    [RemoteAsync]
    IAsyncOperation<string> ConvertBackAsync(string input);
  }
}
