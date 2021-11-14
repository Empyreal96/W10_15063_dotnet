// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.IGeographicRegionFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1396855408, 30644, 17003, 133, 159, 129, 225, 157, 81, 37, 70)]
  [ExclusiveTo(typeof (GeographicRegion))]
  internal interface IGeographicRegionFactory
  {
    GeographicRegion CreateGeographicRegion(string geographicRegionCode);
  }
}
