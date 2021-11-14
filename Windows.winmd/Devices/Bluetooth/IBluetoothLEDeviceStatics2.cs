// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothLEDeviceStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [ExclusiveTo(typeof (BluetoothLEDevice))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(1595064427, 15276, 17384, 173, 22, 86, 50, 113, 189, 65, 194)]
  internal interface IBluetoothLEDeviceStatics2
  {
    string GetDeviceSelectorFromPairingState(bool pairingState);

    string GetDeviceSelectorFromConnectionStatus(BluetoothConnectionStatus connectionStatus);

    string GetDeviceSelectorFromDeviceName(string deviceName);

    [Overload("GetDeviceSelectorFromBluetoothAddress")]
    string GetDeviceSelectorFromBluetoothAddress(ulong bluetoothAddress);

    [Overload("GetDeviceSelectorFromBluetoothAddressWithBluetoothAddressType")]
    string GetDeviceSelectorFromBluetoothAddress(
      ulong bluetoothAddress,
      BluetoothAddressType bluetoothAddressType);

    string GetDeviceSelectorFromAppearance(BluetoothLEAppearance appearance);

    [RemoteAsync]
    [Overload("FromBluetoothAddressWithBluetoothAddressTypeAsync")]
    IAsyncOperation<BluetoothLEDevice> FromBluetoothAddressAsync(
      ulong bluetoothAddress,
      BluetoothAddressType bluetoothAddressType);
  }
}
