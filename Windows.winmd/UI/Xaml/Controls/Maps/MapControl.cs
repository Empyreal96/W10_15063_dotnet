// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ContentProperty(Name = "Children")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IMapControlStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMapControlStatics4), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMapControlStatics5), 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMapControlStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class MapControl : 
    Control,
    IMapControl,
    IMapControl2,
    IMapControl3,
    IMapControl4,
    IMapControl5
  {
    [MethodImpl]
    public extern MapControl();

    public extern Geopoint Center { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<DependencyObject> Children { [MethodImpl] get; }

    public extern MapColorScheme ColorScheme { [MethodImpl] get; [MethodImpl] set; }

    public extern double DesiredPitch { [MethodImpl] get; [MethodImpl] set; }

    public extern double Heading { [MethodImpl] get; [MethodImpl] set; }

    public extern bool LandmarksVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern MapLoadingStatus LoadingStatus { [MethodImpl] get; }

    public extern string MapServiceToken { [MethodImpl] get; [MethodImpl] set; }

    public extern double MaxZoomLevel { [MethodImpl] get; }

    public extern double MinZoomLevel { [MethodImpl] get; }

    public extern bool PedestrianFeaturesVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern double Pitch { [MethodImpl] get; }

    public extern MapStyle Style { [MethodImpl] get; [MethodImpl] set; }

    public extern bool TrafficFlowVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern Point TransformOrigin { [MethodImpl] get; [MethodImpl] set; }

    public extern MapWatermarkMode WatermarkMode { [MethodImpl] get; [MethodImpl] set; }

    public extern double ZoomLevel { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<MapElement> MapElements { [MethodImpl] get; }

    public extern IVector<MapRouteView> Routes { [MethodImpl] get; }

    public extern IVector<MapTileSource> TileSources { [MethodImpl] get; }

    public extern event TypedEventHandler<MapControl, object> CenterChanged;

    public extern event TypedEventHandler<MapControl, object> HeadingChanged;

    public extern event TypedEventHandler<MapControl, object> LoadingStatusChanged;

    public extern event TypedEventHandler<MapControl, MapInputEventArgs> MapDoubleTapped;

    public extern event TypedEventHandler<MapControl, MapInputEventArgs> MapHolding;

    public extern event TypedEventHandler<MapControl, MapInputEventArgs> MapTapped;

    public extern event TypedEventHandler<MapControl, object> PitchChanged;

    public extern event TypedEventHandler<MapControl, object> TransformOriginChanged;

    public extern event TypedEventHandler<MapControl, object> ZoomLevelChanged;

    [Overload("FindMapElementsAtOffset")]
    [MethodImpl]
    public extern IVectorView<MapElement> FindMapElementsAtOffset(Point offset);

    [Overload("GetLocationFromOffset")]
    [MethodImpl]
    public extern void GetLocationFromOffset(Point offset, out Geopoint location);

    [MethodImpl]
    public extern void GetOffsetFromLocation(Geopoint location, out Point offset);

    [MethodImpl]
    public extern void IsLocationInView(Geopoint location, out bool isInView);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TrySetViewBoundsAsync(
      GeoboundingBox bounds,
      IReference<Thickness> margin,
      MapAnimationKind animation);

    [RemoteAsync]
    [Overload("TrySetViewWithCenterAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> TrySetViewAsync(Geopoint center);

    [RemoteAsync]
    [Overload("TrySetViewWithCenterAndZoomAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> TrySetViewAsync(
      Geopoint center,
      IReference<double> zoomLevel);

    [Overload("TrySetViewWithCenterZoomHeadingAndPitchAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TrySetViewAsync(
      Geopoint center,
      IReference<double> zoomLevel,
      IReference<double> heading,
      IReference<double> desiredPitch);

    [Overload("TrySetViewWithCenterZoomHeadingPitchAndAnimationAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TrySetViewAsync(
      Geopoint center,
      IReference<double> zoomLevel,
      IReference<double> heading,
      IReference<double> desiredPitch,
      MapAnimationKind animation);

    public extern bool BusinessLandmarksVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern bool TransitFeaturesVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern MapPanInteractionMode PanInteractionMode { [MethodImpl] get; [MethodImpl] set; }

    public extern MapInteractionMode RotateInteractionMode { [MethodImpl] get; [MethodImpl] set; }

    public extern MapInteractionMode TiltInteractionMode { [MethodImpl] get; [MethodImpl] set; }

    public extern MapInteractionMode ZoomInteractionMode { [MethodImpl] get; [MethodImpl] set; }

    public extern bool Is3DSupported { [MethodImpl] get; }

    public extern bool IsStreetsideSupported { [MethodImpl] get; }

    public extern MapScene Scene { [MethodImpl] get; [MethodImpl] set; }

    public extern MapCamera ActualCamera { [MethodImpl] get; }

    public extern MapCamera TargetCamera { [MethodImpl] get; }

    public extern MapCustomExperience CustomExperience { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<MapControl, MapElementClickEventArgs> MapElementClick;

    public extern event TypedEventHandler<MapControl, MapElementPointerEnteredEventArgs> MapElementPointerEntered;

    public extern event TypedEventHandler<MapControl, MapElementPointerExitedEventArgs> MapElementPointerExited;

    public extern event TypedEventHandler<MapControl, MapActualCameraChangedEventArgs> ActualCameraChanged;

    public extern event TypedEventHandler<MapControl, MapActualCameraChangingEventArgs> ActualCameraChanging;

    public extern event TypedEventHandler<MapControl, MapTargetCameraChangedEventArgs> TargetCameraChanged;

    public extern event TypedEventHandler<MapControl, MapCustomExperienceChangedEventArgs> CustomExperienceChanged;

    [MethodImpl]
    public extern void StartContinuousRotate(double rateInDegreesPerSecond);

    [MethodImpl]
    public extern void StopContinuousRotate();

    [MethodImpl]
    public extern void StartContinuousTilt(double rateInDegreesPerSecond);

    [MethodImpl]
    public extern void StopContinuousTilt();

    [MethodImpl]
    public extern void StartContinuousZoom(double rateOfChangePerSecond);

    [MethodImpl]
    public extern void StopContinuousZoom();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryRotateAsync(double degrees);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryRotateToAsync(double angleInDegrees);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryTiltAsync(double degrees);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryTiltToAsync(double angleInDegrees);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryZoomInAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryZoomOutAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryZoomToAsync(double zoomLevel);

    [Overload("TrySetSceneAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TrySetSceneAsync(MapScene scene);

    [RemoteAsync]
    [Overload("TrySetSceneWithAnimationAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> TrySetSceneAsync(
      MapScene scene,
      MapAnimationKind animationKind);

    public extern event TypedEventHandler<MapControl, MapRightTappedEventArgs> MapRightTapped;

    public extern bool BusinessLandmarksEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool TransitFeaturesEnabled { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern Geopath GetVisibleRegion(MapVisibleRegionKind region);

    public extern MapProjection MapProjection { [MethodImpl] get; [MethodImpl] set; }

    public extern MapStyleSheet StyleSheet { [MethodImpl] get; [MethodImpl] set; }

    public extern Thickness ViewPadding { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<MapControl, MapContextRequestedEventArgs> MapContextRequested;

    [Overload("FindMapElementsAtOffsetWithRadius")]
    [MethodImpl]
    public extern IVectorView<MapElement> FindMapElementsAtOffset(
      Point offset,
      double radius);

    [Overload("GetLocationFromOffsetWithReferenceSystem")]
    [MethodImpl]
    public extern void GetLocationFromOffset(
      Point offset,
      AltitudeReferenceSystem desiredReferenceSystem,
      out Geopoint location);

    [MethodImpl]
    public extern void StartContinuousPan(
      double horizontalPixelsPerSecond,
      double verticalPixelsPerSecond);

    [MethodImpl]
    public extern void StopContinuousPan();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryPanAsync(
      double horizontalPixels,
      double verticalPixels);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryPanToAsync(Geopoint location);

    public static extern DependencyProperty MapProjectionProperty { [MethodImpl] get; }

    public static extern DependencyProperty StyleSheetProperty { [MethodImpl] get; }

    public static extern DependencyProperty ViewPaddingProperty { [MethodImpl] get; }

    public static extern DependencyProperty BusinessLandmarksEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty TransitFeaturesEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty BusinessLandmarksVisibleProperty { [MethodImpl] get; }

    public static extern DependencyProperty TransitFeaturesVisibleProperty { [MethodImpl] get; }

    public static extern DependencyProperty PanInteractionModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty RotateInteractionModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty TiltInteractionModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty ZoomInteractionModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty Is3DSupportedProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsStreetsideSupportedProperty { [MethodImpl] get; }

    public static extern DependencyProperty SceneProperty { [MethodImpl] get; }

    public static extern DependencyProperty CenterProperty { [MethodImpl] get; }

    public static extern DependencyProperty ChildrenProperty { [MethodImpl] get; }

    public static extern DependencyProperty ColorSchemeProperty { [MethodImpl] get; }

    public static extern DependencyProperty DesiredPitchProperty { [MethodImpl] get; }

    public static extern DependencyProperty HeadingProperty { [MethodImpl] get; }

    public static extern DependencyProperty LandmarksVisibleProperty { [MethodImpl] get; }

    public static extern DependencyProperty LoadingStatusProperty { [MethodImpl] get; }

    public static extern DependencyProperty MapServiceTokenProperty { [MethodImpl] get; }

    public static extern DependencyProperty PedestrianFeaturesVisibleProperty { [MethodImpl] get; }

    public static extern DependencyProperty PitchProperty { [MethodImpl] get; }

    public new static extern DependencyProperty StyleProperty { [MethodImpl] get; }

    public static extern DependencyProperty TrafficFlowVisibleProperty { [MethodImpl] get; }

    public static extern DependencyProperty TransformOriginProperty { [MethodImpl] get; }

    public static extern DependencyProperty WatermarkModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty ZoomLevelProperty { [MethodImpl] get; }

    public static extern DependencyProperty MapElementsProperty { [MethodImpl] get; }

    public static extern DependencyProperty RoutesProperty { [MethodImpl] get; }

    public static extern DependencyProperty TileSourcesProperty { [MethodImpl] get; }

    public static extern DependencyProperty LocationProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern Geopoint GetLocation(DependencyObject element);

    [MethodImpl]
    public static extern void SetLocation(DependencyObject element, Geopoint value);

    public static extern DependencyProperty NormalizedAnchorPointProperty { [MethodImpl] get; }

    [MethodImpl]
    public static extern Point GetNormalizedAnchorPoint(DependencyObject element);

    [MethodImpl]
    public static extern void SetNormalizedAnchorPoint(DependencyObject element, Point value);
  }
}
