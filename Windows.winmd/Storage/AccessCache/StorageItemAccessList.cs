// Decompiled with JetBrains decompiler
// Type: Windows.Storage.AccessCache.StorageItemAccessList
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.AccessCache
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class StorageItemAccessList : IStorageItemAccessList
  {
    [Overload("AddOverloadDefaultMetadata")]
    [MethodImpl]
    public extern string Add(IStorageItem file);

    [Overload("Add")]
    [MethodImpl]
    public extern string Add(IStorageItem file, string metadata);

    [Overload("AddOrReplaceOverloadDefaultMetadata")]
    [MethodImpl]
    public extern void AddOrReplace(string token, IStorageItem file);

    [Overload("AddOrReplace")]
    [MethodImpl]
    public extern void AddOrReplace(string token, IStorageItem file, string metadata);

    [Overload("GetItemAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IStorageItem> GetItemAsync(string token);

    [Overload("GetFileAsync")]
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> GetFileAsync(string token);

    [Overload("GetFolderAsync")]
    [MethodImpl]
    public extern IAsyncOperation<StorageFolder> GetFolderAsync(
      string token);

    [Overload("GetItemWithOptionsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IStorageItem> GetItemAsync(
      string token,
      AccessCacheOptions options);

    [Overload("GetFileWithOptionsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> GetFileAsync(
      string token,
      AccessCacheOptions options);

    [Overload("GetFolderWithOptionsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<StorageFolder> GetFolderAsync(
      string token,
      AccessCacheOptions options);

    [MethodImpl]
    public extern void Remove(string token);

    [MethodImpl]
    public extern bool ContainsItem(string token);

    [MethodImpl]
    public extern void Clear();

    [MethodImpl]
    public extern bool CheckAccess(IStorageItem file);

    public extern AccessListEntryView Entries { [MethodImpl] get; }

    public extern uint MaximumItemsAllowed { [MethodImpl] get; }
  }
}
