// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.BarcodeScanner
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.PointOfService
{
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IBarcodeScannerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IBarcodeScannerStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class BarcodeScanner : IBarcodeScanner, IBarcodeScanner2, IClosable
  {
    public extern string DeviceId { [MethodImpl] get; }

    public extern BarcodeScannerCapabilities Capabilities { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ClaimedBarcodeScanner> ClaimScannerAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> CheckHealthAsync(
      UnifiedPosHealthCheckLevel level);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<uint>> GetSupportedSymbologiesAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> IsSymbologySupportedAsync(
      uint barcodeSymbology);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IBuffer> RetrieveStatisticsAsync(
      IIterable<string> statisticsCategories);

    [MethodImpl]
    public extern IVectorView<string> GetSupportedProfiles();

    [MethodImpl]
    public extern bool IsProfileSupported(string profile);

    public extern event TypedEventHandler<BarcodeScanner, BarcodeScannerStatusUpdatedEventArgs> StatusUpdated;

    public extern string VideoDeviceId { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    [Overload("GetDeviceSelectorWithConnectionTypes")]
    [MethodImpl]
    public static extern string GetDeviceSelector(PosConnectionTypes connectionTypes);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<BarcodeScanner> GetDefaultAsync();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<BarcodeScanner> FromIdAsync(
      string deviceId);

    [MethodImpl]
    public static extern string GetDeviceSelector();
  }
}
