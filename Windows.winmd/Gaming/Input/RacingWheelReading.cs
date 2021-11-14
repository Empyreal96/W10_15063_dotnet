// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.RacingWheelReading
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public struct RacingWheelReading
  {
    public ulong Timestamp;
    public RacingWheelButtons Buttons;
    public int PatternShifterGear;
    public double Wheel;
    public double Throttle;
    public double Brake;
    public double Clutch;
    public double Handbrake;
  }
}
