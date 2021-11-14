// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.IPhotoImportSession
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Media.Import
{
  [ExclusiveTo(typeof (PhotoImportSession))]
  [Guid(2858652014, 60635, 20222, 148, 198, 95, 92, 175, 227, 76, 251)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPhotoImportSession : IClosable
  {
    PhotoImportSource Source { get; }

    Guid SessionId { get; }

    IStorageFolder DestinationFolder { set; get; }

    bool AppendSessionDateToDestinationFolder { set; get; }

    PhotoImportSubfolderCreationMode SubfolderCreationMode { set; get; }

    string DestinationFileNamePrefix { set; get; }

    [RemoteAsync]
    IAsyncOperationWithProgress<PhotoImportFindItemsResult, uint> FindItemsAsync(
      PhotoImportContentTypeFilter contentTypeFilter,
      PhotoImportItemSelectionMode itemSelectionMode);
  }
}
