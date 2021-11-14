// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.PhotoImportImportItemsResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class PhotoImportImportItemsResult : IPhotoImportImportItemsResult
  {
    public extern PhotoImportSession Session { [MethodImpl] get; }

    public extern bool HasSucceeded { [MethodImpl] get; }

    public extern IVectorView<PhotoImportItem> ImportedItems { [MethodImpl] get; }

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

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<PhotoImportDeleteImportedItemsFromSourceResult, double> DeleteImportedItemsFromSourceAsync();
  }
}
