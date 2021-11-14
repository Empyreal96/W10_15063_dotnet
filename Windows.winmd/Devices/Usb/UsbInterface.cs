// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbInterface
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  public sealed class UsbInterface : IUsbInterface
  {
    public extern IVectorView<UsbBulkInPipe> BulkInPipes { [MethodImpl] get; }

    public extern IVectorView<UsbInterruptInPipe> InterruptInPipes { [MethodImpl] get; }

    public extern IVectorView<UsbBulkOutPipe> BulkOutPipes { [MethodImpl] get; }

    public extern IVectorView<UsbInterruptOutPipe> InterruptOutPipes { [MethodImpl] get; }

    public extern IVectorView<UsbInterfaceSetting> InterfaceSettings { [MethodImpl] get; }

    public extern byte InterfaceNumber { [MethodImpl] get; }

    public extern IVectorView<UsbDescriptor> Descriptors { [MethodImpl] get; }
  }
}
