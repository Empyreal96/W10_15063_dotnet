// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.IWalletBarcode
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Wallet
{
  [ExclusiveTo(typeof (WalletBarcode))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1334147881, 56960, 20132, 161, 205, 129, 205, 8, 77, 172, 39)]
  internal interface IWalletBarcode
  {
    WalletBarcodeSymbology Symbology { get; }

    string Value { get; }

    [RemoteAsync]
    IAsyncOperation<IRandomAccessStreamReference> GetImageAsync();
  }
}
