// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.IPercentFormatterFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3078785775, 65236, 16408, 166, 226, 224, 153, 97, 224, 55, 101)]
  [ExclusiveTo(typeof (PercentFormatter))]
  internal interface IPercentFormatterFactory
  {
    PercentFormatter CreatePercentFormatter(
      IIterable<string> languages,
      string geographicRegion);
  }
}
