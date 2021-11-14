// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageLibraryStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ExclusiveTo(typeof (StorageLibrary))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1107863259, 26698, 18886, 158, 89, 144, 18, 30, 224, 80, 214)]
  internal interface IStorageLibraryStatics
  {
    [RemoteAsync]
    IAsyncOperation<StorageLibrary> GetLibraryAsync(
      KnownLibraryId libraryId);
  }
}
