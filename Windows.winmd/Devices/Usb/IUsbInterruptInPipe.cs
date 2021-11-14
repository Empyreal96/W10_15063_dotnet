// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbInterruptInPipe
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UsbInterruptInPipe))]
  [Guid(4194332950, 34007, 18631, 138, 63, 76, 11, 35, 95, 46, 166)]
  internal interface IUsbInterruptInPipe
  {
    UsbInterruptInEndpointDescriptor EndpointDescriptor { get; }

    [RemoteAsync]
    IAsyncAction ClearStallAsync();

    event TypedEventHandler<UsbInterruptInPipe, UsbInterruptInEventArgs> DataReceived;
  }
}
