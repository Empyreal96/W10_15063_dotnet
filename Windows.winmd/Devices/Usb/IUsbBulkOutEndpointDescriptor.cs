// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbBulkOutEndpointDescriptor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [Guid(673219706, 65518, 20320, 155, 225, 149, 108, 172, 62, 203, 101)]
  [ExclusiveTo(typeof (UsbBulkOutEndpointDescriptor))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUsbBulkOutEndpointDescriptor
  {
    uint MaxPacketSize { get; }

    byte EndpointNumber { get; }

    UsbBulkOutPipe Pipe { get; }
  }
}
