// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.IWalletItemStore
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Wallet
{
  [ExclusiveTo(typeof (WalletItemStore))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1902135371, 27977, 18680, 145, 169, 64, 161, 208, 241, 62, 244)]
  internal interface IWalletItemStore
  {
    [RemoteAsync]
    IAsyncAction AddAsync(string id, WalletItem item);

    [RemoteAsync]
    IAsyncAction ClearAsync();

    [RemoteAsync]
    IAsyncOperation<WalletItem> GetWalletItemAsync(string id);

    [Overload("GetItemsAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<WalletItem>> GetItemsAsync();

    [Overload("GetItemsWithKindAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<WalletItem>> GetItemsAsync(
      WalletItemKind kind);

    [RemoteAsync]
    IAsyncOperation<WalletItem> ImportItemAsync(
      IRandomAccessStreamReference stream);

    [RemoteAsync]
    IAsyncAction DeleteAsync(string id);

    [RemoteAsync]
    [Overload("ShowAsync")]
    IAsyncAction ShowAsync();

    [RemoteAsync]
    [Overload("ShowItemAsync")]
    IAsyncAction ShowAsync(string id);

    [RemoteAsync]
    IAsyncAction UpdateAsync(WalletItem item);
  }
}
