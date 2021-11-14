// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Adc.AdcController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Adc.Provider;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Adc
{
  [ContractVersion(typeof (DevicesLowLevelContract), 65536)]
  [Static(typeof (IAdcControllerStatics2), 131072, "Windows.Devices.DevicesLowLevelContract")]
  [DualApiPartition(version = 167772160)]
  [Static(typeof (IAdcControllerStatics), 65536, "Windows.Devices.DevicesLowLevelContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AdcController : IAdcController
  {
    public extern int ChannelCount { [MethodImpl] get; }

    public extern int ResolutionInBits { [MethodImpl] get; }

    public extern int MinValue { [MethodImpl] get; }

    public extern int MaxValue { [MethodImpl] get; }

    public extern AdcChannelMode ChannelMode { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern bool IsChannelModeSupported(AdcChannelMode channelMode);

    [MethodImpl]
    public extern AdcChannel OpenChannel(int channelNumber);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<AdcController> GetDefaultAsync();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<AdcController>> GetControllersAsync(
      IAdcProvider provider);
  }
}
