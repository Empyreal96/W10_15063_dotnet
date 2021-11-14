// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.IPhotoImportOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  [Guid(3656882148, 41114, 20196, 164, 177, 32, 148, 2, 119, 165, 190)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PhotoImportOperation))]
  internal interface IPhotoImportOperation
  {
    PhotoImportStage Stage { get; }

    PhotoImportSession Session { get; }

    IAsyncOperationWithProgress<PhotoImportFindItemsResult, uint> ContinueFindingItemsAsync { [RemoteAsync] get; }

    IAsyncOperationWithProgress<PhotoImportImportItemsResult, PhotoImportProgress> ContinueImportingItemsAsync { [RemoteAsync] get; }

    IAsyncOperationWithProgress<PhotoImportDeleteImportedItemsFromSourceResult, double> ContinueDeletingImportedItemsFromSourceAsync { [RemoteAsync] get; }
  }
}
