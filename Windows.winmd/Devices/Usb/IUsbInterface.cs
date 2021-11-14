// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbInterface
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [Guid(2687642517, 32583, 18603, 167, 39, 103, 140, 37, 190, 33, 18)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UsbInterface))]
  internal interface IUsbInterface
  {
    IVectorView<UsbBulkInPipe> BulkInPipes { get; }

    IVectorView<UsbInterruptInPipe> InterruptInPipes { get; }

    IVectorView<UsbBulkOutPipe> BulkOutPipes { get; }

    IVectorView<UsbInterruptOutPipe> InterruptOutPipes { get; }

    IVectorView<UsbInterfaceSetting> InterfaceSettings { get; }

    byte InterfaceNumber { get; }

    IVectorView<UsbDescriptor> Descriptors { get; }
  }
}
