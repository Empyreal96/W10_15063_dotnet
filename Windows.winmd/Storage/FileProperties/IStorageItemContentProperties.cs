// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.IStorageItemContentProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.FileProperties
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(86592429, 48184, 18623, 133, 215, 119, 14, 14, 42, 224, 186)]
  [ExclusiveTo(typeof (StorageItemContentProperties))]
  internal interface IStorageItemContentProperties : IStorageItemExtraProperties
  {
    [RemoteAsync]
    IAsyncOperation<MusicProperties> GetMusicPropertiesAsync();

    [RemoteAsync]
    IAsyncOperation<VideoProperties> GetVideoPropertiesAsync();

    [RemoteAsync]
    IAsyncOperation<ImageProperties> GetImagePropertiesAsync();

    [RemoteAsync]
    IAsyncOperation<DocumentProperties> GetDocumentPropertiesAsync();
  }
}
