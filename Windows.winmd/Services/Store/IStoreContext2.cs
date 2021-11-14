// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.IStoreContext2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [ExclusiveTo(typeof (StoreContext))]
  [ContractVersion(typeof (StoreContract), 131072)]
  [Guid(414995674, 31705, 17708, 145, 22, 59, 189, 6, 255, 198, 58)]
  internal interface IStoreContext2
  {
    [RemoteAsync]
    IAsyncOperation<StoreProductResult> FindStoreProductForPackageAsync(
      IIterable<string> productKinds,
      Package package);
  }
}
