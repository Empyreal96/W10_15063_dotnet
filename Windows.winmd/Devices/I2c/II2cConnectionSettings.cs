// Decompiled with JetBrains decompiler
// Type: Windows.Devices.I2c.II2cConnectionSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Devices.I2c
{
  [ExclusiveTo(typeof (I2cConnectionSettings))]
  [ContractVersion(typeof (DevicesLowLevelContract), 65536)]
  [Guid(4074443527, 43887, 17977, 167, 103, 84, 83, 109, 195, 70, 15)]
  internal interface II2cConnectionSettings
  {
    int SlaveAddress { get; set; }

    I2cBusSpeed BusSpeed { get; set; }

    I2cSharingMode SharingMode { get; set; }
  }
}
