// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.ICurrencyFormatter2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(120336157, 59322, 16791, 146, 14, 36, 124, 146, 247, 222, 166)]
  [ExclusiveTo(typeof (CurrencyFormatter))]
  internal interface ICurrencyFormatter2
  {
    CurrencyFormatterMode Mode { get; set; }

    void ApplyRoundingForCurrency(RoundingAlgorithm roundingAlgorithm);
  }
}
