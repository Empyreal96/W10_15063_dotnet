// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageFile2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Storage
{
  [Guid(2504936399, 2679, 17147, 183, 119, 194, 237, 88, 165, 46, 68)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IStorageFile2
  {
    [RemoteAsync]
    [Overload("OpenWithOptionsAsync")]
    IAsyncOperation<IRandomAccessStream> OpenAsync(
      FileAccessMode accessMode,
      StorageOpenOptions options);

    [RemoteAsync]
    [Overload("OpenTransactedWriteWithOptionsAsync")]
    IAsyncOperation<StorageStreamTransaction> OpenTransactedWriteAsync(
      StorageOpenOptions options);
  }
}
