// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IBarcodeScannerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(1561419631, 55881, 16872, 140, 140, 240, 203, 98, 169, 196, 252)]
  [ExclusiveTo(typeof (BarcodeScanner))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBarcodeScannerStatics
  {
    [RemoteAsync]
    IAsyncOperation<BarcodeScanner> GetDefaultAsync();

    [RemoteAsync]
    IAsyncOperation<BarcodeScanner> FromIdAsync(string deviceId);

    string GetDeviceSelector();
  }
}
