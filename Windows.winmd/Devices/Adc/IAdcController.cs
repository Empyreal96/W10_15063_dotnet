// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Adc.IAdcController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Devices.Adc
{
  [ExclusiveTo(typeof (AdcController))]
  [Guid(712434864, 43158, 16921, 134, 182, 234, 140, 220, 233, 143, 86)]
  [ContractVersion(typeof (DevicesLowLevelContract), 65536)]
  internal interface IAdcController
  {
    int ChannelCount { get; }

    int ResolutionInBits { get; }

    int MinValue { get; }

    int MaxValue { get; }

    AdcChannelMode ChannelMode { get; set; }

    bool IsChannelModeSupported(AdcChannelMode channelMode);

    AdcChannel OpenChannel(int channelNumber);
  }
}
