// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothLEDevice3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [ExclusiveTo(typeof (BluetoothLEDevice))]
  [Guid(2934563987, 17580, 16604, 175, 51, 178, 193, 60, 1, 202, 70)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IBluetoothLEDevice3
  {
    DeviceAccessInformation DeviceAccessInformation { get; }

    [RemoteAsync]
    IAsyncOperation<DeviceAccessStatus> RequestAccessAsync();

    [Overload("GetGattServicesAsync")]
    [RemoteAsync]
    IAsyncOperation<GattDeviceServicesResult> GetGattServicesAsync();

    [Overload("GetGattServicesWithCacheModeAsync")]
    [RemoteAsync]
    IAsyncOperation<GattDeviceServicesResult> GetGattServicesAsync(
      BluetoothCacheMode cacheMode);

    [Overload("GetGattServicesForUuidAsync")]
    [RemoteAsync]
    IAsyncOperation<GattDeviceServicesResult> GetGattServicesForUuidAsync(
      Guid serviceUuid);

    [RemoteAsync]
    [Overload("GetGattServicesForUuidWithCacheModeAsync")]
    IAsyncOperation<GattDeviceServicesResult> GetGattServicesForUuidAsync(
      Guid serviceUuid,
      BluetoothCacheMode cacheMode);
  }
}
