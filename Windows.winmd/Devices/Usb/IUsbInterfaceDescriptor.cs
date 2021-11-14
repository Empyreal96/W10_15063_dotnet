// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbInterfaceDescriptor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UsbInterfaceDescriptor))]
  [Guid(429289671, 47086, 20368, 140, 213, 148, 162, 226, 87, 89, 138)]
  internal interface IUsbInterfaceDescriptor
  {
    byte ClassCode { get; }

    byte SubclassCode { get; }

    byte ProtocolCode { get; }

    byte AlternateSettingNumber { get; }

    byte InterfaceNumber { get; }
  }
}
