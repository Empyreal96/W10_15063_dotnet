// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundDownloaderStaticMethods2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(799675175, 6868, 19621, 178, 205, 8, 219, 240, 116, 106, 254)]
  [ExclusiveTo(typeof (BackgroundDownloader))]
  internal interface IBackgroundDownloaderStaticMethods2
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<DownloadOperation>> GetCurrentDownloadsForTransferGroupAsync(
      BackgroundTransferGroup group);
  }
}
