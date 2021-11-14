// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbInterruptOutPipe
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Usb
{
  [Guid(3917793449, 43769, 18896, 185, 108, 246, 97, 171, 74, 127, 149)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UsbInterruptOutPipe))]
  internal interface IUsbInterruptOutPipe
  {
    UsbInterruptOutEndpointDescriptor EndpointDescriptor { get; }

    [RemoteAsync]
    IAsyncAction ClearStallAsync();

    UsbWriteOptions WriteOptions { set; get; }

    IOutputStream OutputStream { get; }
  }
}
