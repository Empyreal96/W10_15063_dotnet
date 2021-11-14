// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Spi.Provider.ISpiControllerProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Devices.Spi.Provider
{
  [ContractVersion(typeof (DevicesLowLevelContract), 131072)]
  [Guid(3244844292, 718, 16934, 163, 133, 79, 17, 251, 4, 180, 27)]
  public interface ISpiControllerProvider
  {
    ISpiDeviceProvider GetDeviceProvider(ProviderSpiConnectionSettings settings);
  }
}
