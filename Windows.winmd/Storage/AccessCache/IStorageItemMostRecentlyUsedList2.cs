// Decompiled with JetBrains decompiler
// Type: Windows.Storage.AccessCache.IStorageItemMostRecentlyUsedList2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.AccessCache
{
  [Guid(3662159520, 60813, 18225, 161, 219, 228, 78, 226, 32, 64, 147)]
  [ExclusiveTo(typeof (StorageItemMostRecentlyUsedList))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IStorageItemMostRecentlyUsedList2 : 
    IStorageItemMostRecentlyUsedList,
    IStorageItemAccessList
  {
    [Overload("AddWithMetadataAndVisibility")]
    string Add(IStorageItem file, string metadata, RecentStorageItemVisibility visibility);

    [Overload("AddOrReplaceWithMetadataAndVisibility")]
    void AddOrReplace(
      string token,
      IStorageItem file,
      string metadata,
      RecentStorageItemVisibility visibility);
  }
}
