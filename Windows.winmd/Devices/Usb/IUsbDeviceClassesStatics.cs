// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbDeviceClassesStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [Guid(2987066663, 50560, 17817, 161, 101, 152, 27, 79, 208, 50, 48)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UsbDeviceClasses))]
  internal interface IUsbDeviceClassesStatics
  {
    UsbDeviceClass CdcControl { get; }

    UsbDeviceClass Physical { get; }

    UsbDeviceClass PersonalHealthcare { get; }

    UsbDeviceClass ActiveSync { get; }

    UsbDeviceClass PalmSync { get; }

    UsbDeviceClass DeviceFirmwareUpdate { get; }

    UsbDeviceClass Irda { get; }

    UsbDeviceClass Measurement { get; }

    UsbDeviceClass VendorSpecific { get; }
  }
}
