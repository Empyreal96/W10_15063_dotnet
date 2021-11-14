// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbSetupPacketFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Usb
{
  [Guid(3374677328, 6958, 19009, 162, 167, 51, 143, 12, 239, 60, 20)]
  [ExclusiveTo(typeof (UsbSetupPacket))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUsbSetupPacketFactory
  {
    UsbSetupPacket CreateWithEightByteBuffer(IBuffer eightByteBuffer);
  }
}
