// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.System.IWalletManagerSystemStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Wallet.System
{
  [ExclusiveTo(typeof (WalletManagerSystem))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3202935689, 9780, 19354, 139, 35, 238, 137, 3, 201, 31, 224)]
  internal interface IWalletManagerSystemStatics
  {
    [RemoteAsync]
    IAsyncOperation<WalletItemSystemStore> RequestStoreAsync();
  }
}
