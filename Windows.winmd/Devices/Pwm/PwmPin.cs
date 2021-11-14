// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Pwm.PwmPin
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Pwm
{
  [ContractVersion(typeof (DevicesLowLevelContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PwmPin : IPwmPin, IClosable
  {
    public extern PwmController Controller { [MethodImpl] get; }

    [MethodImpl]
    public extern double GetActiveDutyCyclePercentage();

    [MethodImpl]
    public extern void SetActiveDutyCyclePercentage(double dutyCyclePercentage);

    public extern PwmPulsePolarity Polarity { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void Start();

    [MethodImpl]
    public extern void Stop();

    public extern bool IsStarted { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();
  }
}
