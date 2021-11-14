// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Power.IBattery
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Power
{
  [Guid(3163115462, 114, 18376, 139, 93, 97, 74, 170, 122, 67, 126)]
  [ExclusiveTo(typeof (Battery))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBattery
  {
    string DeviceId { get; }

    BatteryReport GetReport();

    event TypedEventHandler<Battery, object> ReportUpdated;
  }
}
