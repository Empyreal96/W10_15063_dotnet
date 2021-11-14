// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.IPhotoImportManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Import
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PhotoImportManager))]
  [Guid(661753917, 41030, 20230, 155, 156, 191, 214, 98, 232, 50, 135)]
  internal interface IPhotoImportManagerStatics
  {
    [RemoteAsync]
    IAsyncOperation<bool> IsSupportedAsync();

    [RemoteAsync]
    IAsyncOperation<IVectorView<PhotoImportSource>> FindAllSourcesAsync();

    IVectorView<PhotoImportOperation> GetPendingOperations();
  }
}
