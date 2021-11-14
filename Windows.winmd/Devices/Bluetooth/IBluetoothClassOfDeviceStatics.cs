// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothClassOfDeviceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3831575997, 4002, 16748, 145, 180, 193, 228, 140, 160, 97, 193)]
  [ExclusiveTo(typeof (BluetoothClassOfDevice))]
  internal interface IBluetoothClassOfDeviceStatics
  {
    BluetoothClassOfDevice FromRawValue(uint rawValue);

    BluetoothClassOfDevice FromParts(
      BluetoothMajorClass majorClass,
      BluetoothMinorClass minorClass,
      BluetoothServiceCapabilities serviceCapabilities);
  }
}
