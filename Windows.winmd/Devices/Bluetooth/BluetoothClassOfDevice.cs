// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.BluetoothClassOfDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [Static(typeof (IBluetoothClassOfDeviceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  public sealed class BluetoothClassOfDevice : IBluetoothClassOfDevice
  {
    public extern uint RawValue { [MethodImpl] get; }

    public extern BluetoothMajorClass MajorClass { [MethodImpl] get; }

    public extern BluetoothMinorClass MinorClass { [MethodImpl] get; }

    public extern BluetoothServiceCapabilities ServiceCapabilities { [MethodImpl] get; }

    [MethodImpl]
    public static extern BluetoothClassOfDevice FromRawValue(uint rawValue);

    [MethodImpl]
    public static extern BluetoothClassOfDevice FromParts(
      BluetoothMajorClass majorClass,
      BluetoothMinorClass minorClass,
      BluetoothServiceCapabilities serviceCapabilities);
  }
}
