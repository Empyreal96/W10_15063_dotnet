// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IBarcodeScanner
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (BarcodeScanner))]
  [Guid(3198369286, 45668, 20227, 169, 193, 69, 178, 15, 1, 19, 79)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBarcodeScanner
  {
    string DeviceId { get; }

    BarcodeScannerCapabilities Capabilities { get; }

    [RemoteAsync]
    IAsyncOperation<ClaimedBarcodeScanner> ClaimScannerAsync();

    [RemoteAsync]
    IAsyncOperation<string> CheckHealthAsync(UnifiedPosHealthCheckLevel level);

    [RemoteAsync]
    IAsyncOperation<IVectorView<uint>> GetSupportedSymbologiesAsync();

    [RemoteAsync]
    IAsyncOperation<bool> IsSymbologySupportedAsync(uint barcodeSymbology);

    [RemoteAsync]
    IAsyncOperation<IBuffer> RetrieveStatisticsAsync(
      IIterable<string> statisticsCategories);

    IVectorView<string> GetSupportedProfiles();

    bool IsProfileSupported(string profile);

    event TypedEventHandler<BarcodeScanner, BarcodeScannerStatusUpdatedEventArgs> StatusUpdated;
  }
}
