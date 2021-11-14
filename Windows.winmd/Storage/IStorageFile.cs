// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageFile
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4198457734, 16916, 17036, 166, 76, 20, 201, 172, 115, 21, 234)]
  public interface IStorageFile : IStorageItem, IRandomAccessStreamReference, IInputStreamReference
  {
    string FileType { get; }

    string ContentType { get; }

    [RemoteAsync]
    IAsyncOperation<IRandomAccessStream> OpenAsync(
      FileAccessMode accessMode);

    [RemoteAsync]
    IAsyncOperation<StorageStreamTransaction> OpenTransactedWriteAsync();

    [Overload("CopyOverloadDefaultNameAndOptions")]
    [RemoteAsync]
    IAsyncOperation<StorageFile> CopyAsync(
      IStorageFolder destinationFolder);

    [RemoteAsync]
    [Overload("CopyOverloadDefaultOptions")]
    IAsyncOperation<StorageFile> CopyAsync(
      IStorageFolder destinationFolder,
      string desiredNewName);

    [RemoteAsync]
    [Overload("CopyOverload")]
    IAsyncOperation<StorageFile> CopyAsync(
      IStorageFolder destinationFolder,
      string desiredNewName,
      NameCollisionOption option);

    [RemoteAsync]
    IAsyncAction CopyAndReplaceAsync(IStorageFile fileToReplace);

    [Overload("MoveOverloadDefaultNameAndOptions")]
    [RemoteAsync]
    IAsyncAction MoveAsync(IStorageFolder destinationFolder);

    [Overload("MoveOverloadDefaultOptions")]
    [RemoteAsync]
    IAsyncAction MoveAsync(IStorageFolder destinationFolder, string desiredNewName);

    [Overload("MoveOverload")]
    [RemoteAsync]
    IAsyncAction MoveAsync(
      IStorageFolder destinationFolder,
      string desiredNewName,
      NameCollisionOption option);

    [RemoteAsync]
    IAsyncAction MoveAndReplaceAsync(IStorageFile fileToReplace);
  }
}
