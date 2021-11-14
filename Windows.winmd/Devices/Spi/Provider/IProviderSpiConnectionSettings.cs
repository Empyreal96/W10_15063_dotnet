// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Spi.Provider.IProviderSpiConnectionSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Devices.Spi.Provider
{
  [Guid(4127409488, 42306, 20160, 150, 1, 164, 221, 104, 248, 105, 123)]
  [ExclusiveTo(typeof (ProviderSpiConnectionSettings))]
  [ContractVersion(typeof (DevicesLowLevelContract), 131072)]
  internal interface IProviderSpiConnectionSettings
  {
    int ChipSelectLine { get; set; }

    ProviderSpiMode Mode { get; set; }

    int DataBitLength { get; set; }

    int ClockFrequency { get; set; }

    ProviderSpiSharingMode SharingMode { get; set; }
  }
}
