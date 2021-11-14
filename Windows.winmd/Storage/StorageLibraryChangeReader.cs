// Decompiled with JetBrains decompiler
// Type: Windows.Storage.StorageLibraryChangeReader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class StorageLibraryChangeReader : IStorageLibraryChangeReader
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<StorageLibraryChange>> ReadBatchAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction AcceptChangesAsync();
  }
}
