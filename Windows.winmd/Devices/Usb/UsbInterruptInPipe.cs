// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbInterruptInPipe
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class UsbInterruptInPipe : IUsbInterruptInPipe
  {
    public extern UsbInterruptInEndpointDescriptor EndpointDescriptor { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ClearStallAsync();

    public extern event TypedEventHandler<UsbInterruptInPipe, UsbInterruptInEventArgs> DataReceived;
  }
}
