// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothDeviceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking;

namespace Windows.Devices.Bluetooth
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(160554833, 22491, 18213, 187, 215, 132, 246, 67, 39, 236, 44)]
  [ExclusiveTo(typeof (BluetoothDevice))]
  internal interface IBluetoothDeviceStatics
  {
    [RemoteAsync]
    IAsyncOperation<BluetoothDevice> FromIdAsync(string deviceId);

    [RemoteAsync]
    IAsyncOperation<BluetoothDevice> FromHostNameAsync(
      HostName hostName);

    [RemoteAsync]
    IAsyncOperation<BluetoothDevice> FromBluetoothAddressAsync(
      ulong address);

    string GetDeviceSelector();
  }
}
