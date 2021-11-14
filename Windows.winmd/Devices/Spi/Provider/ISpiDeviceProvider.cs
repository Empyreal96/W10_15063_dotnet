// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Spi.Provider.ISpiDeviceProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Spi.Provider
{
  [ContractVersion(typeof (DevicesLowLevelContract), 131072)]
  [Guid(219952195, 12363, 16476, 180, 247, 245, 171, 16, 116, 70, 30)]
  public interface ISpiDeviceProvider : IClosable
  {
    string DeviceId { get; }

    ProviderSpiConnectionSettings ConnectionSettings { get; }

    void Write(byte[] buffer);

    void Read([Range(0, 2147483647), Out] byte[] buffer);

    void TransferSequential(byte[] writeBuffer, [Range(0, 2147483647), Out] byte[] readBuffer);

    void TransferFullDuplex(byte[] writeBuffer, [Range(0, 2147483647), Out] byte[] readBuffer);
  }
}
