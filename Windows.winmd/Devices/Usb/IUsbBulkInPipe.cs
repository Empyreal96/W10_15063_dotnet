// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbBulkInPipe
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Usb
{
  [Guid(4028443963, 17736, 19792, 179, 38, 216, 44, 218, 190, 18, 32)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UsbBulkInPipe))]
  internal interface IUsbBulkInPipe
  {
    uint MaxTransferSizeBytes { get; }

    UsbBulkInEndpointDescriptor EndpointDescriptor { get; }

    [RemoteAsync]
    IAsyncAction ClearStallAsync();

    UsbReadOptions ReadOptions { set; get; }

    void FlushBuffer();

    IInputStream InputStream { get; }
  }
}
