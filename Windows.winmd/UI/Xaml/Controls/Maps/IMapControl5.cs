// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapControl5
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Guid(3717926909, 30755, 18082, 130, 201, 101, 221, 172, 79, 54, 95)]
  [WebHostHidden]
  [ExclusiveTo(typeof (MapControl))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IMapControl5
  {
    MapProjection MapProjection { get; set; }

    MapStyleSheet StyleSheet { get; set; }

    Thickness ViewPadding { get; set; }

    event TypedEventHandler<MapControl, MapContextRequestedEventArgs> MapContextRequested;

    [Overload("FindMapElementsAtOffsetWithRadius")]
    IVectorView<MapElement> FindMapElementsAtOffset(
      Point offset,
      double radius);

    [Overload("GetLocationFromOffsetWithReferenceSystem")]
    void GetLocationFromOffset(
      Point offset,
      AltitudeReferenceSystem desiredReferenceSystem,
      out Geopoint location);

    void StartContinuousPan(double horizontalPixelsPerSecond, double verticalPixelsPerSecond);

    void StopContinuousPan();

    [RemoteAsync]
    IAsyncOperation<bool> TryPanAsync(double horizontalPixels, double verticalPixels);

    [RemoteAsync]
    IAsyncOperation<bool> TryPanToAsync(Geopoint location);
  }
}
