// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.WalletItemStore
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Wallet
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WalletItemStore : IWalletItemStore
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction AddAsync(string id, WalletItem item);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ClearAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<WalletItem> GetWalletItemAsync(string id);

    [RemoteAsync]
    [Overload("GetItemsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<WalletItem>> GetItemsAsync();

    [RemoteAsync]
    [Overload("GetItemsWithKindAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<WalletItem>> GetItemsAsync(
      WalletItemKind kind);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<WalletItem> ImportItemAsync(
      IRandomAccessStreamReference stream);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAsync(string id);

    [RemoteAsync]
    [Overload("ShowAsync")]
    [MethodImpl]
    public extern IAsyncAction ShowAsync();

    [RemoteAsync]
    [Overload("ShowItemAsync")]
    [MethodImpl]
    public extern IAsyncAction ShowAsync(string id);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction UpdateAsync(WalletItem item);
  }
}
