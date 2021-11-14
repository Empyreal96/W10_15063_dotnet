// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.IGeographicRegionStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [Guid(702712180, 31449, 20212, 135, 153, 179, 180, 79, 173, 236, 8)]
  [ExclusiveTo(typeof (GeographicRegion))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGeographicRegionStatics
  {
    bool IsSupported(string geographicRegionCode);
  }
}
