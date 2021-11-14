// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageItemProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.FileProperties;

namespace Windows.Storage
{
  [Guid(2254849144, 32809, 18174, 167, 137, 28, 47, 62, 47, 251, 92)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IStorageItemProperties
  {
    [RemoteAsync]
    [Overload("GetThumbnailAsyncOverloadDefaultSizeDefaultOptions")]
    IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync(
      ThumbnailMode mode);

    [RemoteAsync]
    [Overload("GetThumbnailAsyncOverloadDefaultOptions")]
    IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync(
      ThumbnailMode mode,
      uint requestedSize);

    [RemoteAsync]
    [Overload("GetThumbnailAsync")]
    IAsyncOperation<StorageItemThumbnail> GetThumbnailAsync(
      ThumbnailMode mode,
      uint requestedSize,
      ThumbnailOptions options);

    string DisplayName { get; }

    string DisplayType { get; }

    string FolderRelativeId { get; }

    StorageItemContentProperties Properties { get; }
  }
}
