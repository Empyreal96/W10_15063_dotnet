// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.IPhotoImportFindItemsResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  [Guid(957736519, 27768, 18731, 132, 78, 143, 229, 232, 246, 191, 185)]
  [ExclusiveTo(typeof (PhotoImportFindItemsResult))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPhotoImportFindItemsResult
  {
    PhotoImportSession Session { get; }

    bool HasSucceeded { get; }

    IVectorView<PhotoImportItem> FoundItems { get; }

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

    void SelectAll();

    void SelectNone();

    [RemoteAsync]
    IAsyncAction SelectNewAsync();

    void SetImportMode(PhotoImportImportMode value);

    PhotoImportImportMode ImportMode { get; }

    uint SelectedPhotosCount { get; }

    ulong SelectedPhotosSizeInBytes { get; }

    uint SelectedVideosCount { get; }

    ulong SelectedVideosSizeInBytes { get; }

    uint SelectedSidecarsCount { get; }

    ulong SelectedSidecarsSizeInBytes { get; }

    uint SelectedSiblingsCount { get; }

    ulong SelectedSiblingsSizeInBytes { get; }

    uint SelectedTotalCount { get; }

    ulong SelectedTotalSizeInBytes { get; }

    event TypedEventHandler<PhotoImportFindItemsResult, PhotoImportSelectionChangedEventArgs> SelectionChanged;

    [RemoteAsync]
    IAsyncOperationWithProgress<PhotoImportImportItemsResult, PhotoImportProgress> ImportItemsAsync();

    event TypedEventHandler<PhotoImportFindItemsResult, PhotoImportItemImportedEventArgs> ItemImported;
  }
}
