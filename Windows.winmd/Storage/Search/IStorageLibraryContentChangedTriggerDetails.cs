// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.IStorageLibraryContentChangedTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Search
{
  [ExclusiveTo(typeof (StorageLibraryContentChangedTriggerDetails))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(708254071, 43967, 19997, 138, 165, 99, 133, 216, 136, 71, 153)]
  internal interface IStorageLibraryContentChangedTriggerDetails
  {
    StorageFolder Folder { get; }

    StorageItemQueryResult CreateModifiedSinceQuery(DateTime lastQueryTime);
  }
}
