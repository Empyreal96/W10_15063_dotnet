// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.OfflineMaps.OfflineMapPackage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.OfflineMaps
{
  [Static(typeof (IOfflineMapPackageStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  public sealed class OfflineMapPackage : IOfflineMapPackage
  {
    public extern OfflineMapPackageStatus Status { [MethodImpl] get; }

    public extern string DisplayName { [MethodImpl] get; }

    public extern string EnclosingRegionName { [MethodImpl] get; }

    public extern ulong EstimatedSizeInBytes { [MethodImpl] get; }

    public extern event TypedEventHandler<OfflineMapPackage, object> StatusChanged;

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<OfflineMapPackageStartDownloadResult> RequestStartDownloadAsync();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<OfflineMapPackageQueryResult> FindPackagesAsync(
      Geopoint queryPoint);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<OfflineMapPackageQueryResult> FindPackagesInBoundingBoxAsync(
      GeoboundingBox queryBoundingBox);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<OfflineMapPackageQueryResult> FindPackagesInGeocircleAsync(
      Geocircle queryCircle);
  }
}
