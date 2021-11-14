// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Devices.Power.Battery
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Devices.Power
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IBatteryStatics), 65536, "Windows.Phone.PhoneContract")]
  [ContractVersion(typeof (PhoneContract), 65536)]
  public sealed class Battery : IBattery
  {
    public extern int RemainingChargePercent { [MethodImpl] get; }

    public extern TimeSpan RemainingDischargeTime { [MethodImpl] get; }

    public extern event EventHandler<object> RemainingChargePercentChanged;

    [MethodImpl]
    public static extern Battery GetDefault();
  }
}
