// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Adc.IAdcControllerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Adc.Provider;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Adc
{
  [Guid(3437858316, 504, 18577, 188, 59, 190, 83, 239, 39, 156, 164)]
  [ContractVersion(typeof (DevicesLowLevelContract), 65536)]
  [ExclusiveTo(typeof (AdcController))]
  internal interface IAdcControllerStatics
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<AdcController>> GetControllersAsync(
      IAdcProvider provider);
  }
}
