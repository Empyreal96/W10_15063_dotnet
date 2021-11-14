// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Usb
{
  [ExclusiveTo(typeof (UsbDevice))]
  [Guid(1380563346, 50262, 17621, 173, 94, 36, 245, 160, 137, 246, 59)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUsbDevice : IClosable
  {
    [Overload("SendControlOutTransferAsync")]
    IAsyncOperation<uint> SendControlOutTransferAsync(
      UsbSetupPacket setupPacket,
      IBuffer buffer);

    [Overload("SendControlOutTransferAsyncNoBuffer")]
    IAsyncOperation<uint> SendControlOutTransferAsync(UsbSetupPacket setupPacket);

    [Overload("SendControlInTransferAsync")]
    IAsyncOperation<IBuffer> SendControlInTransferAsync(
      UsbSetupPacket setupPacket,
      IBuffer buffer);

    [Overload("SendControlInTransferAsyncNoBuffer")]
    IAsyncOperation<IBuffer> SendControlInTransferAsync(
      UsbSetupPacket setupPacket);

    UsbInterface DefaultInterface { get; }

    UsbDeviceDescriptor DeviceDescriptor { get; }

    UsbConfiguration Configuration { get; }
  }
}
