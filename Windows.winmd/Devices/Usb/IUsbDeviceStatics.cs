// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbDeviceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [Guid(107709858, 2487, 17478, 133, 2, 111, 230, 220, 170, 115, 9)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UsbDevice))]
  internal interface IUsbDeviceStatics
  {
    [Overload("GetDeviceSelector")]
    string GetDeviceSelector(uint vendorId, uint productId, Guid winUsbInterfaceClass);

    [Overload("GetDeviceSelectorGuidOnly")]
    string GetDeviceSelector(Guid winUsbInterfaceClass);

    [Overload("GetDeviceSelectorVidPidOnly")]
    string GetDeviceSelector(uint vendorId, uint productId);

    string GetDeviceClassSelector(UsbDeviceClass usbClass);

    [RemoteAsync]
    IAsyncOperation<UsbDevice> FromIdAsync(string deviceId);
  }
}
