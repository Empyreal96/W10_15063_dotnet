// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.IGeographicRegion
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [ExclusiveTo(typeof (GeographicRegion))]
  [Guid(32089633, 19044, 20185, 149, 79, 158, 222, 176, 123, 217, 3)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGeographicRegion
  {
    string Code { get; }

    string CodeTwoLetter { get; }

    string CodeThreeLetter { get; }

    string CodeThreeDigit { get; }

    string DisplayName { get; }

    string NativeName { get; }

    IVectorView<string> CurrenciesInUse { get; }
  }
}
