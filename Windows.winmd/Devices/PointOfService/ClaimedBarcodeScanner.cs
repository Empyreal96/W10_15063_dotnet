// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ClaimedBarcodeScanner
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ClaimedBarcodeScanner : 
    IClaimedBarcodeScanner,
    IClosable,
    IClaimedBarcodeScanner1,
    IClaimedBarcodeScanner2
  {
    public extern string DeviceId { [MethodImpl] get; }

    public extern bool IsEnabled { [MethodImpl] get; }

    public extern bool IsDisabledOnDataReceived { [MethodImpl] set; [MethodImpl] get; }

    public extern bool IsDecodeDataEnabled { [MethodImpl] set; [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction EnableAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DisableAsync();

    [MethodImpl]
    public extern void RetainDevice();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetActiveSymbologiesAsync(IIterable<uint> symbologies);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ResetStatisticsAsync(
      IIterable<string> statisticsCategories);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction UpdateStatisticsAsync(
      IIterable<IKeyValuePair<string, string>> statistics);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetActiveProfileAsync(string profile);

    public extern event TypedEventHandler<ClaimedBarcodeScanner, BarcodeScannerDataReceivedEventArgs> DataReceived;

    public extern event EventHandler<ClaimedBarcodeScanner> TriggerPressed;

    public extern event EventHandler<ClaimedBarcodeScanner> TriggerReleased;

    public extern event EventHandler<ClaimedBarcodeScanner> ReleaseDeviceRequested;

    public extern event TypedEventHandler<ClaimedBarcodeScanner, BarcodeScannerImagePreviewReceivedEventArgs> ImagePreviewReceived;

    public extern event TypedEventHandler<ClaimedBarcodeScanner, BarcodeScannerErrorOccurredEventArgs> ErrorOccurred;

    [MethodImpl]
    public extern void Close();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StartSoftwareTriggerAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StopSoftwareTriggerAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<BarcodeSymbologyAttributes> GetSymbologyAttributesAsync(
      uint barcodeSymbology);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> SetSymbologyAttributesAsync(
      uint barcodeSymbology,
      BarcodeSymbologyAttributes attributes);
  }
}
