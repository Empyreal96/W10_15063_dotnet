// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.PhotoImportFindItemsResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PhotoImportFindItemsResult : 
    IPhotoImportFindItemsResult,
    IPhotoImportFindItemsResult2
  {
    public extern PhotoImportSession Session { [MethodImpl] get; }

    public extern bool HasSucceeded { [MethodImpl] get; }

    public extern IVectorView<PhotoImportItem> FoundItems { [MethodImpl] get; }

    public extern uint PhotosCount { [MethodImpl] get; }

    public extern ulong PhotosSizeInBytes { [MethodImpl] get; }

    public extern uint VideosCount { [MethodImpl] get; }

    public extern ulong VideosSizeInBytes { [MethodImpl] get; }

    public extern uint SidecarsCount { [MethodImpl] get; }

    public extern ulong SidecarsSizeInBytes { [MethodImpl] get; }

    public extern uint SiblingsCount { [MethodImpl] get; }

    public extern ulong SiblingsSizeInBytes { [MethodImpl] get; }

    public extern uint TotalCount { [MethodImpl] get; }

    public extern ulong TotalSizeInBytes { [MethodImpl] get; }

    [MethodImpl]
    public extern void SelectAll();

    [MethodImpl]
    public extern void SelectNone();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SelectNewAsync();

    [MethodImpl]
    public extern void SetImportMode(PhotoImportImportMode value);

    public extern PhotoImportImportMode ImportMode { [MethodImpl] get; }

    public extern uint SelectedPhotosCount { [MethodImpl] get; }

    public extern ulong SelectedPhotosSizeInBytes { [MethodImpl] get; }

    public extern uint SelectedVideosCount { [MethodImpl] get; }

    public extern ulong SelectedVideosSizeInBytes { [MethodImpl] get; }

    public extern uint SelectedSidecarsCount { [MethodImpl] get; }

    public extern ulong SelectedSidecarsSizeInBytes { [MethodImpl] get; }

    public extern uint SelectedSiblingsCount { [MethodImpl] get; }

    public extern ulong SelectedSiblingsSizeInBytes { [MethodImpl] get; }

    public extern uint SelectedTotalCount { [MethodImpl] get; }

    public extern ulong SelectedTotalSizeInBytes { [MethodImpl] get; }

    public extern event TypedEventHandler<PhotoImportFindItemsResult, PhotoImportSelectionChangedEventArgs> SelectionChanged;

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<PhotoImportImportItemsResult, PhotoImportProgress> ImportItemsAsync();

    public extern event TypedEventHandler<PhotoImportFindItemsResult, PhotoImportItemImportedEventArgs> ItemImported;

    [MethodImpl]
    public extern void AddItemsInDateRangeToSelection(DateTime rangeStart, TimeSpan rangeLength);
  }
}
