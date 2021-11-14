// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapRoute
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [WebHostHidden]
  [ExclusiveTo(typeof (MapRoute))]
  [Guid(4211586866, 22605, 17795, 156, 96, 100, 31, 234, 39, 67, 73)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMapRoute
  {
    GeoboundingBox BoundingBox { get; }

    double LengthInMeters { get; }

    TimeSpan EstimatedDuration { get; }

    Geopath Path { get; }

    IVectorView<MapRouteLeg> Legs { get; }

    bool IsTrafficBased { get; }
  }
}
