// Decompiled with JetBrains decompiler
// Type: Windows.Devices.I2c.II2cDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.I2c
{
  [Guid(2251735350, 47557, 20336, 148, 73, 204, 70, 220, 111, 87, 235)]
  [ContractVersion(typeof (DevicesLowLevelContract), 65536)]
  [ExclusiveTo(typeof (I2cDevice))]
  internal interface II2cDevice : IClosable
  {
    string DeviceId { get; }

    I2cConnectionSettings ConnectionSettings { get; }

    void Write(byte[] buffer);

    I2cTransferResult WritePartial(byte[] buffer);

    void Read([Range(0, 2147483647), Out] byte[] buffer);

    I2cTransferResult ReadPartial([Range(0, 2147483647), Out] byte[] buffer);

    void WriteRead(byte[] writeBuffer, [Range(0, 2147483647), Out] byte[] readBuffer);

    I2cTransferResult WriteReadPartial(byte[] writeBuffer, [Range(0, 2147483647), Out] byte[] readBuffer);
  }
}
