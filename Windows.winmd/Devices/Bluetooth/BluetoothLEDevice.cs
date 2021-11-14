// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.BluetoothLEDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IBluetoothLEDeviceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IBluetoothLEDeviceStatics2), 131072, "Windows.Foundation.UniversalApiContract")]
  public sealed class BluetoothLEDevice : 
    IBluetoothLEDevice,
    IClosable,
    IBluetoothLEDevice2,
    IBluetoothLEDevice3
  {
    public extern string DeviceId { [MethodImpl] get; }

    public extern string Name { [MethodImpl] get; }

    public extern IVectorView<GattDeviceService> GattServices { [Deprecated("Use GetGattServicesAsync instead of GattServices.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern BluetoothConnectionStatus ConnectionStatus { [MethodImpl] get; }

    public extern ulong BluetoothAddress { [MethodImpl] get; }

    [Deprecated("Use GetGattServicesForUuidAsync instead of GetGattService.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern GattDeviceService GetGattService(Guid serviceUuid);

    public extern event TypedEventHandler<BluetoothLEDevice, object> NameChanged;

    public extern event TypedEventHandler<BluetoothLEDevice, object> GattServicesChanged;

    public extern event TypedEventHandler<BluetoothLEDevice, object> ConnectionStatusChanged;

    [MethodImpl]
    public extern void Close();

    public extern DeviceInformation DeviceInformation { [MethodImpl] get; }

    public extern BluetoothLEAppearance Appearance { [MethodImpl] get; }

    public extern BluetoothAddressType BluetoothAddressType { [MethodImpl] get; }

    public extern DeviceAccessInformation DeviceAccessInformation { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DeviceAccessStatus> RequestAccessAsync();

    [RemoteAsync]
    [Overload("GetGattServicesAsync")]
    [MethodImpl]
    public extern IAsyncOperation<GattDeviceServicesResult> GetGattServicesAsync();

    [RemoteAsync]
    [Overload("GetGattServicesWithCacheModeAsync")]
    [MethodImpl]
    public extern IAsyncOperation<GattDeviceServicesResult> GetGattServicesAsync(
      BluetoothCacheMode cacheMode);

    [RemoteAsync]
    [Overload("GetGattServicesForUuidAsync")]
    [MethodImpl]
    public extern IAsyncOperation<GattDeviceServicesResult> GetGattServicesForUuidAsync(
      Guid serviceUuid);

    [RemoteAsync]
    [Overload("GetGattServicesForUuidWithCacheModeAsync")]
    [MethodImpl]
    public extern IAsyncOperation<GattDeviceServicesResult> GetGattServicesForUuidAsync(
      Guid serviceUuid,
      BluetoothCacheMode cacheMode);

    [MethodImpl]
    public static extern string GetDeviceSelectorFromPairingState(bool pairingState);

    [MethodImpl]
    public static extern string GetDeviceSelectorFromConnectionStatus(
      BluetoothConnectionStatus connectionStatus);

    [MethodImpl]
    public static extern string GetDeviceSelectorFromDeviceName(string deviceName);

    [Overload("GetDeviceSelectorFromBluetoothAddress")]
    [MethodImpl]
    public static extern string GetDeviceSelectorFromBluetoothAddress(ulong bluetoothAddress);

    [Overload("GetDeviceSelectorFromBluetoothAddressWithBluetoothAddressType")]
    [MethodImpl]
    public static extern string GetDeviceSelectorFromBluetoothAddress(
      ulong bluetoothAddress,
      BluetoothAddressType bluetoothAddressType);

    [MethodImpl]
    public static extern string GetDeviceSelectorFromAppearance(BluetoothLEAppearance appearance);

    [RemoteAsync]
    [Overload("FromBluetoothAddressWithBluetoothAddressTypeAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<BluetoothLEDevice> FromBluetoothAddressAsync(
      ulong bluetoothAddress,
      BluetoothAddressType bluetoothAddressType);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<BluetoothLEDevice> FromIdAsync(
      string deviceId);

    [RemoteAsync]
    [Overload("FromBluetoothAddressAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<BluetoothLEDevice> FromBluetoothAddressAsync(
      ulong bluetoothAddress);

    [MethodImpl]
    public static extern string GetDeviceSelector();
  }
}
