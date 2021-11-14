// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBluetoothLEAdvertisementWatcherTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.Advertisement;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Guid(447420441, 48353, 18667, 168, 39, 89, 251, 124, 238, 82, 166)]
  [ExclusiveTo(typeof (BluetoothLEAdvertisementWatcherTrigger))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBluetoothLEAdvertisementWatcherTrigger : IBackgroundTrigger
  {
    TimeSpan MinSamplingInterval { get; }

    TimeSpan MaxSamplingInterval { get; }

    TimeSpan MinOutOfRangeTimeout { get; }

    TimeSpan MaxOutOfRangeTimeout { get; }

    BluetoothSignalStrengthFilter SignalStrengthFilter { get; set; }

    BluetoothLEAdvertisementFilter AdvertisementFilter { get; set; }
  }
}
