// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IGameControllerBatteryInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Power;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [Guid(3706504833, 14691, 19878, 149, 93, 85, 63, 59, 111, 97, 97)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public interface IGameControllerBatteryInfo
  {
    BatteryReport TryGetBatteryReport();
  }
}
