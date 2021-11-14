// Decompiled with JetBrains decompiler
// Type: Windows.Storage.AccessCache.IStorageItemMostRecentlyUsedList
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.AccessCache
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (StorageItemMostRecentlyUsedList))]
  [Guid(23214549, 20749, 16670, 140, 241, 195, 209, 239, 250, 76, 51)]
  internal interface IStorageItemMostRecentlyUsedList : IStorageItemAccessList
  {
    event TypedEventHandler<StorageItemMostRecentlyUsedList, ItemRemovedEventArgs> ItemRemoved;
  }
}
