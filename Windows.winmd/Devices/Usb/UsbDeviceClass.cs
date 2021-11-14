// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbDeviceClass
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class UsbDeviceClass : IUsbDeviceClass
  {
    [MethodImpl]
    public extern UsbDeviceClass();

    public extern byte ClassCode { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<byte> SubclassCode { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<byte> ProtocolCode { [MethodImpl] get; [MethodImpl] set; }
  }
}
