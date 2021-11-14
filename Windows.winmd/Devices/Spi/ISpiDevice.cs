// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Spi.ISpiDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Spi
{
  [Guid(97858925, 4534, 19769, 132, 213, 149, 223, 180, 201, 242, 206)]
  [ExclusiveTo(typeof (SpiDevice))]
  [ContractVersion(typeof (DevicesLowLevelContract), 65536)]
  internal interface ISpiDevice : IClosable
  {
    string DeviceId { get; }

    SpiConnectionSettings ConnectionSettings { get; }

    void Write(byte[] buffer);

    void Read([Range(0, 2147483647), Out] byte[] buffer);

    void TransferSequential(byte[] writeBuffer, [Range(0, 2147483647), Out] byte[] readBuffer);

    void TransferFullDuplex(byte[] writeBuffer, [Range(0, 2147483647), Out] byte[] readBuffer);
  }
}
