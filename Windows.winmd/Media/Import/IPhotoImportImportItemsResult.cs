// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.IPhotoImportImportItemsResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  [Guid(3839161464, 54297, 17475, 168, 78, 240, 106, 133, 12, 11, 0)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PhotoImportImportItemsResult))]
  internal interface IPhotoImportImportItemsResult
  {
    PhotoImportSession Session { get; }

    bool HasSucceeded { get; }

    IVectorView<PhotoImportItem> ImportedItems { get; }

    uint PhotosCount { get; }

    ulong PhotosSizeInBytes { get; }

    uint VideosCount { get; }

    ulong VideosSizeInBytes { get; }

    uint SidecarsCount { get; }

    ulong SidecarsSizeInBytes { get; }

    uint SiblingsCount { get; }

    ulong SiblingsSizeInBytes { get; }

    uint TotalCount { get; }

    ulong TotalSizeInBytes { get; }

    [RemoteAsync]
    IAsyncOperationWithProgress<PhotoImportDeleteImportedItemsFromSourceResult, double> DeleteImportedItemsFromSourceAsync();
  }
}
