// Decompiled with JetBrains decompiler
// Type: Windows.Storage.BulkAccess.IStorageItemInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.FileProperties;

namespace Windows.Storage.BulkAccess
{
  [Guid(2275789707, 35186, 20288, 141, 224, 216, 111, 177, 121, 216, 250)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IStorageItemInformation
  {
    MusicProperties MusicProperties { get; }

    VideoProperties VideoProperties { get; }

    ImageProperties ImageProperties { get; }

    DocumentProperties DocumentProperties { get; }

    BasicProperties BasicProperties { get; }

    StorageItemThumbnail Thumbnail { get; }

    event TypedEventHandler<IStorageItemInformation, object> ThumbnailUpdated;

    event TypedEventHandler<IStorageItemInformation, object> PropertiesUpdated;
  }
}
