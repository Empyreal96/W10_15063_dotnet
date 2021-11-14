// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbBulkInPipe
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Usb
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  public sealed class UsbBulkInPipe : IUsbBulkInPipe
  {
    public extern uint MaxTransferSizeBytes { [MethodImpl] get; }

    public extern UsbBulkInEndpointDescriptor EndpointDescriptor { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ClearStallAsync();

    public extern UsbReadOptions ReadOptions { [MethodImpl] set; [MethodImpl] get; }

    [MethodImpl]
    public extern void FlushBuffer();

    public extern IInputStream InputStream { [MethodImpl] get; }
  }
}
