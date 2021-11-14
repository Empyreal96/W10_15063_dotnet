// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Adc.Provider.IAdcControllerProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Devices.Adc.Provider
{
  [ContractVersion(typeof (DevicesLowLevelContract), 65536)]
  [Guid(3193198632, 33133, 19941, 160, 72, 171, 160, 105, 88, 170, 168)]
  public interface IAdcControllerProvider
  {
    int ChannelCount { get; }

    int ResolutionInBits { get; }

    int MinValue { get; }

    int MaxValue { get; }

    ProviderAdcChannelMode ChannelMode { get; set; }

    bool IsChannelModeSupported(ProviderAdcChannelMode channelMode);

    void AcquireChannel(int channel);

    void ReleaseChannel(int channel);

    int ReadValue(int channelNumber);
  }
}
