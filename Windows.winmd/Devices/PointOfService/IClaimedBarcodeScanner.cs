// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IClaimedBarcodeScanner
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(1248048284, 36772, 17202, 187, 38, 148, 93, 17, 216, 30, 15)]
  [ExclusiveTo(typeof (ClaimedBarcodeScanner))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IClaimedBarcodeScanner : IClosable
  {
    string DeviceId { get; }

    bool IsEnabled { get; }

    bool IsDisabledOnDataReceived { set; get; }

    bool IsDecodeDataEnabled { set; get; }

    [RemoteAsync]
    IAsyncAction EnableAsync();

    [RemoteAsync]
    IAsyncAction DisableAsync();

    void RetainDevice();

    [RemoteAsync]
    IAsyncAction SetActiveSymbologiesAsync(IIterable<uint> symbologies);

    [RemoteAsync]
    IAsyncAction ResetStatisticsAsync(IIterable<string> statisticsCategories);

    [RemoteAsync]
    IAsyncAction UpdateStatisticsAsync(
      IIterable<IKeyValuePair<string, string>> statistics);

    [RemoteAsync]
    IAsyncAction SetActiveProfileAsync(string profile);

    event TypedEventHandler<ClaimedBarcodeScanner, BarcodeScannerDataReceivedEventArgs> DataReceived;

    event EventHandler<ClaimedBarcodeScanner> TriggerPressed;

    event EventHandler<ClaimedBarcodeScanner> TriggerReleased;

    event EventHandler<ClaimedBarcodeScanner> ReleaseDeviceRequested;

    event TypedEventHandler<ClaimedBarcodeScanner, BarcodeScannerImagePreviewReceivedEventArgs> ImagePreviewReceived;

    event TypedEventHandler<ClaimedBarcodeScanner, BarcodeScannerErrorOccurredEventArgs> ErrorOccurred;
  }
}
