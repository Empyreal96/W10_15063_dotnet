// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothDevice3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Bluetooth.Rfcomm;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [ExclusiveTo(typeof (BluetoothDevice))]
  [Guid(1476392843, 25882, 17492, 185, 15, 235, 33, 239, 11, 13, 113)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IBluetoothDevice3 : IBluetoothDevice2, IBluetoothDevice
  {
    DeviceAccessInformation DeviceAccessInformation { get; }

    [RemoteAsync]
    IAsyncOperation<DeviceAccessStatus> RequestAccessAsync();

    [Overload("GetRfcommServicesAsync")]
    [RemoteAsync]
    IAsyncOperation<RfcommDeviceServicesResult> GetRfcommServicesAsync();

    [RemoteAsync]
    [Overload("GetRfcommServicesWithCacheModeAsync")]
    IAsyncOperation<RfcommDeviceServicesResult> GetRfcommServicesAsync(
      BluetoothCacheMode cacheMode);

    [Overload("GetRfcommServicesForIdAsync")]
    [RemoteAsync]
    IAsyncOperation<RfcommDeviceServicesResult> GetRfcommServicesForIdAsync(
      RfcommServiceId serviceId);

    [RemoteAsync]
    [Overload("GetRfcommServicesForIdWithCacheModeAsync")]
    IAsyncOperation<RfcommDeviceServicesResult> GetRfcommServicesForIdAsync(
      RfcommServiceId serviceId,
      BluetoothCacheMode cacheMode);
  }
}
