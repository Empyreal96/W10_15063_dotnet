// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbInterruptOutEndpointDescriptor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UsbInterruptOutEndpointDescriptor))]
  [Guid(3433033089, 4298, 17715, 149, 45, 158, 39, 131, 65, 232, 15)]
  internal interface IUsbInterruptOutEndpointDescriptor
  {
    uint MaxPacketSize { get; }

    byte EndpointNumber { get; }

    TimeSpan Interval { get; }

    UsbInterruptOutPipe Pipe { get; }
  }
}
