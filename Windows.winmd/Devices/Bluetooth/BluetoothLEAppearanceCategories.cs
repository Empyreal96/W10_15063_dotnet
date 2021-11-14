// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.BluetoothLEAppearanceCategories
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [Static(typeof (IBluetoothLEAppearanceCategoriesStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772161)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public static class BluetoothLEAppearanceCategories
  {
    public static extern ushort Uncategorized { [MethodImpl] get; }

    public static extern ushort Phone { [MethodImpl] get; }

    public static extern ushort Computer { [MethodImpl] get; }

    public static extern ushort Watch { [MethodImpl] get; }

    public static extern ushort Clock { [MethodImpl] get; }

    public static extern ushort Display { [MethodImpl] get; }

    public static extern ushort RemoteControl { [MethodImpl] get; }

    public static extern ushort EyeGlasses { [MethodImpl] get; }

    public static extern ushort Tag { [MethodImpl] get; }

    public static extern ushort Keyring { [MethodImpl] get; }

    public static extern ushort MediaPlayer { [MethodImpl] get; }

    public static extern ushort BarcodeScanner { [MethodImpl] get; }

    public static extern ushort Thermometer { [MethodImpl] get; }

    public static extern ushort HeartRate { [MethodImpl] get; }

    public static extern ushort BloodPressure { [MethodImpl] get; }

    public static extern ushort HumanInterfaceDevice { [MethodImpl] get; }

    public static extern ushort GlucoseMeter { [MethodImpl] get; }

    public static extern ushort RunningWalking { [MethodImpl] get; }

    public static extern ushort Cycling { [MethodImpl] get; }

    public static extern ushort PulseOximeter { [MethodImpl] get; }

    public static extern ushort WeightScale { [MethodImpl] get; }

    public static extern ushort OutdoorSportActivity { [MethodImpl] get; }
  }
}
