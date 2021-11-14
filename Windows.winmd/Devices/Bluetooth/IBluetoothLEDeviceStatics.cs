// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothLEDeviceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [Guid(3369015833, 61622, 19440, 134, 137, 65, 48, 61, 226, 217, 244)]
  [ExclusiveTo(typeof (BluetoothLEDevice))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBluetoothLEDeviceStatics
  {
    [RemoteAsync]
    IAsyncOperation<BluetoothLEDevice> FromIdAsync(string deviceId);

    [Overload("FromBluetoothAddressAsync")]
    [RemoteAsync]
    IAsyncOperation<BluetoothLEDevice> FromBluetoothAddressAsync(
      ulong bluetoothAddress);

    string GetDeviceSelector();
  }
}
