// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbDeviceDescriptor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [Guid(524866038, 47767, 17186, 185, 44, 181, 177, 137, 33, 101, 136)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UsbDeviceDescriptor))]
  internal interface IUsbDeviceDescriptor
  {
    uint BcdUsb { get; }

    byte MaxPacketSize0 { get; }

    uint VendorId { get; }

    uint ProductId { get; }

    uint BcdDeviceRevision { get; }

    byte NumberOfConfigurations { get; }
  }
}
