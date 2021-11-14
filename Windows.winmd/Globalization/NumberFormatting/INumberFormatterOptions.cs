// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.INumberFormatterOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  [Guid(2150837537, 44769, 19001, 186, 162, 7, 237, 140, 150, 218, 246)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface INumberFormatterOptions
  {
    IVectorView<string> Languages { get; }

    string GeographicRegion { get; }

    int IntegerDigits { get; set; }

    int FractionDigits { get; set; }

    bool IsGrouped { get; set; }

    bool IsDecimalPointAlwaysDisplayed { get; set; }

    string NumeralSystem { get; set; }

    string ResolvedLanguage { get; }

    string ResolvedGeographicRegion { get; }
  }
}
