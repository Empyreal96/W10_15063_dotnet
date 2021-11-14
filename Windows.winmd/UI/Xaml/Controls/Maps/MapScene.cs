// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapScene
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Static(typeof (IMapSceneStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MapScene : DependencyObject, IMapScene
  {
    public extern MapCamera TargetCamera { [MethodImpl] get; }

    public extern event TypedEventHandler<MapScene, MapTargetCameraChangedEventArgs> TargetCameraChanged;

    [Overload("CreateFromBoundingBox")]
    [MethodImpl]
    public static extern MapScene CreateFromBoundingBox(GeoboundingBox bounds);

    [Overload("CreateFromBoundingBoxWithHeadingAndPitch")]
    [MethodImpl]
    public static extern MapScene CreateFromBoundingBox(
      GeoboundingBox bounds,
      double headingInDegrees,
      double pitchInDegrees);

    [MethodImpl]
    public static extern MapScene CreateFromCamera(MapCamera camera);

    [Overload("CreateFromLocation")]
    [MethodImpl]
    public static extern MapScene CreateFromLocation(Geopoint location);

    [Overload("CreateFromLocationWithHeadingAndPitch")]
    [MethodImpl]
    public static extern MapScene CreateFromLocation(
      Geopoint location,
      double headingInDegrees,
      double pitchInDegrees);

    [Overload("CreateFromLocationAndRadius")]
    [MethodImpl]
    public static extern MapScene CreateFromLocationAndRadius(
      Geopoint location,
      double radiusInMeters);

    [Overload("CreateFromLocationAndRadiusWithHeadingAndPitch")]
    [MethodImpl]
    public static extern MapScene CreateFromLocationAndRadius(
      Geopoint location,
      double radiusInMeters,
      double headingInDegrees,
      double pitchInDegrees);

    [Overload("CreateFromLocations")]
    [MethodImpl]
    public static extern MapScene CreateFromLocations(IIterable<Geopoint> locations);

    [Overload("CreateFromLocationsWithHeadingAndPitch")]
    [MethodImpl]
    public static extern MapScene CreateFromLocations(
      IIterable<Geopoint> locations,
      double headingInDegrees,
      double pitchInDegrees);
  }
}
