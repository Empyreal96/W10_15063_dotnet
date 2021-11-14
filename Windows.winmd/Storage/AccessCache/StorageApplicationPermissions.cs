// Decompiled with JetBrains decompiler
// Type: Windows.Storage.AccessCache.StorageApplicationPermissions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.AccessCache
{
  [Static(typeof (IStorageApplicationPermissionsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class StorageApplicationPermissions
  {
    public static extern StorageItemAccessList FutureAccessList { [MethodImpl] get; }

    public static extern StorageItemMostRecentlyUsedList MostRecentlyUsedList { [MethodImpl] get; }
  }
}
