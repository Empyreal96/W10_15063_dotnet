// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Spi.Provider.IProviderSpiConnectionSettingsFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Devices.Spi.Provider
{
  [ContractVersion(typeof (DevicesLowLevelContract), 131072)]
  [Guid(1715825498, 3193, 17379, 159, 60, 229, 151, 128, 172, 24, 250)]
  [ExclusiveTo(typeof (ProviderSpiConnectionSettings))]
  internal interface IProviderSpiConnectionSettingsFactory
  {
    ProviderSpiConnectionSettings Create(int chipSelectLine);
  }
}
