// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbInterruptOutPipe
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Usb
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  public sealed class UsbInterruptOutPipe : IUsbInterruptOutPipe
  {
    public extern UsbInterruptOutEndpointDescriptor EndpointDescriptor { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ClearStallAsync();

    public extern UsbWriteOptions WriteOptions { [MethodImpl] set; [MethodImpl] get; }

    public extern IOutputStream OutputStream { [MethodImpl] get; }
  }
}
