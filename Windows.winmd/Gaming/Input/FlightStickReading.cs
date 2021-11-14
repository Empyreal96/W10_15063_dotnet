// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.FlightStickReading
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public struct FlightStickReading
  {
    public ulong Timestamp;
    public FlightStickButtons Buttons;
    public GameControllerSwitchPosition HatSwitch;
    public double Roll;
    public double Pitch;
    public double Yaw;
    public double Throttle;
  }
}
