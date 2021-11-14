// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.BluetoothLEAppearanceSubcategories
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IBluetoothLEAppearanceSubcategoriesStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772161)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class BluetoothLEAppearanceSubcategories
  {
    public static extern ushort Generic { [MethodImpl] get; }

    public static extern ushort SportsWatch { [MethodImpl] get; }

    public static extern ushort ThermometerEar { [MethodImpl] get; }

    public static extern ushort HeartRateBelt { [MethodImpl] get; }

    public static extern ushort BloodPressureArm { [MethodImpl] get; }

    public static extern ushort BloodPressureWrist { [MethodImpl] get; }

    public static extern ushort Keyboard { [MethodImpl] get; }

    public static extern ushort Mouse { [MethodImpl] get; }

    public static extern ushort Joystick { [MethodImpl] get; }

    public static extern ushort Gamepad { [MethodImpl] get; }

    public static extern ushort DigitizerTablet { [MethodImpl] get; }

    public static extern ushort CardReader { [MethodImpl] get; }

    public static extern ushort DigitalPen { [MethodImpl] get; }

    public static extern ushort BarcodeScanner { [MethodImpl] get; }

    public static extern ushort RunningWalkingInShoe { [MethodImpl] get; }

    public static extern ushort RunningWalkingOnShoe { [MethodImpl] get; }

    public static extern ushort RunningWalkingOnHip { [MethodImpl] get; }

    public static extern ushort CyclingComputer { [MethodImpl] get; }

    public static extern ushort CyclingSpeedSensor { [MethodImpl] get; }

    public static extern ushort CyclingCadenceSensor { [MethodImpl] get; }

    public static extern ushort CyclingPowerSensor { [MethodImpl] get; }

    public static extern ushort CyclingSpeedCadenceSensor { [MethodImpl] get; }

    public static extern ushort OximeterFingertip { [MethodImpl] get; }

    public static extern ushort OximeterWristWorn { [MethodImpl] get; }

    public static extern ushort LocationDisplay { [MethodImpl] get; }

    public static extern ushort LocationNavigationDisplay { [MethodImpl] get; }

    public static extern ushort LocationPod { [MethodImpl] get; }

    public static extern ushort LocationNavigationPod { [MethodImpl] get; }
  }
}
