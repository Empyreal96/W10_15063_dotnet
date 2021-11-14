// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothLEDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BluetoothLEDevice))]
  [Guid(3052285819, 19160, 17986, 172, 72, 128, 160, 181, 0, 232, 135)]
  internal interface IBluetoothLEDevice
  {
    string DeviceId { get; }

    string Name { get; }

    IVectorView<GattDeviceService> GattServices { [Deprecated("Use GetGattServicesAsync instead of GattServices.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    BluetoothConnectionStatus ConnectionStatus { get; }

    ulong BluetoothAddress { get; }

    [Deprecated("Use GetGattServicesForUuidAsync instead of GetGattService.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    GattDeviceService GetGattService(Guid serviceUuid);

    event TypedEventHandler<BluetoothLEDevice, object> NameChanged;

    event TypedEventHandler<BluetoothLEDevice, object> GattServicesChanged;

    event TypedEventHandler<BluetoothLEDevice, object> ConnectionStatusChanged;
  }
}
