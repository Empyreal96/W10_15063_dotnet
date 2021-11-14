// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Adc.IAdcControllerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Adc
{
  [ContractVersion(typeof (DevicesLowLevelContract), 131072)]
  [Guid(2730048285, 38779, 20314, 165, 254, 166, 171, 175, 254, 100, 132)]
  [ExclusiveTo(typeof (AdcController))]
  internal interface IAdcControllerStatics2
  {
    [RemoteAsync]
    IAsyncOperation<AdcController> GetDefaultAsync();
  }
}
