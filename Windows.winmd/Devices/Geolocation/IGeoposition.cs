// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeoposition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [Guid(3247244372, 32065, 20471, 169, 87, 157, 255, 180, 239, 127, 91)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Geoposition))]
  internal interface IGeoposition
  {
    Geocoordinate Coordinate { get; }

    CivicAddress CivicAddress { get; }
  }
}
