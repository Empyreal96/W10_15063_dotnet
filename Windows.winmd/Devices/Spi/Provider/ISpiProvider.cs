// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Spi.Provider.ISpiProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Spi.Provider
{
  [ContractVersion(typeof (DevicesLowLevelContract), 131072)]
  [Guid(2528403938, 30676, 18638, 170, 160, 117, 113, 90, 131, 98, 207)]
  public interface ISpiProvider
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<ISpiControllerProvider>> GetControllersAsync();
  }
}
