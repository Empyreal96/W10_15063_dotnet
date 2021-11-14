// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.DownloadOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Networking.BackgroundTransfer
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DownloadOperation : 
    IDownloadOperation,
    IBackgroundTransferOperation,
    IBackgroundTransferOperationPriority,
    IDownloadOperation2
  {
    public extern IStorageFile ResultFile { [MethodImpl] get; }

    public extern BackgroundDownloadProgress Progress { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DownloadOperation, DownloadOperation> StartAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DownloadOperation, DownloadOperation> AttachAsync();

    [MethodImpl]
    public extern void Pause();

    [MethodImpl]
    public extern void Resume();

    public extern Guid Guid { [MethodImpl] get; }

    public extern global::Windows.Foundation.Uri RequestedUri { [MethodImpl] get; }

    public extern string Method { [MethodImpl] get; }

    public extern string Group { [Deprecated("Group may be altered or unavailable for releases after Windows 8.1. Instead, use TransferGroup.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern BackgroundTransferCostPolicy CostPolicy { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern IInputStream GetResultStreamAt(ulong position);

    [MethodImpl]
    public extern ResponseInformation GetResponseInformation();

    public extern BackgroundTransferPriority Priority { [MethodImpl] get; [MethodImpl] set; }

    public extern BackgroundTransferGroup TransferGroup { [MethodImpl] get; }
  }
}
