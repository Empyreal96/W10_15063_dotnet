// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothLEDevice2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(653288115, 31470, 19761, 186, 186, 177, 185, 119, 95, 89, 22)]
  [ExclusiveTo(typeof (BluetoothLEDevice))]
  internal interface IBluetoothLEDevice2 : IBluetoothLEDevice
  {
    DeviceInformation DeviceInformation { get; }

    BluetoothLEAppearance Appearance { get; }

    BluetoothAddressType BluetoothAddressType { get; }
  }
}
