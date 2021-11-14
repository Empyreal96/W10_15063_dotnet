// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbDeviceClasses
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IUsbDeviceClassesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class UsbDeviceClasses : IUsbDeviceClasses
  {
    public static extern UsbDeviceClass CdcControl { [MethodImpl] get; }

    public static extern UsbDeviceClass Physical { [MethodImpl] get; }

    public static extern UsbDeviceClass PersonalHealthcare { [MethodImpl] get; }

    public static extern UsbDeviceClass ActiveSync { [MethodImpl] get; }

    public static extern UsbDeviceClass PalmSync { [MethodImpl] get; }

    public static extern UsbDeviceClass DeviceFirmwareUpdate { [MethodImpl] get; }

    public static extern UsbDeviceClass Irda { [MethodImpl] get; }

    public static extern UsbDeviceClass Measurement { [MethodImpl] get; }

    public static extern UsbDeviceClass VendorSpecific { [MethodImpl] get; }
  }
}
