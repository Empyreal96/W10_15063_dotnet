// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbSetupPacket
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
  [DualApiPartition(version = 100859904)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IUsbSetupPacketFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class UsbSetupPacket : IUsbSetupPacket
  {
    [MethodImpl]
    public extern UsbSetupPacket(IBuffer eightByteBuffer);

    [MethodImpl]
    public extern UsbSetupPacket();

    public extern UsbControlRequestType RequestType { [MethodImpl] get; [MethodImpl] set; }

    public extern byte Request { [MethodImpl] get; [MethodImpl] set; }

    public extern uint Value { [MethodImpl] get; [MethodImpl] set; }

    public extern uint Index { [MethodImpl] get; [MethodImpl] set; }

    public extern uint Length { [MethodImpl] get; [MethodImpl] set; }
  }
}
