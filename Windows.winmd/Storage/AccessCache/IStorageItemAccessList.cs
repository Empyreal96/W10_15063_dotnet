// Decompiled with JetBrains decompiler
// Type: Windows.Storage.AccessCache.IStorageItemAccessList
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.AccessCache
{
  [Guid(749729453, 56976, 18421, 178, 195, 221, 54, 201, 253, 212, 83)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IStorageItemAccessList
  {
    [Overload("AddOverloadDefaultMetadata")]
    string Add(IStorageItem file);

    [Overload("Add")]
    string Add(IStorageItem file, string metadata);

    [Overload("AddOrReplaceOverloadDefaultMetadata")]
    void AddOrReplace(string token, IStorageItem file);

    [Overload("AddOrReplace")]
    void AddOrReplace(string token, IStorageItem file, string metadata);

    [Overload("GetItemAsync")]
    IAsyncOperation<IStorageItem> GetItemAsync(string token);

    [Overload("GetFileAsync")]
    IAsyncOperation<StorageFile> GetFileAsync(string token);

    [Overload("GetFolderAsync")]
    IAsyncOperation<StorageFolder> GetFolderAsync(string token);

    [Overload("GetItemWithOptionsAsync")]
    IAsyncOperation<IStorageItem> GetItemAsync(
      string token,
      AccessCacheOptions options);

    [Overload("GetFileWithOptionsAsync")]
    IAsyncOperation<StorageFile> GetFileAsync(
      string token,
      AccessCacheOptions options);

    [Overload("GetFolderWithOptionsAsync")]
    IAsyncOperation<StorageFolder> GetFolderAsync(
      string token,
      AccessCacheOptions options);

    void Remove(string token);

    bool ContainsItem(string token);

    void Clear();

    bool CheckAccess(IStorageItem file);

    AccessListEntryView Entries { get; }

    uint MaximumItemsAllowed { get; }
  }
}
