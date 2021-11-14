// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothClassOfDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3594527358, 55255, 18017, 148, 84, 101, 3, 156, 161, 122, 43)]
  [ExclusiveTo(typeof (BluetoothClassOfDevice))]
  internal interface IBluetoothClassOfDevice
  {
    uint RawValue { get; }

    BluetoothMajorClass MajorClass { get; }

    BluetoothMinorClass MinorClass { get; }

    BluetoothServiceCapabilities ServiceCapabilities { get; }
  }
}
