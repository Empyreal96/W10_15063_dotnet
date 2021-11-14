// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.IWalletItemCustomPropertyFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Wallet
{
  [ExclusiveTo(typeof (WalletItemCustomProperty))]
  [Guid(3489950276, 24993, 16810, 178, 89, 165, 97, 10, 181, 213, 117)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWalletItemCustomPropertyFactory
  {
    WalletItemCustomProperty CreateWalletItemCustomProperty(
      string name,
      string value);
  }
}
