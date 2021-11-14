// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.ICurrencyFormatter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(292752549, 19200, 16818, 179, 50, 115, 177, 42, 73, 125, 84)]
  [ExclusiveTo(typeof (CurrencyFormatter))]
  internal interface ICurrencyFormatter : 
    INumberFormatterOptions,
    INumberFormatter,
    INumberFormatter2,
    INumberParser
  {
    string Currency { get; [Deprecated("Currency may be read-only for releases after Windows 8.1. Instead, use a new CurrencyFormatter.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; }
  }
}
