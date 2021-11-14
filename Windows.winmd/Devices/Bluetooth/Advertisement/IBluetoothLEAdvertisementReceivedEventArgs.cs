// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.IBluetoothLEAdvertisementReceivedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Advertisement
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(664305119, 58774, 16830, 141, 67, 158, 103, 49, 212, 169, 19)]
  [ExclusiveTo(typeof (BluetoothLEAdvertisementReceivedEventArgs))]
  internal interface IBluetoothLEAdvertisementReceivedEventArgs
  {
    short RawSignalStrengthInDBm { get; }

    ulong BluetoothAddress { get; }

    BluetoothLEAdvertisementType AdvertisementType { get; }

    DateTime Timestamp { get; }

    BluetoothLEAdvertisement Advertisement { get; }
  }
}
