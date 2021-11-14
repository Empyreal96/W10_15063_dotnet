// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeocoordinateWithPoint
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [ExclusiveTo(typeof (Geocoordinate))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4276749605, 53804, 19782, 181, 39, 11, 150, 6, 111, 199, 219)]
  internal interface IGeocoordinateWithPoint
  {
    Geopoint Point { get; }
  }
}
