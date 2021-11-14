// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.BackgroundUploader
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
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IBackgroundUploaderStaticMethods), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IBackgroundUploaderUserConsent), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IBackgroundUploaderStaticMethods2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IBackgroundUploaderFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class BackgroundUploader : 
    IBackgroundUploader,
    IBackgroundTransferBase,
    IBackgroundUploader2,
    IBackgroundUploader3
  {
    [MethodImpl]
    public extern BackgroundUploader(BackgroundTransferCompletionGroup completionGroup);

    [MethodImpl]
    public extern BackgroundUploader();

    [MethodImpl]
    public extern UploadOperation CreateUpload(Uri uri, IStorageFile sourceFile);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<UploadOperation> CreateUploadFromStreamAsync(
      Uri uri,
      IInputStream sourceStream);

    [Overload("CreateUploadWithFormDataAndAutoBoundaryAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<UploadOperation> CreateUploadAsync(
      Uri uri,
      IIterable<BackgroundTransferContentPart> parts);

    [Overload("CreateUploadWithSubTypeAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<UploadOperation> CreateUploadAsync(
      Uri uri,
      IIterable<BackgroundTransferContentPart> parts,
      string subType);

    [Overload("CreateUploadWithSubTypeAndBoundaryAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<UploadOperation> CreateUploadAsync(
      Uri uri,
      IIterable<BackgroundTransferContentPart> parts,
      string subType,
      string boundary);

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
    public static extern IAsyncOperation<IVectorView<UploadOperation>> GetCurrentUploadsForTransferGroupAsync(
      BackgroundTransferGroup group);

    [RemoteAsync]
    [Deprecated("RequestUnconstrainedUploadsAsync is deprecated and may not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern IAsyncOperation<UnconstrainedTransferRequestResult> RequestUnconstrainedUploadsAsync(
      IIterable<UploadOperation> operations);

    [RemoteAsync]
    [Overload("GetCurrentUploadsAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<UploadOperation>> GetCurrentUploadsAsync();

    [Overload("GetCurrentUploadsForGroupAsync")]
    [Deprecated("GetCurrentUploadsAsync(group) may be altered or unavailable for releases after Windows 8.1. Instead, use GetCurrentUploadsForTransferGroupAsync.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<UploadOperation>> GetCurrentUploadsAsync(
      string group);
  }
}
