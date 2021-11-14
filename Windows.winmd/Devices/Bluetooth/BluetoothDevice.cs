// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.BluetoothDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Bluetooth.Rfcomm;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth
{
  [Static(typeof (IBluetoothDeviceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IBluetoothDeviceStatics2), 131072, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  public sealed class BluetoothDevice : 
    IBluetoothDevice,
    IClosable,
    IBluetoothDevice2,
    IBluetoothDevice3
  {
    public extern string DeviceId { [MethodImpl] get; }

    public extern HostName HostName { [MethodImpl] get; }

    public extern string Name { [MethodImpl] get; }

    public extern BluetoothClassOfDevice ClassOfDevice { [MethodImpl] get; }

    public extern IVectorView<IBuffer> SdpRecords { [MethodImpl] get; }

    public extern IVectorView<RfcommDeviceService> RfcommServices { [Deprecated("Use GetRfcommServicesAsync instead of RfcommServices.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public extern BluetoothConnectionStatus ConnectionStatus { [MethodImpl] get; }

    public extern ulong BluetoothAddress { [MethodImpl] get; }

    public extern event TypedEventHandler<BluetoothDevice, object> NameChanged;

    public extern event TypedEventHandler<BluetoothDevice, object> SdpRecordsChanged;

    public extern event TypedEventHandler<BluetoothDevice, object> ConnectionStatusChanged;

    [MethodImpl]
    public extern void Close();

    public extern DeviceInformation DeviceInformation { [MethodImpl] get; }

    public extern DeviceAccessInformation DeviceAccessInformation { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DeviceAccessStatus> RequestAccessAsync();

    [Overload("GetRfcommServicesAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<RfcommDeviceServicesResult> GetRfcommServicesAsync();

    [RemoteAsync]
    [Overload("GetRfcommServicesWithCacheModeAsync")]
    [MethodImpl]
    public extern IAsyncOperation<RfcommDeviceServicesResult> GetRfcommServicesAsync(
      BluetoothCacheMode cacheMode);

    [Overload("GetRfcommServicesForIdAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<RfcommDeviceServicesResult> GetRfcommServicesForIdAsync(
      RfcommServiceId serviceId);

    [RemoteAsync]
    [Overload("GetRfcommServicesForIdWithCacheModeAsync")]
    [MethodImpl]
    public extern IAsyncOperation<RfcommDeviceServicesResult> GetRfcommServicesForIdAsync(
      RfcommServiceId serviceId,
      BluetoothCacheMode cacheMode);

    [MethodImpl]
    public static extern string GetDeviceSelectorFromPairingState(bool pairingState);

    [MethodImpl]
    public static extern string GetDeviceSelectorFromConnectionStatus(
      BluetoothConnectionStatus connectionStatus);

    [MethodImpl]
    public static extern string GetDeviceSelectorFromDeviceName(string deviceName);

    [MethodImpl]
    public static extern string GetDeviceSelectorFromBluetoothAddress(ulong bluetoothAddress);

    [MethodImpl]
    public static extern string GetDeviceSelectorFromClassOfDevice(
      BluetoothClassOfDevice classOfDevice);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<BluetoothDevice> FromIdAsync(
      string deviceId);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<BluetoothDevice> FromHostNameAsync(
      HostName hostName);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<BluetoothDevice> FromBluetoothAddressAsync(
      ulong address);

    [MethodImpl]
    public static extern string GetDeviceSelector();
  }
}
