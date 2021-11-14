// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothDevice2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [ExclusiveTo(typeof (BluetoothDevice))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(20183380, 45398, 19920, 177, 245, 193, 27, 195, 26, 81, 99)]
  internal interface IBluetoothDevice2 : IBluetoothDevice
  {
    DeviceInformation DeviceInformation { get; }
  }
}
