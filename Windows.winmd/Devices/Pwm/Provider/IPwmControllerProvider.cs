// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Pwm.Provider.IPwmControllerProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Devices.Pwm.Provider
{
  [ContractVersion(typeof (DevicesLowLevelContract), 65536)]
  [Guid(318789947, 58083, 16548, 183, 217, 72, 223, 240, 55, 122, 82)]
  public interface IPwmControllerProvider
  {
    int PinCount { get; }

    double ActualFrequency { get; }

    double SetDesiredFrequency(double frequency);

    double MaxFrequency { get; }

    double MinFrequency { get; }

    void AcquirePin(int pin);

    void ReleasePin(int pin);

    void EnablePin(int pin);

    void DisablePin(int pin);

    void SetPulseParameters(int pin, double dutyCycle, bool invertPolarity);
  }
}
