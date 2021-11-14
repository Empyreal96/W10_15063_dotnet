// Decompiled with JetBrains decompiler
// Type: Windows.Media.Ocr.IOcrEngineStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.Media.Ocr
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (OcrEngine))]
  [Guid(1543481434, 13188, 13632, 153, 64, 105, 145, 32, 212, 40, 168)]
  internal interface IOcrEngineStatics
  {
    uint MaxImageDimension { get; }

    IVectorView<Language> AvailableRecognizerLanguages { get; }

    bool IsLanguageSupported(Language language);

    OcrEngine TryCreateFromLanguage(Language language);

    OcrEngine TryCreateFromUserProfileLanguages();
  }
}
