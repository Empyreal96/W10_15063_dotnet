// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MapControl))]
  [Guid(1120974929, 21078, 18247, 158, 108, 13, 17, 233, 102, 20, 30)]
  [WebHostHidden]
  internal interface IMapControl
  {
    Geopoint Center { get; set; }

    IVector<DependencyObject> Children { get; }

    MapColorScheme ColorScheme { get; set; }

    double DesiredPitch { get; set; }

    double Heading { get; set; }

    bool LandmarksVisible { get; set; }

    MapLoadingStatus LoadingStatus { get; }

    string MapServiceToken { get; set; }

    double MaxZoomLevel { get; }

    double MinZoomLevel { get; }

    bool PedestrianFeaturesVisible { get; set; }

    double Pitch { get; }

    MapStyle Style { get; set; }

    bool TrafficFlowVisible { get; set; }

    Point TransformOrigin { get; set; }

    MapWatermarkMode WatermarkMode { get; set; }

    double ZoomLevel { get; set; }

    IVector<MapElement> MapElements { get; }

    IVector<MapRouteView> Routes { get; }

    IVector<MapTileSource> TileSources { get; }

    event TypedEventHandler<MapControl, object> CenterChanged;

    event TypedEventHandler<MapControl, object> HeadingChanged;

    event TypedEventHandler<MapControl, object> LoadingStatusChanged;

    event TypedEventHandler<MapControl, MapInputEventArgs> MapDoubleTapped;

    event TypedEventHandler<MapControl, MapInputEventArgs> MapHolding;

    event TypedEventHandler<MapControl, MapInputEventArgs> MapTapped;

    event TypedEventHandler<MapControl, object> PitchChanged;

    event TypedEventHandler<MapControl, object> TransformOriginChanged;

    event TypedEventHandler<MapControl, object> ZoomLevelChanged;

    [Overload("FindMapElementsAtOffset")]
    IVectorView<MapElement> FindMapElementsAtOffset(Point offset);

    [Overload("GetLocationFromOffset")]
    void GetLocationFromOffset(Point offset, out Geopoint location);

    void GetOffsetFromLocation(Geopoint location, out Point offset);

    void IsLocationInView(Geopoint location, out bool isInView);

    [RemoteAsync]
    IAsyncOperation<bool> TrySetViewBoundsAsync(
      GeoboundingBox bounds,
      IReference<Thickness> margin,
      MapAnimationKind animation);

    [RemoteAsync]
    [Overload("TrySetViewWithCenterAsync")]
    IAsyncOperation<bool> TrySetViewAsync(Geopoint center);

    [RemoteAsync]
    [Overload("TrySetViewWithCenterAndZoomAsync")]
    IAsyncOperation<bool> TrySetViewAsync(
      Geopoint center,
      IReference<double> zoomLevel);

    [Overload("TrySetViewWithCenterZoomHeadingAndPitchAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> TrySetViewAsync(
      Geopoint center,
      IReference<double> zoomLevel,
      IReference<double> heading,
      IReference<double> desiredPitch);

    [RemoteAsync]
    [Overload("TrySetViewWithCenterZoomHeadingPitchAndAnimationAsync")]
    IAsyncOperation<bool> TrySetViewAsync(
      Geopoint center,
      IReference<double> zoomLevel,
      IReference<double> heading,
      IReference<double> desiredPitch,
      MapAnimationKind animation);
  }
}
