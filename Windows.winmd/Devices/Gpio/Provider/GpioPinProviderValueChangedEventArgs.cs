// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Gpio.Provider.GpioPinProviderValueChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Gpio.Provider
{
  [Activatable(typeof (IGpioPinProviderValueChangedEventArgsFactory), 131072, "Windows.Devices.DevicesLowLevelContract")]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (DevicesLowLevelContract), 131072)]
  [Threading(ThreadingModel.Both)]
  public sealed class GpioPinProviderValueChangedEventArgs : IGpioPinProviderValueChangedEventArgs
  {
    [MethodImpl]
    public extern GpioPinProviderValueChangedEventArgs(ProviderGpioPinEdge edge);

    public extern ProviderGpioPinEdge Edge { [MethodImpl] get; }
  }
}
