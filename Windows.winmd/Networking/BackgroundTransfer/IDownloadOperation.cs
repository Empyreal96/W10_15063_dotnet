// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IDownloadOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Networking.BackgroundTransfer
{
  [ExclusiveTo(typeof (DownloadOperation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3179801520, 22292, 19977, 186, 104, 190, 247, 57, 3, 176, 215)]
  internal interface IDownloadOperation : IBackgroundTransferOperation
  {
    IStorageFile ResultFile { get; }

    BackgroundDownloadProgress Progress { get; }

    [RemoteAsync]
    IAsyncOperationWithProgress<DownloadOperation, DownloadOperation> StartAsync();

    [RemoteAsync]
    IAsyncOperationWithProgress<DownloadOperation, DownloadOperation> AttachAsync();

    void Pause();

    void Resume();
  }
}
