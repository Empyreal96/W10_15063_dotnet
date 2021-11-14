// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.IWalletManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Wallet
{
  [Guid(1360123576, 51620, 19556, 180, 221, 225, 229, 72, 0, 28, 13)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WalletManager))]
  internal interface IWalletManagerStatics
  {
    [RemoteAsync]
    IAsyncOperation<WalletItemStore> RequestStoreAsync();
  }
}
