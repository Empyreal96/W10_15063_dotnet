// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Usb
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IUsbDeviceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  public sealed class UsbDevice : IUsbDevice, IClosable
  {
    [Overload("SendControlOutTransferAsync")]
    [MethodImpl]
    public extern IAsyncOperation<uint> SendControlOutTransferAsync(
      UsbSetupPacket setupPacket,
      IBuffer buffer);

    [Overload("SendControlOutTransferAsyncNoBuffer")]
    [MethodImpl]
    public extern IAsyncOperation<uint> SendControlOutTransferAsync(
      UsbSetupPacket setupPacket);

    [Overload("SendControlInTransferAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IBuffer> SendControlInTransferAsync(
      UsbSetupPacket setupPacket,
      IBuffer buffer);

    [Overload("SendControlInTransferAsyncNoBuffer")]
    [MethodImpl]
    public extern IAsyncOperation<IBuffer> SendControlInTransferAsync(
      UsbSetupPacket setupPacket);

    public extern UsbInterface DefaultInterface { [MethodImpl] get; }

    public extern UsbDeviceDescriptor DeviceDescriptor { [MethodImpl] get; }

    public extern UsbConfiguration Configuration { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    [Overload("GetDeviceSelector")]
    [MethodImpl]
    public static extern string GetDeviceSelector(
      uint vendorId,
      uint productId,
      Guid winUsbInterfaceClass);

    [Overload("GetDeviceSelectorGuidOnly")]
    [MethodImpl]
    public static extern string GetDeviceSelector(Guid winUsbInterfaceClass);

    [Overload("GetDeviceSelectorVidPidOnly")]
    [MethodImpl]
    public static extern string GetDeviceSelector(uint vendorId, uint productId);

    [MethodImpl]
    public static extern string GetDeviceClassSelector(UsbDeviceClass usbClass);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<UsbDevice> FromIdAsync(
      string deviceId);
  }
}
