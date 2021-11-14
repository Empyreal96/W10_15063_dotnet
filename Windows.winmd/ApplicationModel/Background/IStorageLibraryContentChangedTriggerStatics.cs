// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IStorageLibraryContentChangedTriggerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.Background
{
  [Guid(2141133625, 24464, 19986, 145, 78, 167, 216, 224, 187, 251, 24)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (StorageLibraryContentChangedTrigger))]
  internal interface IStorageLibraryContentChangedTriggerStatics
  {
    StorageLibraryContentChangedTrigger Create(
      StorageLibrary storageLibrary);

    StorageLibraryContentChangedTrigger CreateFromLibraries(
      IIterable<StorageLibrary> storageLibraries);
  }
}
