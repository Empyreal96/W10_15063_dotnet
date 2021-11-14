// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapControl2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3791479885, 38636, 16485, 176, 240, 117, 40, 29, 163, 101, 77)]
  [ExclusiveTo(typeof (MapControl))]
  internal interface IMapControl2
  {
    bool BusinessLandmarksVisible { get; set; }

    bool TransitFeaturesVisible { get; set; }

    MapPanInteractionMode PanInteractionMode { get; set; }

    MapInteractionMode RotateInteractionMode { get; set; }

    MapInteractionMode TiltInteractionMode { get; set; }

    MapInteractionMode ZoomInteractionMode { get; set; }

    bool Is3DSupported { get; }

    bool IsStreetsideSupported { get; }

    MapScene Scene { get; set; }

    MapCamera ActualCamera { get; }

    MapCamera TargetCamera { get; }

    MapCustomExperience CustomExperience { get; set; }

    event TypedEventHandler<MapControl, MapElementClickEventArgs> MapElementClick;

    event TypedEventHandler<MapControl, MapElementPointerEnteredEventArgs> MapElementPointerEntered;

    event TypedEventHandler<MapControl, MapElementPointerExitedEventArgs> MapElementPointerExited;

    event TypedEventHandler<MapControl, MapActualCameraChangedEventArgs> ActualCameraChanged;

    event TypedEventHandler<MapControl, MapActualCameraChangingEventArgs> ActualCameraChanging;

    event TypedEventHandler<MapControl, MapTargetCameraChangedEventArgs> TargetCameraChanged;

    event TypedEventHandler<MapControl, MapCustomExperienceChangedEventArgs> CustomExperienceChanged;

    void StartContinuousRotate(double rateInDegreesPerSecond);

    void StopContinuousRotate();

    void StartContinuousTilt(double rateInDegreesPerSecond);

    void StopContinuousTilt();

    void StartContinuousZoom(double rateOfChangePerSecond);

    void StopContinuousZoom();

    [RemoteAsync]
    IAsyncOperation<bool> TryRotateAsync(double degrees);

    [RemoteAsync]
    IAsyncOperation<bool> TryRotateToAsync(double angleInDegrees);

    [RemoteAsync]
    IAsyncOperation<bool> TryTiltAsync(double degrees);

    [RemoteAsync]
    IAsyncOperation<bool> TryTiltToAsync(double angleInDegrees);

    [RemoteAsync]
    IAsyncOperation<bool> TryZoomInAsync();

    [RemoteAsync]
    IAsyncOperation<bool> TryZoomOutAsync();

    [RemoteAsync]
    IAsyncOperation<bool> TryZoomToAsync(double zoomLevel);

    [RemoteAsync]
    [Overload("TrySetSceneAsync")]
    IAsyncOperation<bool> TrySetSceneAsync(MapScene scene);

    [Overload("TrySetSceneWithAnimationAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> TrySetSceneAsync(
      MapScene scene,
      MapAnimationKind animationKind);
  }
}
