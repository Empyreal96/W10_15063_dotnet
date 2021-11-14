// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Power.BatteryReport
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System.Power;

namespace Windows.Devices.Power
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class BatteryReport : IBatteryReport
  {
    public extern IReference<int> ChargeRateInMilliwatts { [MethodImpl] get; }

    public extern IReference<int> DesignCapacityInMilliwattHours { [MethodImpl] get; }

    public extern IReference<int> FullChargeCapacityInMilliwattHours { [MethodImpl] get; }

    public extern IReference<int> RemainingCapacityInMilliwattHours { [MethodImpl] get; }

    public extern BatteryStatus Status { [MethodImpl] get; }
  }
}
