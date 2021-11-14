// Decompiled with JetBrains decompiler
// Type: Windows.Devices.I2c.Provider.II2cDeviceProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.I2c.Provider
{
  [ContractVersion(typeof (DevicesLowLevelContract), 131072)]
  [Guid(2905876052, 22504, 17726, 131, 41, 209, 228, 71, 209, 3, 169)]
  public interface II2cDeviceProvider : IClosable
  {
    string DeviceId { get; }

    void Write(byte[] buffer);

    ProviderI2cTransferResult WritePartial(byte[] buffer);

    void Read([Range(0, 2147483647), Out] byte[] buffer);

    ProviderI2cTransferResult ReadPartial([Range(0, 2147483647), Out] byte[] buffer);

    void WriteRead(byte[] writeBuffer, [Range(0, 2147483647), Out] byte[] readBuffer);

    ProviderI2cTransferResult WriteReadPartial(
      byte[] writeBuffer,
      [Range(0, 2147483647), Out] byte[] readBuffer);
  }
}
