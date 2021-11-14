// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothLEAppearanceSubcategoriesStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [Guid(3850085894, 8516, 16730, 131, 18, 113, 204, 242, 145, 248, 209)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (BluetoothLEAppearanceSubcategories))]
  internal interface IBluetoothLEAppearanceSubcategoriesStatics
  {
    ushort Generic { get; }

    ushort SportsWatch { get; }

    ushort ThermometerEar { get; }

    ushort HeartRateBelt { get; }

    ushort BloodPressureArm { get; }

    ushort BloodPressureWrist { get; }

    ushort Keyboard { get; }

    ushort Mouse { get; }

    ushort Joystick { get; }

    ushort Gamepad { get; }

    ushort DigitizerTablet { get; }

    ushort CardReader { get; }

    ushort DigitalPen { get; }

    ushort BarcodeScanner { get; }

    ushort RunningWalkingInShoe { get; }

    ushort RunningWalkingOnShoe { get; }

    ushort RunningWalkingOnHip { get; }

    ushort CyclingComputer { get; }

    ushort CyclingSpeedSensor { get; }

    ushort CyclingCadenceSensor { get; }

    ushort CyclingPowerSensor { get; }

    ushort CyclingSpeedCadenceSensor { get; }

    ushort OximeterFingertip { get; }

    ushort OximeterWristWorn { get; }

    ushort LocationDisplay { get; }

    ushort LocationNavigationDisplay { get; }

    ushort LocationPod { get; }

    ushort LocationNavigationPod { get; }
  }
}
