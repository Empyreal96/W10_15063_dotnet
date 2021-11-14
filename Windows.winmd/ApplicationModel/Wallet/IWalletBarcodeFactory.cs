// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.IWalletBarcodeFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Wallet
{
  [Guid(806449505, 60828, 18078, 187, 253, 48, 108, 149, 234, 113, 8)]
  [ExclusiveTo(typeof (WalletBarcode))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWalletBarcodeFactory
  {
    WalletBarcode CreateWalletBarcode(WalletBarcodeSymbology symbology, string value);

    WalletBarcode CreateCustomWalletBarcode(
      IRandomAccessStreamReference streamToBarcodeImage);
  }
}
