// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattDeviceService
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IGattDeviceServiceStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  [Static(typeof (IGattDeviceServiceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GattDeviceService : 
    IGattDeviceService,
    IClosable,
    IGattDeviceService2,
    IGattDeviceService3
  {
    [Deprecated("Use GetCharacteristicsForUuidAsync instead of GetCharacteristics.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IVectorView<GattCharacteristic> GetCharacteristics(
      Guid characteristicUuid);

    [Deprecated("Use GetIncludedServicesForUuidAsync instead of GetIncludedServices.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IVectorView<GattDeviceService> GetIncludedServices(
      Guid serviceUuid);

    public extern string DeviceId { [MethodImpl] get; }

    public extern Guid Uuid { [MethodImpl] get; }

    public extern ushort AttributeHandle { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    public extern BluetoothLEDevice Device { [Deprecated("Use Session instead of Device property.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern IVectorView<GattDeviceService> ParentServices { [Deprecated("ParentServices may be altered or unavailable in future releases.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    [Deprecated("Use GetCharacteristicsAsync instead of GetAllCharacteristics.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IVectorView<GattCharacteristic> GetAllCharacteristics();

    [Deprecated("Use GetIncludedServicesAsync instead of GetAllIncludedServices.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IVectorView<GattDeviceService> GetAllIncludedServices();

    public extern DeviceAccessInformation DeviceAccessInformation { [MethodImpl] get; }

    public extern GattSession Session { [MethodImpl] get; }

    public extern GattSharingMode SharingMode { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DeviceAccessStatus> RequestAccessAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GattOpenStatus> OpenAsync(
      GattSharingMode sharingMode);

    [RemoteAsync]
    [Overload("GetCharacteristicsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<GattCharacteristicsResult> GetCharacteristicsAsync();

    [RemoteAsync]
    [Overload("GetCharacteristicsWithCacheModeAsync")]
    [MethodImpl]
    public extern IAsyncOperation<GattCharacteristicsResult> GetCharacteristicsAsync(
      BluetoothCacheMode cacheMode);

    [Overload("GetCharacteristicsForUuidAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GattCharacteristicsResult> GetCharacteristicsForUuidAsync(
      Guid characteristicUuid);

    [RemoteAsync]
    [Overload("GetCharacteristicsForUuidWithCacheModeAsync")]
    [MethodImpl]
    public extern IAsyncOperation<GattCharacteristicsResult> GetCharacteristicsForUuidAsync(
      Guid characteristicUuid,
      BluetoothCacheMode cacheMode);

    [RemoteAsync]
    [Overload("GetIncludedServicesAsync")]
    [MethodImpl]
    public extern IAsyncOperation<GattDeviceServicesResult> GetIncludedServicesAsync();

    [RemoteAsync]
    [Overload("GetIncludedServicesWithCacheModeAsync")]
    [MethodImpl]
    public extern IAsyncOperation<GattDeviceServicesResult> GetIncludedServicesAsync(
      BluetoothCacheMode cacheMode);

    [RemoteAsync]
    [Overload("GetIncludedServicesForUuidAsync")]
    [MethodImpl]
    public extern IAsyncOperation<GattDeviceServicesResult> GetIncludedServicesForUuidAsync(
      Guid serviceUuid);

    [RemoteAsync]
    [Overload("GetIncludedServicesForUuidWithCacheModeAsync")]
    [MethodImpl]
    public extern IAsyncOperation<GattDeviceServicesResult> GetIncludedServicesForUuidAsync(
      Guid serviceUuid,
      BluetoothCacheMode cacheMode);

    [RemoteAsync]
    [Overload("FromIdWithSharingModeAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<GattDeviceService> FromIdAsync(
      string deviceId,
      GattSharingMode sharingMode);

    [Overload("GetDeviceSelectorForBluetoothDeviceId")]
    [MethodImpl]
    public static extern string GetDeviceSelectorForBluetoothDeviceId(
      BluetoothDeviceId bluetoothDeviceId);

    [Overload("GetDeviceSelectorForBluetoothDeviceIdWithCacheMode")]
    [MethodImpl]
    public static extern string GetDeviceSelectorForBluetoothDeviceId(
      BluetoothDeviceId bluetoothDeviceId,
      BluetoothCacheMode cacheMode);

    [Overload("GetDeviceSelectorForBluetoothDeviceIdAndUuid")]
    [MethodImpl]
    public static extern string GetDeviceSelectorForBluetoothDeviceIdAndUuid(
      BluetoothDeviceId bluetoothDeviceId,
      Guid serviceUuid);

    [Overload("GetDeviceSelectorForBluetoothDeviceIdAndUuidWithCacheMode")]
    [MethodImpl]
    public static extern string GetDeviceSelectorForBluetoothDeviceIdAndUuid(
      BluetoothDeviceId bluetoothDeviceId,
      Guid serviceUuid,
      BluetoothCacheMode cacheMode);

    [RemoteAsync]
    [Overload("FromIdAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<GattDeviceService> FromIdAsync(
      string deviceId);

    [MethodImpl]
    public static extern string GetDeviceSelectorFromUuid(Guid serviceUuid);

    [Deprecated("Use GetDeviceSelectorFromUuid instead of GetDeviceSelectorFromShortId.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern string GetDeviceSelectorFromShortId(ushort serviceShortId);

    [Deprecated("Use BluetoothUuidHelper instead of ConvertShortIdToUuid.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern Guid ConvertShortIdToUuid(ushort shortId);
  }
}
