// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbInterfaceSetting
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [Guid(405257127, 36263, 19191, 143, 76, 127, 48, 50, 231, 129, 245)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UsbInterfaceSetting))]
  internal interface IUsbInterfaceSetting
  {
    IVectorView<UsbBulkInEndpointDescriptor> BulkInEndpoints { get; }

    IVectorView<UsbInterruptInEndpointDescriptor> InterruptInEndpoints { get; }

    IVectorView<UsbBulkOutEndpointDescriptor> BulkOutEndpoints { get; }

    IVectorView<UsbInterruptOutEndpointDescriptor> InterruptOutEndpoints { get; }

    bool Selected { get; }

    [RemoteAsync]
    IAsyncAction SelectSettingAsync();

    UsbInterfaceDescriptor InterfaceDescriptor { get; }

    IVectorView<UsbDescriptor> Descriptors { get; }
  }
}
