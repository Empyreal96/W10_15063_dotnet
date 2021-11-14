// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.OfflineMaps.IOfflineMapPackageQueryResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.OfflineMaps
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  [Guid(1431852049, 14817, 20033, 164, 225, 95, 72, 114, 190, 225, 153)]
  [ExclusiveTo(typeof (OfflineMapPackageQueryResult))]
  internal interface IOfflineMapPackageQueryResult
  {
    OfflineMapPackageQueryStatus Status { get; }

    IVectorView<OfflineMapPackage> Packages { get; }
  }
}
