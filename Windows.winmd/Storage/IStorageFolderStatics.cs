// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageFolderStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (StorageFolder))]
  [Guid(150153215, 34261, 18617, 174, 233, 40, 81, 30, 51, 159, 159)]
  internal interface IStorageFolderStatics
  {
    [RemoteAsync]
    IAsyncOperation<StorageFolder> GetFolderFromPathAsync(string path);
  }
}
