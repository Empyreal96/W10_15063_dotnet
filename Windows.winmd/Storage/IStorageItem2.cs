// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageItem2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [Guid(1408837330, 2108, 17027, 180, 91, 129, 192, 7, 35, 126, 68)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IStorageItem2 : IStorageItem
  {
    [RemoteAsync]
    IAsyncOperation<StorageFolder> GetParentAsync();

    bool IsEqual(IStorageItem item);
  }
}
