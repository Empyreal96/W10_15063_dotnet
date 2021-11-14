// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbDeviceClass
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [ExclusiveTo(typeof (UsbDeviceClass))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(85541625, 33886, 18411, 177, 42, 56, 242, 246, 23, 175, 231)]
  internal interface IUsbDeviceClass
  {
    byte ClassCode { get; set; }

    IReference<byte> SubclassCode { get; set; }

    IReference<byte> ProtocolCode { get; set; }
  }
}
