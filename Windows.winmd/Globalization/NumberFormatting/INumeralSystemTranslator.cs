// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.INumeralSystemTranslator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (NumeralSystemTranslator))]
  [Guid(687193132, 35875, 16948, 173, 46, 250, 90, 58, 66, 110, 155)]
  internal interface INumeralSystemTranslator
  {
    IVectorView<string> Languages { get; }

    string ResolvedLanguage { get; }

    string NumeralSystem { get; set; }

    string TranslateNumerals(string value);
  }
}
