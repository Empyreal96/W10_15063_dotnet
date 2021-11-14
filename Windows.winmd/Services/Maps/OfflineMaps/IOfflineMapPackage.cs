// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.OfflineMaps.IOfflineMapPackage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.OfflineMaps
{
  [Guid(2811717435, 42421, 16708, 181, 37, 230, 140, 136, 98, 102, 75)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  [ExclusiveTo(typeof (OfflineMapPackage))]
  internal interface IOfflineMapPackage
  {
    OfflineMapPackageStatus Status { get; }

    string DisplayName { get; }

    string EnclosingRegionName { get; }

    ulong EstimatedSizeInBytes { get; }

    event TypedEventHandler<OfflineMapPackage, object> StatusChanged;

    [RemoteAsync]
    IAsyncOperation<OfflineMapPackageStartDownloadResult> RequestStartDownloadAsync();
  }
}
