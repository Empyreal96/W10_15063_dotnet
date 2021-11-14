// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Rfcomm.IRfcommDeviceServiceStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Rfcomm
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (RfcommDeviceService))]
  [Guid(2861347273, 59277, 19428, 128, 118, 10, 61, 135, 160, 160, 95)]
  internal interface IRfcommDeviceServiceStatics2 : IRfcommDeviceServiceStatics
  {
    [Overload("GetDeviceSelectorForBluetoothDevice")]
    string GetDeviceSelectorForBluetoothDevice(BluetoothDevice bluetoothDevice);

    [Overload("GetDeviceSelectorForBluetoothDeviceWithCacheMode")]
    string GetDeviceSelectorForBluetoothDevice(
      BluetoothDevice bluetoothDevice,
      BluetoothCacheMode cacheMode);

    [Overload("GetDeviceSelectorForBluetoothDeviceAndServiceId")]
    string GetDeviceSelectorForBluetoothDeviceAndServiceId(
      BluetoothDevice bluetoothDevice,
      RfcommServiceId serviceId);

    [Overload("GetDeviceSelectorForBluetoothDeviceAndServiceIdWithCacheMode")]
    string GetDeviceSelectorForBluetoothDeviceAndServiceId(
      BluetoothDevice bluetoothDevice,
      RfcommServiceId serviceId,
      BluetoothCacheMode cacheMode);
  }
}
