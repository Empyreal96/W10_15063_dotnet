// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothDeviceStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [Guid(3265170991, 19988, 17527, 170, 27, 184, 180, 126, 91, 126, 206)]
  [ExclusiveTo(typeof (BluetoothDevice))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IBluetoothDeviceStatics2 : IBluetoothDeviceStatics
  {
    string GetDeviceSelectorFromPairingState(bool pairingState);

    string GetDeviceSelectorFromConnectionStatus(BluetoothConnectionStatus connectionStatus);

    string GetDeviceSelectorFromDeviceName(string deviceName);

    string GetDeviceSelectorFromBluetoothAddress(ulong bluetoothAddress);

    string GetDeviceSelectorFromClassOfDevice(BluetoothClassOfDevice classOfDevice);
  }
}
