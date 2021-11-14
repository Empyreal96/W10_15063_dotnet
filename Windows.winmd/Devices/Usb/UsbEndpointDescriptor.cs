// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbEndpointDescriptor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IUsbEndpointDescriptorStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  public sealed class UsbEndpointDescriptor : IUsbEndpointDescriptor
  {
    public extern byte EndpointNumber { [MethodImpl] get; }

    public extern UsbTransferDirection Direction { [MethodImpl] get; }

    public extern UsbEndpointType EndpointType { [MethodImpl] get; }

    public extern UsbBulkInEndpointDescriptor AsBulkInEndpointDescriptor { [MethodImpl] get; }

    public extern UsbInterruptInEndpointDescriptor AsInterruptInEndpointDescriptor { [MethodImpl] get; }

    public extern UsbBulkOutEndpointDescriptor AsBulkOutEndpointDescriptor { [MethodImpl] get; }

    public extern UsbInterruptOutEndpointDescriptor AsInterruptOutEndpointDescriptor { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool TryParse(UsbDescriptor descriptor, out UsbEndpointDescriptor parsed);

    [MethodImpl]
    public static extern UsbEndpointDescriptor Parse(UsbDescriptor descriptor);
  }
}
