// Decompiled with JetBrains decompiler
// Type: Windows.System.Power.IPowerManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Power
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(328499805, 25294, 17252, 152, 213, 170, 40, 199, 251, 209, 91)]
  [ExclusiveTo(typeof (PowerManager))]
  internal interface IPowerManagerStatics
  {
    EnergySaverStatus EnergySaverStatus { get; }

    event EventHandler<object> EnergySaverStatusChanged;

    BatteryStatus BatteryStatus { get; }

    event EventHandler<object> BatteryStatusChanged;

    PowerSupplyStatus PowerSupplyStatus { get; }

    event EventHandler<object> PowerSupplyStatusChanged;

    int RemainingChargePercent { get; }

    event EventHandler<object> RemainingChargePercentChanged;

    TimeSpan RemainingDischargeTime { get; }

    event EventHandler<object> RemainingDischargeTimeChanged;
  }
}
