// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.System.WalletItemSystemStore
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Wallet.System
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class WalletItemSystemStore : IWalletItemSystemStore, IWalletItemSystemStore2
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<WalletItem>> GetItemsAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAsync(WalletItem item);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<WalletItem> ImportItemAsync(
      IRandomAccessStreamReference stream);

    [MethodImpl]
    public extern WalletItemAppAssociation GetAppStatusForItem(
      WalletItem item);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> LaunchAppForItemAsync(WalletItem item);

    public extern event TypedEventHandler<WalletItemSystemStore, object> ItemsChanged;
  }
}
