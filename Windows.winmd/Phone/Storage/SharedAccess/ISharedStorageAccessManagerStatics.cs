// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Storage.SharedAccess.ISharedStorageAccessManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Phone.Storage.SharedAccess
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Guid(2900768559, 38166, 17875, 137, 98, 56, 8, 178, 23, 188, 110)]
  [ExclusiveTo(typeof (SharedStorageAccessManager))]
  internal interface ISharedStorageAccessManagerStatics
  {
    IAsyncOperation<IStorageFile> CopySharedFileAsync(
      StorageFolder destinationFolder,
      string desiredName,
      NameCollisionOption option,
      string fileToken);

    string GetSharedFileName(string fileToken);
  }
}
