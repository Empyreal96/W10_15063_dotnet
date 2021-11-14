// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IUploadOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Networking.BackgroundTransfer
{
  [ExclusiveTo(typeof (UploadOperation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1045832928, 29577, 17228, 139, 53, 66, 127, 211, 107, 189, 174)]
  internal interface IUploadOperation : IBackgroundTransferOperation
  {
    IStorageFile SourceFile { get; }

    BackgroundUploadProgress Progress { get; }

    [RemoteAsync]
    IAsyncOperationWithProgress<UploadOperation, UploadOperation> StartAsync();

    [RemoteAsync]
    IAsyncOperationWithProgress<UploadOperation, UploadOperation> AttachAsync();
  }
}
