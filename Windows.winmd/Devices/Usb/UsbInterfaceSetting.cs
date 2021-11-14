// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbInterfaceSetting
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class UsbInterfaceSetting : IUsbInterfaceSetting
  {
    public extern IVectorView<UsbBulkInEndpointDescriptor> BulkInEndpoints { [MethodImpl] get; }

    public extern IVectorView<UsbInterruptInEndpointDescriptor> InterruptInEndpoints { [MethodImpl] get; }

    public extern IVectorView<UsbBulkOutEndpointDescriptor> BulkOutEndpoints { [MethodImpl] get; }

    public extern IVectorView<UsbInterruptOutEndpointDescriptor> InterruptOutEndpoints { [MethodImpl] get; }

    public extern bool Selected { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SelectSettingAsync();

    public extern UsbInterfaceDescriptor InterfaceDescriptor { [MethodImpl] get; }

    public extern IVectorView<UsbDescriptor> Descriptors { [MethodImpl] get; }
  }
}
