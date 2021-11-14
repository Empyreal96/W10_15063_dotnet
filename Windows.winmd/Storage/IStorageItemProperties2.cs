// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageItemProperties2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.FileProperties;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2391189841, 1209, 19410, 146, 157, 254, 243, 247, 22, 33, 208)]
  public interface IStorageItemProperties2 : IStorageItemProperties
  {
    [Overload("GetScaledImageAsThumbnailAsyncOverloadDefaultSizeDefaultOptions")]
    [RemoteAsync]
    IAsyncOperation<StorageItemThumbnail> GetScaledImageAsThumbnailAsync(
      ThumbnailMode mode);

    [Overload("GetScaledImageAsThumbnailAsyncOverloadDefaultOptions")]
    [RemoteAsync]
    IAsyncOperation<StorageItemThumbnail> GetScaledImageAsThumbnailAsync(
      ThumbnailMode mode,
      uint requestedSize);

    [Overload("GetScaledImageAsThumbnailAsync")]
    [RemoteAsync]
    IAsyncOperation<StorageItemThumbnail> GetScaledImageAsThumbnailAsync(
      ThumbnailMode mode,
      uint requestedSize,
      ThumbnailOptions options);
  }
}
