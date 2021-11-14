// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Pwm.IPwmPin
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Pwm
{
  [ExclusiveTo(typeof (PwmPin))]
  [Guid(580333000, 50895, 18465, 183, 249, 198, 69, 79, 182, 175, 121)]
  [ContractVersion(typeof (DevicesLowLevelContract), 65536)]
  internal interface IPwmPin : IClosable
  {
    PwmController Controller { get; }

    double GetActiveDutyCyclePercentage();

    void SetActiveDutyCyclePercentage(double dutyCyclePercentage);

    PwmPulsePolarity Polarity { get; set; }

    void Start();

    void Stop();

    bool IsStarted { get; }
  }
}
