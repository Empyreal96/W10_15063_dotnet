// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbInterfaceDescriptor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IUsbInterfaceDescriptorStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class UsbInterfaceDescriptor : IUsbInterfaceDescriptor
  {
    public extern byte ClassCode { [MethodImpl] get; }

    public extern byte SubclassCode { [MethodImpl] get; }

    public extern byte ProtocolCode { [MethodImpl] get; }

    public extern byte AlternateSettingNumber { [MethodImpl] get; }

    public extern byte InterfaceNumber { [MethodImpl] get; }

    [MethodImpl]
    public static extern bool TryParse(UsbDescriptor descriptor, out UsbInterfaceDescriptor parsed);

    [MethodImpl]
    public static extern UsbInterfaceDescriptor Parse(UsbDescriptor descriptor);
  }
}
