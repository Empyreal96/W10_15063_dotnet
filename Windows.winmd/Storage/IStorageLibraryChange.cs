// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageLibraryChange
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (StorageLibraryChange))]
  [Guid(9964323, 11234, 18697, 170, 72, 21, 159, 82, 3, 165, 30)]
  internal interface IStorageLibraryChange
  {
    StorageLibraryChangeType ChangeType { get; }

    string Path { get; }

    string PreviousPath { get; }

    bool IsOfType(StorageItemTypes type);

    [RemoteAsync]
    IAsyncOperation<IStorageItem> GetStorageItemAsync();
  }
}
