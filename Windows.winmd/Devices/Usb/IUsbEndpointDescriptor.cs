// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbEndpointDescriptor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1799906009, 36343, 19264, 172, 131, 87, 143, 19, 159, 5, 117)]
  [ExclusiveTo(typeof (UsbEndpointDescriptor))]
  internal interface IUsbEndpointDescriptor
  {
    byte EndpointNumber { get; }

    UsbTransferDirection Direction { get; }

    UsbEndpointType EndpointType { get; }

    UsbBulkInEndpointDescriptor AsBulkInEndpointDescriptor { get; }

    UsbInterruptInEndpointDescriptor AsInterruptInEndpointDescriptor { get; }

    UsbBulkOutEndpointDescriptor AsBulkOutEndpointDescriptor { get; }

    UsbInterruptOutEndpointDescriptor AsInterruptOutEndpointDescriptor { get; }
  }
}
