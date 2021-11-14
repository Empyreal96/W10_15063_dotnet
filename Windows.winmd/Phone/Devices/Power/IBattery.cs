// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Devices.Power.IBattery
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Devices.Power
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  [ExclusiveTo(typeof (Battery))]
  [Guid(2536168413, 26400, 18178, 164, 118, 185, 211, 138, 0, 112, 227)]
  internal interface IBattery
  {
    int RemainingChargePercent { get; }

    TimeSpan RemainingDischargeTime { get; }

    event EventHandler<object> RemainingChargePercentChanged;
  }
}
