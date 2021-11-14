// Decompiled with JetBrains decompiler
// Type: Windows.Storage.AccessCache.IStorageApplicationPermissionsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.AccessCache
{
  [Guid(1133633450, 53299, 18681, 128, 96, 62, 200, 71, 210, 227, 241)]
  [ExclusiveTo(typeof (StorageApplicationPermissions))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IStorageApplicationPermissionsStatics
  {
    StorageItemAccessList FutureAccessList { get; }

    StorageItemMostRecentlyUsedList MostRecentlyUsedList { get; }
  }
}
