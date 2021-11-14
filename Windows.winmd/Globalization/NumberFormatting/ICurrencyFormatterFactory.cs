// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.ICurrencyFormatterFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CurrencyFormatter))]
  [Guid(2261209982, 47416, 19106, 132, 176, 44, 51, 220, 91, 20, 80)]
  internal interface ICurrencyFormatterFactory
  {
    CurrencyFormatter CreateCurrencyFormatterCode(string currencyCode);

    CurrencyFormatter CreateCurrencyFormatterCodeContext(
      string currencyCode,
      IIterable<string> languages,
      string geographicRegion);
  }
}
