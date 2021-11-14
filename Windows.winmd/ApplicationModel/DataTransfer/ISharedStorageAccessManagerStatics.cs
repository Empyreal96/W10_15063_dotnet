// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.ISharedStorageAccessManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.ApplicationModel.DataTransfer
{
  [Guid(3323144922, 13489, 18505, 189, 95, 208, 159, 238, 49, 88, 197)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SharedStorageAccessManager))]
  internal interface ISharedStorageAccessManagerStatics
  {
    string AddFile(IStorageFile file);

    [RemoteAsync]
    IAsyncOperation<StorageFile> RedeemTokenForFileAsync(string token);

    void RemoveFile(string token);
  }
}
