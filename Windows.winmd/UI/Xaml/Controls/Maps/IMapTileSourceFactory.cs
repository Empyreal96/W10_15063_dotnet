// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapTileSourceFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Guid(3447685407, 30714, 18475, 157, 52, 113, 211, 29, 70, 92, 72)]
  [ExclusiveTo(typeof (MapTileSource))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IMapTileSourceFactory
  {
    MapTileSource CreateInstance(object outer, out object inner);

    MapTileSource CreateInstanceWithDataSource(
      MapTileDataSource dataSource,
      object outer,
      out object inner);

    MapTileSource CreateInstanceWithDataSourceAndZoomRange(
      MapTileDataSource dataSource,
      MapZoomLevelRange zoomLevelRange,
      object outer,
      out object inner);

    MapTileSource CreateInstanceWithDataSourceZoomRangeAndBounds(
      MapTileDataSource dataSource,
      MapZoomLevelRange zoomLevelRange,
      GeoboundingBox bounds,
      object outer,
      out object inner);

    MapTileSource CreateInstanceWithDataSourceZoomRangeBoundsAndTileSize(
      MapTileDataSource dataSource,
      MapZoomLevelRange zoomLevelRange,
      GeoboundingBox bounds,
      int tileSizeInPixels,
      object outer,
      out object inner);
  }
}
