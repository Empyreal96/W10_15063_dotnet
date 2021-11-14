// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.BackgroundDownloader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Notifications;

namespace Windows.Networking.BackgroundTransfer
{
  [Static(typeof (IBackgroundDownloaderStaticMethods), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IBackgroundDownloaderFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IBackgroundDownloaderUserConsent), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IBackgroundDownloaderStaticMethods2), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class BackgroundDownloader : 
    IBackgroundDownloader,
    IBackgroundTransferBase,
    IBackgroundDownloader2,
    IBackgroundDownloader3
  {
    [MethodImpl]
    public extern BackgroundDownloader(BackgroundTransferCompletionGroup completionGroup);

    [MethodImpl]
    public extern BackgroundDownloader();

    [Overload("CreateDownload")]
    [MethodImpl]
    public extern DownloadOperation CreateDownload(
      Uri uri,
      IStorageFile resultFile);

    [Overload("CreateDownloadFromFile")]
    [MethodImpl]
    public extern DownloadOperation CreateDownload(
      Uri uri,
      IStorageFile resultFile,
      IStorageFile requestBodyFile);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DownloadOperation> CreateDownloadAsync(
      Uri uri,
      IStorageFile resultFile,
      IInputStream requestBodyStream);

    [MethodImpl]
    public extern void SetRequestHeader(string headerName, string headerValue);

    public extern PasswordCredential ServerCredential { [MethodImpl] get; [MethodImpl] set; }

    public extern PasswordCredential ProxyCredential { [MethodImpl] get; [MethodImpl] set; }

    public extern string Method { [MethodImpl] get; [MethodImpl] set; }

    public extern string Group { [Deprecated("Group may be altered or unavailable for releases after Windows 8.1. Instead, use TransferGroup.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("Group may be altered or unavailable for releases after Windows 8.1. Instead, use TransferGroup.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    public extern BackgroundTransferCostPolicy CostPolicy { [MethodImpl] get; [MethodImpl] set; }

    public extern BackgroundTransferGroup TransferGroup { [MethodImpl] get; [MethodImpl] set; }

    public extern ToastNotification SuccessToastNotification { [MethodImpl] get; [MethodImpl] set; }

    public extern ToastNotification FailureToastNotification { [MethodImpl] get; [MethodImpl] set; }

    public extern TileNotification SuccessTileNotification { [MethodImpl] get; [MethodImpl] set; }

    public extern TileNotification FailureTileNotification { [MethodImpl] get; [MethodImpl] set; }

    public extern BackgroundTransferCompletionGroup CompletionGroup { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<DownloadOperation>> GetCurrentDownloadsForTransferGroupAsync(
      BackgroundTransferGroup group);

    [RemoteAsync]
    [Deprecated("RequestUnconstrainedDownloadsAsync is deprecated and may not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern IAsyncOperation<UnconstrainedTransferRequestResult> RequestUnconstrainedDownloadsAsync(
      IIterable<DownloadOperation> operations);

    [RemoteAsync]
    [Overload("GetCurrentDownloadsAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<DownloadOperation>> GetCurrentDownloadsAsync();

    [RemoteAsync]
    [Deprecated("GetCurrentDownloadsAsync(group) may be altered or unavailable for releases after Windows 8.1. Instead, use GetCurrentDownloadsForTransferGroupAsync.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [Overload("GetCurrentDownloadsForGroupAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<DownloadOperation>> GetCurrentDownloadsAsync(
      string group);
  }
}
