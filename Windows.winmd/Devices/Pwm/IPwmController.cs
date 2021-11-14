// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Pwm.IPwmController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Devices.Pwm
{
  [ContractVersion(typeof (DevicesLowLevelContract), 65536)]
  [Guid(3294583941, 53992, 17103, 155, 214, 207, 94, 208, 41, 230, 167)]
  [ExclusiveTo(typeof (PwmController))]
  internal interface IPwmController
  {
    int PinCount { get; }

    double ActualFrequency { get; }

    double SetDesiredFrequency(double desiredFrequency);

    double MinFrequency { get; }

    double MaxFrequency { get; }

    PwmPin OpenPin(int pinNumber);
  }
}
