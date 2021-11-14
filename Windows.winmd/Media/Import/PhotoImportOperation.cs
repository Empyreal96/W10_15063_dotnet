// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.PhotoImportOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PhotoImportOperation : IPhotoImportOperation
  {
    public extern PhotoImportStage Stage { [MethodImpl] get; }

    public extern PhotoImportSession Session { [MethodImpl] get; }

    public extern IAsyncOperationWithProgress<PhotoImportFindItemsResult, uint> ContinueFindingItemsAsync { [RemoteAsync, MethodImpl] get; }

    public extern IAsyncOperationWithProgress<PhotoImportImportItemsResult, PhotoImportProgress> ContinueImportingItemsAsync { [RemoteAsync, MethodImpl] get; }

    public extern IAsyncOperationWithProgress<PhotoImportDeleteImportedItemsFromSourceResult, double> ContinueDeletingImportedItemsFromSourceAsync { [RemoteAsync, MethodImpl] get; }
  }
}
