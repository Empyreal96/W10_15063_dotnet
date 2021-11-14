// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageLibraryChangeReader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(4060462211, 64674, 16889, 137, 84, 238, 46, 153, 30, 185, 111)]
  [ExclusiveTo(typeof (StorageLibraryChangeReader))]
  internal interface IStorageLibraryChangeReader
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<StorageLibraryChange>> ReadBatchAsync();

    [RemoteAsync]
    IAsyncAction AcceptChangesAsync();
  }
}
