// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothLEAppearanceCategoriesStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [Guid(1833784574, 1130, 16773, 170, 182, 130, 76, 240, 97, 8, 97)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (BluetoothLEAppearanceCategories))]
  internal interface IBluetoothLEAppearanceCategoriesStatics
  {
    ushort Uncategorized { get; }

    ushort Phone { get; }

    ushort Computer { get; }

    ushort Watch { get; }

    ushort Clock { get; }

    ushort Display { get; }

    ushort RemoteControl { get; }

    ushort EyeGlasses { get; }

    ushort Tag { get; }

    ushort Keyring { get; }

    ushort MediaPlayer { get; }

    ushort BarcodeScanner { get; }

    ushort Thermometer { get; }

    ushort HeartRate { get; }

    ushort BloodPressure { get; }

    ushort HumanInterfaceDevice { get; }

    ushort GlucoseMeter { get; }

    ushort RunningWalking { get; }

    ushort Cycling { get; }

    ushort PulseOximeter { get; }

    ushort WeightScale { get; }

    ushort OutdoorSportActivity { get; }
  }
}
