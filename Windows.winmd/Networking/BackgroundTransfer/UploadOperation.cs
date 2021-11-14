// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.UploadOperation
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
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class UploadOperation : 
    IUploadOperation,
    IBackgroundTransferOperation,
    IBackgroundTransferOperationPriority,
    IUploadOperation2
  {
    public extern IStorageFile SourceFile { [MethodImpl] get; }

    public extern BackgroundUploadProgress Progress { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<UploadOperation, UploadOperation> StartAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<UploadOperation, UploadOperation> AttachAsync();

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
