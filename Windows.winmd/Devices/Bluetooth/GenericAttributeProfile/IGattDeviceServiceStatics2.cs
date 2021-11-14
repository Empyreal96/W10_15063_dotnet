// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattDeviceServiceStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattDeviceService))]
  [Guid(100931694, 9382, 19213, 162, 242, 48, 204, 1, 84, 93, 37)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IGattDeviceServiceStatics2
  {
    [Overload("FromIdWithSharingModeAsync")]
    [RemoteAsync]
    IAsyncOperation<GattDeviceService> FromIdAsync(
      string deviceId,
      GattSharingMode sharingMode);

    [Overload("GetDeviceSelectorForBluetoothDeviceId")]
    string GetDeviceSelectorForBluetoothDeviceId(BluetoothDeviceId bluetoothDeviceId);

    [Overload("GetDeviceSelectorForBluetoothDeviceIdWithCacheMode")]
    string GetDeviceSelectorForBluetoothDeviceId(
      BluetoothDeviceId bluetoothDeviceId,
      BluetoothCacheMode cacheMode);

    [Overload("GetDeviceSelectorForBluetoothDeviceIdAndUuid")]
    string GetDeviceSelectorForBluetoothDeviceIdAndUuid(
      BluetoothDeviceId bluetoothDeviceId,
      Guid serviceUuid);

    [Overload("GetDeviceSelectorForBluetoothDeviceIdAndUuidWithCacheMode")]
    string GetDeviceSelectorForBluetoothDeviceIdAndUuid(
      BluetoothDeviceId bluetoothDeviceId,
      Guid serviceUuid,
      BluetoothCacheMode cacheMode);
  }
}
