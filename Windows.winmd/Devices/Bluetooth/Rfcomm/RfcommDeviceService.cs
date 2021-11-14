// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Rfcomm.RfcommDeviceService
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking;
using Windows.Networking.Sockets;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.Rfcomm
{
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IRfcommDeviceServiceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  [Static(typeof (IRfcommDeviceServiceStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class RfcommDeviceService : 
    IRfcommDeviceService,
    IRfcommDeviceService2,
    IClosable,
    IRfcommDeviceService3
  {
    public extern HostName ConnectionHostName { [MethodImpl] get; }

    public extern string ConnectionServiceName { [MethodImpl] get; }

    public extern RfcommServiceId ServiceId { [MethodImpl] get; }

    public extern SocketProtectionLevel ProtectionLevel { [MethodImpl] get; }

    public extern SocketProtectionLevel MaxProtectionLevel { [MethodImpl] get; }

    [Overload("GetSdpRawAttributesAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IMapView<uint, IBuffer>> GetSdpRawAttributesAsync();

    [Overload("GetSdpRawAttributesWithCacheModeAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IMapView<uint, IBuffer>> GetSdpRawAttributesAsync(
      BluetoothCacheMode cacheMode);

    public extern BluetoothDevice Device { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    public extern DeviceAccessInformation DeviceAccessInformation { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DeviceAccessStatus> RequestAccessAsync();

    [Overload("GetDeviceSelectorForBluetoothDevice")]
    [MethodImpl]
    public static extern string GetDeviceSelectorForBluetoothDevice(BluetoothDevice bluetoothDevice);

    [Overload("GetDeviceSelectorForBluetoothDeviceWithCacheMode")]
    [MethodImpl]
    public static extern string GetDeviceSelectorForBluetoothDevice(
      BluetoothDevice bluetoothDevice,
      BluetoothCacheMode cacheMode);

    [Overload("GetDeviceSelectorForBluetoothDeviceAndServiceId")]
    [MethodImpl]
    public static extern string GetDeviceSelectorForBluetoothDeviceAndServiceId(
      BluetoothDevice bluetoothDevice,
      RfcommServiceId serviceId);

    [Overload("GetDeviceSelectorForBluetoothDeviceAndServiceIdWithCacheMode")]
    [MethodImpl]
    public static extern string GetDeviceSelectorForBluetoothDeviceAndServiceId(
      BluetoothDevice bluetoothDevice,
      RfcommServiceId serviceId,
      BluetoothCacheMode cacheMode);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<RfcommDeviceService> FromIdAsync(
      string deviceId);

    [MethodImpl]
    public static extern string GetDeviceSelector(RfcommServiceId serviceId);
  }
}
