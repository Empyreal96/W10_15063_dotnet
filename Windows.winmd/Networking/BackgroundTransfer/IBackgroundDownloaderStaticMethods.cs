// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundDownloaderStaticMethods
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [ExclusiveTo(typeof (BackgroundDownloader))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1386633781, 50766, 17004, 153, 25, 84, 13, 13, 33, 166, 80)]
  internal interface IBackgroundDownloaderStaticMethods
  {
    [Overload("GetCurrentDownloadsAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<DownloadOperation>> GetCurrentDownloadsAsync();

    [Overload("GetCurrentDownloadsForGroupAsync")]
    [Deprecated("GetCurrentDownloadsAsync(group) may be altered or unavailable for releases after Windows 8.1. Instead, use GetCurrentDownloadsForTransferGroupAsync.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<DownloadOperation>> GetCurrentDownloadsAsync(
      string group);
  }
}
