// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.OfflineMaps.IOfflineMapPackageStartDownloadResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.OfflineMaps
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  [Guid(3647322392, 54486, 19198, 147, 120, 62, 199, 30, 241, 28, 61)]
  [ExclusiveTo(typeof (OfflineMapPackageStartDownloadResult))]
  internal interface IOfflineMapPackageStartDownloadResult
  {
    OfflineMapPackageStartDownloadStatus Status { get; }
  }
}
