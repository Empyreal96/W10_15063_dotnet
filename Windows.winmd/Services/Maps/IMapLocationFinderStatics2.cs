// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapLocationFinderStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2509933462, 25733, 19965, 133, 26, 51, 172, 49, 126, 58, 246)]
  [WebHostHidden]
  [ExclusiveTo(typeof (MapLocationFinder))]
  internal interface IMapLocationFinderStatics2
  {
    [RemoteAsync]
    [Overload("FindLocationsAtWithAccuracyAsync")]
    IAsyncOperation<MapLocationFinderResult> FindLocationsAtAsync(
      Geopoint queryPoint,
      MapLocationDesiredAccuracy accuracy);
  }
}
