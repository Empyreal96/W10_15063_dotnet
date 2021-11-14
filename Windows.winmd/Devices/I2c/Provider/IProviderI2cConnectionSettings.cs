// Decompiled with JetBrains decompiler
// Type: Windows.Devices.I2c.Provider.IProviderI2cConnectionSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Devices.I2c.Provider
{
  [Guid(3923463732, 58640, 17591, 128, 157, 242, 248, 91, 85, 83, 57)]
  [ExclusiveTo(typeof (ProviderI2cConnectionSettings))]
  [ContractVersion(typeof (DevicesLowLevelContract), 131072)]
  internal interface IProviderI2cConnectionSettings
  {
    int SlaveAddress { get; set; }

    ProviderI2cBusSpeed BusSpeed { get; set; }

    ProviderI2cSharingMode SharingMode { get; set; }
  }
}
