// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IClaimedBarcodeScanner2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3820330636, 11659, 20336, 138, 243, 52, 72, 190, 221, 95, 226)]
  [ExclusiveTo(typeof (ClaimedBarcodeScanner))]
  internal interface IClaimedBarcodeScanner2 : IClosable
  {
    [RemoteAsync]
    IAsyncOperation<BarcodeSymbologyAttributes> GetSymbologyAttributesAsync(
      uint barcodeSymbology);

    [RemoteAsync]
    IAsyncOperation<bool> SetSymbologyAttributesAsync(
      uint barcodeSymbology,
      BarcodeSymbologyAttributes attributes);
  }
}
