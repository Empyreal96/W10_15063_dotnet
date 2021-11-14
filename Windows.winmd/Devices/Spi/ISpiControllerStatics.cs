// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Spi.ISpiControllerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Spi.Provider;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Spi
{
  [Guid(223488482, 5003, 20040, 185, 100, 79, 47, 121, 185, 197, 162)]
  [ContractVersion(typeof (DevicesLowLevelContract), 131072)]
  [ExclusiveTo(typeof (SpiController))]
  internal interface ISpiControllerStatics
  {
    [RemoteAsync]
    IAsyncOperation<SpiController> GetDefaultAsync();

    [RemoteAsync]
    IAsyncOperation<IVectorView<SpiController>> GetControllersAsync(
      ISpiProvider provider);
  }
}
