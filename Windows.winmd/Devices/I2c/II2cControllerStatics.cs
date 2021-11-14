// Decompiled with JetBrains decompiler
// Type: Windows.Devices.I2c.II2cControllerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.I2c.Provider;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.I2c
{
  [ContractVersion(typeof (DevicesLowLevelContract), 131072)]
  [Guid(1090257765, 24325, 20094, 132, 189, 16, 13, 184, 224, 174, 197)]
  [ExclusiveTo(typeof (I2cController))]
  internal interface II2cControllerStatics
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<I2cController>> GetControllersAsync(
      II2cProvider provider);

    [RemoteAsync]
    IAsyncOperation<I2cController> GetDefaultAsync();
  }
}
