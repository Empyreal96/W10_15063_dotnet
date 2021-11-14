// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageLibrary
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [Guid(517828867, 3678, 19820, 181, 232, 147, 24, 152, 61, 106, 3)]
  [ExclusiveTo(typeof (StorageLibrary))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IStorageLibrary
  {
    IAsyncOperation<StorageFolder> RequestAddFolderAsync();

    IAsyncOperation<bool> RequestRemoveFolderAsync(StorageFolder folder);

    IObservableVector<StorageFolder> Folders { get; }

    StorageFolder SaveFolder { get; }

    event TypedEventHandler<StorageLibrary, object> DefinitionChanged;
  }
}
