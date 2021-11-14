// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.OfflineMaps.IOfflineMapPackageStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.OfflineMaps
{
  [ExclusiveTo(typeof (OfflineMapPackage))]
  [Guid(408844578, 43057, 19120, 148, 31, 105, 152, 250, 146, 146, 133)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IOfflineMapPackageStatics
  {
    [RemoteAsync]
    IAsyncOperation<OfflineMapPackageQueryResult> FindPackagesAsync(
      Geopoint queryPoint);

    [RemoteAsync]
    IAsyncOperation<OfflineMapPackageQueryResult> FindPackagesInBoundingBoxAsync(
      GeoboundingBox queryBoundingBox);

    [RemoteAsync]
    IAsyncOperation<OfflineMapPackageQueryResult> FindPackagesInGeocircleAsync(
      Geocircle queryCircle);
  }
}
