// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.WalletBarcode
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Wallet
{
  [Activatable(typeof (IWalletBarcodeFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class WalletBarcode : IWalletBarcode
  {
    [MethodImpl]
    public extern WalletBarcode(WalletBarcodeSymbology symbology, string value);

    [MethodImpl]
    public extern WalletBarcode(IRandomAccessStreamReference streamToBarcodeImage);

    public extern WalletBarcodeSymbology Symbology { [MethodImpl] get; }

    public extern string Value { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStreamReference> GetImageAsync();
  }
}
