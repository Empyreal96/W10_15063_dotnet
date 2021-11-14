// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapLocationFinderStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [Guid(831183709, 7261, 20277, 162, 223, 170, 202, 148, 149, 149, 23)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (MapLocationFinder))]
  internal interface IMapLocationFinderStatics
  {
    [Overload("FindLocationsAtAsync")]
    [RemoteAsync]
    IAsyncOperation<MapLocationFinderResult> FindLocationsAtAsync(
      Geopoint queryPoint);

    [Overload("FindLocationsAsync")]
    [RemoteAsync]
    IAsyncOperation<MapLocationFinderResult> FindLocationsAsync(
      string searchText,
      Geopoint referencePoint);

    [Overload("FindLocationsWithMaxCountAsync")]
    [RemoteAsync]
    IAsyncOperation<MapLocationFinderResult> FindLocationsAsync(
      string searchText,
      Geopoint referencePoint,
      uint maxCount);
  }
}
