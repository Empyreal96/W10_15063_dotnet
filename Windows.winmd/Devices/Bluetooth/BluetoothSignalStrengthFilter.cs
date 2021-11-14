// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.BluetoothSignalStrengthFilter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class BluetoothSignalStrengthFilter : IBluetoothSignalStrengthFilter
  {
    [MethodImpl]
    public extern BluetoothSignalStrengthFilter();

    public extern IReference<short> InRangeThresholdInDBm { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<short> OutOfRangeThresholdInDBm { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<TimeSpan> OutOfRangeTimeout { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<TimeSpan> SamplingInterval { [MethodImpl] get; [MethodImpl] set; }
  }
}
