// Decompiled with JetBrains decompiler
// Type: Windows.Media.Import.PhotoImportSession
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Media.Import
{
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PhotoImportSession : IPhotoImportSession, IClosable, IPhotoImportSession2
  {
    public extern PhotoImportSource Source { [MethodImpl] get; }

    public extern Guid SessionId { [MethodImpl] get; }

    public extern IStorageFolder DestinationFolder { [MethodImpl] set; [MethodImpl] get; }

    public extern bool AppendSessionDateToDestinationFolder { [MethodImpl] set; [MethodImpl] get; }

    public extern PhotoImportSubfolderCreationMode SubfolderCreationMode { [MethodImpl] set; [MethodImpl] get; }

    public extern string DestinationFileNamePrefix { [MethodImpl] set; [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<PhotoImportFindItemsResult, uint> FindItemsAsync(
      PhotoImportContentTypeFilter contentTypeFilter,
      PhotoImportItemSelectionMode itemSelectionMode);

    [MethodImpl]
    public extern void Close();

    public extern PhotoImportSubfolderDateFormat SubfolderDateFormat { [MethodImpl] set; [MethodImpl] get; }

    public extern bool RememberDeselectedItems { [MethodImpl] set; [MethodImpl] get; }
  }
}
