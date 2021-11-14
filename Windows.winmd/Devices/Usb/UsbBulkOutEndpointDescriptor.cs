// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbBulkOutEndpointDescriptor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  public sealed class UsbBulkOutEndpointDescriptor : IUsbBulkOutEndpointDescriptor
  {
    public extern uint MaxPacketSize { [MethodImpl] get; }

    public extern byte EndpointNumber { [MethodImpl] get; }

    public extern UsbBulkOutPipe Pipe { [MethodImpl] get; }
  }
}
