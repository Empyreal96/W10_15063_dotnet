// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.IBluetoothLEAdvertisementDataTypesStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Advertisement
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1001801519, 1542, 17227, 167, 110, 116, 21, 159, 6, 132, 211)]
  [ExclusiveTo(typeof (BluetoothLEAdvertisementDataTypes))]
  internal interface IBluetoothLEAdvertisementDataTypesStatics
  {
    byte Flags { get; }

    byte IncompleteService16BitUuids { get; }

    byte CompleteService16BitUuids { get; }

    byte IncompleteService32BitUuids { get; }

    byte CompleteService32BitUuids { get; }

    byte IncompleteService128BitUuids { get; }

    byte CompleteService128BitUuids { get; }

    byte ShortenedLocalName { get; }

    byte CompleteLocalName { get; }

    byte TxPowerLevel { get; }

    byte SlaveConnectionIntervalRange { get; }

    byte ServiceSolicitation16BitUuids { get; }

    byte ServiceSolicitation32BitUuids { get; }

    byte ServiceSolicitation128BitUuids { get; }

    byte ServiceData16BitUuids { get; }

    byte ServiceData32BitUuids { get; }

    byte ServiceData128BitUuids { get; }

    byte PublicTargetAddress { get; }

    byte RandomTargetAddress { get; }

    byte Appearance { get; }

    byte AdvertisingInterval { get; }

    byte ManufacturerSpecificData { get; }
  }
}
