// Decompiled with JetBrains decompiler
// Type: Windows.Storage.BulkAccess.IFileInformationFactoryFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.FileProperties;
using Windows.Storage.Search;

namespace Windows.Storage.BulkAccess
{
  [ExclusiveTo(typeof (FileInformationFactory))]
  [Guid(2229931645, 58530, 20224, 138, 250, 175, 94, 15, 130, 107, 213)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFileInformationFactoryFactory
  {
    FileInformationFactory CreateWithMode(
      IStorageQueryResultBase queryResult,
      ThumbnailMode mode);

    FileInformationFactory CreateWithModeAndSize(
      IStorageQueryResultBase queryResult,
      ThumbnailMode mode,
      uint requestedThumbnailSize);

    FileInformationFactory CreateWithModeAndSizeAndOptions(
      IStorageQueryResultBase queryResult,
      ThumbnailMode mode,
      uint requestedThumbnailSize,
      ThumbnailOptions thumbnailOptions);

    FileInformationFactory CreateWithModeAndSizeAndOptionsAndFlags(
      IStorageQueryResultBase queryResult,
      ThumbnailMode mode,
      uint requestedThumbnailSize,
      ThumbnailOptions thumbnailOptions,
      bool delayLoad);
  }
}
