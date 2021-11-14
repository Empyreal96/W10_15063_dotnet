// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.System.IWalletItemSystemStore
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Wallet.System
{
  [Guid(1378757631, 38562, 18967, 141, 25, 254, 29, 159, 131, 117, 97)]
  [ExclusiveTo(typeof (WalletItemSystemStore))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWalletItemSystemStore
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<WalletItem>> GetItemsAsync();

    [RemoteAsync]
    IAsyncAction DeleteAsync(WalletItem item);

    [RemoteAsync]
    IAsyncOperation<WalletItem> ImportItemAsync(
      IRandomAccessStreamReference stream);

    WalletItemAppAssociation GetAppStatusForItem(WalletItem item);

    [RemoteAsync]
    IAsyncOperation<bool> LaunchAppForItemAsync(WalletItem item);
  }
}
