// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.BluetoothLEAppearance
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [Static(typeof (IBluetoothLEAppearanceStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [DualApiPartition(version = 167772161)]
  public sealed class BluetoothLEAppearance : IBluetoothLEAppearance
  {
    public extern ushort RawValue { [MethodImpl] get; }

    public extern ushort Category { [MethodImpl] get; }

    public extern ushort SubCategory { [MethodImpl] get; }

    [MethodImpl]
    public static extern BluetoothLEAppearance FromRawValue(ushort rawValue);

    [MethodImpl]
    public static extern BluetoothLEAppearance FromParts(
      ushort appearanceCategory,
      ushort appearanceSubCategory);
  }
}
