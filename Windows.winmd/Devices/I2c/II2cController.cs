// Decompiled with JetBrains decompiler
// Type: Windows.Devices.I2c.II2cController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Devices.I2c
{
  [ContractVersion(typeof (DevicesLowLevelContract), 131072)]
  [ExclusiveTo(typeof (I2cController))]
  [Guid(3297423794, 34720, 16742, 142, 62, 180, 184, 249, 124, 215, 41)]
  internal interface II2cController
  {
    I2cDevice GetDevice(I2cConnectionSettings settings);
  }
}
