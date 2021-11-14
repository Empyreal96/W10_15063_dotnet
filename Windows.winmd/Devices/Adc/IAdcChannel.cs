// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Adc.IAdcChannel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Adc
{
  [Guid(67892244, 9608, 19030, 171, 239, 115, 162, 96, 172, 198, 10)]
  [ContractVersion(typeof (DevicesLowLevelContract), 65536)]
  [ExclusiveTo(typeof (AdcChannel))]
  internal interface IAdcChannel : IClosable
  {
    AdcController Controller { get; }

    int ReadValue();

    double ReadRatio();
  }
}
