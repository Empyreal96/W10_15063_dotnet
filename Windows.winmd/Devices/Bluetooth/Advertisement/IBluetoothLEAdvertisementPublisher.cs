// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.IBluetoothLEAdvertisementPublisher
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Advertisement
{
  [Guid(3454542073, 55802, 17366, 162, 100, 221, 216, 183, 218, 139, 120)]
  [ExclusiveTo(typeof (BluetoothLEAdvertisementPublisher))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBluetoothLEAdvertisementPublisher
  {
    BluetoothLEAdvertisementPublisherStatus Status { get; }

    BluetoothLEAdvertisement Advertisement { get; }

    void Start();

    void Stop();

    event TypedEventHandler<BluetoothLEAdvertisementPublisher, BluetoothLEAdvertisementPublisherStatusChangedEventArgs> StatusChanged;
  }
}
