// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundUploader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Networking.BackgroundTransfer
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3314928046, 52909, 18011, 136, 1, 197, 90, 201, 10, 1, 206)]
  [ExclusiveTo(typeof (BackgroundUploader))]
  internal interface IBackgroundUploader : IBackgroundTransferBase
  {
    UploadOperation CreateUpload(Uri uri, IStorageFile sourceFile);

    [RemoteAsync]
    IAsyncOperation<UploadOperation> CreateUploadFromStreamAsync(
      Uri uri,
      IInputStream sourceStream);

    [RemoteAsync]
    [Overload("CreateUploadWithFormDataAndAutoBoundaryAsync")]
    IAsyncOperation<UploadOperation> CreateUploadAsync(
      Uri uri,
      IIterable<BackgroundTransferContentPart> parts);

    [RemoteAsync]
    [Overload("CreateUploadWithSubTypeAsync")]
    IAsyncOperation<UploadOperation> CreateUploadAsync(
      Uri uri,
      IIterable<BackgroundTransferContentPart> parts,
      string subType);

    [Overload("CreateUploadWithSubTypeAndBoundaryAsync")]
    [RemoteAsync]
    IAsyncOperation<UploadOperation> CreateUploadAsync(
      Uri uri,
      IIterable<BackgroundTransferContentPart> parts,
      string subType,
      string boundary);
  }
}
