// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbBulkOutPipe
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Usb
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UsbBulkOutPipe))]
  [Guid(2833903214, 277, 17834, 139, 33, 55, 178, 37, 188, 206, 231)]
  internal interface IUsbBulkOutPipe
  {
    UsbBulkOutEndpointDescriptor EndpointDescriptor { get; }

    [RemoteAsync]
    IAsyncAction ClearStallAsync();

    UsbWriteOptions WriteOptions { set; get; }

    IOutputStream OutputStream { get; }
  }
}
