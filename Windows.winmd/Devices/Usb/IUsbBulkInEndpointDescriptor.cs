// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbBulkInEndpointDescriptor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [Guid(1013860422, 1743, 17065, 157, 194, 151, 28, 27, 20, 182, 227)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UsbBulkInEndpointDescriptor))]
  internal interface IUsbBulkInEndpointDescriptor
  {
    uint MaxPacketSize { get; }

    byte EndpointNumber { get; }

    UsbBulkInPipe Pipe { get; }
  }
}
