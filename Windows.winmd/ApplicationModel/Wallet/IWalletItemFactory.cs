// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.IWalletItemFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Wallet
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1407349872, 20235, 19006, 153, 229, 11, 187, 30, 171, 56, 212)]
  [ExclusiveTo(typeof (WalletItem))]
  internal interface IWalletItemFactory
  {
    WalletItem CreateWalletItem(WalletItemKind kind, string displayName);
  }
}
