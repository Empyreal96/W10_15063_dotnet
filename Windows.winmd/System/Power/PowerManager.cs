// Decompiled with JetBrains decompiler
// Type: Windows.System.Power.PowerManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Power
{
  [Static(typeof (IPowerManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class PowerManager
  {
    public static extern EnergySaverStatus EnergySaverStatus { [MethodImpl] get; }

    public static extern event EventHandler<object> EnergySaverStatusChanged;

    public static extern BatteryStatus BatteryStatus { [MethodImpl] get; }

    public static extern event EventHandler<object> BatteryStatusChanged;

    public static extern PowerSupplyStatus PowerSupplyStatus { [MethodImpl] get; }

    public static extern event EventHandler<object> PowerSupplyStatusChanged;

    public static extern int RemainingChargePercent { [MethodImpl] get; }

    public static extern event EventHandler<object> RemainingChargePercentChanged;

    public static extern TimeSpan RemainingDischargeTime { [MethodImpl] get; }

    public static extern event EventHandler<object> RemainingDischargeTimeChanged;
  }
}
