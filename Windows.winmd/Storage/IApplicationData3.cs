// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IApplicationData3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [Guid(3693227252, 10098, 19485, 170, 44, 201, 247, 67, 173, 232, 209)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ApplicationData))]
  internal interface IApplicationData3
  {
    StorageFolder GetPublisherCacheFolder(string folderName);

    [RemoteAsync]
    IAsyncAction ClearPublisherCacheFolderAsync(string folderName);

    StorageFolder SharedLocalFolder { get; }
  }
}
