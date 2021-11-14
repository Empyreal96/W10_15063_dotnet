// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapRouteFinderStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MapRouteFinder))]
  [WebHostHidden]
  [Guid(2949393523, 30560, 18863, 179, 189, 186, 241, 53, 183, 3, 225)]
  internal interface IMapRouteFinderStatics2
  {
    [DefaultOverload]
    [Overload("GetDrivingRouteWithOptionsAsync")]
    [RemoteAsync]
    IAsyncOperation<MapRouteFinderResult> GetDrivingRouteAsync(
      Geopoint startPoint,
      Geopoint endPoint,
      MapRouteDrivingOptions options);
  }
}
