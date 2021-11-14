// Decompiled with JetBrains decompiler
// Type: Windows.Devices.I2c.Provider.II2cProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.I2c.Provider
{
  [ContractVersion(typeof (DevicesLowLevelContract), 131072)]
  [Guid(1863518270, 48994, 20450, 169, 90, 240, 137, 153, 102, 152, 24)]
  public interface II2cProvider
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<II2cControllerProvider>> GetControllersAsync();
  }
}
