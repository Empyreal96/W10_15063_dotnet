// Decompiled with JetBrains decompiler
// Type: Windows.Devices.I2c.II2cConnectionSettingsFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Devices.I2c
{
  [Guid(2176157363, 38547, 16817, 162, 67, 222, 212, 246, 230, 105, 38)]
  [ExclusiveTo(typeof (I2cConnectionSettings))]
  [ContractVersion(typeof (DevicesLowLevelContract), 65536)]
  internal interface II2cConnectionSettingsFactory
  {
    I2cConnectionSettings Create(int slaveAddress);
  }
}
