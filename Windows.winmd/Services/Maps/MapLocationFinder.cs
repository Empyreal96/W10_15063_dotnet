// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.MapLocationFinder
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IMapLocationFinderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMapLocationFinderStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public static class MapLocationFinder
  {
    [RemoteAsync]
    [Overload("FindLocationsAtWithAccuracyAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<MapLocationFinderResult> FindLocationsAtAsync(
      Geopoint queryPoint,
      MapLocationDesiredAccuracy accuracy);

    [Overload("FindLocationsAtAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MapLocationFinderResult> FindLocationsAtAsync(
      Geopoint queryPoint);

    [Overload("FindLocationsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MapLocationFinderResult> FindLocationsAsync(
      string searchText,
      Geopoint referencePoint);

    [Overload("FindLocationsWithMaxCountAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MapLocationFinderResult> FindLocationsAsync(
      string searchText,
      Geopoint referencePoint,
      uint maxCount);
  }
}
