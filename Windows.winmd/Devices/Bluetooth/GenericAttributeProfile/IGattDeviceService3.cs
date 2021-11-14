// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattDeviceService3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [Guid(2996021584, 3155, 17276, 169, 179, 92, 50, 16, 198, 229, 105)]
  [ExclusiveTo(typeof (GattDeviceService))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IGattDeviceService3
  {
    DeviceAccessInformation DeviceAccessInformation { get; }

    GattSession Session { get; }

    GattSharingMode SharingMode { get; }

    [RemoteAsync]
    IAsyncOperation<DeviceAccessStatus> RequestAccessAsync();

    [RemoteAsync]
    IAsyncOperation<GattOpenStatus> OpenAsync(
      GattSharingMode sharingMode);

    [RemoteAsync]
    [Overload("GetCharacteristicsAsync")]
    IAsyncOperation<GattCharacteristicsResult> GetCharacteristicsAsync();

    [Overload("GetCharacteristicsWithCacheModeAsync")]
    [RemoteAsync]
    IAsyncOperation<GattCharacteristicsResult> GetCharacteristicsAsync(
      BluetoothCacheMode cacheMode);

    [Overload("GetCharacteristicsForUuidAsync")]
    [RemoteAsync]
    IAsyncOperation<GattCharacteristicsResult> GetCharacteristicsForUuidAsync(
      Guid characteristicUuid);

    [RemoteAsync]
    [Overload("GetCharacteristicsForUuidWithCacheModeAsync")]
    IAsyncOperation<GattCharacteristicsResult> GetCharacteristicsForUuidAsync(
      Guid characteristicUuid,
      BluetoothCacheMode cacheMode);

    [RemoteAsync]
    [Overload("GetIncludedServicesAsync")]
    IAsyncOperation<GattDeviceServicesResult> GetIncludedServicesAsync();

    [Overload("GetIncludedServicesWithCacheModeAsync")]
    [RemoteAsync]
    IAsyncOperation<GattDeviceServicesResult> GetIncludedServicesAsync(
      BluetoothCacheMode cacheMode);

    [RemoteAsync]
    [Overload("GetIncludedServicesForUuidAsync")]
    IAsyncOperation<GattDeviceServicesResult> GetIncludedServicesForUuidAsync(
      Guid serviceUuid);

    [Overload("GetIncludedServicesForUuidWithCacheModeAsync")]
    [RemoteAsync]
    IAsyncOperation<GattDeviceServicesResult> GetIncludedServicesForUuidAsync(
      Guid serviceUuid,
      BluetoothCacheMode cacheMode);
  }
}
