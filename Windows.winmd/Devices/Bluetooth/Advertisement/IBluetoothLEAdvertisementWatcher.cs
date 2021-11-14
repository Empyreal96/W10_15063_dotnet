// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.IBluetoothLEAdvertisementWatcher
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Advertisement
{
  [ExclusiveTo(typeof (BluetoothLEAdvertisementWatcher))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2796303215, 62419, 17047, 141, 108, 200, 30, 166, 98, 63, 64)]
  internal interface IBluetoothLEAdvertisementWatcher
  {
    TimeSpan MinSamplingInterval { get; }

    TimeSpan MaxSamplingInterval { get; }

    TimeSpan MinOutOfRangeTimeout { get; }

    TimeSpan MaxOutOfRangeTimeout { get; }

    BluetoothLEAdvertisementWatcherStatus Status { get; }

    BluetoothLEScanningMode ScanningMode { get; set; }

    BluetoothSignalStrengthFilter SignalStrengthFilter { get; set; }

    BluetoothLEAdvertisementFilter AdvertisementFilter { get; set; }

    void Start();

    void Stop();

    event TypedEventHandler<BluetoothLEAdvertisementWatcher, BluetoothLEAdvertisementReceivedEventArgs> Received;

    event TypedEventHandler<BluetoothLEAdvertisementWatcher, BluetoothLEAdvertisementWatcherStoppedEventArgs> Stopped;
  }
}
