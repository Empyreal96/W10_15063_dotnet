// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.IPhotoImportSourceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Media.Import
{
  [ExclusiveTo(typeof (PhotoImportSource))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(86566278, 13016, 18044, 140, 238, 35, 161, 178, 244, 62, 133)]
  internal interface IPhotoImportSourceStatics
  {
    [RemoteAsync]
    IAsyncOperation<PhotoImportSource> FromIdAsync(string sourceId);

    [RemoteAsync]
    IAsyncOperation<PhotoImportSource> FromFolderAsync(
      IStorageFolder sourceRootFolder);
  }
}
