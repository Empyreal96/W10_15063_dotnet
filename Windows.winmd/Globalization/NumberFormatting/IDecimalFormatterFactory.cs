// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.IDecimalFormatterFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(218205338, 58259, 18104, 184, 48, 122, 105, 200, 248, 159, 187)]
  [ExclusiveTo(typeof (DecimalFormatter))]
  internal interface IDecimalFormatterFactory
  {
    DecimalFormatter CreateDecimalFormatter(
      IIterable<string> languages,
      string geographicRegion);
  }
}
