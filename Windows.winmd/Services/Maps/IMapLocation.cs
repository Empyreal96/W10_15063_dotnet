// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapLocation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [Guid(1007107927, 3492, 17128, 158, 226, 169, 111, 207, 35, 113, 220)]
  [ExclusiveTo(typeof (MapLocation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IMapLocation
  {
    Geopoint Point { get; }

    string DisplayName { get; }

    string Description { get; }

    MapAddress Address { get; }
  }
}
