// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothAdapter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Radios;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [Guid(2037706828, 24442, 18996, 146, 37, 168, 85, 248, 75, 26, 139)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (BluetoothAdapter))]
  internal interface IBluetoothAdapter
  {
    string DeviceId { get; }

    ulong BluetoothAddress { get; }

    bool IsClassicSupported { get; }

    bool IsLowEnergySupported { get; }

    bool IsPeripheralRoleSupported { get; }

    bool IsCentralRoleSupported { get; }

    bool IsAdvertisementOffloadSupported { get; }

    [RemoteAsync]
    IAsyncOperation<Radio> GetRadioAsync();
  }
}
